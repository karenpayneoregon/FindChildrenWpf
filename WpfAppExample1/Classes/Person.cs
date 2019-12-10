using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WpfAppExample1.Annotations;

namespace WpfAppExample1.Classes
{
    public class Person : INotifyPropertyChanged, IEditableObject
    {
        private Person _TempValues;
        private string _firstName;
        public int Id { get; set; }

        public string FirstName
        {
            get => _firstName;
            set
            {
                if (value == _firstName) return;
                _firstName = value;
                OnPropertyChanged();
            }
        }

        public string LastName { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void BeginEdit()
        {
            _TempValues = new Person()
            {
                Id = Id,
                FirstName = FirstName,
                LastName = LastName
            };
        }

        public void EndEdit()
        {
            _TempValues = null;
        }

        public void CancelEdit()
        {
            Id = _TempValues.Id;
            FirstName = _TempValues.FirstName;
            LastName = _TempValues.LastName;
        }
    }
}
/*
 * ICollectionView
 *
 *
 * DataGrid
 *  - Property IsSynchronizedWithCurrentItem
 *  https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.primitives.selector.issynchronizedwithcurrentitem?view=netframework-4.8
 */
