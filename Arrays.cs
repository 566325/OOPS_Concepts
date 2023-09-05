using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Concepts
{
    internal class Arrays
    {
        public static void ArraysDecleration()
        {
            int[] NumArray = new int[10];
            NumArray[0] = 1;
            NumArray[1] = 2;
            NumArray[2] = 3;
            NumArray[3] = 5;
            NumArray[7] = 9;
            

            //Console.Write(NumArray[6]);
            //Console.WriteLine(NumArray.Length);

            for (int i = 0; i < NumArray.Length; i++)
            {
                Console.WriteLine(NumArray[i]);
            }
            Console.WriteLine("****************");
            
            foreach (int i in NumArray)
            {
                Console.WriteLine(i);
            }

           
            int[] numberArray2 = new int[9] { 10, 11, 12, 14, 15, 19, 17, 18, 20 };
            
            int[] numberArray3 = { 15, 20, 21, 22, 23, 24 };
        }
        public static void ArraysListDecleration()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Sireesha");
            arrayList.Add(2.4f);
            arrayList.Add('N');

            foreach (var data in arrayList)
            {
                Console.WriteLine("Value of arrayList are :{0}",data);
            }

            Console.WriteLine(" *******************");
            
            var Arraylist1= new ArrayList();
            int[] array = {120,54,234,674,89 };

            Arraylist1.AddRange(array);


            foreach (var data in Arraylist1)
            {
                Console.WriteLine("Value of arrayList are :{0}", data);
            }
            Console.WriteLine(Arraylist1.Count);

            Console.WriteLine("*******************");

            var ArrayList2 = new ArrayList();
            {
                12, "Siri",null, 23.3f;
            };
            ArrayList2.Insert();


        }
    }
}
