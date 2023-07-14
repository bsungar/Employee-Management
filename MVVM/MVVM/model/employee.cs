using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.model
{
    public class employee : INotifyPropertyChanged //first thing is making public INOTIFY Bir property'nin(özelliğin) değeri değiştiği zaman bu değişimi eş zamanlı olarak view(arayüz) kısmına bildirilmesini sağlar
    {

        private int? employeeAge;
        public int? EmployeeAge { get { return employeeAge; } set { employeeAge = value; OnPropertyChanged("EmployeeAge"); } }
        
        private string employeeName;    
        public string EmployeeName { get { return employeeName; } set { employeeName = value; OnPropertyChanged("EmployeeName"); } }

        private int? employeeID;
        public int? EmployeeID { get { return employeeID; } set { employeeID = value; OnPropertyChanged(nameof(EmployeeID)); } }
          
        
        public event PropertyChangedEventHandler PropertyChanged;
            private void OnPropertyChanged(string propertyName) //özelliğin değeri değiştiğinde anlamamızı sağlayan method 
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                }
            }
        }
    }


