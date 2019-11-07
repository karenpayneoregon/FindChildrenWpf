namespace WpfAppExample1.Classes
{
    public class HeaderInfo
    {
        public HeaderInfo()
        {
            TaxRatesField = 3;
            TaxRateInfo = new TaxRateInfo();

        }
        public int TaxRatesField { get; set; }
        public int WageBase { get; set; } = 45;
        public TaxRateInfo TaxRateInfo { get; set; }
    }
}