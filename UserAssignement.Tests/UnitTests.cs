using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using UserAssignement;

namespace UserAssignement.Tests
{
	public class ExtractDataTests
	{
		[Test]
		public void ExtractByEmail_ReturnsJaneSmith()
		{
			ExtractData extractData = new ExtractData();

			User? result = extractData.ExtractByEmail("jane.smith@example.com");

			Assert.That(result?.Name, Is.EqualTo("Jane Smith"));
			Assert.That(result.Email, Is.EqualTo("jane.smith@example.com"));
			Assert.That(result.Age, Is.EqualTo(25));
		}

		[Test]
		public void ExtractByAge_ReturnsUsersOlderThan30()
		{
			ExtractData extractData = new ExtractData();

			List<User> result = extractData.ExtractByAge(30);

			Assert.That(result.Count, Is.EqualTo(2));
			Assert.That(result.Any(u => u.Name == "John Doe"), Is.True);
			Assert.That(result.Any(u => u.Name == "Bob Johnson"), Is.True);
			Assert.That(result.Any(u => u.Name == "Jane Smith"), Is.False);
		}

		[Test]
		public void ExtractAverageAge_ReturnsCorrectAverage()
		{
			ExtractData extractData = new ExtractData();

			double result = extractData.ExtractAverageAge();

			Assert.That(result, Is.EqualTo(32));
		}
	}
}