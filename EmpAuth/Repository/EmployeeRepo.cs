using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmpAuth.Models;

namespace EmpAuth.Repository
{
    public class EmployeeRepo
    {
        

        public int AddEmployee(EmployeeModel model)
        {
            using (var context = new EmpAuthEntities())
            {
                Employee employee  = new Employee()
                {
                    Name = model.Name,
                    DOB = model.DOB,
                    Email = model.Email,
                    Phone = model.Phone,
                };

                context.Employee.Add(employee);
                context.SaveChanges();

                return employee.Id;

            }
        }
        public List<EmployeeModel> GetAllData()
        {
            using (var context = new EmpAuthEntities())
            {
                var result = context.Employee.Select(x => new EmployeeModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    DOB = x.DOB,
                    Email = x.Email,
                    Phone = x.Phone,
                }
                ).ToList();
                return result;
            }
        }

        public EmployeeModel GetDetails(int id)
        {
            using (var context = new EmpAuthEntities())
            {
                var result = context.Employee.Where(x => x.Id == id).Select(x => new EmployeeModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    DOB = x.DOB,
                    Email = x.Email,
                    Phone = x.Phone,
                }
                ).FirstOrDefault();

                return result;
            }
        }
        public bool UpdateData(int id, EmployeeModel model)
        {
            using (var context = new EmpAuthEntities())
            {

                var Employee = context.Employee.FirstOrDefault(x => x.Id == id);
                if (Employee != null)
                {
                    Employee.Name = model.Name;
                    Employee.Email = model.Email;
                    Employee.Phone = model.Phone;
                    Employee.DOB = model.DOB;
                }

                context.SaveChanges();

                return true;
            }
        }

        public bool DeleteData(int id)
        {
            using (var context = new EmpAuthEntities())
            {
                var Employee = context.Employee.FirstOrDefault(x => x.Id == id);
                if (Employee != null)
                {
                    context.Employee.Remove(Employee);
                    context.SaveChanges();
                    return true;
                }

                return false;
            }
        }
    }
}