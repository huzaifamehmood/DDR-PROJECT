using System;
using System.Collections.Generic;
using DDR_Project.Implementation.Core;
using DDR_Project.Implementation.Specification;
using DDR_Project.Implementation.Order;
namespace DDR_Project
{
    class Program
    {
		public static void Main(string[] args)
		{
			Console.WriteLine("Specification Design Pattern");
			Console.WriteLine("===============================");



			var Huzaifa = new Implementation.Core.User("Huzaifa", "Mehmood", new List<User.Role>()   
			{
				User.Role.Invoicing
			});

			var Umair = new Implementation.Core.User("Umair", "Shah", new List<User.Role>() {      
				User.Role.Accounting,
				User.Role.CustomerServiceRepresentative
			});

			var Ali = new Implementation.Core.User("Ali", "Khan", new List<User.Role>() {          
				User.Role.CustomerServiceManager
			});


			// Setting up some dummy orders for demonstration purposes
			var order1 = new OrderAggregate(100, 0);
			var order2 = new OrderAggregate(50, 10);
			var order3 = new OrderAggregate(40, 0);

			var huzaifaCanDiscountSpec = Factory<IOrderAggregate>.GetUserCanDiscountSpecification(Huzaifa);
			var umairCanDiscountSpec = Factory<IOrderAggregate>.GetUserCanDiscountSpecification(Umair);
			var aliCanDiscountSpec = Factory<IOrderAggregate>.GetUserCanDiscountSpecification(Ali);

            //Should all be false - Huzaifa only has the "Invoicing" Role...none of the customer service roles
            Console.WriteLine("Huzaifa (ROLE: Invoiving) can Modify Order1: " + huzaifaCanDiscountSpec.IsSatisfiedBy(order1));
            Console.WriteLine("Huzaifa (ROLE: Invoiving) can Modify Order2: " + huzaifaCanDiscountSpec.IsSatisfiedBy(order2));
            Console.WriteLine("Huzaifa (ROLE: Invoiving) can Modify Order3: " + huzaifaCanDiscountSpec.IsSatisfiedBy(order3));
            Console.WriteLine("");

            //// Should all be true - Umair is a Customer Service Representative
            Console.WriteLine("Umair (ROLE: Customer Service Representative) can Modify Order1: " + umairCanDiscountSpec.IsSatisfiedBy(order1));
            Console.WriteLine("Umair (ROLE: Customer Service Representative) can Modify Order2: " + umairCanDiscountSpec.IsSatisfiedBy(order2));
            Console.WriteLine("Umair (ROLE: Customer Service Representative) can Modify Order3: " + umairCanDiscountSpec.IsSatisfiedBy(order3));
            Console.WriteLine();

            //// Should all be true - Ali is a Customer Service Manager
            Console.WriteLine("Ali (ROLE: Customer Service Manager) can Modify Order1: " + aliCanDiscountSpec.IsSatisfiedBy(order1));
            Console.WriteLine("Ali (ROLE: Customer Service Manager) can Modify Order2: " + aliCanDiscountSpec.IsSatisfiedBy(order2));
            Console.WriteLine("Ali (ROLE: Customer Service Manager) can Modify Order3: " + aliCanDiscountSpec.IsSatisfiedBy(order3));
            Console.WriteLine();



            //double do_discountby = 10;
            //var UmairCanDiscountInputAmount = Factory<IOrderAggregate>.GetUserCanDiscountByAmountSpecification(Umair, do_discountby);
            //var AliCanDoItAllSpec = aliCanDiscountSpec.And(UmairCanDiscountInputAmount);
            //Console.WriteLine("umair (ROLE: Customer Service Representative) can discount order1 by $10 {0}", AliCanDoItAllSpec.IsSatisfiedBy(order1));
            //Console.WriteLine("Umair (ROLE: Customer Service Representative) can discount order2 by $10 {0}", AliCanDoItAllSpec.IsSatisfiedBy(order2));




          //  var umairCanDiscountOrder1By10Spec = Factory<IOrderAggregate>.GetUserCanDiscountByAmountSpecification(Umair, 10);
           // var umairCanDiscountOrder1By25Spec = Factory<IOrderAggregate>.GetUserCanDiscountByAmountSpecification(Umair, 25);

            //Console.WriteLine("Umair (ROLE: Customer Service Representative) can Modify Order1 by 10: " + umairCanDiscountOrder1By10Spec.IsSatisfiedBy(order1));
           // Console.WriteLine("Umair (ROLE: Customer Service Representative) can Modify Order2 by 25: " + umairCanDiscountOrder1By25Spec.IsSatisfiedBy(order1));
           // Console.WriteLine();

            //var aliCanDiscountOrder1By10Spec = Factory<IOrderAggregate>.GetUserCanDiscountByAmountSpecification(Ali, 10);
            //var aliCanDiscountOrder1By25Spec = Factory<IOrderAggregate>.GetUserCanDiscountByAmountSpecification(Ali, 25);
            //var aliCanDiscountOrder1By35Spec = Factory<IOrderAggregate>.GetUserCanDiscountByAmountSpecification(Ali, 35);
            //var aliCanDiscountOrder1By40Spec = Factory<IOrderAggregate>.GetUserCanDiscountByAmountSpecification(Ali, 40);
            //var aliCanDiscountOrder2By7_50Spec = Factory<IOrderAggregate>.GetUserCanDiscountByAmountSpecification(Ali, 7.50);
            //var aliCanDiscountOrder2By7_51Spec = Factory<IOrderAggregate>.GetUserCanDiscountByAmountSpecification(Ali, 7.51);

            //Console.WriteLine("Ali (ROLE: Customer Service Manager) can Modify Order1 by 10: " + aliCanDiscountOrder1By10Spec.IsSatisfiedBy(order1));
            //Console.WriteLine("Ali (ROLE: Customer Service Manager) can Modify Order1 by 25: " + aliCanDiscountOrder1By25Spec.IsSatisfiedBy(order1));
            //Console.WriteLine("Ali (ROLE: Customer Service Manager) can Modify Order1 by 35: " + aliCanDiscountOrder1By35Spec.IsSatisfiedBy(order1));
            //Console.WriteLine("Ali (ROLE: Customer Service Manager) can Modify Order1 by 40: " + aliCanDiscountOrder1By40Spec.IsSatisfiedBy(order1));
            //Console.WriteLine("ALi (ROLE: Customer Service Manager) can Modify Order2 by 7.50: " + aliCanDiscountOrder2By7_50Spec.IsSatisfiedBy(order2));
            //Console.WriteLine("Ali (ROLE: Customer Service Manager) can Modify Order2 by 7.51: " + aliCanDiscountOrder2By7_51Spec.IsSatisfiedBy(order2));
            //Console.WriteLine();






        }
    }
}
