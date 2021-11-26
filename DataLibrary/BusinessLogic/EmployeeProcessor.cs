using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
	public static class EmployeeProcessor
	{
		public static int CreateEmployee(int employeeId, string firstName,
			string lastName, string emailAddress)
		{
			EmployeeModel data = new EmployeeModel
			{
				
				EmployeeID = employeeId,
				FirstName = firstName,
				LastName = lastName,
				Email = emailAddress
			};

			string sql = @"insert into dbo.Employee (EmployeeID, FirstName, LastName, Email)
                           values (@EmployeeID, @FirstName, @LastName, @Email);";

			return SqlDataAccess.SaveData(sql, data);
		}

		public static List<EmployeeModel> LoadEmployees()
		{
			string sql = @"select Id, EmployeeID, FirstName, LastName, Email
                           from dbo.Employee;";

			return SqlDataAccess.LoadData<EmployeeModel>(sql);
		}
	}
}

