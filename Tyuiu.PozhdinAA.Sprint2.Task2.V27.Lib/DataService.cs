﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PozhdinAA.Sprint2.Task2.V27.Lib
{
    public class DataService : ISprint2Task2V27
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if (((x >= 3) && (x <= 5) && (y >= 3) && (y <= 5)) || ((x == 3) && (y == 6)) || ((x >= 6) && (x <= 9) && (y >= 5) && (y <= 8)) || (x == 6) && (y >= 9) && (y <= 11) || (x >= 3) && (x <= 6) && (y == 11) || (x == 9) && (y >= 3) && (y <= 12) || (x >= 10) && (x <= 12) && (y >= 8) && (y <= 13) || (x == 13) && (y >= 6) && (y <= 8))

            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }
    }
}