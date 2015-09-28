﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bankomat.Models
{
    public class ClickLog
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime Time { get; set; }
        public string TurnOut { get; set; }
        public double Amount { get; set; }
        public string EventType { get; set; }
    }
}