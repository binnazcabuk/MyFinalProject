﻿using Business.Abstract;
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
    [ApiController]
    public class OrdersController : ControllerBase
    {
        IOrderService _orderService;
        

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
           
        }

     


        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _orderService.GetAll();
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

     

        [HttpGet("getbyuserid")]
        public IActionResult GetById(int userId)
        {
            var result = _orderService.GetByUserId(userId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Order order)
        {
            var result = _orderService.Add(order);
            if (result.Success == true)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }


        [HttpPost("delete")]
        public IActionResult Delete(Order order)
        {
            var result = _orderService.Delete(order);
            if (result.Success == true)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Order order)
        {
            var result = _orderService.Update(order);
            if (result.Success == true)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }
    }
}
