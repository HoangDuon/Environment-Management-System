using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DuAnCNPM.Models
{
    [Table("CHI_SO_MOI_TRUONG")]
    public class ChiSoMoiTruong
    {
        [Key]
        public string MA_CHI_SO { get; set; }
        public string TEN_CHI_SO { get; set; }
        public string LOAI_MOI_TRUONG { get; set; }
        public string VI_TRI { get; set; }
        public string TIEU_CHUAN { get; set; }

        // update 
        public bool TRANG_THAI { get; set; }
        public string NOI_NHAP { get; set; }
    }
}
