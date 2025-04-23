using DuAnCNPM.Datas;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using DuAnCNPM.Models;

namespace DuAnCNPM
{
    [Table("HOP_DONG")]
    public class HopDong
    {
        [Key]
        public string MA_HOP_DONG { get; set; }
        public string MA_NHAN_VIEN { get; set; }
        public string MA_CONG_TY { get; set; }
        public DateTime? NGAY_KY { get; set; }
        public DateTime? NGAY_TRA_KQ { get; set; }
        public long? SO_TIEN { get; set; }

        [ForeignKey("MA_NHAN_VIEN")]
        public virtual NhanVien NhanVien { get; set; }

        [ForeignKey("MA_CONG_TY")]
        public virtual KhachHang KhachHang { get; set; }
        //update 
        public bool TRANG_THAI { get; set; }
        public bool HOAN_THANH { get; set; }
        public String QUY { get; set; }
    }
}