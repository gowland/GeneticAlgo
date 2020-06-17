﻿using System;

namespace GeneticSolver.Expressions
{
    public interface IExpressionVisitor<T>
    {
        void Visit(BoundValueExpression<T> expression);
        void Visit(FuncExpression<T> expression);
        void Visit(ValueExpression<T> expression);
    }
}