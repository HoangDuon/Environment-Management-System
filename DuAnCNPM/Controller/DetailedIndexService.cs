using DuAnCNPM.Datas;
using DuAnCNPM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DuAnCNPM.Controller
{
    class DetailedIndexService
    {
        public DetailedIndexService() { }

        public Boolean addDetailedIndex(String MaHopDong, String MaChiSo, String MaNhanVien, float ChiSo, DateTime NgayNhap, String GhiChu)
        {
            using (var context = new CTQLMTContext())
            {
                var hopdong = context.HopDongs.Find(MaHopDong);
                if (hopdong == null) return false;

                var chisomoitruong = context.ChiSoMoiTruongs.Find(MaChiSo);
                if (chisomoitruong == null) return false;

                var chitietchiso = new ChiTietChiSo
                {
                    MA_HOP_DONG = MaHopDong,
                    MA_CHI_SO = MaChiSo,
                    MA_NHAN_VIEN = MaNhanVien,
                    CHI_SO = ChiSo,
                    NGAY_NHAP = NgayNhap,
                    GHI_CHU = GhiChu,
                    KET_LUAN_LT = "CHƯA ĐẠT",
                    KET_LUAN_SV_TC = "CHƯA ĐẠT",
                    FLAG = false // flag cho biết chỉ số này đã được nhập chưa, flag tự động thay đổi khi có theo tác edit chỉ số
                };
                context.ChiTietChiSos.Add(chitietchiso);
                context.SaveChanges();
            }
            return true;
        }

        public Boolean deleteDetailedIndex(String MaHopDong, String MaChiSo)
        {
            using (var context = new CTQLMTContext())
            {
                var chitietchiso = context.ChiTietChiSos.FindAsync(MaHopDong, MaChiSo).Result;
                if (chitietchiso == null) return false;
                context.ChiTietChiSos.Remove(chitietchiso);
                context.SaveChanges();
            }
            return true;
        }

        public Boolean editChiSo(String MaHopDong, String MaChiSo, float ChiSo, String MaNhanVien)
        {
            using (var context = new CTQLMTContext())
            {
                var chitietchiso = context.ChiTietChiSos.FindAsync(MaHopDong, MaChiSo).Result;
                if (chitietchiso == null) return false;
                chitietchiso.CHI_SO = ChiSo;
                chitietchiso.MA_NHAN_VIEN = MaNhanVien;
                chitietchiso.NGAY_NHAP = DateTime.Today;
                chitietchiso.FLAG = true;
                updateConclusionWithStandard(context.ChiSoMoiTruongs.Find(MaChiSo).TIEU_CHUAN, ChiSo, MaChiSo, MaHopDong);
                chitietchiso.KET_LUAN_LT = updateConclusionWithLastedContract(MaChiSo, ChiSo, MaHopDong);
                context.SaveChanges();
            }
            return true;
        }

        //private async Task updateConclusion(float chiso,string machiso, string mahopdong)
        //{
        //    await updateConclusionWithLastedContract(machiso, chiso, mahopdong);
        //}


        public Boolean editNgayNhap(String MaHopDong, String MaChiSo, String MaNhanVien, DateTime NgayNhap)
        {
            using (var context = new CTQLMTContext())
            {
                var chitietchiso = context.ChiTietChiSos.FindAsync(MaHopDong, MaChiSo).Result;
                if (chitietchiso == null) return false;
                chitietchiso.NGAY_NHAP = NgayNhap;
                context.SaveChanges();
            }
            return true;
        }
        public Boolean editGhiChu(String MaHopDong, String MaChiSo, String MaNhanVien, String GhiChu)
        {
            using (var context = new CTQLMTContext())
            {
                var chitietchiso = context.ChiTietChiSos.FindAsync(MaHopDong, MaChiSo).Result;
                if (chitietchiso == null) return false;
                chitietchiso.GHI_CHU = GhiChu;
                context.SaveChanges();
            }
            return true;
        }

        private void updateConclusionWithStandard(String standardText, float cs, String machiso, String mahopdong)
        {
            using (var context = new CTQLMTContext())
            {
                var chitietchiso = context.ChiTietChiSos.FindAsync(mahopdong, machiso).Result;
                if (chitietchiso == null)
                {
                    Console.WriteLine("Null");
                }

                if (checkStandard(standardText) == 0)
                {
                    float standard = float.Parse(standardText);
                    if (cs < standard)
                    {
                        chitietchiso.KET_LUAN_SV_TC = "NHỎ HƠN TIÊU CHUẨN";
                    }
                    else if (cs == standard)
                    {
                        chitietchiso.KET_LUAN_SV_TC = "ĐẠT TIÊU CHUẨN";
                    }
                    else
                    {
                        chitietchiso.KET_LUAN_SV_TC = "LỚN HƠN TIÊU CHUẨN";
                    }
                }
                else if (checkStandard(standardText) == -1)
                {
                    chitietchiso.KET_LUAN_SV_TC = "CHƯA RÕ";
                }
                else
                {
                    String[] arrStandard = standardText.Split('-');
                    float first = float.Parse(arrStandard[0]);
                    float final = float.Parse(arrStandard[1]);
                    if (cs > first && cs < final)
                    {
                        chitietchiso.KET_LUAN_SV_TC = "ĐẠT TIÊU CHUẨN";
                    }
                    else
                    {
                        chitietchiso.KET_LUAN_SV_TC = "CHƯA ĐẠT";
                    }
                }
                context.SaveChanges();
            }
        }


        private HopDong getPreviousContract(String mahopdong)
        {
            using (var context = new CTQLMTContext())
            {
                var hopDong = context.HopDongs.Find(mahopdong);
                var listHD = context.HopDongs.ToList();
                var listHDOld = new List<HopDong>();
                foreach (HopDong hd in listHD)
                {
                    if (hd.MA_CONG_TY == hopDong.MA_CONG_TY && hd.MA_HOP_DONG != hopDong.MA_HOP_DONG)
                    {
                        listHDOld.Add(hd);
                    }
                }
                int[] now = analysisQuarter(hopDong.QUY);
                int[] previous = new int[2];
                if (now[0] == 1)
                {
                    previous[0] = 4;
                    previous[1] = now[1] - 1;
                }
                else
                {
                    previous[0] = now[0] - 1;
                    previous[1] = now[1];
                }
                foreach (HopDong hd in listHDOld)
                {
                    int[] data = analysisQuarter(hd.QUY);
                    if (previous[0] == data[0] && previous[1] == data[1])
                    {
                        return hd;
                    }
                }
                return null;
            }
        }

        private int[] analysisQuarter(String quarter)
        {
            String[] quy = quarter.Split('/');
            int[] result = new int[2] { int.Parse(quy[0]), int.Parse(quy[1]) };
            return result;
        }

        // update kết luận so với hợp đồng trước
        // hàm này được gọi tại nút save khi lưu việc edit 1 chỉ số
        public String updateConclusionWithLastedContract(String machiso, float cs, String mahopdong) 
        {
            HopDong preContract = getPreviousContract(mahopdong);
            using(var context = new CTQLMTContext())
            {
                var preIndex = context.ChiTietChiSos.FindAsync(preContract.MA_HOP_DONG, machiso).Result;

                if (preContract == null)
                {
                    return "";
                }
                if (preIndex != null)
                {
                    if (preIndex.CHI_SO > cs)
                    {
                        return  "Thấp hơn quý trước";
                    }
                    else if (preIndex.CHI_SO < cs)
                    {
                        return"Cao hơn quý trước";
                    }
                    else
                    {
                        return "Không thay đổi";
                    }
                }
                else return "";
            }
        }

        // kiểm tra tiêu chuẩn nếu là nằm trong khoảng thì trả về 1 còn là 1 chỉ số thì trả về 0
        private int checkStandard(String standard)
        {
            if (float.TryParse(standard, out float result))
            {
                return 0;
            }
            else if (standard.Equals("CR"))
            {
                return -1;
            }
            else return 1;
        }
    }
}
