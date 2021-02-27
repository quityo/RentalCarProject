﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    class ColorManager:IColorService
    {
        IColorDal _colorDal;
         public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Add(Color color)

        {
            _colorDal.Add(color);
        }
        public void Update(Color color)
        {
            _colorDal.Update(color);
        }
        public void Delete(Color color)
        {
            _colorDal.Delete(color);

        }
        public List<Color> GetAll()
        {
            return _colorDal.GetAll().ToList();
        }
        public Color GetById(int colorId)
        {
            return _colorDal.Get(p => p.ColorId == colorId);
        }

        Color IColorService.GetById(int colorId)
        {
            throw new NotImplementedException();
        }
    }
}
