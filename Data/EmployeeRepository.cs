using System;
using Data.DataModel;

namespace Data
{
    public interface IEmployeeRepository
    {
        EmployeeDto GetEmployeeDetails();
    }
    public class EmployeeRepository : IEmployeeRepository
    {
        public EmployeeDto GetEmployeeDetails()
        {
            // In real time scenario data will be fetched from database
            // Mocking Data for sample coding demo

            return new EmployeeDto()
            {
                EmployeeId = "1111",
                EmployeeName = "Alex"
            };
        }
    }
}
