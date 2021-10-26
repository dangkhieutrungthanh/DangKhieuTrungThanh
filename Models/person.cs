using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DangKhieuTrungThanh.Models
{
    [Table("Person")]
    public class Person
    { 
        [Key]
        [StringLength(20)]
        public string PersonId { get; set; }

        [Required]
        [StringLength(50)]
        public string PersonName { get; set; }

       
    }
}