using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppExample1.Classes;
using WpfAppExample1.ViewModel.BaseClasses;

namespace WpfAppExample1.ViewModel
{
    public class QuarterViewModel : ViewModelBase
    {
        public Quarter Quarter { get; set; }
        public ObservableCollection<Quarter> QuarterList { get; set; }

        public QuarterViewModel()
        {
            Quarter = new Quarter()
            {
                Month01 = 1,
                Month02 = 2,
                Month03 = 3,
                Month04 = 4,
                Month05 = 5,
                Month06 = 6,
                Month07 = 7,
                Month08 = 8,
                Month09 = 9,
                Month10 = 10,
                Month11 = 0,
                Month12 = 33,
                HeaderInfo = new HeaderInfo()
            };

            QuarterList = new ObservableCollection<Quarter>
            {
                new Quarter() {AuditId = 1},
                new Quarter() {AuditId = 2},
                new Quarter() {AuditId = 3},
                new Quarter() {AuditId = 4}
            };
        }
    }
}
