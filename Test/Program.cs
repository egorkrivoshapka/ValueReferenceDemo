using System;
using System.Collections.Generic;

namespace Test
{
    class MainClass
    {
        public class SomeClass
        {
            public int num { get; set; }
        }

        public static void Main(string[] args)
        {
            int a = 5;
            Modify(a);
            Console.WriteLine(a);




            var s = new SomeClass()
            {
                num = a
            };
            Modify(s);
            Console.WriteLine($"SomeClass: {s.num}");

            List<SomeClass> list = new List<SomeClass>()
            {
                new SomeClass()
                {
                    num = 1
                },
                new SomeClass()
                {
                    num = 2
                },
                new SomeClass()
                {
                    num = 3
                },
                new SomeClass()
                {
                    num = 4
                },
                new SomeClass()
                {
                    num = 5
                }
            };


            var temp = list[3];
            temp.num = 20;
            Console.WriteLine(list[3].num);

            List<int> listInt = new List<int>()
            {
                1,2,3,4,5,6
            };

            var value = listInt[3];
            value = 25;
            Console.WriteLine(listInt[3]);

            var listRange = list.GetRange(3, 2);
            for(int i = 0; i<listRange.Count; i++)
            {
                listRange[i] = null;
            }
            foreach(var item in list)
            {
                Console.WriteLine(item.num);
            }
        }

        public static int Modify(int a)
        {
            a++;
            Console.WriteLine(a);
            return a;
        }

        public static int Modify(int a, int b)
        {
            return 0;
        }

        public static void Modify(SomeClass a)
        {
            a.num++;
            Console.WriteLine($"SomeClass: {a.num}");
        }
    }

    
}
