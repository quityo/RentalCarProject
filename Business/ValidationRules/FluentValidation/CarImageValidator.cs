﻿

using Business.Constants;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{

    public class CarImageValidator : AbstractValidator<CarImage>
    {
        public CarImageValidator()
        {
           
        }
    }
}
