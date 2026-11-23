using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ShurlyginDS.Sprint3.Task3.V18.Lib
{
    public class DataService : ISprint3Task3V18
    {
        public string ReplaceNumOnChar(string value, char item)
        {
            string res = "";

            foreach (char symbol in value)
            {
                if (char.IsDigit(symbol))
                {
                    res += item;
                }
                else
                {
                    res += symbol;
                }
            }

            return res;
        }
    }
}