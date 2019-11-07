using System;

namespace WpfAppExample1.Classes
{
    public class TaxRateInfo
    {
        public int Year { get; set; } = DateTime.Now.Year -2;
        public int APR { get; set; } = 9;
    }
}