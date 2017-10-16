using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QLTaiLieuCNTT.Models
{
    public class LoaiTaiLieu
    {
        public byte Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Loai { get; set; }
        public ICollection<TaiLieu> Courses { get; set; }
    }
}