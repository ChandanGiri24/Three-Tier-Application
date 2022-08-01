using System;
using Data.DataModel;

namespace Web.Application.Models
{
    public class EmployeeViewModel
    {
        public EmployeeViewModel()
        {
        }
        public Employee GetEmployeeInformation(EmployeeDto dto)
        {
            var empDetails = new Employee();

            if (dto.EmployeeId != string.Empty)
            {
                empDetails.EmployeeId = dto.EmployeeId;
                empDetails.EmployeeName = dto.EmployeeName;
            }
            return empDetails;
        }
    }
}
