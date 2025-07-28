using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace Advainced2
{
    internal class Program
    {

        #region SumArrList
        public static int SumArrList(ArrayList arrayList)
        {
            int sum = 0;
            if (arrayList is not null && arrayList.Count > 0)
            {
                for (int i = 0; i < arrayList.Count; i++)
                {
                    sum += (int?)arrayList[i] ?? 0;
                }
            }
            return sum;
        }



        #endregion


        static void Main(string[] args)
        {

            #region ArrayList

            //ArrayList arrayList = new ArrayList();
            //Console.WriteLine($"Capacity ==> {arrayList.Capacity} , conut ==>{arrayList.Count}");
            //arrayList.Add( 1 );
            //Console.WriteLine($"Capacity ==> {arrayList.Capacity} , conut ==>{arrayList.Count}");
            //arrayList.Add(2);
            //Console.WriteLine($"Capacity ==> {arrayList.Capacity} , conut ==>{arrayList.Count}");
            //arrayList.AddRange(new int[] { 3, 4 });
            //Console.WriteLine($"Capacity ==> {arrayList.Capacity} , conut ==>{arrayList.Count}");
            //arrayList.Add(5);
            //Console.WriteLine($"Capacity ==> {arrayList.Capacity} , conut ==>{arrayList.Count}");

            //*****Trim
            //arrayList.TrimToSize();
            //Console.WriteLine($"Capacity ==> {arrayList.Capacity} , conut ==>{arrayList.Count}");

            //foreach (int i in arrayList)
            //{
            //    Console.WriteLine($"{i}");
            //}
            ////*****Remove
            //arrayList.Remove(5);
            //arrayList.RemoveAt(5);
            //arrayList.RemoveRange(0, 1);
            //Console.WriteLine($"Capacity ==> {arrayList.Capacity} , conut ==>{arrayList.Count}");
            //Console.WriteLine();
            //foreach (int i in arrayList)
            //{
            //    Console.WriteLine($"{i}");
            //}



            //****Index
            // int? firstElement = (int?) arrayList[0];
            //Console.WriteLine();
            //Console.WriteLine(firstElement);
            //arrayList[5] = 20;
            //arrayList[2] = 200;
            //arrayList.Insert(0, new int[] { 1000, 2000 });
            //Console.WriteLine($"After chang");
            //foreach (int i in arrayList)

            //    Console.WriteLine($"{i}");
            //Console.WriteLine($"Capacity ==> {arrayList.Capacity} , conut ==>{arrayList.Count}");


            //for(int i = 0; i < arrayList.Count; i++)
            //{
            //    Console.WriteLine($"{arrayList[i]}");
            //}



            //*****Contains
            //bool flag = arrayList.Contains(4);
            //Console.WriteLine();
            //Console.WriteLine($"flag ={flag}");

            //*****Constructors
            //arrayList = new ArrayList();
            //Console.WriteLine($"Capacity ==> {arrayList.Capacity} , conut ==>{arrayList.Count}");
            //foreach (int i in arrayList)

            //    Console.WriteLine($"{i}");

            //arrayList =new ArrayList(new int[] {1, 2, 3, 4});
            //arrayList = new ArrayList(100);
            //Console.WriteLine($"capacity ==> {arrayList.Capacity}");



            //****

            #endregion


            




        }
    }
}
