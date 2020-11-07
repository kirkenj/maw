using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Transactions;

namespace OOP4.models
{
    public static class B7ArithmethicLogic
    {
        private static double Sum(double a, double b)
        { 
            return a + b;
        }

        private static double Dif(double a, double b)
        {
            return a - b;
        }

        private static double Mul(double a, double b)
        {
            return a * b;
        }

        private static double Dev(double a,double b)
        {
            try
            {
                return a / b;
            }
            catch(Exception)
            {
                return -1;
            }
        }
        private static double Mod(double a,double b)
        {
            try
            {
                return a % b;
            }
            catch (Exception)
            {
                return -1;
            }
        }


        public static double DoArithmetic(double aOperand, string act, double bOperand)
        {
            switch (act)
            {
                case "+":
                    {
                        return Sum(aOperand, bOperand);
                    }
                case "-":
                    {
                        return Dif(aOperand,bOperand);
                    }
                case "*":
                    {
                        return Mul(aOperand,bOperand);
                    }
                case "/":
                    {
                        return Dev(aOperand,bOperand);
                    }
                case "%":
                    {
                        return Mod(aOperand,bOperand);
                    }
                default:
                    {
                        return 0;
                    }
            }
        }
    }
}
