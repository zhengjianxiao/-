﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StreetLight.ViewModels.Role
{
    public class RoleAddViewModel
    {
        [Required]
        [Display(Name = "角色名称")]
        public string RoleName { get; set; }
    }
}
