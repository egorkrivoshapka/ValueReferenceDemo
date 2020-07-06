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

            //Example 1
            int a = 5;
            Modify(a);
            Console.WriteLine(a);


            //Example 2
            var s = new SomeClass()
            {
                num = a
            };
            Modify(s);
            Console.WriteLine($"SomeClass: {s.num}");


            //Example 3
            List<int> originalListInt = new List<int>()
            {
                1,2,3,4,5,6
            };

            var value = originalListInt[3];
            value = 25;
            Console.WriteLine(originalListInt[3]);


            List<SomeClass> originalObjectList = new List<SomeClass>()
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

            var temp = originalObjectList[3];
            temp.num = 20;
            Console.WriteLine(originalObjectList[3].num);

            //Range, Creates a shallow copy?
            var listRangeObjects = originalObjectList.GetRange(3, 2);
            for (int i = 0; i < listRangeObjects.Count; i++)
            {
                listRangeObjects[i].num = 2000;
                //listRange[i] = null;
            }
            Console.WriteLine("Original list objects");
            foreach (var item in originalObjectList)
            {
                Console.Write($"{item.num},");
            }


        }

        public static int Modify(int a)
        {
            a++;
            Console.WriteLine(a);
            return a;
        }

        public static void Modify(SomeClass a)
        {
            a.num++;
            Console.WriteLine($"SomeClass: {a.num}");
        }
    }

    
}
