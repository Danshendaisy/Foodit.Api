using System;

namespace Foodit.Api.Models{


 public class Item {
    public int Id {get;set;}
    public string ItemDescription {get;set;}
    public int ItemSoldPrice {get;set;}
    public int ItemHighestBid {get;set;}


    public string SellerName {get;set;}

   // public User Seller {get;set;}


    public string BuyerName {get;set;}
   // public User Buyer {get;set;}


   //  public string MyTransId  {get;set;}
   //      public int Id { get; internal set; }

       
   //      public Transaction MyTrans {get;set;}
    }
}