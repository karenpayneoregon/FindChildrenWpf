using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppExample1.Classes
{
    /// <summary>
    /// For Binding to Main View
    /// </summary>
    public class Quarter
    {
        public int AuditId { get; set; } = 90;
        public int Month01 { get; set; }
        public int Month02 { get; set; }
        public int Month03 { get; set; }
        public int Month04 { get; set; }
        public int Month05 { get; set; }
        public int Month06 { get; set; }
        public int Month07 { get; set; }
        public int Month08 { get; set; }
        public int Month09 { get; set; }
        public int Month10 { get; set; }
        public int Month11 { get; set; }
        public int Month12 { get; set; }
        public int Q1ExcessWage { get; set; }
        public int Q1Supplemental { get; set; }
        public int Q3Supplemental { get; set; }
        public int Q1SubjectWage { get; set; }
        public int Q2SubjectWage { get; set; }
        public int Q3SubjectWage { get; set; }
        public int Q4SubjectWage { get; set; }
        public int Q2ExcessWage { get; set; }
        public int Q3ExcessWage { get; set; }
        public int Q4ExcessWage { get; set; }
        public int Q1TaxableWage { get; set; }
        public int Q2TaxableWage { get; set; }
        public int Q3TaxableWage { get; set; }
        public int Q4TaxableWage { get; set; }
        public int Q1TaxDue { get; set; }
        public int Q2TaxDue { get; set; }
        public int Q3TaxDue { get; set; }
        public int Q4TaxDue { get; set; }
        public int Q1Interest { get; set; }
        public int Q2Interest { get; set; }
        public int Q3Interest { get; set; }
        public int Q4Interest { get; set; }
        public int Q1AmountDue { get; set; }
        public int Q2AmountDue { get; set; }
        public int Q3AmountDue { get; set; }
        public int Q4AmountDue { get; set; }
        public bool IsNotReadOnly { get; set; } = true;
        public HeaderInfo HeaderInfo { get; set; }
    }
}
