using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Transactions;

namespace OOP4.models
{
    public static class B7ArithmethicLogic
    {
        private static double GetSum(double a, double b)
        { 
            return a + b;
        }

        private static double GetDif(double a, double b)
        {
            return a - b;
        }

        private static double GetMul(double a, double b)
        {
            return a * b;
        }

        private static double GetDev(double a,double b)
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
        private static double GetMod(double a,double b)
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
                        return GetSum(aOperand, bOperand);
                    }
                case "-":
                    {
                        return GetDif(aOperand,bOperand);
                    }
                case "*":
                    {
                        return GetMul(aOperand,bOperand);
                    }
                case "/":
                    {
                        return GetDev(aOperand,bOperand);
                    }
                case "%":
                    {
                        return GetMod(aOperand,bOperand);
                    }
                default:
                    {
                        return 0;
                    }
            }
        }
    }
}
