using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QLTaiLieuCNTT.Models
{
    public class TaiLieu
    {
        public int Id { get; set; }

        public ApplicationUser Lecturer { get; set; }

        [Required]
        public string LecturerId { get; set; }

        [Required]
        [StringLength(500)]
        public string Link { get; set; }

        public DateTime DateTime { get; set; }

        public LoaiTaiLieu LoaiTaiLieu { get; set; }

        [Required]
        public byte LoaiTaiLieuId { get; set; }
    }
}