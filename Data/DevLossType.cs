using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Data
{
    public partial class DevLossType
    {
        public int LossTypeId { get; set; }
        public string LossTypeCode { get; set; }
        public string LossTypeDescription { get; set; }
    }
}
