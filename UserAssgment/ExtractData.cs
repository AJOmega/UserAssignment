using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAssignement
{
	public class ExtractData
	{
		private readonly ReadUsers reader = new ReadUsers();

		public User? ExtractByEmail(string email)
		{
			List<User> usersList = reader.Read();
			User? user = usersList.FirstOrDefault(u => u.Email == email);
			return user;
		}

		public List<User> ExtractByAge(int age)
		{
			List<User> usersList = reader.Read();
			var user = usersList
				.Where(x => x.Age > age)
				.ToList();
			return user;
		}

		public double ExtractAverageAge()
		{
			List<User> usersList = reader.Read();
			double averageAge = usersList.Average(x => x.Age);
			return averageAge;
		}
		
	}
}
