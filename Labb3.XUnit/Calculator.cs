using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3.XUnit
{
    public class Calculator
    {
        public double _FirstNumber { get; set; }
        public double _SecondNumber { get; set; }
        public double _Result { get; set; }
        public string? _MatematikSign { get; set; }

        List<Calculator> _Calculations = new List<Calculator>();


        public double Addition(Calculator calculator)
        {
            var result = calculator._FirstNumber + calculator._SecondNumber;
            calculator._Result = result;
            calculator._MatematikSign = " + ";
            WriteResult(calculator);
            _Calculations.Add(calculator);
            return result;
        }

        public double Substraktion(Calculator calculator)
        {
            var result = calculator._FirstNumber - calculator._SecondNumber;
            calculator._Result = result;
            calculator._MatematikSign = " - ";
            WriteResult(calculator);
            _Calculations.Add(calculator);
            return result;
        }

        public double Division(Calculator calculator)
        {
            var result = calculator._FirstNumber / calculator._SecondNumber;
            calculator._Result = result;
            calculator._MatematikSign = " / ";
            WriteResult(calculator);
            _Calculations.Add(calculator);
            return result;
        }

        public double Multiplikation(Calculator calculator)
        {
            var result = calculator._FirstNumber * calculator._SecondNumber;
            calculator._Result = result;
            calculator._MatematikSign = " * ";
            WriteResult(calculator);
            _Calculations.Add(calculator);
            return result;
        }

        public Calculator GetNumbers()
        {
            var calculator = new Calculator();
            Console.WriteLine("Var god att ange 2 siffor");
            bool getnumbers;
            do
            {
                try
                {
                    Console.WriteLine("Ange den första siffran");
                    string number1 = Console.ReadLine();
                    calculator._FirstNumber = double.Parse(number1);
                    getnumbers = false;

                }
                catch (Exception)
                {
                    Console.WriteLine("Var god ange en siffra");
                    getnumbers = true;
                }
            } while (getnumbers);

            do
            {
                try
                {
                    Console.WriteLine("Ange den andra siffran");
                    string number2 = Console.ReadLine();
                    calculator._SecondNumber = double.Parse(number2);
                    getnumbers = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Var god ange en siffra");
                    getnumbers = true;

                }
            } while (getnumbers);
         
           
            return calculator;
        }


        public void Calculate()
        {
            bool menuBool = true;

            while (menuBool)
            {
                Console.WriteLine("Meny");
                Console.WriteLine("[1] Addition");
                Console.WriteLine("[2] Substraktion");
                Console.WriteLine("[3] Division");
                Console.WriteLine("[4] Multiplikation");
                Console.WriteLine("[5] Write all results");
                Console.WriteLine("[6] Quit");

                int menu;
                Int32.TryParse(Console.ReadLine(), out menu);

                switch (menu)
                {
                case 1:
                        var Cal = GetNumbers();
                        Addition(Cal);
                    break;
                case 2:
                        var Cal2 = GetNumbers();
                        Substraktion(Cal2);
                    break;
                case 3:
                        var Cal3 = GetNumbers();
                        Division(Cal3);
                    break;
                case 4:
                        var Cal4 = GetNumbers();
                        Multiplikation(Cal4);
                    break;
                case 5:
                        WriteAllCalculations();
                    break;
                case 6:
                        menuBool = false;
                     break;
                default:
                        Console.WriteLine("type a number from 1 to 5");
                    break;
                }
            }

        }

        public void WriteAllCalculations()
        {
            foreach (var item in _Calculations)
            {
                Console.WriteLine(item._FirstNumber +" "+ item._MatematikSign +" "+ item._SecondNumber+" = " + item._Result); 
            }
            Console.ReadKey();
            Console.Clear();
        }

        public void WriteResult(Calculator calculator)
        {
            Console.WriteLine(calculator._FirstNumber + " " + calculator._MatematikSign + " " + calculator._SecondNumber + " = " + calculator._Result);
            Console.ReadKey ();
            Console.Clear ();
        }

    }

}
