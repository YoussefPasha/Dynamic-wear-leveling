using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;
namespace ConsoleApp4
{
    public class File
    {
        List<KeyValuePair<int, int>> device = new List<KeyValuePair<int, int>>();
        Block[] block = new Block[20];
        public File()
        {
            for (int i = 0; i < 20; i++)
            {
                block[i] = new Block();
                device.Add(new KeyValuePair<int, int>(0, i));
            }
        }
        public void add(string x, double k)
        {
            double left = k;
            for (int i = 0; i < 20; i++)
            {
                if (!block[device.ElementAt(i).Value].getfull())
                {
                    left = block[device.ElementAt(i).Value].fill(x, left);
                    if (left <= 0)
                    {
                        return;
                    }
                }
            }

            Console.WriteLine("No more space avaialable in the SSD");
        }
        public void print()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(i + ":");
                Console.WriteLine("Size:" + block[i].getSize());
                Console.WriteLine("counter:" + block[i].getCounter());
                Console.WriteLine("--------------");

            }
        }
        public void erase(string x)
        {
            for (int i = 0; i < 20; i++)
            {
                if (block[i].check(x))
                {
                    device.Remove(new KeyValuePair<int, int>(block[i].getCounter(), i));
                    block[i].remove(x);
                    device.Add(new KeyValuePair<int, int>(block[i].getCounter(), i));
                }

            }
        }
    }
}
