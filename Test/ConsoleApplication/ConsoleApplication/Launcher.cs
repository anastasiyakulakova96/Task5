using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Math;
using NUnit;
using OpenQA.Selenium;
using Microsoft.VisualStudio.QualityTools.UnitTestFramework;
using System.Configuration;



namespace ConsoleApplication
{
    class Launcher
    {
        int firstNumber=0;
        int secondNumber=0;
        Calculator calc = new Calculator();
        string chooseClass = ConfigurationManager.AppSettings["chooseClass"];
        string readDate = ConfigurationManager.AppSettings["readDate"];


        static void Main(string[] args)
        {
            Launcher launcher = new Launcher();
            launcher.ChooseOfReading();
        }

        void ChooseOfReading()
        {
            if (chooseClass.Equals("consolClass")) //читает из класса консоль
            { 
                if (readDate.Equals("consol")) //читает из консоли
                {
                    EnterNumber();
                }
                else // читает из ресур файла
                {
                    firstNumber = Int32.Parse(Resource.firstNumber); 
                    secondNumber = Int32.Parse(Resource.secondNumber); 
                }

                long sum = (long)(firstNumber + secondNumber);
                Console.WriteLine("sum=" + sum);
                Console.ReadLine();
            }
            else
            {
                if (readDate.Equals("consol")) //читает из консоли
                {
                    EnterNumber();
                    Result(firstNumber, secondNumber);
                }
                else // читает из ресур файла
                {
                    firstNumber = Int32.Parse(Resource.firstNumber);
                    secondNumber = Int32.Parse(Resource.secondNumber);
                    Result(firstNumber, secondNumber);
                }
            }
        }

        void EnterNumber()
        {
            Console.WriteLine("Enter integer first number ");
            while (!int.TryParse(Console.ReadLine(), out firstNumber))
            {
                Console.WriteLine("Exception!!Please enter first number again ");
            }
             
            Console.WriteLine("Enter integer second number ");
            while (!int.TryParse(Console.ReadLine(), out secondNumber))
            {
                Console.WriteLine("Exception!Please enter second number again ");
            }
        }

        void Result(int firstNumber, int secondNumber)
        {
            long sum = calc.Sum(firstNumber, secondNumber);
            long subtraction = calc.Subtraction(firstNumber, secondNumber);
            long multiplication = calc.Multiplication(firstNumber, secondNumber);
            double division = calc.Division(firstNumber, secondNumber);

            Console.WriteLine($"first number={firstNumber}, second number= {secondNumber} ");
            Console.WriteLine($"sum= {sum} , subtraction= {subtraction}, multiplication= {multiplication}, division= {division}");
            Console.WriteLine("Enter any symbol to exit ");

            int exit = Int32.Parse(Console.ReadLine());

        }
    }
}
