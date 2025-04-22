using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DuAnCNPM
{
    [Table("NHAN_VIEN")]
    public class NhanVien
    {
        [Key]
        public string MA_NHAN_VIEN { get; set; }
        public string HO_TEN { get; set; }
        public string CHUC_VU { get; set; }
        public DateTime NGAY_SINH { get; set; }
        public string MAT_KHAU { get; set; }
        public string GIOI_TINH { get; set; }
        public string SO_DIEN_THOAI { get; set; }
        public string GMAIL { get; set; }

        // update
        public bool TRANG_THAI { get; set; }
        public bool TRUONG_PHONG { get; set; }
        public DateTime THOI_GIAN { get; set; }
    }
}