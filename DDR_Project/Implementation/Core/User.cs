using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDR_Project.Implementation.Core
{
	public class User
	{
		public enum Role
		{
			CustomerServiceRepresentative,
			CustomerServiceManager,
			Accounting,
			Shipping,
			Invoicing
		}

		public string FirstName { get; private set; }
		public string LastName { get; private set; }
		public List<Role> Roles { get; private set; }

		public User(string firstName, string lastName, IEnumerable<Role> roles)
		{
			FirstName = firstName;
			LastName = lastName;
			Roles = roles.ToList();
		}
	}
}
