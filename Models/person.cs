using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DangKhieuTrungThanh.Models
{
    [Table("person")]
    public class person
    {
        [Key]
        public int PersonId { get; set; }
        [Required]
        [StringLength(50)]
        public string PersonName { get; set; }
    }
}