﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bankomat.Models
{
    public class Money
    {
        public int Id { get; set; }
        public int Denomination { get; set; }

    }
}