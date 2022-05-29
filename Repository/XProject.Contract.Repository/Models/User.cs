using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XProject.Contract.Repository.Models
{
    public class User : Entity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(250)]
        public string Password { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public DateTime BirthDay { get; set; }
        public string Sex { get; set; }
        public int ParenId { get; set; }
    }
}
