using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAssignement
{
	class Program
	{
		static void Main(string[] args)
		{
			ExtractData extractData = new ExtractData();

			User? EmailUser = extractData.ExtractByEmail("jane.smith@example.com");

			List<User> AgeUsers = extractData.ExtractByAge(30);

			double AverageAge = extractData.ExtractAverageAge();

			Console.WriteLine("---------------------------");

			Console.WriteLine("Email Test: ");

			Console.WriteLine("Id: " + EmailUser?.Id + " Name: " + EmailUser?.Name + " Email: " + EmailUser?.Email + " Age: " + EmailUser?.Age);

			Console.WriteLine("---------------------------");

			Console.WriteLine("Age Test: ");

			foreach (var user in AgeUsers)
			{
				Console.WriteLine("Id: " + user.Id + " Name: " + user.Name + " Email: " + user.Email + " Age: " + user.Age);
			}

			Console.WriteLine("---------------------------");

			Console.WriteLine("Average Age Test: " + AverageAge.ToString());

			Console.WriteLine("---------------------------");
		}
	}
}
