using System;
using System.Collections.Generic;
using System.Text;

namespace DDR_Project.Specifications
{
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T item);
        ISpecification<T> And(ISpecification<T> specification);
        ISpecification<T> Or(ISpecification<T> specification);
        ISpecification<T> Not(ISpecification<T> specification);
    }
}
