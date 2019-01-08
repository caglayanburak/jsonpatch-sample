using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JsonPatchSample.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace JsonPatchSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankAccountsController : ControllerBase
    {
        [HttpPatch("{bankAccountId}")]
        public async Task<IActionResult> Patch(int bankAccountId, [FromBody]JsonPatchDocument<BankAccount> patches)
        {
            var bankAccount = new BankAccount()
            {
                Id = 1,
                AccountName = "burak hesap",
                Balance = 2000
            };

            patches.ApplyTo(bankAccount);

            return Ok(bankAccount);

        }
    }
}
