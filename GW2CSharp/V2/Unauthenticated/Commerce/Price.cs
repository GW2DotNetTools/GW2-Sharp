﻿using GW2CSharp.V2.Unauthenticated.Items;
using System.Collections.Generic;

namespace GW2CSharp.V2.Unauthenticated.Commerce
{
    /// <summary>
    /// 
    /// </summary>
    public class Price
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="buys"></param>
        /// <param name="sells"></param>
        public Price(int id, bool whitelisted, TpItemListing buys, TpItemListing sells)
        {
            Item = new ItemWrapper().GetById(id);
            Buys = buys;
            Sells = sells;
            Whitelisted = whitelisted;
        }

        /// <summary>
        /// The item.
        /// </summary>
        public Item Item { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool Whitelisted { get; set; }

        /// <summary>
        /// A list of all buy listings, ascending from lowest buy order.
        /// </summary>
        public TpItem Buys { get; set; }

        /// <summary>
        /// A list of all sell listings, ascending from lowest sell offer.
        /// </summary>
        public TpItem Sells { get; set; }
    }
}