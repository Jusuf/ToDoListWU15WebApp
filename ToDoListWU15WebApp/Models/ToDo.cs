﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoListWU15WebApp.Models
{
    public class ToDo
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public DateTime Created { get; set; }

        public bool Active { get; set; }
    }
}