using System;
using System.Collections.Generic;
using System.Text;

namespace AssetManagement.Library.Data.Entities
{
    public class Asset : EntityBase<Guid>
    {
        public string AssetName { get; set; }
        public string AssetCode { get; set; }
        public double AssetPrice { get; set; }
        public int AssetQuantity { get; set; }
        public DateTime AssetPurchaseDate { get; set; }
        public DateTime? AssetExpirationDate { get; set; }
        public string ShopName { get; set; }
        public string ShopAddress { get; set; }
        public bool IsActive { get; set; }
        public AllotedStatus AllotedStatus { get; set; }
        public Guid AssetCategoryId { get; set; }

        public virtual AssetCategory AssetCategory { get; set; }
    }

    public enum AllotedStatus
    {
        None = 0, Assign, Retain, Unavailable
    }
}
