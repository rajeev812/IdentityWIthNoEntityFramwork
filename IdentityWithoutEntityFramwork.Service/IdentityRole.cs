﻿using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityWithoutEntityFramwork.Service
{
   public class IdentityRole:IRole<Guid>
    {

       public Guid Id
       {
           get
           {
               return RoleId;
           }
       }

        public Guid RoleId { get; set; }
        public string Name { get; set; }
    }
}
