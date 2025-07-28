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

            #region List
            List <int> List =new List<int>();
            Console.WriteLine($"Capacity ==> {List.Capacity} , conut ==>{List.Count}");
            List.Add(1);
            List.AddRange(new int[] { 1, 2, 3 });
            List.AddRange([2, 3, 4]);
            Console.WriteLine($"Capacity ==> {List.Capacity} , conut ==>{List.Count}");

            foreach (int i in List)
            
                Console.WriteLine($"{i}");
            List.Insert(0, 100);
            Console.WriteLine($"Capacity ==> {List.Capacity} , conut ==>{List.Count}");
            List.TrimExcess();
            Console.WriteLine($"Capacity ==> {List.Capacity} , conut ==>{List.Count}");


            //****Remove
            //List.Remove(100);
            //List.RemoveAt(2);
            //List.RemoveRange(2, 2);
            //Console.WriteLine($"After remove");
            //foreach (int i in List)

            //    Console.WriteLine($"{i}");
            //List.Clear(); 
            //Console.WriteLine($"Capacity ==> {List.Capacity} , conut ==>{List.Count}");


            //****index
            //int firstElement =  List[0];
            //Console.WriteLine();
            //Console.WriteLine($"firstElement: {firstElement}");
            //List[7] = 800;
            //List[2] = 90000;

            //foreach (int i in List)
            //{

            //    Console.WriteLine($"{i}");
            //}


            //******Contains
            //bool flag = List.Contains(1000);
            //Console.WriteLine(flag);


            //****constructors
            //List = new List<int>() {1, 2, 3, 4, 5 };
            //List = new List<int>(10);
            //List = new List<int> (new int[] {1, 2, 3, 4 ,5});

            //******
            //List.EnsureCapacity(10);
            //Console.WriteLine();
            //Console.WriteLine($"Capacity ==>{List.Capacity}");
            //List.EnsureCapacity(10);






            #endregion





        }
    }
}
