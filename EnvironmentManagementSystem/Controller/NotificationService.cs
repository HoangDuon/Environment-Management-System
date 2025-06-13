using DuAnCNPM.Datas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnCNPM.Controller
{
    class NotificationService
    {
        public NotificationService() { }

        private String generateNotiID()
        {
            int count = 0;
            using (var context = new CTQLMTContext())
            {
                if (context.ThongBaos.Count() == 0)
                {
                    count = 1;
                }
                else
                {
                    int[] stt = new int[context.ThongBaos.Count()];
                    List<ThongBao> listHD = context.ThongBaos.ToList();
                    int i = 0;
                    foreach (ThongBao hd in listHD)
                    {
                        stt[i] = int.Parse(hd.MA_THONG_BAO.Substring(2));
                        i++;
                    }
                    count = stt.Max() + 1;
                }
            }
            String result = "TB" + count.ToString();
            return result;
        }

        public Boolean addNoti(String title, DateTime date, String content)
        {
            using (var context = new CTQLMTContext())
            {
                var thongBao = new ThongBao
                {
                    MA_THONG_BAO = generateNotiID(),
                    TIEU_DE = title,
                    NGAY_PHAT_HANH = date,
                    NOI_DUNG = content
                };
                context.ThongBaos.Add(thongBao);
                context.SaveChanges();
            }
            return true;
        }

        public Boolean removeNoti(String notiID)
        {
            using (var context = new CTQLMTContext())
            {
                var thongBao = context.ThongBaos.Find(notiID);
                if (thongBao == null) return false;

                context.ThongBaos.Remove(thongBao);
                context.SaveChanges();
            }
            return true;
        }

        public Boolean editNoti(String notiID, String title, DateTime date, String content)
        {
            using (var context = new CTQLMTContext())
            {
                var thongBao = context.ThongBaos.Find(notiID);
                if (thongBao == null) return false;

                if (thongBao.TIEU_DE != title)
                {
                    thongBao.TIEU_DE = title;
                }
                if (thongBao.NGAY_PHAT_HANH != date)
                {
                    thongBao.NGAY_PHAT_HANH = date;
                }
                if (thongBao.NOI_DUNG != content)
                {
                    thongBao.NOI_DUNG = content;
                }
                context.SaveChanges();
            }
            return true;
        }

        /*                                   */
        /*        CHỨC NĂNG TÌM KIẾM         */
        /*                                   */
        public Dictionary<String, HashSet<String>> dataName()
        {
            Dictionary<String, HashSet<String>> data = new Dictionary<String, HashSet<String>>();
            using (var context = new CTQLMTContext())
            {
                var listTB = context.ThongBaos.ToList();
                foreach (ThongBao nv in listTB)
                {
                    String[] nameArr = nv.TIEU_DE.ToLower().Trim().Split(' ');
                    for (int i = 0; i < nameArr.Length; i++)
                    {
                        if (data.ContainsKey(nameArr[i]))
                        {
                            data[nameArr[i]].Add(nv.MA_THONG_BAO);

                        }
                        else
                        {
                            if (string.IsNullOrWhiteSpace(nameArr[i].Trim()))
                            {
                                continue;
                            }
                            HashSet<String> set = new HashSet<string>();
                            set.Add(nv.MA_THONG_BAO);
                            data.Add(nameArr[i], set);
                        }
                    }
                }
            }
            return data;
        }

        // tìm theo tên thông báo 
        private List<ThongBao> searchByNotiName(String text)
        {
            var context = new CTQLMTContext();
            String[] textEle = text.Trim().ToLower().Split(' ');
            Dictionary<String, HashSet<String>> data = dataName();
            List<HashSet<String>> saveResult = new List<HashSet<String>>();
            for (int i = 0; i < textEle.Length; i++)
            {
                if (data.ContainsKey(textEle[i]))
                {
                    saveResult.Add(data[textEle[i]]);
                }
            }
            List<ThongBao> result = new List<ThongBao>();
            if (saveResult.Count() == 0) return result;
            if (saveResult.Count() > 1)
            {
                for (int i = 1; i < saveResult.Count; i++)
                {
                    saveResult[0].IntersectWith(saveResult[i]);
                }
                foreach (String s in saveResult[0])
                {
                    result.Add(context.ThongBaos.Find(s));
                }
            }
            else
            {
                foreach (String s in saveResult[0])
                {
                    result.Add(context.ThongBaos.Find(s));
                }
            }

            return result;
        }

        // Kiểm tra chuỗi nhập có phải là id không
        private bool checkTextIsNotiID(String text)
        {
            if (string.IsNullOrWhiteSpace(text) || text.Length <= 2) return false;
            List<String> sample = new List<String>() { "TB" };
            String first = text.Substring(2);      // lấy stt
            String final = text.Substring(0, 2);   // lấy 5 kí tự đầu
            bool checkFinal = sample.Contains(final);
            bool checkFirst = int.TryParse(first, out int result);
            if (checkFinal && checkFirst) return true;
            return false;
        }

        public List<ThongBao> searchNoti(String text)
        {
            List<ThongBao> result = new List<ThongBao>();
            if (string.IsNullOrWhiteSpace(text)) return result;
            // Phân tích chuỗi truyền vào laà mã nhân viên
            if (checkTextIsNotiID(text.Trim()))
            {
                using (var context = new CTQLMTContext())
                {
                    ThongBao nv = context.ThongBaos.Find(text.Trim());
                    if (nv != null)
                    {
                        result.Add(nv);
                    }
                }
                return result;
            }
            // phân tích chuỗi truyền vào là tên nhân viên
            else
            {
                return searchByNotiName(text.ToLower());
            }
        }

    }
}
