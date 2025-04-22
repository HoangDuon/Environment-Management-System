using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DuAnCNPM
{
    [Table("KHACH_HANG")]
    public class KhachHang
    {
        [Key]
        public string MA_CONG_TY { get; set; }
        public string TEN_CONG_TY { get; set; }
        public string DIA_CHI { get; set; }
        public string SDT_KHACHHANG { get; set; }
        public string GMAIL_KHACHHANG { get; set; }
        // update 
        public bool TRANG_THAI { get; set; }
        public DateTime THOI_GIAN { get; set; }
        public String MA_SO_THUE { get; set; }
    }

}