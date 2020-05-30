using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Block
    {
        int counter = 0;
        bool full = false;
        double size = 0;
        Dictionary<string, double> Dict = new Dictionary<string, double>();
        public int getCounter()
        {
            return counter;
        }
        public void setCounter(int l)
        {
            counter = l;
        }
        public double getSize()
        {
            return size;
        }
        public void setSize(double l)
        {
            size = l;
        }
        public bool getfull()
        {
            return full;
        }
        public void setfull(bool l)
        {
            full = l;
        }
        public double fill(String k, double x)
        {
            if (x < 2 - size)
            {
                if (!Dict.ContainsKey(k))
                    Dict.Add(k, x);
                else
                    Dict[k] += x;
                size += x;
                return 0;
            }
            else
            {
                if (!Dict.ContainsKey(k))
                    Dict.Add(k, 2 - size);
                else
                    Dict[k] += 2 - size;

                double ret = x - (2 - size);

                size = 2;
                full = true;

                return (ret);
            }
        }

        public bool check(string a)
        {
            if (Dict.ContainsKey(a))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void remove(string a)
        {
            if (Dict.ContainsKey(a))
            {
                size = size - Dict[a];
                Dict.Remove(a);
                if (full)
                    full = false;
                counter++;
            }
        }
    }
}
