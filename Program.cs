using System;
using System.Collections.Generic;

namespace htc_final_project_Cehelnik
{
    class Program
    {
        static void Main(string[] args)
        {
            bool KeepGoing = true;

            while (KeepGoing) {
                Console.WriteLine("What do you need to calculate?");
                //area of a triangle, perimeter of a triangle, area of a square
                
                List<string> calculator = new List<string>(){"Area of a Triangle", "Perimeter of a Triangle","Area of a Square", "Perimeter of a Square", "Area of a Circle", "Circumference of a Circle", "DO NOT ENTER SPELLED OUT NUMBERS BOBBY"};
                foreach(string area in calculator){
                    Console.WriteLine(area);
                }
                string choice = Console.ReadLine();
                if (choice == "Area of a Triangle"){
                    double val = aTriangle();
                    Console.WriteLine(val);
                }
                else if (choice == "Perimeter of a Triangle"){
                    double valu = pTriangle();
                    Console.WriteLine(valu);
                }
                else if (choice == "Area of a Square"){
                    double value1 = aSquare();
                    Console.WriteLine(value1);
                }
                else if (choice == "Perimeter of a Square"){
                    double value2 = psquare();
                    Console.WriteLine(value2);
                }
                else if (choice == "Area of a Circle"){
                    double value3 = aCircle();
                    Console.WriteLine(value3);
                }
                else if (choice == "Circumference of a Circle"){
                    double value4 = pCircle();
                    Console.WriteLine(value4);
                }
                else {
                    Console.WriteLine("(Your opinion) Not valid");
                }

                Console.WriteLine("Do you want continue? Y or N");
                string YN = Console.ReadLine();
                if (YN == "Y"){
                    KeepGoing = true;
                }
                else if (YN == "N"){
                    KeepGoing = false;
                }
                else{
                    Console.WriteLine("That's not an Y or X");
                    Console.WriteLine("Are you Bobby? Y or N");
                    string WhoareYou = Console.ReadLine();
                    if(WhoareYou == "Y"){
                        Console.WriteLine("Bobby leave");
                    }
                    else if (WhoareYou == "N"){
                        Console.WriteLine("Okay you're fine have nice day");
                    }
                    else {
                        Console.WriteLine("Bobby I know it's you leave");
                    }
                }
            }
        }
        //Copy aTriangle and change to type 
        public static double aTriangle (){
                Console.WriteLine("Enter X values: ");
                string xValue = Console.ReadLine();
                double XValue = Convert.ToDouble(xValue);

                Console.WriteLine("Enter Y value: ");
                string yValue = Console.ReadLine();
                double YValue = Convert.ToDouble(yValue);

                double XYValues = XValue * YValue;
                double finaltriangle = XYValues / 2;
                return finaltriangle;
            
        }
         public static double aSquare(){
                Console.WriteLine("Enter X values: ");
                string xValue = Console.ReadLine();
                double XValue = Convert.ToDouble(xValue);

                Console.WriteLine("Enter Y value: ");
                string yValue = Console.ReadLine();
                double YValue = Convert.ToDouble(yValue);
                
                double XYValues = XValue * YValue;
                return XYValues;
            
        }
        //pTriangle chage to A B C make it plus
        public static double pTriangle (){
                Console.WriteLine("Enter A values: ");
                string aValue = Console.ReadLine();
                double AValue = Convert.ToDouble(aValue);

                Console.WriteLine("Enter B value: ");
                string bValue = Console.ReadLine();
                double BValue = Convert.ToDouble(bValue);

                Console.WriteLine("Enter C value: ");
                string cValue = Console.ReadLine();
                double CValue = Convert.ToDouble(cValue);

                double ABCValues = AValue + BValue + CValue;
                return ABCValues;
            
        }
        public static double psquare(){
                Console.WriteLine("Enter X values: ");
                string xValue = Console.ReadLine();
                double XValue = Convert.ToDouble(xValue);

                Console.WriteLine("Enter Y value: ");
                string yValue = Console.ReadLine();
                double YValue = Convert.ToDouble(yValue);

                double XYXYValues = XValue + YValue + XValue + YValue;
                return XYXYValues;
        }
        public static Double aCircle(){
            Console.WriteLine("Enter R value: ");
            string rValue = Console.ReadLine();
            Double Rvalue = Convert.ToDouble(rValue);

            Double rpiValue = Rvalue * Rvalue * 3.14159265359;
            return rpiValue;

        }
        public static Double pCircle(){
            Console.WriteLine("Enter R value");
            string rvalue = Console.ReadLine();
            Double RValue = Convert.ToDouble(rvalue);

            Double RPValue = 2 * 3.14159265359 * RValue;
            return RPValue;

        }
    }
}
