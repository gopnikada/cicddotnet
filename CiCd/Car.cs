using System;
using System.Collections.Generic;
using System.Text;

namespace CiCd
{
    public class Car
    {
        public int _year { get; set; }
        public Car(int year)
        {
            _year = year;
        }
        
        public string GetYear()
        {
            switch (_year)
            {
                case int n when (n <= 2000):
                    return "old";
                case int n when (n > 2000 && n<=2015):
                    return "modern";
                case int n when (n >= 2015):
                    return "new";
                default:
                    return "";

            }
        }
    }
}
