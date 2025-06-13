using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnCNPM
{
    [Table("THONG_BAO")]

    public class ThongBao
    {
        [Key]
        public string MA_THONG_BAO { get; set; }
        public string TIEU_DE { get; set; }
        public string NOI_DUNG { get; set; }
        public DateTime NGAY_PHAT_HANH { get; set; }
    }

}
