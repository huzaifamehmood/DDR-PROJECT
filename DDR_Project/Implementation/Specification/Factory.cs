using System;
using DDR_Project.Implementation.Order;
using System.Collections.Generic;
using System.Text;

namespace DDR_Project.Implementation.Specification
{
    public static class Factory<T> where T : IOrderAggregate
    {
        public static UserCanDiscount<T> GetUserCanDiscountSpecification(Implementation.Core.User activeUser)
        {
            return new UserCanDiscount<T>(activeUser);
        }

        public static CanDiscountByAmount<T> GetCanDiscountSpecification(Implementation.Core.User activeUser, double additionalDiscount)
        {
            return new CanDiscountByAmount<T>(activeUser, additionalDiscount);
        }

        public static Specifications.ExpressionSpecification<T> GetUserCanDiscountByAmountSpecification(Core.User activeUser, double additionalDiscount)
        {
            return new Specifications.ExpressionSpecification<T>(o => {
                var userCanDiscountSpec = GetUserCanDiscountSpecification(activeUser);
                var canDiscountByAmountSpec = GetCanDiscountSpecification(activeUser, additionalDiscount);

                return userCanDiscountSpec.IsSatisfiedBy(o) == true && canDiscountByAmountSpec.IsSatisfiedBy(o) == true;
            });
        }
    }
}
