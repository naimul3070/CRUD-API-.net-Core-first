using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CRUD.Models.Write
{
    public partial class User
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string FathersName { get; set; }
        public string MobileNo { get; set; }
    }
}
