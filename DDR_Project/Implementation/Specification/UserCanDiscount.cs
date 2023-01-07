using System;
using DDR_Project.Specifications;
using DDR_Project.Implementation.Order;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace DDR_Project.Implementation.Specification
{
    public class UserCanDiscount<T> : CompositeSpecification<T> where T : IOrderAggregate
    {
        private Core.User _activeUser;

        public UserCanDiscount(Core.User activeUser)
        {
            _activeUser = activeUser;
        }

        public override bool IsSatisfiedBy(T o)
        {
            return _activeUser.Roles.Any(x =>
                (
                    x == Core.User.Role.CustomerServiceManager
                    || x == Core.User.Role.CustomerServiceRepresentative
                )
               );

        }
    }
}
