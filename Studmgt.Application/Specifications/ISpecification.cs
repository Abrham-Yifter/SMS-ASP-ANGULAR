﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Studmgt.Application.Specifications
{
    public interface ISpecification<T>
    {
        Expression<Func<T,object>> OrderBy { get; }
        Expression<Func<T, object>> OrderByDesc { get; }
    }
}
