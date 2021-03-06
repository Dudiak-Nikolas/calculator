﻿using Calculator.Models.Calculation.Operations.Base;

namespace Calculator.Models.Calculation.Operations.ArithmeticOperations
{
    class PartOfTheWhole : UnaryOperation
    {
        public PartOfTheWhole(UniversalOperation PartOfTheWhole) : base(PartOfTheWhole) { }

        public override double Operation()
        {
            return 1 / arg.Operation();
        }
    }
}