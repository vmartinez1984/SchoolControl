﻿using System.ComponentModel.DataAnnotations;

namespace SchoolControl.Core.Entities
{
    public class GroupEntity
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public DateTime DateRegistration { get; set; }

        public bool IsActive { get; set; }
    }
}