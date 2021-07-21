using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.Specifications
{
    public class BaseSpecification<T> : ISpecification<T>
    {
        Expression<Func<T, bool>> ISpecification<T>.Criteria => throw new NotImplementedException();

        List<Expression<Func<T, object>>> ISpecification<T>.Includes => throw new NotImplementedException();
    }
}