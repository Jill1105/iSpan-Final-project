﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HotelFuen31.APIs.Models;
using HotelFuen31.APIs.Dto.Jill;
using HotelFuen31.APIs.Services.Jill;
using HotelFuen31.APIs.Dtos.Jill;

namespace HotelFuen31.APIs.Controllers.Jill
{
    [Route("api/[controller]")]
    [ApiController]
    public class HallMenusController : ControllerBase
    {
        private readonly HallMenuService _service;

        public HallMenusController(HallMenuService service)
        {
            _service = service;
        }

        // GET: api/HallItems
        [HttpGet]
        public async Task<IEnumerable<HallMenuDto>> GetHallItems()
        {
            return await _service.GetrAll().ToListAsync();
        }
    }
}