﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
   public class User
    {
        public int userid { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public int isLogin { get; set; }
    }
}
