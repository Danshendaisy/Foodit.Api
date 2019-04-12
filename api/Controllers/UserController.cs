using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Foodit.Api.Data;
using Foodit.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Foodit.Api.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserContext db;

        public UsersController(UserContext db)
        {
            this.db=db;
            if (this.db.Users.Count() == 0)
            {
                this.db.Users.Add(new User()
                {
                  UserName = "HelloWorld",
                  UserPassword = "123321",
                  UserId = "1",
                  UserFooditCoins = 10,
                  UserAddress = "250 W Lane Ave.",
                  UserPhoneNumber = 1111111111,
                  UserEmail = "hello@123.com",
                  UserItems = new List<Item>(),

                });
                this.db.Users.Add(new User()
                {
                  UserName = "Daisy",
                  UserPassword = "1111",
                  UserId = "2",
                  UserFooditCoins = 20,
                  UserAddress = "20 W Lane Ave.",
                  UserPhoneNumber = 1111111112,
                  UserEmail = "hello1@123.com",
                  UserItems = new List<Item>()
                });

            }
            this.db.SaveChanges();
        
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(db.Users);
        }

    }

   
}