using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntiryFrameworkCore.Models
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        public string Name { get; set; }
        public string Descriptions { get; set; }
        public DateTime Date_Created { get; set; }
        public DateTime Date_Modify { get; set; }
    }
}
