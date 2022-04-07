﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOverloadingMethod
{
    internal class Numbers
    {
        public int FindMinimum(int number1, int number2)
        {
            int minim;
            
            if (number1 < number2)
            {
                minim = number1;
            } else
            {
                minim = number2;
            }

            return minim;
        }

        public int FindMinimum(int number1, int number2, float number3)
        {
            int minim;

            if ((number1 < number2) && (number1 < number3))
            {
                minim = number1;
            } else if ((number2 < number3) && (number2 < number1))
            {
                minim = number2;
            } else
            {
                minim = (int)number3;
            }

            return minim;
        }

        public int FindMaximum(int number1, int number2)
        {
            int maxim;

            if(number1 > number2)
            {
                maxim = number1;
            } else
            {
                maxim = number2;
            }

            return maxim;
        }

        public int FindMaximum(int number1, int number2, float number3)
        {
            int maximum;

            if((number1 > number2) && (number1 > number3))
            {
                maximum = number1;
            } else if((number2 > number3) && (number2 > number1))
            {
                maximum = number2;
            } else
            {
                maximum = (int)number3;
            }

            return maximum;
        }

    }
}
