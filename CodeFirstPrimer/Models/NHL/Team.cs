﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Web;

namespace CodeFirstPrimer.Models.NHL
{
    public class Team
    {
        [Key]
        [MaxLength(30)]
        public string TeamName { get; set; }

        public string City { get; set; }
        public string Province { get; set; }
        public List<Player> Players { get; set; }
    }
}