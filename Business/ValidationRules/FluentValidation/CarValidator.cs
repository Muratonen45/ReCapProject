using Business.Constants;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
      {
        RuleFor(p => p.DailyPrice).GreaterThan(15000).WithMessage(Messages.CarDailyPriceInvalid);
        RuleFor(p => p.Description).Must(StartWithA);
      }

    private bool StartWithA(string arg)
    {
        return arg.StartsWith("a");
    }

}  
}

