using System;
using Foodit.Api.Models;

namespace Foodit.Api.Models
{
       public class Transaction
    {
        public string TransId {get;set;}
        public DateTime TransDate {get;set;}
        public int TransAmount {get;set;}


        public string TransItemId {get;set;}
        public Item TransItem {get;set;}


        public string SellerUserId {get;set;}
        public User TransSeller {get;set;}


        public string BuyerUserId {get;set;}
        public User TransBuyer{get;set;}

    }
    
}