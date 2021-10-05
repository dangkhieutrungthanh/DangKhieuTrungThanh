namespace DangKhieuTrungThanh.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SinhVien")]
    public partial class SinhVien
    {
        [Key]
        [StringLength(20)]
        public string MaSinhVien { get; set; }

        [Required]
        [StringLength(50)]
        public string HoTen { get; set; }

        public int MaLop { get; set; }
    }
}
