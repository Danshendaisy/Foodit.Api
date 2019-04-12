// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Foodit.Api.Data;
// using Foodit.Api.Models;
// using Microsoft.AspNetCore.Mvc;

//     [Route("api/items")]
//     [ApiController]
//     public class ItemsController : ControllerBase
//     {
//         private readonly ItemContext db;
//            public ItemsController(ItemContext db)
//         {
//             this.db=db;
//             if (this.db.Items.Count() == 0)
//             {
//                 this.db.Items.Add(new Item()
//                 {
//                    ItemId=1,
//                    ItemDescription="General-Tso Chicken",
//                    ItemSoldPrice=0,
//                    ItemHighestBid=8,
//                    SellerName="HelloWorld",
//                 //    Seller = { 
//                 //        UserName = "HelloWorld",
//                 //        UserPassword = "123321",
//                 //        UserId = "1",
//                 //        UserFooditCoins = 10,
//                 //        UserAddress = "250 W Lane Ave.",
//                 //        UserPhoneNumber = 1111111111,
//                 //        UserEmail = "hello@123.com",
//                 //        UserItems = null
//                 //        },

//                     BuyerName="Daisy",
//                     // Buyer = {
//                     //     UserName = "Daisy",
//                     //     UserPassword = "1111",
//                     //     UserId = "2",
//                     //     UserFooditCoins = 20,
//                     //     UserAddress = "20 W Lane Ave.",
//                     //     UserPhoneNumber = 1111111112,
//                     //     UserEmail = "hello1@123.com",
//                     //     UserItems = null
//                     // }, 
//                     MyTransId="101",
                   

//                 });
//                 this.db.SaveChanges();
//             }
            
           

//         }
//         //  [HttpGet]
//         //     public IActionResult Get()
//         //     {
//         //         return Ok(db.Items);
//         //     }
//         [HttpGet("{id}")]
//         public IActionResult GetItem(int id)
//         {
//             var item =db.Items.FirstOrDefault(i =>i.ItemId==id);
//             if(item==null)
//             {
//                 return NotFound();
//             }
//             return Ok(item);
//         }

//         [HttpPost]
//         public IActionResult Post([FromBody]Item item)
//         {
//             if(item == null)
//             {
//                 return BadRequest();
//             }
//             db.Items.Add(item);
//             db.SaveChanges();

//             return Ok(item);
//            // return CreatedAtRoute("GetItem", new {id = item.Id},item);
//         }
        

//     }