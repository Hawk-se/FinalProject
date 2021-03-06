﻿using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    // public'e çekmeyi unutma!!!
    // DAL = Data Access Layer    DAO = Data Access Object
    // interface metotları default olarak public'tir ama kendi değil!!!
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();
    }
}
// Code Refactoring