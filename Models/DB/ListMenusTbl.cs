using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace JoinTable.Models.DB
{
    public partial class ListMenusTbl
    {
        public int Id { get; set; }
        public string MenusName { get; set; }
        public int? GroupMenu { get; set; }
        public int? Price { get; set; }
    }
}
