﻿using DataDonation.Database;
using DataDonation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Text.Json;
using System.Threading.Tasks;

namespace DataDonation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DonateController : ControllerBase
    {
        private readonly ILogger<DonateController> _logger;
        private readonly DatabaseContext _dbcontext;

        public DonateController(ILogger<DonateController> logger, DatabaseContext dbcontext)
        {
            _logger = logger;
            _dbcontext = dbcontext;
        }

        /// <summary>
        /// Submits a data Donation
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> Submit(JsonElement data)
        {
            // TODO: Add validation
            var dataDonation = new DataDonationEntry(
                Guid.NewGuid(), DateTime.Now, JsonSerializer.Serialize(data));
            await _dbcontext.DataDonationEntries.AddAsync(dataDonation);
            await _dbcontext.SaveChangesAsync();
            return Ok();
        }
    }
}
