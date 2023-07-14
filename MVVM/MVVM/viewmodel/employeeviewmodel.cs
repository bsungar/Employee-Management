using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM.Commands;
using MVVM.model;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using System.Net.Cache;

namespace MVVM.viewmodel


{
    class employeeviewmodel : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged_Implementation
        public event PropertyChangedEventHandler PropertyChanged;


        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
        EmployeeServices ObjEmployeeService;
        public employeeviewmodel()
        {
            ObjEmployeeService = new EmployeeServices();
            LoadData();
            currentEmployee = new employee();
            SaveCommand = new RelayCommand(Save);
            searchCommand = new RelayCommand(Search);
            deleteCommand = new RelayCommand(Delete);
            updateEmployee = new RelayCommand(Update);


        }

        #region Display Operation
        private ObservableCollection<employee> employeesList;

        public ObservableCollection<employee> EmployeeLists
        {
            get { return employeesList; }
            set { employeesList = value; OnPropertyChanged("EmployeeList"); }
        }




        private void LoadData()
        {
            EmployeeLists = new ObservableCollection<employee>(ObjEmployeeService.GetAll());
            OnPropertyChanged(nameof(EmployeeLists));
        }
        #endregion

        private employee currentEmployee;

        public employee CurrentEmployee
        {
            get { return currentEmployee; }
            set { currentEmployee = value; OnPropertyChanged("CurrentEmployee"); }
        }



        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; OnPropertyChanged("Message"); }
        }




        #region Save_Operation
        private RelayCommand SaveCommand;
        public RelayCommand saveCommand
        {
            get { return SaveCommand; }

        }

        public void Save()
        {
            try
            {
                var newEmp = new employee
                {
                    EmployeeAge = currentEmployee.EmployeeAge,
                    EmployeeID = currentEmployee.EmployeeID,
                    EmployeeName = currentEmployee.EmployeeName
                };

                var IsSaved = ObjEmployeeService.AddEmployee(newEmp);
                //currentEmployee = new();
                LoadData();

                if (IsSaved)
                {
                    Message = "Employee Saved";
                }
                else
                    Message = "Save operation failed.";
            }
            catch (Exception ex)
            {
                Message = ex.Message;

            }
        }
        #endregion
        #region Search_Operation
        private RelayCommand searchCommand;

        public RelayCommand SearchCommand
        {
            get { return searchCommand; }

        }

        public void Search()
        {
            try
            {
                var ObjEmployee = ObjEmployeeService.Search(currentEmployee.EmployeeID);
                if (ObjEmployee != null)
                {
                    CurrentEmployee.EmployeeName = ObjEmployee.EmployeeName;
                    CurrentEmployee.EmployeeID = ObjEmployee.EmployeeID;
                    CurrentEmployee.EmployeeAge = ObjEmployee.EmployeeAge;
                }
                else
                {
                    Message = "Employee Not Found.";
                }
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }

        }
        #endregion
        #region Delete_Operation
        private RelayCommand deleteCommand;


        public RelayCommand DeleteCommand
        {
            get { return deleteCommand; }
            set { deleteCommand = value; }
        }

        public void Delete()
        {
            try
            {
                var IsDelete = ObjEmployeeService.DeleteEmployee(currentEmployee);
                if (IsDelete)
                {
                    Message = "Employee Deleted.";
                    LoadData();
                }
                else
                {
                    Message = "Employee cannot deleted.";
                }

            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
            
        }
        #endregion



        private RelayCommand UpdateEmployee;

        public RelayCommand updateEmployee
        {
            get { return UpdateEmployee; }
            set { UpdateEmployee = value; }
        }

        public void Update()
        {
            var IsUpdated = ObjEmployeeService.UpdateEmployee(currentEmployee);
            try
            {
                if (IsUpdated)
                {

                    message = "Employee Updated.";
                }
                else
                {
                    message = "Update operation has failed.";
                }
            }
            catch(Exception ex)
            {
                message = ex.Message;
            }
        }



    }



}


    


    

