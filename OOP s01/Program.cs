using System.Drawing;

namespace OOP_s01
{

    internal enum WeakDays
    {
        monday, tuesday, wednesday, thursday, friday, saturday, sunday

    }
    internal enum Season
    {
        Spring, Summer, Autumn, Winter
    }
    [Flags]
    internal enum Permissions : byte
    {
        Read = 1, Write = 2, Delete = 4, Execute = 8
    }
    [Flags]
    internal enum Colors : byte
    {
        Red = 1, Green = 2, Blue = 4
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            #region #1 Enum for weakDays
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine((WeakDays)i);
            };

            #endregion
            #region #2 Array Of Type Person


            //person[] per = new person[3];
            //per[0] = new person("mostafa",19);
            //per[1] = new person("mohamed", 20);
            //per[2] = new person("afify", 24);

            //for (int i = 0; i < per.Length; i++) 
            //{
            //    Console.WriteLine(per[i]);
            //}





            #endregion
            #region #3 EnumForSeasons
            //int z = 0 ;
            //string name;
            //Console.WriteLine("PleaseInputTheSeason");
            //name = Console.ReadLine();
            //Enum.TryParse<Season>(name,true, out Season s1);           
            //if (s1 == (Season)0)
            //{
            //    Console.WriteLine($"theMonthRangeForTheThatSeason [{s1}] isFrom March =>> May");
            //}
            //else if (s1 == (Season)1)
            //{
            //    Console.WriteLine($"theMonthRangeForTheThatSeason [{s1}]  isFrom june =>> august");
            //}
            //else if (s1 == (Season)2) 
            //{
            //    Console.WriteLine($"theMonthRangeForTheThatSeason [{s1}]  isFrom September =>> November");
            //}
            //else if (s1 == (Season)3)
            //{
            //    Console.WriteLine($"theMonthRangeForTheThatSeason [{s1}]  isFrom December =>> February");
            //}
            #endregion
            #region #4 EnumForPermations
            //Permissions per1 = (Permissions)7;
            //Console.WriteLine(per1);
            //per1 = per1 | Permissions.Execute;
            //Console.WriteLine(per1);
            //per1 &= ~ Permissions.Execute;
            //Console.WriteLine(per1);
            //if ((per1 & Permissions.Execute) ==Permissions.Execute)
            //{
            //    Console.WriteLine("Permission is existed ");
            //}
            //else
            //{
            //    Console.WriteLine("Permission is [NOT] existed ");
            //}
            #endregion
            #region #5 EnumForColors
            //Colors colors = new Colors();
            //Console.WriteLine("PleaseEnterColor");
            //string colName = Console.ReadLine();
            //Enum.TryParse(colName, true, out colors);
            //if ((colors & Colors.Red) == Colors.Red)
            //{
            //    Console.WriteLine("that'sPrimaryColor");
            //}
            //else if ((colors & Colors.Blue) == Colors.Blue)
            //{
            //    Console.WriteLine("that'sPrimaryColor");
            //}
            //else
            //{
            //    Console.WriteLine("that'sNotPrimaryColor");
            //}
            #endregion
            #region #6 Create a struct called "Point" to represent a 2D point 
            //Console.WriteLine("pleaseEnterTheFirestPoint[X,Y]");
            //Point p1 = new Point();
            //Console.Write("X = ");
            //p1.X = int.Parse(Console.ReadLine());
            //Console.Write("Y = ");
            //p1.Y = int.Parse(Console.ReadLine());          
            //Console.WriteLine("pleaseEnterTheSecondPoint[X,Y]");
            //Point p2 = new Point();
            //Console.Write("X = ");
            //p2.X = int.Parse(Console.ReadLine());
            //Console.Write("Y = ");
            //p2.Y = int.Parse(Console.ReadLine());

            //double distance;
            //distance = Math.Sqrt(Math.Pow(p1.X - p2.X, 2 )+ Math.Pow(p1.Y - p2.Y , 2));
            //Console.WriteLine($"TheDistanceBetween2PointIs {distance}");







            #endregion
            #region #7 Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
            person[] per = new person[3];
            per[0] = new person();
            Console.Write("EnterNameOF(Person1) : ");
            per[0].Name = Console.ReadLine();
            Console.Write("EnterAgeOf(Person1) : ");
            per[0].Age = int.Parse(Console.ReadLine());

            per[1] = new person();
            Console.Write("EnterNameOF(Person2) :");
            per[1].Name = Console.ReadLine();
            Console.Write("EnterAgeOf(Person2) : ");
            per[1].Age = int.Parse(Console.ReadLine());

            per[2] = new person();
            Console.Write("EnterNameOF(Person3) :");
            per[2].Name = Console.ReadLine();
            Console.Write("EnterAgeOf(Person3) : ");
            per[2].Age = int.Parse(Console.ReadLine());

            for (int i = 0; i < per.Length; i++)
            {
                int count = 1;
                for (int j = 0 ; j < per.Length; j++)
                {
                    if (per[i].Age > per[j].Age )
                    {
                        count++;
                    }
                    
                }
                if (count == 3)
                {

                    Console.WriteLine($"theOldestPersonIs =>> {per[i]}");
                }
                
                
                Console.WriteLine(per.Max(x => x.Age));

            }

            

            #endregion
        }
    }
}
