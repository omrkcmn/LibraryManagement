﻿using Core.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Publisher : IEntityBook
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}