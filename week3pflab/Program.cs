using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3pflab
{
    class Program
    {
        class Task1
        {
            public Task1()
            {
                Console.WriteLine("Default Constructer Called ");
            }
        }

        class Task2
        {
            public Task2(string s)
            {
                sname = s;
            }
            public string sname;
            public float matricMarks;
            public float fscmarks;
            public float ecatmarks;
            public float aggregate;
        }
        class SelfAssessment
        {
            public SelfAssessment(string s, float m1, float m2, float m3, float m4)
            {
                sname = s;
                matricMarks = m1;
                fscmarks = m2;
                ecatmarks = m3;
                aggregate = m4;
            }
            public SelfAssessment(SelfAssessment obj)
            {
                sname = obj.sname;
                matricMarks = obj.matricMarks;
                fscmarks = obj.fscmarks;
                ecatmarks = obj.ecatmarks;
                aggregate = obj.aggregate;
            }
            public string sname;
            public float matricMarks;
            public float fscmarks;
            public float ecatmarks;
            public float aggregate;
        }


        static void Main(string[] args)
        {
            //task1();
            //task2();
            //SelfAssessmenttask1A();
            //SelfAssessmenttask1B();
            //CopyConstructer();
            //foreachloop();
            //ClockTypeTask();
            //Challange1();
            Challange2();
            Console.ReadKey();
        }
        static void task1()
        {
            Task1 obj = new Task1();
        }
        static void task2()
        {
            Task2 obj = new Task2("Bilal");
            Console.WriteLine(obj.sname);
            Console.ReadKey();
        }
        static void SelfAssessmenttask1A()
        {
            SelfAssessment obj1 = new SelfAssessment("bilal", 1012, 992, 161, 80.45F);
        }
        static void SelfAssessmenttask1B()
        {
            SelfAssessment obj1 = new SelfAssessment("bilal", 1012, 992, 161, 80.45F);
            SelfAssessment obj2 = new SelfAssessment("Usman", 1015, 1095, 208, 85.45F);
            SelfAssessment obj3 = new SelfAssessment("Bahaudin", 1015, 1008, 159, 81.42F);
            if (obj1.sname != obj2.sname && obj1.sname != obj3.sname && obj2.sname != obj3.sname)
            {
                Console.WriteLine("All the objects of given class has different values for its attributes");
            }
        }
        static void CopyConstructer()
        {
            SelfAssessment obj1 = new SelfAssessment("bilal", 1012, 992, 161, 80.45F);
            SelfAssessment obj2 = new SelfAssessment(obj1);
            Console.WriteLine(obj2.sname);
            Console.WriteLine(obj2.matricMarks);
            Console.WriteLine(obj2.fscmarks);
            Console.WriteLine(obj2.ecatmarks);
            Console.WriteLine(obj2.aggregate);
        }
        static void foreachloop()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
        static void ClockTypeTask()
        {

            ClockType emptytime = new ClockType(0, 0, 0);
            Console.Write("Empty Time: ");
            emptytime.printtime();
            ClockType hourtime = new ClockType(8);
            Console.Write("Hour Time: ");
            hourtime.printtime();
            ClockType minutetime = new ClockType(8, 10);
            Console.Write("Minute Time: ");
            minutetime.printtime();
            ClockType Fulltime = new ClockType(8, 10, 10);
            Console.Write("Full Time: ");
            Fulltime.printtime();
            Fulltime.incrementsecound();
            Console.Write("Full Time (Incremented Secound) : ");
            Fulltime.printtime();
            Fulltime.incrementhour();
            Console.Write("Full Time (Incremented hour) : ");
            Fulltime.printtime();
            Fulltime.incrementminute();
            Console.Write("Full Time (Incremented minute) : ");
            Fulltime.printtime();
            bool flag = Fulltime.isEqual(2, 6, 7);
            Console.WriteLine("Flag " + flag);
            bool objectflag = Fulltime.isEqualByObject(Fulltime);
            Console.WriteLine("ObjectFlag " + objectflag);
        }
        static void Challange1()
        {
            ClockType CurrentTime = new ClockType(8, 10, 10);
            ClockType ElapsedTime = new ClockType(0, 0, 0);
            ElapsedTime.ShowElapsedTime(CurrentTime);
            ClockType DayTime = new ClockType(24, 0, 0);
            ClockType RemainingTime = new ClockType(0, 0, 0);
            RemainingTime.ShowRemainingTime(DayTime, CurrentTime);
            ClockType Clock1 = new ClockType(8, 9, 11);
            ClockType Clock2 = new ClockType(12, 44, 19);
            ClockType Difference = new ClockType(0, 0, 0);
            Difference.ShowDifference(Clock1, Clock2);
        }
        static void Challange2()
        {
            List<Store> objects = new List<Store>();
            string option;
            int highest;
            
            do
            {
                Console.Clear();
                option = menu();
                if (option == "1")
                {
                    objects.Add(new Store());
                    objects.AddProduct();
                   
                }
                if(option=="2")
                {
                    ViewProducts(objects);
                }
                if(option=="3")
                {
                    highest = Highest(objects);
                    Console.WriteLine("Highest price of any product in our shop is " + highest);
                }
                if(option=="4")
                {
                    Console.WriteLine("Product Name                         Sales Tax");
                    for(int n=0;n<objects.Count;n++)
                    {
                        Console.WriteLine(objects[n].product_name + "                                   "+objects[n].CalculateTax());
                    }
                }
                if(option=="5")
                {
                    bool flag;
                    for (int n = 0; n < objects.Count; n++)
                    {
                        flag = objects[n].Objecttobeordered();
                        if (flag == true)
                        {
                            Console.WriteLine(objects[n].product_name + "      is needed to be ordered");
                        }
                    }
                }
                Console.ReadKey();
                
            } while (option != "6");
        }
        static string menu()
        {
            Console.WriteLine("1-AddProduct");
            Console.WriteLine("2-ViewProducts");
            Console.WriteLine("3-Find the Product with highest Price");
            Console.WriteLine("4-View Sales Tax of All Products");
            Console.WriteLine("5-Product to be ordered ");
            Console.WriteLine("Enter number between 1 to 5 to get respective functionalities");
            string choice = Console.ReadLine();
            return choice;
        }
        static void ViewProducts(List<Store> arr)
        {
            for(int i=0;i<arr.Count;i++)
            {
                Console.Write("Product Name: ");
                Console.WriteLine(arr[i].product_name);
                Console.Write("Product Category: ");
                Console.WriteLine(arr[i].product_category);
                Console.Write("Product Price: ");
                Console.WriteLine(arr[i].product_price);
                Console.Write("Stock Quantity: ");
                Console.WriteLine(arr[i].Stock_quantity);
                Console.Write("Minimum Quantity: ");
                Console.WriteLine(arr[i].Minimum_quantity);
                Console.WriteLine();
            }
        }
        static int Highest(List<Store> array)
        {
            int highest = array[0].product_price;
            for(int i=1;i<array.Count;i++)
            {
                if(highest<array[i].product_price)
                {
                    highest = array[i].product_price;
                }
            }
            return highest;
        }
    }
}

