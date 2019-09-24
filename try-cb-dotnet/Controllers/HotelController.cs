﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using try_cb_dotnet.Models;
using try_cb_dotnet.Services;

namespace try_cb_dotnet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HotelController : ControllerBase
    {
        private readonly IHotelService _hotelService;

        public HotelController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }

        [HttpGet("{description?}/{location?}")]
        public async Task<ActionResult> GetFlights(string description, string location)
        {
            var hotels = await _hotelService.FindHotel(description, location);
            return Ok(new Result(hotels));
        }
    }
}

