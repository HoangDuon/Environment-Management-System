using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DuAnCNPM.Models
{
    [Table("CHI_TIET_CHI_SO")]
    public class ChiTietChiSo
    {
        [Key, Column(Order = 0)]
        public string MA_HOP_DONG { get; set; }

        [Key, Column(Order = 1)]
        public string MA_CHI_SO { get; set; }

        public string MA_NHAN_VIEN { get; set; }

        public float CHI_SO { get; set; }
        public DateTime NGAY_NHAP { get; set; }
        public string GHI_CHU { get; set; }

        [ForeignKey("MA_HOP_DONG")]
        public virtual HopDong HopDong { get; set; }

        [ForeignKey("MA_CHI_SO")]
        public virtual ChiSoMoiTruong ChiSoMoiTruong { get; set; }

        // update 
        public string KET_LUAN_SV_TC { get; set; }
        public string KET_LUAN_LT { get; set; }
        public Boolean FLAG { get; set; }
    }
}
