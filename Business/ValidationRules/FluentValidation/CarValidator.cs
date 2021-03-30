using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(car => car.CarName).NotEmpty();
            RuleFor(car => car.CarName).MinimumLength(2);
            RuleFor(car => car.DailyPrice).NotEmpty();
            RuleFor(car => car.DailyPrice).GreaterThan(0);
            RuleFor(car => car.DailyPrice).GreaterThanOrEqualTo(10); //sular 10tlden asagi olmasin.Categoryid=1 liquidleri gosterir
            RuleFor(car => car.CarName).Must(StartWithA).WithMessage("Cars A herfi ile baslamalidir");
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
