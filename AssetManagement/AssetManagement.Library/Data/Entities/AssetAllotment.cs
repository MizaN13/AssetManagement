using System;
using System.Collections.Generic;
using System.Text;

namespace AssetManagement.Library.Data.Entities
{
    public class AssetAllotment : EntityBase<Guid>
    {
        public string AssetName { get; set; }
        public string AssetAllotedTo { get; set; }
        public string AssetDisAllotedIssue { get; set; }
        public Guid EmployeeId { get; set; }
        public DateTime AssetAllotedDate { get; set; }
        public DateTime? AssetDisAllotedDate { get; set; }
        public Guid AssetId { get; set; }
        public virtual Asset Asset { get; set; }
    }
}
