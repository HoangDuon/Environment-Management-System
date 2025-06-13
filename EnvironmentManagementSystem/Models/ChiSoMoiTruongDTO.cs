using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnCNPM.Models
{
    public class ChiSoMoiTruongDTO
    {
        public string MA_CHI_SO { get; set; }
        public string TEN_CHI_SO { get; set; }
        public string HO_TEN { get; set; }
        public string LOAI_MOI_TRUONG { get; set; }
        public float CHI_SO { get; set; }
        public string TIEU_CHUAN { get; set; }
        public string VI_TRI { get; set; }
        public DateTime NGAY_NHAP { get; set; }
        public string GHI_CHU { get; set; }
        public string KET_LUAN_SV_TC { get; set; }
        public string KET_LUAN_LT { get; set; }
    }
}
