using DuAnCNPM.Controller;
using DuAnCNPM.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;

namespace DuAnCNPM.Datas
{
    public class DataSeeder
    {
        public DataSeeder()
        {
        }

        private static int[] analysisQuarter(String quarter)
        {
            String[] quy = quarter.Split('/');
            int[] result = new int[2] { int.Parse(quy[0]), int.Parse(quy[1]) };
            return result;
        }

        public static void SeedData()
        {
            using (var context = new CTQLMTContext())
            {
                // Checking data
                if (context.KhachHangs.Any() || context.NhanViens.Any() || context.HopDongs.Any())
                {
                    Console.WriteLine(" Dữ liệu đã tồn tại, không cần thêm!");

                    //ContractService e = new ContractService();
                    //List<HopDong> listNV = e.sortContract();
                    //foreach (HopDong nv in listNV)
                    //{
                    //    Console.WriteLine(nv.MA_HOP_DONG + " " + nv.MA_CONG_TY);
                    //}

                    //Dictionary<int, String> dic = e.dataToSort();
                    //foreach (int i in dic.Keys)
                    //{
                    //    Console.WriteLine(i + ": " + dic[i]);
                    //}

                    //EnviromentIndexService eid = new EnviromentIndexService();
                    //Dictionary<String, HashSet<String>> dic = eid.dataName();
                    //foreach (String i in dic.Keys)
                    //{
                    //    Console.Write(i + ": ");
                    //    foreach(String j in dic[i])
                    //    {
                    //        Console.Write(j + " ");
                    //    }
                    //    Console.WriteLine();
                    //}

                    //EmployeeService cs = new EmployeeService();
                    //String[] testCase = new string[11] { "Nguyễn Thanh Tú", "Nguyễn Văn 123", "Phan", "Phan C ao H",
                    //    "Nguyen Thi Diem M", "NgUYễN ThỊ DiễM M", "Lê Văn Đạt", "han", "@Phan Cao H", "", " Nguyễn Thanh Tú" };
                    //for (int i = 0; i < testCase.Length; i++)
                    //{
                    //    Console.WriteLine("Test case: "+testCase[i] + "----------------------------------");
                    //    List<NhanVien> listnv = cs.searchEmployee(testCase[i]);
                    //    foreach (NhanVien nv in listnv)
                    //    {
                    //        Console.WriteLine("      " + nv.MA_NHAN_VIEN + " " + nv.HO_TEN);
                    //    }                        
                    //}

                    //ContractService cs = new ContractService();
                    //for (int i = 0; i < testCase.Length; i++)
                    //{
                    //    Console.WriteLine("Test case: " + testCase[i] + "----------------------------------");
                    //    List<HopDong> listnv = cs.searchContract(testCase[i]);
                    //    foreach (HopDong nv in listnv)
                    //    {
                    //        Console.WriteLine("      " + nv.MA_HOP_DONG + " " + nv.MA_CONG_TY + " " + context.KhachHangs.Find(nv.MA_CONG_TY).TEN_CONG_TY);
                    //    }
                    //}
                    //var list = new List<ChiTietChiSo>();
                    //var listCTTS = context.ChiTietChiSos.ToList();
                    //foreach (var ctcs in listCTTS)
                    //{
                    //    if (ctcs.MA_HOP_DONG == "HD1")
                    //    {
                    //        list.Add(ctcs);
                    //    }
                    //}
                    //int i = 0;
                    //foreach (var cs in list)
                    //{
                    //    i++;
                    //    Console.WriteLine(i + " " + cs.FLAG);
                    //}
                    //ContractService cs = new ContractService();
                    //Console.WriteLine(cs.checkPrintCondition("HD1"));


                    //var hopDong = context.HopDongs.Find("HD1");
                    //var listHD = context.HopDongs.ToList();
                    //var listHDOld = new List<HopDong>();
                    //foreach (HopDong hd in listHD)
                    //{
                    //    if (hd.MA_CONG_TY == hopDong.MA_CONG_TY && hd.MA_HOP_DONG != hopDong.MA_HOP_DONG)
                    //    {
                    //        listHDOld.Add(hd);
                    //    }
                    //}
                    //int[] now = analysisQuarter(hopDong.QUY);
                    //int[] previous = new int[2];
                    //if (now[0] == 1)
                    //{
                    //    previous[0] = 4;
                    //    previous[1] = now[1] - 1;
                    //}
                    //else
                    //{
                    //    previous[0] = now[0] - 1;
                    //    previous[1] = now[1];
                    //}
                    //HopDong hd1 = new HopDong();
                    //foreach (HopDong hd in listHDOld)
                    //{
                    //    int[] data = analysisQuarter(hd.QUY);
                    //    if (previous[0] == data[0] && previous[1] == data[1])
                    //    {
                    //        hd1 = hd;
                    //        break;
                    //    }
                    //}

                    //Console.WriteLine(previous[0] + " " + previous[1]);
                    //Console.WriteLine(hd1.MA_HOP_DONG + " " + hd1.MA_CONG_TY);

                    ContractService cs = new ContractService();
                    Dictionary<String, int> dic = cs.dataForPieChart("2/2025");
                    foreach(var item in dic)
                    {
                        Console.WriteLine(item.Key + " " + item.Value);
                    }


                    return;
                }

                Console.WriteLine(" Đang thêm dữ liệu mẫu vào database...");

                var cusService = new CustomerService();
                cusService.addCustomer("Ngũ Long Công Túa Company", "0123456789", "ngulongcongtua@gmail.com", "Cobi tower, q7", "MST1");
                cusService.addCustomer("Dạ Company", "0163845621", "dacompany@gmail.com", "ThisoMall, TP.Thủ Đức", "MST2");
                cusService.addCustomer("Green Company", "0163842621", "greencompany@gmail.com", "Waterfront, Q1", "MST3");
                cusService.addCustomer("Phiền Company", "0163849621", "phiencompany@gmail.com", "Marina centeral tower, TP.Thủ Đức", "MST4");
                cusService.addCustomer("Gúp nine Company", "0263849621", "gupninecompany@gmail.com", "The Hall Mark, TP.Thủ Đức", "MST5");
                cusService.addCustomer("Green Leaf Ltd", "0283940012", "greenleaf@gmail.com", "123 Nguyễn Văn Linh, Q.7, TP.HCM", "MST6");
                cusService.addCustomer("Blue Ocean Corp", "0243777888", "blueocean@gmail.com", "456 Hai Bà Trưng, Q.1, TP.HCM", "MST7");
                cusService.addCustomer("Red Stone JSC", "0909123456", "redstone@gmail.com", "789 Lê Văn Việt, TP.Thủ Đức", "MST8");
                cusService.addCustomer("Sunshine Trading", "0988998877", "sunshine@gmail.com", "101 Trần Hưng Đạo, Q.5, TP.HCM", "MST9");
                cusService.addCustomer("Eco Life Co., Ltd", "0933221122", "ecolife@gmail.com", "23 Phan Xích Long, Q.Phú Nhuận, TP.HCM", "MST10");
                cusService.addCustomer("Future Tech Inc.", "0911223344", "futuretech@gmail.com", "88 Trường Chinh, Q.Tân Bình, TP.HCM", "MST11");
                cusService.addCustomer("Golden Star Co", "0908777888", "goldenstar@gmail.com", "12 Hoàng Hoa Thám, Q.Bình Thạnh, TP.HCM", "MST12");
                cusService.addCustomer("VinaClean Services", "0988123456", "vinaclean@gmail.com", "67 Lê Lợi, TP.Huế", "MST13");
                cusService.addCustomer("SkyNet JSC", "0939111222", "skynet@gmail.com", "22 Hùng Vương, TP.Đà Nẵng", "MST14");
                cusService.addCustomer("MountainView Ltd", "0977333111", "mountainview@gmail.com", "99 Nguyễn Tất Thành, TP.Đà Lạt", "MST15");
                cusService.addCustomer("OceanWave Co.", "0909666777", "oceanwave@gmail.com", "345 Trần Phú, TP.Nha Trang", "MST16");
                cusService.addCustomer("RiverSide Trading", "0922887766", "riverside@gmail.com", "14 Nguyễn Trãi, TP.Cần Thơ", "MST17");
                cusService.addCustomer("NovaLand Group", "0966444555", "novaland@gmail.com", "123 Điện Biên Phủ, TP.HCM", "MST18");
                cusService.addCustomer("CleanAir Solutions", "0911225566", "cleanair@gmail.com", "56 Trần Não, TP.Thủ Đức", "MST19");
                cusService.addCustomer("GreenPlanet Inc.", "0944777888", "greenplanet@gmail.com", "78 Pasteur, Q.3, TP.HCM", "MST20");
                cusService.addCustomer("PowerGrid Vietnam", "0977111000", "grid@gmail.com", "200 Lý Thường Kiệt, Q.10, TP.HCM", "MST21");
                cusService.addCustomer("HappyHome Co.", "0955667788", "happyhome@gmail.com", "11 Nguyễn Văn Cừ, Q.5, TP.HCM", "MST22");
                cusService.addCustomer("AgriTech Ltd", "0901234567", "agritech@gmail.com", "85 Quốc lộ 13, Q.Thủ Đức, TP.HCM", "MST23");
                cusService.addCustomer("BuildPro Corp", "0933666999", "buildpro@gmail.com", "190 Võ Văn Kiệt, Q.1, TP.HCM", "MST24");
                cusService.addCustomer("NextGen IT", "0944111222", "nextgen@gmail.com", "33 Nguyễn Du, TP.Đà Nẵng", "MST25");
                cusService.addCustomer("CleanWater JSC", "0988111000", "cleanwater@gmail.com", "16 Lê Lai, TP.Biên Hòa", "MST26");
                cusService.addCustomer("SmartLogistics", "0922998877", "smart@gmail.com", "102 Phạm Văn Đồng, TP.Thủ Đức", "MST27");
                cusService.addCustomer("GreenBuild Co", "0966333555", "greenbuild@gmail.com", "70 Nguyễn Văn Trỗi, TP.HCM", "MST28");
                cusService.addCustomer("SafeFood VN", "0911555777", "safe@gmail.com", "29 Phan Đăng Lưu, Q.Bình Thạnh, TP.HCM", "MST29");
                cusService.addCustomer("VietRecycle Co.", "0977444999", "vietrecycle@gmail.com", "81 Lê Văn Sỹ, Q.3, TP.HCM", "MST30");
                cusService.addCustomer("WindEnergy Ltd", "0933444222", "wind@gmail.com", "42 Tôn Đức Thắng, TP.Vũng Tàu", "MST31");
                cusService.addCustomer("BioHealth Group", "0988001122", "biohealth@gmail.com", "36 Đường 3/2, Q.10, TP.HCM", "MST32");
                cusService.addCustomer("UrbanTech Co.", "0908777444", "urban@gmail.com", "48 Lý Chính Thắng, Q.3, TP.HCM", "MST33");
                cusService.addCustomer("EcoFarm Vietnam", "0911333555", "ecofarm@gmail.com", "65 Nguyễn Hữu Cảnh, TP.Thủ Đức", "MST34");


                var empService = new EmployeeService();
                empService.AddEmployee("Nguyễn Thanh Tú", "PTN", new DateTime(2005, 12, 21), "123456", "nam", "0123747789", "ntu318485@gmail.com", true);
                empService.AddEmployee("Nguyễn Văn C", "PTN", new DateTime(2005, 12, 21), "123456", "nam", "0123747789", "ntu318485@gmail.com", false);
                empService.AddEmployee("Nguyễn Thanh A", "PTN", new DateTime(2005, 12, 21), "123456", "nam", "0123747789", "ntu318485@gmail.com", false);
                empService.AddEmployee("Trần Thanh Tun", "PTN", new DateTime(2005, 12, 21), "123456", "nam", "0123747789", "ntu318485@gmail.com", false);
                empService.AddEmployee("Phạm Thanh H", "PTN", new DateTime(2005, 12, 21), "123456", "nam", "0123747789", "ntu318485@gmail.com", false);
                empService.AddEmployee("Nguyễn Văn An", "PTN", new DateTime(1996, 4, 10), "123456", "nam", "0909090909", "an.nguyen@example.com", true);
                empService.AddEmployee("Lê Thị Hồng Gấm", "PKD", new DateTime(1993, 9, 22), "123456", "nữ", "0918181818", "gam.le@example.com", false);
                empService.AddEmployee("Phạm Hoàng L", "PKH", new DateTime(1990, 2, 5), "123456", "nam", "0927272727", "hoang.pham@example.com", true);
                empService.AddEmployee("Trần Thị Ngọc T", "PQT", new DateTime(1998, 6, 18), "123456", "nữ", "0936363636", "ngoc.tran@example.com", false);
                empService.AddEmployee("Vũ Minh H", "PKQ", new DateTime(1995, 12, 30), "123456", "nam", "0945454545", "minh.vu@example.com", true);

                empService.AddEmployee("Phan Tuấn Vỹ", "PQT", new DateTime(2005, 09, 24), "123456", "nam", "0123747764", "boty1402@gmail.com", true);
                empService.AddEmployee("Phan Thanh N", "PQT", new DateTime(2005, 09, 24), "123456", "nam", "0123747764", "boty1402@gmail.com", false);
                empService.AddEmployee("Trần Tuấn T", "PQT", new DateTime(2005, 09, 24), "123456", "nam", "0123747764", "boty1402@gmail.com", false);
                empService.AddEmployee("Nguyễn Văn P", "PQT", new DateTime(2005, 09, 24), "123456", "nam", "0123747764", "boty1402@gmail.com", false);
                empService.AddEmployee("Phan Thanh K", "PQT", new DateTime(2005, 09, 24), "123456", "nam", "0123747764", "boty1402@gmail.com", false);
                empService.AddEmployee("Lê Văn Hảo", "PKH", new DateTime(1992, 3, 11), "123456", "nam", "0909091122", "hao.le@example.com", true);
                empService.AddEmployee("Trần Thị Mỹ L", "PKQ", new DateTime(1995, 8, 24), "123456", "nữ", "0911223344", "my.tran@example.com", false);
                empService.AddEmployee("Nguyễn Hữu Tài", "PTN", new DateTime(1990, 6, 2), "123456", "nam", "0922334455", "tai.nguyen@example.com", true);
                empService.AddEmployee("Phạm Thị Minh H", "PKD", new DateTime(1993, 12, 9), "123456", "nữ", "0933445566", "minh.pham@example.com", false);
                empService.AddEmployee("Đặng Quốc Khang", "PQT", new DateTime(1988, 11, 30), "123456", "nam", "0944556677", "khang.dang@example.com", true);

                empService.AddEmployee("Trần Cao Phong", "PKQ", new DateTime(2005, 06, 20), "123456", "nam", "0123727789", "52300144gmail.com", true);
                empService.AddEmployee("Trần Thanh K", "PKQ", new DateTime(2005, 06, 20), "123456", "nam", "0123727789", "52300144gmail.com", false);
                empService.AddEmployee("Nguyễn Văn M", "PKQ", new DateTime(2005, 06, 20), "123456", "nam", "0123727789", "52300144gmail.com", false);
                empService.AddEmployee("Phan Cao h", "PKQ", new DateTime(2005, 06, 20), "123456", "nam", "0123727789", "52300144gmail.com", false);
                empService.AddEmployee("Nguyễn Văn Tun", "PKQ", new DateTime(2005, 06, 20), "123456", "nam", "0123727789", "52300144gmail.com", false);
                empService.AddEmployee("Nguyễn Thị Diễm M", "PKD", new DateTime(1996, 4, 15), "123456", "nữ", "0966111222", "diem.nguyen@example.com", true);
                empService.AddEmployee("Lâm Văn Hùng", "PQT", new DateTime(1991, 9, 27), "123456", "nam", "0977222333", "hung.lam@example.com", false);
                empService.AddEmployee("Võ Thị Thu T", "PKH", new DateTime(1998, 2, 8), "123456", "nữ", "0988333444", "thu.vo@example.com", true);
                empService.AddEmployee("Trần Nhật Minh", "PKQ", new DateTime(1994, 7, 20), "123456", "nam", "0999444555", "minh.tran@example.com", true);
                empService.AddEmployee("Hoàng Thị Lan", "PTN", new DateTime(1990, 11, 3), "123456", "nữ", "0900555666", "lan.hoang@example.com", false);

                empService.AddEmployee("Dương Nguyễn Minh Hoàng", "PKD", new DateTime(2005, 08, 20), "123456", "nam", "0123747789", "52300025gmail.com", true);
                empService.AddEmployee("Trần Nguyễn Thanh K", "PKD", new DateTime(2005, 08, 20), "123456", "nam", "0123747789", "52300025gmail.com", false);
                empService.AddEmployee("Nguyễn Minh F", "PKD", new DateTime(2005, 08, 20), "123456", "nam", "0123747789", "52300025gmail.com", false);
                empService.AddEmployee("Nguyễn Trần Minh M", "PKD", new DateTime(2005, 08, 20), "123456", "nam", "0123747789", "52300025gmail.com", false);
                empService.AddEmployee("Nguyễn Thanh T", "PKD", new DateTime(2005, 08, 20), "123456", "nam", "0123747789", "52300025gmail.com", false);
                empService.AddEmployee("Đinh Văn Tùng", "PKQ", new DateTime(1993, 3, 19), "123456", "nam", "0911002233", "tung.dinh@example.com", true);
                empService.AddEmployee("Phạm Thị Bích Ng", "PTN", new DateTime(1997, 10, 25), "123456", "nữ", "0922113344", "bich.pham@example.com", false);
                empService.AddEmployee("Lưu Đức Tài", "PKD", new DateTime(1992, 5, 5), "123456", "nam", "0933224455", "tai.luu@example.com", true);
                empService.AddEmployee("Nguyễn Thị Ánh M", "PKH", new DateTime(1999, 6, 12), "123456", "nữ", "0944335566", "anh.nguyen@example.com", true);
                empService.AddEmployee("Trần Quốc Việt", "PQT", new DateTime(1989, 1, 9), "123456", "nam", "0955446677", "viet.tran@example.com", false);

                empService.AddEmployee("Hoàng Công Tài Thế", "PKH", new DateTime(2005, 01, 24), "123456", "nam", "0123747719", "52300065@gmail.com", true);
                empService.AddEmployee("Nguyễn Văn T", "PKH", new DateTime(2005, 01, 24), "123456", "nam", "0123747719", "52300065@gmail.com", false);
                empService.AddEmployee("Trần Tài M", "PKH", new DateTime(2005, 01, 24), "123456", "nam", "0123747719", "52300065@gmail.com", false);
                empService.AddEmployee("Nguyễn Văn K", "PKH", new DateTime(2005, 01, 24), "123456", "nam", "0123747719", "52300065@gmail.com", false);
                empService.AddEmployee("Nguyễn Văn D", "PKH", new DateTime(2005, 01, 24), "123456", "nam", "0123747719", "52300065@gmail.com", false);
                empService.AddEmployee("Lê Văn Sơn", "PKH", new DateTime(1990, 8, 14), "123456", "nam", "0966557788", "son.le@example.com", true);
                empService.AddEmployee("Ngô Thị Kim L", "PKQ", new DateTime(1996, 12, 3), "123456", "nữ", "0977668899", "kim.ngo@example.com", false);
                empService.AddEmployee("Phan Hoàng Phúc", "PTN", new DateTime(1995, 2, 20), "123456", "nam", "0988779900", "phuc.phan@example.com", true);
                empService.AddEmployee("Trịnh Thị Ngọc H", "PKD", new DateTime(1993, 7, 7), "123456", "nữ", "0999888001", "ngoc.trinh@example.com", false);
                empService.AddEmployee("Đoàn Quốc Thịnh", "PQT", new DateTime(1988, 9, 30), "123456", "nam", "0900999112", "thinh.doan@example.com", true);

                empService.AddEmployee("Nguyễn Văn Tú", "ADMIN", new DateTime(2005, 01, 24), "123456", "nam", "0123747719", "52300065@gmail.com", false);

                //, 14, 20, 0

                var enService = new EnviromentIndexService();
                enService.addEnviromentIndex("Asen(As)", "DAT", "0.05", "PTN");
                enService.addEnviromentIndex("Cadimi(Cd)", "DAT", "0.05", "PTN");
                enService.addEnviromentIndex("Chì(Pb)", "DAT", "0.1", "PTN");
                enService.addEnviromentIndex("Kẽm(Zn)", "DAT", "3", "PTN");
                enService.addEnviromentIndex("Đồng(Cu)", "DAT", "2", "PTN");


                enService.addEnviromentIndex("pH", "NUOC", "6-9", "PTN");
                enService.addEnviromentIndex("Nhiệt độ(độ C)", "NUOC", "CR", "HT");
                enService.addEnviromentIndex("Lưu lượng(m^3/h)", "NUOC", "CR", "HT");
                enService.addEnviromentIndex("Độ màu(Pt-Co)", "NUOC", "50", "PTN");
                enService.addEnviromentIndex("Nhu cầu Oxi sinh học (BOD5) (mg/L)", "NUOC", "30", "PTN");
                enService.addEnviromentIndex("Nhu cầu Oxi hóa học (COD5) (mg/L)", "NUOC", "75", "PTN");
                enService.addEnviromentIndex("Tổng chất rắn lơ lửng (mg/L)", "NUOC", "50", "PTN");
                enService.addEnviromentIndex("Tổng dầu mở khoáng (mg/L)", "NUOC", "5", "PTN");
                enService.addEnviromentIndex("Amoni (NH4+ tiính theo N) (mg/L)", "NUOC", "CR", "PTN");
                enService.addEnviromentIndex("Tổng N (mg/L)", "NUOC", "CR", "PTN");
                enService.addEnviromentIndex("Tổng P (mg/L)", "NUOC", "CR", "PTN");
                enService.addEnviromentIndex("Halogen hữu cơ dễ hấp thụ (AOX) (mg/L)", "NUOC", "CR", "PTN");
                enService.addEnviromentIndex("Caliform (MPN) (MPN/100mL)", "NUOC", "CR", "PTN");

                enService.addEnviromentIndex("Lưu lượng Method 2(Nm^3/h)", "KHITHAI", "CR", "PTN");
                enService.addEnviromentIndex("CO (mg/Nm^3)", "KHITHAI", "40", "PTN");
                enService.addEnviromentIndex("Lưu huỳnh dioioxit (mg/Nm^3)", "KHITHAI", "10", "PTN");
                enService.addEnviromentIndex("NO2 (mg/Nm^3)", "KHITHAI", "10", "PTN");
                enService.addEnviromentIndex("Bụi tổng (mg/Nm^3)", "KHITHAI", "CR", "HT");

                enService.addEnviromentIndex("Ánh sáng (Lux)", "KHONGKHI", "CR", "HT");
                enService.addEnviromentIndex("Nhiệt độ (độ C)", "KHONGKHI", "CR", "HT");
                enService.addEnviromentIndex("Độ ẩm (%)", "KHONGKHI", "CR", "HT");
                enService.addEnviromentIndex("Tốc độ gió (m/s)", "KHONGKHI", "CR", "HT");
                enService.addEnviromentIndex("Tiếng ồn (dBA)", "KHONGKHI", "85", "HT");
                enService.addEnviromentIndex("Tổng bụi lơ lửng (TSP-Tổng bụi toàn phần) (mg/m^3)", "KHONGKHI", "8", "HT");
                enService.addEnviromentIndex("NO2 (mg/m^3)", "KHONGKHI", "10", "PTN");
                enService.addEnviromentIndex("sulfur dioxide", "KHONGKHI", "10", "PTN");
                enService.addEnviromentIndex("Hidro sulfur", "KHONGKHI", "15", "PTN");
                enService.addEnviromentIndex("Carbon dioxit", "KHONGKHI", "CR", "PTN");

                var contractService = new ContractService();
                contractService.addContract("NVPTN4", "KH1", DateTime.Today, new DateTime(2025, 5, 4), 50000000);
                contractService.addContract("NVPTN4", "KH2", DateTime.Today, new DateTime(2025, 5, 3), 50000000);
                contractService.addContract("NVPTN4", "KH3", DateTime.Today, new DateTime(2025, 5, 7), 50000000);
                contractService.addContract("NVPTN4", "KH4", DateTime.Today, new DateTime(2025, 5, 21), 50000000);
                contractService.addContract("NVPTN4", "KH5", DateTime.Today, new DateTime(2025, 5, 10), 50000000);
                contractService.addContract("NVPTN4", "KH1", DateTime.Today, new DateTime(2025, 4, 1), 50000000);
                contractService.addContract("NVPTN4", "KH2", DateTime.Today, new DateTime(2025, 4, 12), 50000000);
                contractService.addContract("NVPTN4", "KH3", DateTime.Today, new DateTime(2025, 4, 14), 50000000);
                contractService.addContract("NVPTN4", "KH4", DateTime.Today, new DateTime(2025, 5, 3), 50000000);
                contractService.addContract("NVPTN4", "KH5", DateTime.Today, new DateTime(2025, 5, 2), 50000000);
                contractService.addContract("NVPTN4", "KH6", DateTime.Today, new DateTime(2025, 5, 20), 50000000);
                contractService.addContract("NVPTN4", "KH7", DateTime.Today, new DateTime(2025, 5, 19), 50000000);
                contractService.addContract("NVPTN4", "KH8", DateTime.Today, new DateTime(2025, 5, 18), 50000000);
                contractService.addContract("NVPTN4", "KH9", DateTime.Today, new DateTime(2025, 5, 16), 50000000);
                contractService.addContract("NVPTN4", "KH10", DateTime.Today, new DateTime(2025, 5, 15), 50000000);
                contractService.addContract("NVPTN4", "KH11", DateTime.Today, new DateTime(2025, 5, 3), 50000000);
                contractService.addContract("NVPTN4", "KH12", DateTime.Today, new DateTime(2025, 5, 5), 50000000);
                contractService.addContract("NVPTN4", "KH13", DateTime.Today, new DateTime(2025, 5, 8), 50000000);
                contractService.addContract("NVPTN4", "KH14", DateTime.Today, new DateTime(2025, 5, 9), 50000000);
                contractService.addContract("NVPTN4", "KH15", DateTime.Today, new DateTime(2025, 5, 1), 50000000);
                contractService.addContract("NVPTN4", "KH16", DateTime.Today, new DateTime(2025, 5, 7), 50000000);
                contractService.addContract("NVPTN4", "KH17", DateTime.Today, new DateTime(2025, 5, 8), 50000000);
                contractService.addContract("NVPTN4", "KH18", DateTime.Today, new DateTime(2025, 5, 6), 50000000);
                contractService.addContract("NVPTN4", "KH19", DateTime.Today, new DateTime(2025, 5, 8), 50000000);
                contractService.addContract("NVPTN4", "KH20", DateTime.Today, new DateTime(2025, 5, 4), 50000000);
                Console.WriteLine(" Sample data generate successful!");
            }
        }
    }
}