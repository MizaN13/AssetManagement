using System;
using System.Collections.Generic;
using System.Text;

namespace AssetManagement.Library.Data.Entities
{
    public class AssetCategory : EntityBase<Guid>
    {
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
