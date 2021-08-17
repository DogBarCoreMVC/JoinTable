using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace JoinTable.Models.DB
{
    public partial class GroupMenusTbl
    {
        public int Id { get; set; }
        public string GroupNameMenu { get; set; }

        [ForeignKey("Id")]
        public int GroupMenu { get; set; }
    }
}
