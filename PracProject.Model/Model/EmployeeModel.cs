using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracProject.Model.Model
{
    public class EmployeeModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Fname { get; set; }
        [Required]
        public string Lname { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public Nullable<System.DateTime> DOB { get; set; }
        [Required]
        public Nullable<int> Country { get; set; }
        [Required]
        public Nullable<int> State { get; set; }
    }
}
