//using Microsoft.Build.Framework;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace FirstDemo.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage="Name is required")]
        [MaxLength(50)]
        [MinLength(2)]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Required(ErrorMessage="Salary is required")]
        public double Salary { get; set; }
        [Required(ErrorMessage="Age is required")]
        [Range(18,60,ErrorMessage ="Age should be in between 18 to 60")]
        public int Age { get; set; }

        [Required(ErrorMessage ="Email is required")]
        [DataType(DataType.EmailAddress)]
        public string EmailId { get; set; }

        [Required(ErrorMessage ="Paasword is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage ="Contact number is required")]
        public long ContactNumber { get; set; }

        [DataType(DataType.Date)]
        public DateTime JoinDate { get; set; }
    }
}
