﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   
   public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>>GetAllByCategoryId(int categoryId);
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
        IResult Add(Product product);
        IResult Update(Product product);
        IDataResult<Product> GetById(int productId);
        IResult AddTransactionalTest(Product product);
        IDataResult<List<ProductDetailDto>> GetProductDetails();
    }
}
