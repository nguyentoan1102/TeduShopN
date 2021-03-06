﻿using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("AppRoles")]
    public class AppRole : IdentityRole
    {
        public AppRole()
        {
        }

        public AppRole(string name, string description) : base(name) => Description = description;

        public virtual string Description { get; set; }
    }
}