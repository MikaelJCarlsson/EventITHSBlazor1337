using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ITHSManagement.Data;

namespace ITHSManagement.Models
{
    public class EmployeeService
    {
        public List<Student> GetEmployeesFromExcel()
        {
            List<Student> employees = new List<Student>();
            string filePath = @"..\EventITHSBlazor1337\Data\UserTest.xlsx";

            FileInfo fileInfo = new FileInfo(filePath);

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage excelPackage = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.FirstOrDefault();
                int totalColumns = worksheet.Dimension.End.Column;
                int totalRows = worksheet.Dimension.End.Row;

                for (int row = 1; row <= totalRows; row++)
                {
                    Student student = new Student();

                    for (int col = 1; col < totalColumns; col++)
                    {
                        if (col == 1) student.FirstName = worksheet.Cells[row, col].Value.ToString();
                        if (col == 2) student.LastName = worksheet.Cells[row, col].Value.ToString();
                        //if (col == 3) student.Birthdate = worksheet.Cells[row, col].GetValue<DateTime>();
                    }

                    employees.Add(student);
                }
            }

            return employees;
        }
    }
}
