using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAssignement
{
    public class ReadUsers
    {	
		public List<User> Read()
		{
			List<User> usersList = new List<User>();

			string filePath = Path.Combine(AppContext.BaseDirectory, "users.csv");
			var rows = File.ReadAllLines(filePath);

			foreach (var row in rows.Skip(1))
			{
				var values = row.Split(',');
				User user = new User
				{
					Id = int.Parse(values[0]),
					Name = values[1],
					Email = values[2],
					Age = int.Parse(values[3])
				};
				usersList.Add(user);
			}
			return usersList;
		}
	}
}
