﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty();
            //minumum 2 karakter
            RuleFor(p => p.ProductName).MinimumLength(2);

            RuleFor(p => p.UnitPrice).NotEmpty();

            RuleFor(p => p.UnitPrice).GreaterThan(0);

            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1);

            //kendimiz uydurma bir method yazıcaksak örnek

            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("A harfi ile başlmalı");
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
