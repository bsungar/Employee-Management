using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.model
{
    public class EmployeeServices
    {
        private  List<employee> ObjEmployeesList=new();

       




        public EmployeeServices()
        {
            ObjEmployeesList  = new List<employee>()
            {
                new employee { EmployeeID = 21, EmployeeAge = 21, EmployeeName = "Beyza Sungar" },
                new employee { EmployeeID = 22, EmployeeAge = 55, EmployeeName = "Atilla Sungar" },
                new employee { EmployeeID = 23, EmployeeAge = 29, EmployeeName = "Furkan Baytak" }
            };

            
        }
        public List<employee> GetAll()
        {
            return ObjEmployeesList;
        }

        public bool AddEmployee(employee objnewemployee)
        {
            // Age must be between 21 and 58 
            if (objnewemployee.EmployeeAge < 21 || objnewemployee.EmployeeAge > 58)
            {
                throw new ArgumentException("Invalid age limit for employee.");
            }
            else
            {
                ObjEmployeesList.Add(objnewemployee);
                return true;
            }
        }
        public bool UpdateEmployee(employee objupemployee)
        {
            bool IsUpdated = false;
            for (int i = 0; i < ObjEmployeesList.Count; i++)
            {
                if (ObjEmployeesList[i].EmployeeID == objupemployee.EmployeeID)
                {
                    ObjEmployeesList[i].EmployeeName = objupemployee.EmployeeName;
                    ObjEmployeesList[i].EmployeeAge = objupemployee.EmployeeAge;
                    ObjEmployeesList[i].EmployeeID = objupemployee.EmployeeID;

                    IsUpdated = true;
                    break;
                }
            }
            return IsUpdated;
        }

        public bool DeleteEmployee(employee objdelemployee)
        {
            bool IsDeleted = false;
            for (int i = 0; i < ObjEmployeesList.Count; i++)
            {
                if (ObjEmployeesList[i].EmployeeID == objdelemployee.EmployeeID)
                {
                    ObjEmployeesList.RemoveAt(i);
                    IsDeleted = true; break;
                }

            }
            return IsDeleted;


        }

        public employee Search(int? id)
        {
            return ObjEmployeesList.FirstOrDefault(e => e.EmployeeID == id);
        }
    }
}