﻿using System.Collections.Generic;
using System.Linq;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;

using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (var context = new RentACarContext())
            {
                var result = from rent in context.Rentals
                             join car in context.Cars on rent.CarId equals car.CarId
                             join brand in context.Brands on car.BrandId equals brand.BrandId
                             join color in context.Colors on car.ColorId equals color.ColorId
                             join cus in context.Customers on rent.CustomerId equals cus.UserId
                             join user in context.Users on cus.UserId equals user.UserId
                             select new RentalDetailDto
                             {
                                 Id = rent.RentalId,
                                 CarName = car.Description,
                                 BrandName = brand.BrandName,
                                 ColorName = color.ColorName,
                                 CompanyName = cus.CompanyName,
                                 FirstName = user.FirstName,
                                 LastName = user.LastName,
                                 RentDate = rent.RentDate,
                                 ReturnDate = rent.ReturnDate,
                             };

                return result.ToList();
            }
        }
    }
}