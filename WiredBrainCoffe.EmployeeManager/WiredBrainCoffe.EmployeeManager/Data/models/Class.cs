﻿using System.ComponentModel.DataAnnotations;

namespace WiredBrainCoffe.EmployeeManager.Data.models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        public bool IsDeveloper { get; set; }
        public int? DepartmentId { get; set; }
        [Required]
        public Department? Department { get; set; }
    }
}