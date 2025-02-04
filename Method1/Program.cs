using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method1
{
    internal class Program
    {
        static double HandleDoubleInput(string aMessage) //aMessage is a parameter/arguement/input of method HandleDoubleInput
        {
            double returnValue = Double.MaxValue;
            do
            {
                try
                {
                    Console.WriteLine(aMessage);
                    returnValue = Convert.ToDouble(Console.ReadLine()); //this method can trigger an exception when wrong format number is input
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid Input, Please input a valid number");
                }

            } while (returnValue == Int32.MaxValue);//keep repeating when the variable still has the initiate value -until the variable does not have the initiate value
          return returnValue;
        }
        static int HandleDoubleInput(string aMessage) //aMessage is a parameter/arguement/input of method HandleDoubleInput
        {
            double returnValue = Int32.MaxValue;
            do
            {
                try
                {
                    Console.WriteLine(aMessage);
                    returnValue = Convert.ToDouble(Console.ReadLine()); //this method can trigger an exception when wrong format number is input
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid Input, Please input a valid number");
                }

            } while (returnValue == Int32.MaxValue);//keep repeating when the variable still has the initiate value -until the variable does not have the initiate value
            return returnValue;
        }
        static int HandleDoubleInput(string aMessage, string anError) //aMessage is a parameter/arguement/input of method HandleDoubleInput
        {
            double returnValue = Int32.MaxValue;
            do
            {
                try
                {
                    Console.WriteLine(aMessage);
                    returnValue = Convert.ToInt32(Console.ReadLine()); //this method can trigger an exception when wrong format number is input
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid Input, Please input a valid number");
                }

            } while (returnValue == Int32.MaxValue);//keep repeating when the variable still has the initiate value -until the variable does not have the initiate value
            return returnValue;
        }
            static void Main(string[] args)
        {

            //quiz: calculate the total cost of a sale

            //declaration

            double tax;
            double price = Double.MaxValue; //initiate value
            double promotion = Double.MaxValue;
            double totalSale = Double.MaxValue;

            //ask for the price
            //keep asking user to input a value until a valid input
            price = HandleDoubleInput("What is the price?");
            

            //ask for the promotion
            
            promotion = HandleDoubleInput("What is the promotion?");

            //ask for tax
            tax = HandleDoubleInput("How much is the tax?");
            

            //calculate total
            totalSale = price*(1-promotion)* (1+tax);

            int customerBill = HandleIntegerInput("How much customer pay?" , "Bill should be a whole number");
            Console.WriteLine(totalSale);

            Console.Read();

        }
    }
}
