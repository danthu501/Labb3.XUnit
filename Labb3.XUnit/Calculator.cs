using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3.XUnit
{
    public class Calculator
    {
        public decimal _FirstNumber { get; set; }
        public decimal _SecondNumber { get; set; }
        public decimal _Result { get; set; }
        public string? _MatematikSign { get; set; }


        public List<Calculator> _Calculations = new List<Calculator>();

      
        public void Calculate()
        {
            bool menuBool = true;


            while (menuBool)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("[1] Addition");
                Console.WriteLine("[2] Substraktion");
                Console.WriteLine("[3] Division");
                Console.WriteLine("[4] Multiplikation");
                Console.WriteLine("[5] Write all results");
                Console.WriteLine("[6] Quit");
                string menu = Console.ReadLine();


                switch (menu)
                {
                    case "1":
                        Addition();
                        break;
                    case "2":
                        Substraktion();
                        break;
                    case "3":
                        Division();
                        break;
                    case "4":
                        Multiplikation();
                        break;
                    case "5":
                        WriteAllCalculations();
                        break;
                    case "6":
                        menuBool = false;
                        break;
                    default:
                        Console.WriteLine("type a number from 1 to 5");
                        break;
                }
            }
        }

        public void Addition()
        {
            var Cal = GetNumbers();
            var calculation = Addition(Cal);
            var result = Result(calculation);
            WriteTheresult(result);
        }
        public void Substraktion()
        {
            var Cal2 = GetNumbers();
            var calculation1 = Substraktion(Cal2);
            var result = Result(calculation1);
            WriteTheresult(result);
        }
        public void Division()
        {
            var Cal3 = GetNumbers();
            var calculation2 = Division(Cal3);
            var result = Result(calculation2);
            WriteTheresult(result);
        }
        public void Multiplikation()
        {
            var Cal4 = GetNumbers();
            var calculation3 = Multiplikation(Cal4);
            var result =Result(calculation3);
            WriteTheresult(result);
        }
        public void WriteAllCalculations()
        {
    
            string allCal;
            foreach (var item in _Calculations)
            {
                allCal = item._FirstNumber + " " + item._MatematikSign + " " + item._SecondNumber + " = " + item._Result;
                Console.WriteLine(allCal);
            }
            Console.ReadKey();
            Console.Clear();
        }

        public string Result(Calculator calculator)
        {
            string result = calculator._FirstNumber + " " + calculator._MatematikSign + " " + calculator._SecondNumber + " = " + calculator._Result;

            return result;
        }
        public void WriteTheresult(string result)
        {
            Console.WriteLine(result);
            Console.ReadKey();
            Console.Clear();
        }

        public Calculator Addition(Calculator calculator)
        {
            var result = calculator._FirstNumber + calculator._SecondNumber;
            calculator._Result = result;
            calculator._MatematikSign = " + ";
            _Calculations.Add(calculator);
            return calculator;
        }

        public Calculator Substraktion(Calculator calculator)
        {
            var result = calculator._FirstNumber - calculator._SecondNumber;
            calculator._Result = result;
            calculator._MatematikSign = " - ";
            _Calculations.Add(calculator);
            return calculator;
        }

        public Calculator Division(Calculator calculator)
        {
            try
            {
                var result = calculator._FirstNumber / calculator._SecondNumber;
                calculator._Result = result;
                calculator._MatematikSign = " / ";
                _Calculations.Add(calculator);
                return calculator;
            }
            catch (Exception)
            {
                Console.WriteLine("You can not devide by zero");
                return calculator;
            }

        }

        public Calculator Multiplikation(Calculator calculator)
        {
            var result = calculator._FirstNumber * calculator._SecondNumber;
            calculator._Result = result;
            calculator._MatematikSign = " * ";
            _Calculations.Add(calculator);
            return calculator;
        }

        public Calculator GetNumbers()
        {
            var calculator = new Calculator();
            Console.WriteLine("Please enter two numbers");
            bool getnumbers;
            do
            {
                try
                {
                    Console.WriteLine("Write the first number");
                    string number1 = Console.ReadLine();
                    calculator._FirstNumber = decimal.Parse(number1);
                    getnumbers = false;

                }
                catch (Exception)
                {
                    Console.WriteLine("Please write a number");
                    getnumbers = true;
                }
            } while (getnumbers);

            do
            {
                try
                {
                    Console.WriteLine("Write the second number");
                    string number2 = Console.ReadLine();
                    calculator._SecondNumber = decimal.Parse(number2);
                    getnumbers = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Please write a number");
                    getnumbers = true;

                }
            } while (getnumbers);


            return calculator;
        }
    }

}
