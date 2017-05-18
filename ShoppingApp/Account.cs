using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp
{
    /// <summary>
    /// Shopping User Account that holds information needed to make purchases.
    /// </summary>
    class Account
    {
        #region Properties
        /// <summary>
        /// Account information for user. Are there too many properties here? 
        /// </summary>

        public string UserName { get; set; }

        public string FullName { get; set; }

        public string EmailAddress { get; set; }

        public string ItemName { get; set; }/// <summary>
        /// Are both ItemName and ItemCost both needed as properties, or can properties have two values?
        /// </summary>

        public decimal ItemCost { get; set; }

        public decimal TotalCost { get; set; } /// <summary>
        /// Are both TotalCost and ItemCost  needed as separate properties? 
        /// </summary>

        public string BillingAddress { get; set; }

        public int CreditCardNumber { get; set; }

        public string ShippingAddress { get; set; }

        public string TrackItems { get; set; }

        #endregion

        public void AddToCart (string, decimal amount)
            ///What do I do if an item should be counted both by name and value?
        {
            ItemName += string;
            ItemCost += amount; 
        }

        public void PurchaseItems (decimal amount)
            ///Should the names of the items purchased also be found in this method? Can ItemNames become plural? 
        {
            TotalCost += amount; 
        }

        public void CheckStatus (string)
        {
            TrackItems += string; 
        }

        #region Methods
        #endregion

    }
}
