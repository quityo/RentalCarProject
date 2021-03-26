﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;


namespace Business.Abstract
{
    public interface ICarImageService
    {
        IResult Add(CarImageDto carImage);
        IResult Update(CarImageDto carImage);
        IResult Delete(CarImageDto carImage);
        IResult DeleteByCarId(int carId);
        IDataResult<List<CarImage>> GetAll();
        IDataResult<CarImage> GetById(int imageId);
        IDataResult<List<CarImage>> GetByCarId(int carId);
    }
}
