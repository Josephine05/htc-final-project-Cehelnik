using System;

namespace htc_final_project_Cehelnik
{
    class Program
    {
        static void Main(string[] args)
        {
            bool KeepGoing = true;

            while (KeepGoing == true) {
            Console.WriteLine("What do you need to calculate?");
           //area of a triangle, perimeter of a triangle, area of a square
           list <string> calculator = new list<string>(){"Area of a Triangle", "Perimeter of a Triangle","Area of a Square", "Perimeter of a Square", "Area of a Circle", "Perimeter of a Circle"};

            string choice = Console.ReadLine();
                        if (choice == "Area of a Triangle"){
                            int val = aTriangle();
                            Console.WriteLine(val);
                        }
                        else if (choice == "Perimeter of a Triangle"){
                            int valu = pTriangle();
                            Console.WriteLine(valu);
                        }
                        else if (choice == "Area of a Square"){
                            int value1 = aSquare();
                            Console.WriteLine(value1);
                        }
                        else if (choice == "Perimeter of a Square"){
                            int value2 = psquare();
                            Console.WriteLine(value2);
                        }

            Console.WriteLine("Do you want continue? Y or N");
            string YN = Console.ReadLine();
            if (YN == "Yes"){
                KeepGoing = true;
            }
            else {
                KeepGoing = false;
            }
            }
        }
        //Copy aTriangle and change to type 
        public static int aTriangle (){
                Console.WriteLine("Enter X values: ");
                string xValue = Console.ReadLine();
                int XValue = Convert.ToInt32(xValue);

                Console.WriteLine("Enter Y value: ");
                string yValue = Console.ReadLine();
                int YValue = Convert.ToInt32(yValue);

                int XYValues = XValue * YValue;
                int finaltriangle = XYValues / 2;
                return finaltriangle;
            
        }
         public static int aSquare(){
                Console.WriteLine("Enter X values: ");
                string xValue = Console.ReadLine();
                int XValue = Convert.ToInt32(xValue);

                Console.WriteLine("Enter Y value: ");
                string yValue = Console.ReadLine();
                int YValue = Convert.ToInt32(yValue);
                
                int XYValues = XValue * YValue;
                return XYValues;
            
        }
        //pTriangle chage to A B C make it plus
        public static int pTriangle (){
                Console.WriteLine("Enter A values: ");
                string aValue = Console.ReadLine();
                int AValue = Convert.ToInt32(aValue);

                Console.WriteLine("Enter B value: ");
                string bValue = Console.ReadLine();
                int BValue = Convert.ToInt32(bValue);

                Console.WriteLine("Enter C value: ");
                string cValue = Console.ReadLine();
                int CValue = Convert.ToInt32(cValue);

                int ABCValues = AValue + BValue + CValue;
                return ABCValues;
            
        }
        public static int psquare(){
                Console.WriteLine("Enter X values: ");
                string xValue = Console.ReadLine();
                int XValue = Convert.ToInt32(xValue);

                Console.WriteLine("Enter Y value: ");
                string yValue = Console.ReadLine();
                int YValue = Convert.ToInt32(yValue);

                int XYXYValues = XValue + YValue + XValue + YValue;
                return XYXYValues;
        }
    }

