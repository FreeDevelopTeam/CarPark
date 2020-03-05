﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebFramework.Data.Models
{
    [Table("Users")]
    public partial class Users
    {
        public long id { get; set; }
        public string userName { get; set; }
        public string carNumber { get; set; }
    }
}
