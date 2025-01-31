﻿using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]//attribute -->  bu class bir controllers der
    public class ProductsController : ControllerBase
    {
        IProductService _productService;
       
        public ProductsController(IProductService productService)
        {
            _productService = productService;
            
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _productService.GetAll();
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getalldetail")]
        public IActionResult GetAllDetail()
        {
            var result = _productService.GetProductDetails();
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }



        [HttpGet("getbyid")]
        public IActionResult GetById(int productId)
        {
            var result = _productService.GetById(productId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbycategory")]
        public IActionResult GetByCategory(int categoryId)
        {
            var result = _productService.GetAllByCategoryId(categoryId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //silme,güncellemeyi post ile yapabilirsin
        //httpput günncelleme için
        //httpdelete silmek için kullanılabilir istenirse
        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success == true)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }
    }
}
