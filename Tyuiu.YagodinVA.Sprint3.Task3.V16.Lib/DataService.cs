﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.YagodinVA.Sprint3.Task3.V16.Lib
{
    public class DataService : ISprint3Task3V16
    {
        public int GetCharCount(string value, char item)
        {
            int count = 0;
            foreach (char letter in value)
            {
                if (letter == 'c')
                {
                    count += 1;
                }
            }
            return count;
        }
    }
}
