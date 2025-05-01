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

                    //ContractService cs = new ContractService();
                    //Dictionary<String, int> dic = cs.dataForPieChart("2/2025");
                    //foreach(var item in dic)
                    //{
                    //    Console.WriteLine(item.Key + " " + item.Value);
                    //}


                    return;
                }

                Console.WriteLine(" Đang thêm dữ liệu mẫu vào database...");

                var cusService = new CustomerService();
                cusService.addCustomer("Ngũ Long Công Túa Company", "0123456789", "ngulongcongtua@gmail.com", "Cobi tower, q7", "MST1");
                cusService.addCustomer("Dạ Company", "0163845621", "dacompany@gmail.com", "ThisoMall, TP.Thủ Đức", "MST2");
                cusService.addCustomer("Green Company", "0163842621", "greencompany@gmail.com", "Waterfront, Q1", "MST3");
                cusService.addCustomer("Phiền Company", "0163849621", "phantuanvy.tv2019@gmail.com", "Marina centeral tower, TP.Thủ Đức", "MST4");
                // sample
                cusService.addCustomer("Gúp nine Company", "0263849621", "ntu318485@gmail.com", "The Hall Mark, TP.Thủ Đức", "MST5");

                cusService.addCustomer("Công ty Cổ phần Nhựa An Phát Xanh", "0283940012", "greenleaf@gmail.com", "123 Nguyễn Văn Linh, Q.7, TP.HCM", "MST6");
                cusService.addCustomer("Công ty TNHH Minh Long I", "0243777888", "blueocean@gmail.com", "456 Hai Bà Trưng, Q.1, TP.HCM", "MST7");
                cusService.addCustomer("Công ty TNHH Dịch vụ Bảo vệ Bảo An", "0909123456", "redstone@gmail.com", "789 Lê Văn Việt, TP.Thủ Đức", "MST8");
                cusService.addCustomer("Công ty Cổ phần Đại Nam", "0988998877", "sunshine@gmail.com", "101 Trần Hưng Đạo, Q.5, TP.HCM", "MST9");
                cusService.addCustomer("Công ty Cổ phần Việt Xanh", "0933221122", "ecolife@gmail.com", "23 Phan Xích Long, Q.Phú Nhuận, TP.HCM", "MST10");
                cusService.addCustomer("Công ty TNHH Hưng Thịnh", "0911223344", "futuretech@gmail.com", "88 Trường Chinh, Q.Tân Bình, TP.HCM", "MST11");
                cusService.addCustomer("Công ty Cổ phần Sáng Tạo Việt", "0908777888", "goldenstar@gmail.com", "12 Hoàng Hoa Thám, Q.Bình Thạnh, TP.HCM", "MST12");
                cusService.addCustomer("Công ty TNHH Tầm Nhìn Mới", "0988123456", "vinaclean@gmail.com", "67 Lê Lợi, TP.Huế", "MST13");
                cusService.addCustomer("Công ty Cổ phần Đại Phát Holdings", "0939111222", "skynet@gmail.com", "22 Hùng Vương, TP.Đà Nẵng", "MST14");
                cusService.addCustomer("Công ty Cổ phần Đầu tư Nam Long", "0977333111", "mountainview@gmail.com", "99 Nguyễn Tất Thành, TP.Đà Lạt", "MST15");
                cusService.addCustomer("Công ty Cổ phần Tập đoàn Hòa Bình", "0909666777", "oceanwave@gmail.com", "345 Trần Phú, TP.Nha Trang", "MST16");
                cusService.addCustomer("Công ty TNHH Thương mại Dịch vụ An Khang", "0922887766", "riverside@gmail.com", "14 Nguyễn Trãi, TP.Cần Thơ", "MST17");
                cusService.addCustomer("Công ty TNHH Quang Minh", "0966444555", "novaland@gmail.com", "123 Điện Biên Phủ, TP.HCM", "MST18");
                cusService.addCustomer("Công ty TNHH Xây dựng Thanh Đạt", "0911225566", "cleanair@gmail.com", "56 Trần Não, TP.Thủ Đức", "MST19");
                cusService.addCustomer("Công ty TNHH Đầu tư Hoàng Gia", "0944777888", "greenplanet@gmail.com", "78 Pasteur, Q.3, TP.HCM", "MST20");
                cusService.addCustomer("Công ty TNHH MTV Đông Nam", "0977111000", "grid@gmail.com", "200 Lý Thường Kiệt, Q.10, TP.HCM", "MST21");
                cusService.addCustomer("Công ty TNHH Kim Long", "0955667788", "happyhome@gmail.com", "11 Nguyễn Văn Cừ, Q.5, TP.HCM", "MST22");
                cusService.addCustomer("Công ty TNHH Thương mại Thái Sơn", "0901234567", "agritech@gmail.com", "85 Quốc lộ 13, Q.Thủ Đức, TP.HCM", "MST23");
                cusService.addCustomer("Công ty TNHH Xây dựng Tân Long", "0933666999", "buildpro@gmail.com", "190 Võ Văn Kiệt, Q.1, TP.HCM", "MST24");
                cusService.addCustomer("NextGen IT", "0944111222", "nextgen@gmail.com", "33 Nguyễn Du, TP.Đà Nẵng", "MST25");
                cusService.addCustomer("Công ty Cổ phần Bình Minh Plastic", "0988111000", "cleanwater@gmail.com", "16 Lê Lai, TP.Biên Hòa", "MST26");
                cusService.addCustomer("Công ty Cổ phần Đầu tư Phúc An City", "0922998877", "smart@gmail.com", "102 Phạm Văn Đồng, TP.Thủ Đức", "MST27");
                cusService.addCustomer("Công ty Đại Nam", "0966333555", "greenbuild@gmail.com", "70 Nguyễn Văn Trỗi, TP.HCM", "MST28");
                cusService.addCustomer("Tập đoàn SafeFood Việt Nam", "0911555777", "safe@gmail.com", "29 Phan Đăng Lưu, Q.Bình Thạnh, TP.HCM", "MST29");
                cusService.addCustomer("Trường Đại học Tôn Đức Thắng", "0977444999", "vietrecycle@gmail.com", "81 Lê Văn Sỹ, Q.3, TP.HCM", "MST30");
                cusService.addCustomer("Tập đoàn Thảo Điền", "0933444222", "wind@gmail.com", "42 Tôn Đức Thắng, TP.Vũng Tàu", "MST31");
                cusService.addCustomer("Tập đoàn Phú Mỹ Hưng", "0988001122", "biohealth@gmail.com", "36 Đường 3/2, Q.10, TP.HCM", "MST32");
                cusService.addCustomer("Tập đoàn công nghệ đô thị ", "0908777444", "urban@gmail.com", "48 Lý Chính Thắng, Q.3, TP.HCM", "MST33");
                cusService.addCustomer("EcoFarm Việt Nam", "0911333555", "ecofarm@gmail.com", "65 Nguyễn Hữu Cảnh, TP.Thủ Đức", "MST34");


                var empService = new EmployeeService();
                empService.AddEmployee("Nguyễn Thanh Tun", "ADMIN", new DateTime(2005, 12, 21), "123456", "nam", "0123747789", "tu21122005@gmail.com", true, "Q7");
                empService.AddEmployee("Phan Tuấn Vỹ", "PTN", new DateTime(2005, 12, 21), "123456", "nam", "0123747789", "tuanvy24905@gmail.com", false, "Q1");
                empService.AddEmployee("Trần Cao Phong", "PTN", new DateTime(2005, 12, 21), "123456", "nam", "0123747789", "caophongt60@gmail.com", false, "Q3");
                empService.AddEmployee("Dương Nguyễn Minh Hoàng", "PTN", new DateTime(2005, 12, 21), "123456", "nam", "0123747789", "boty1402@gmail.com", false, "Q4");
                empService.AddEmployee("Hoàng Công Tài Thế", "PTN", new DateTime(2005, 12, 21), "123456", "nam", "0123747789", "52300074@gmail.com", false, "Q5");
                empService.AddEmployee("Nguyễn Thanh Tú", "PTN", new DateTime(1996, 4, 10), "123456", "nam", "0909090909", "tu03673@gmail.com", true, "Q6");
                empService.AddEmployee("Lê Thị Hồng Gấm", "PKD", new DateTime(1993, 9, 22), "123456", "nữ", "0918181818", "gam.le@example.com", false, "Q5");
                empService.AddEmployee("Phạm Hoàng L", "PKH", new DateTime(1990, 2, 5), "123456", "nam", "0927272727", "hoang.pham@example.com", true, "Q8");
                empService.AddEmployee("Trần Thị Ngọc T", "PQT", new DateTime(1998, 6, 18), "123456", "nữ", "0936363636", "ngoc.tran@example.com", false, "Q9");
                empService.AddEmployee("Vũ Minh H", "PKQ", new DateTime(1995, 12, 30), "123456", "nam", "0945454545", "minh.vu@example.com", true, "Q10");

                empService.AddEmployee("Phan Thanh N", "PQT", new DateTime(2005, 09, 24), "123456", "nam", "0123747764", "52300144@gmail.com", false, "Q3");
                empService.AddEmployee("Trần Tuấn T", "PQT", new DateTime(2005, 09, 24), "123456", "nam", "0123747764", "52300087@gmail.com", false, "Q2");
                empService.AddEmployee("Nguyễn Văn P", "PQT", new DateTime(2005, 09, 24), "123456", "nam", "0123747764", "52300081@gmail.com", false, "Q1");
                empService.AddEmployee("Phan Thanh K", "PQT", new DateTime(2005, 09, 24), "123456", "nam", "0123747764", "52300082@gmail.com", false, "Bình Thạnh");
                empService.AddEmployee("Lê Văn Hảo", "PKH", new DateTime(1992, 3, 11), "123456", "nam", "0909091122", "hao.le@example.com", true, "Tân Bình");
                empService.AddEmployee("Trần Thị Mỹ L", "PKQ", new DateTime(1995, 8, 24), "123456", "nữ", "0911223344", "my.tran@example.com", false, "Nhà Pè");
                empService.AddEmployee("Nguyễn Hữu Tài", "PTN", new DateTime(1990, 6, 2), "123456", "nam", "0922334455", "tai.nguyen@example.com", true, "Cần Giờ");
                empService.AddEmployee("Phạm Thị Minh H", "PKD", new DateTime(1993, 12, 9), "123456", "nữ", "0933445566", "minh.pham@example.com", false, "Q9");
                empService.AddEmployee("Đặng Quốc Khang", "PQT", new DateTime(1988, 11, 30), "123456", "nam", "0944556677", "khang.dang@example.com", true, "Phú Nhuận");

                //, 14, 20, 0

                var enService = new EnviromentIndexService();
                enService.addEnviromentIndex("Asen(As)", "DAT", "0,05", "PTN");
                enService.addEnviromentIndex("Cadimi(Cd)", "DAT", "0,05", "PTN");
                enService.addEnviromentIndex("Chì(Pb)", "DAT", "0,1", "PTN");
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
                contractService.addContract("ADMIN1", "KH1", new DateTime(2025, 4, 1), new DateTime(2025, 4, 27), 50000000);
                contractService.addContract("ADMIN1", "KH2", new DateTime(2025, 4, 20), new DateTime(2025, 5, 3), 50000000);
                contractService.addContract("ADMIN1", "KH3", new DateTime(2025, 4, 8), new DateTime(2025, 5, 7), 50000000);
                contractService.addContract("ADMIN1", "KH4", new DateTime(2025, 4, 21), new DateTime(2025, 5, 21), 50000000);
                contractService.addContract("ADMIN1", "KH8", new DateTime(2025, 4, 16), new DateTime(2025, 4, 18), 50000000);
                contractService.addContract("ADMIN1", "KH8", new DateTime(2025, 4, 9), new DateTime(2025, 5, 18), 50000000);

                //sample
                contractService.addContract("ADMIN1", "KH5", new DateTime(2025, 3, 4), new DateTime(2025, 4, 27), 50000000);
                contractService.addContract("ADMIN1", "KH4", new DateTime(2025, 3, 28), new DateTime(2025, 4, 30), 50000000);



                contractService.addContract("ADMIN1", "KH5", new DateTime(2025, 3, 4), new DateTime(2025, 4, 10), 50000000);
                contractService.addContract("ADMIN1", "KH1", new DateTime(2025, 3, 20), new DateTime(2025, 4, 1), 50000000);
                contractService.addContract("ADMIN1", "KH2", new DateTime(2025, 3, 18), new DateTime(2025, 4, 12), 50000000);

                contractService.addContract("ADMIN1", "KH4", new DateTime(2025, 2, 4), new DateTime(2025, 3, 3), 50000000);
                contractService.addContract("ADMIN1", "KH5", new DateTime(2025, 2, 20), new DateTime(2025, 3, 2), 50000000);
                contractService.addContract("ADMIN1", "KH6", new DateTime(2025, 2, 19), new DateTime(2025, 3, 20), 50000000);
                contractService.addContract("ADMIN1", "KH7", new DateTime(2025, 2, 1), new DateTime(2025, 3, 19), 50000000);
                contractService.addContract("ADMIN1", "KH8", new DateTime(2025, 2, 4), new DateTime(2025, 2, 18), 50000000);

                contractService.addContract("ADMIN1", "KH8", new DateTime(2025, 1, 4), new DateTime(2025, 2, 18), 50000000);
                contractService.addContract("ADMIN1", "KH9", new DateTime(2025, 1, 5), new DateTime(2025, 2, 16), 50000000);
                contractService.addContract("ADMIN1", "KH10", new DateTime(2025, 1, 20), new DateTime(2025, 2, 15), 50000000);
                contractService.addContract("ADMIN1", "KH11", new DateTime(2025, 1, 18), new DateTime(2025, 2, 3), 50000000);
                contractService.addContract("ADMIN1", "KH11", new DateTime(2025, 1, 23), new DateTime(2025, 2, 3), 50000000);
                contractService.addContract("ADMIN1", "KH11", new DateTime(2025, 1, 29), new DateTime(2025, 2, 3), 50000000);

                contractService.addContract("ADMIN1", "KH12", new DateTime(2024, 12, 20), new DateTime(2025, 1, 20), 50000000);
                contractService.addContract("ADMIN1", "KH14", new DateTime(2024, 12, 24), new DateTime(2025, 1, 20), 50000000);
                contractService.addContract("ADMIN1", "KH15", new DateTime(2024, 12, 2), new DateTime(2025, 1, 20), 50000000);

                contractService.addContract("ADMIN1", "KH16", new DateTime(2024, 11, 19), new DateTime(2024, 12, 20), 50000000);
                contractService.addContract("ADMIN1", "KH17", new DateTime(2024, 11, 20), new DateTime(2024, 12, 20), 50000000);
                contractService.addContract("ADMIN1", "KH18", new DateTime(2024, 11, 21), new DateTime(2024, 12, 20), 50000000);
                contractService.addContract("ADMIN1", "KH19", new DateTime(2024, 11, 4), new DateTime(2024, 12, 20), 50000000);
                contractService.addContract("ADMIN1", "KH20", new DateTime(2024, 11, 2), new DateTime(2024, 12, 20), 50000000);

                contractService.addContract("ADMIN1", "KH16", new DateTime(2024, 10, 19), new DateTime(2024, 11, 20), 50000000);
                contractService.addContract("ADMIN1", "KH17", new DateTime(2024, 10, 20), new DateTime(2024, 11, 20), 50000000);
                contractService.addContract("ADMIN1", "KH18", new DateTime(2024, 10, 21), new DateTime(2024, 11, 20), 50000000);
                contractService.addContract("ADMIN1", "KH19", new DateTime(2024, 10, 4), new DateTime(2024, 11, 20), 50000000);
                contractService.addContract("ADMIN1", "KH20", new DateTime(2024, 10, 2), new DateTime(2024, 11, 20), 50000000);

                contractService.addContract("ADMIN1", "KH16", new DateTime(2024, 9, 19), new DateTime(2024, 10, 20), 50000000);
                contractService.addContract("ADMIN1", "KH17", new DateTime(2024, 9, 25), new DateTime(2024, 10, 25), 50000000);

                contractService.addContract("ADMIN1", "KH16", new DateTime(2024, 8, 19), new DateTime(2024, 9, 20), 50000000);
                contractService.addContract("ADMIN1", "KH17", new DateTime(2024, 8, 20), new DateTime(2024, 9, 20), 50000000);
                contractService.addContract("ADMIN1", "KH18", new DateTime(2024, 8, 21), new DateTime(2024, 9, 20), 50000000);
                contractService.addContract("ADMIN1", "KH19", new DateTime(2024, 8, 4), new DateTime(2024, 9, 20), 50000000);
                contractService.addContract("ADMIN1", "KH20", new DateTime(2024, 8, 2), new DateTime(2024, 9, 20), 50000000);


                NotificationService noti = new NotificationService();
                noti.addNoti("Thông báo hệ thống", new DateTime(2025, 4, 26), "Hệ thống sẽ bảo trì vào lúc 23:00 hôm nay.");
                noti.addNoti("Cập nhật dịch vụ", new DateTime(2025, 4, 25), "Dịch vụ đo chất lượng nước đã được nâng cấp.");
                noti.addNoti("Nhắc nhở thanh toán", new DateTime(2025, 4, 24), "Vui lòng thanh toán hóa đơn tháng 4 trước ngày 30/4.");
                noti.addNoti("Khuyến mãi đặc biệt", new DateTime(2025, 4, 23), "Giảm 20% phí dịch vụ quan trắc môi trường tuần này.");
                noti.addNoti("Thông tin tuyển dụng", new DateTime(2025, 4, 22), "Công ty đang tuyển nhân viên môi trường, ứng tuyển ngay!");
                noti.addNoti("Thông báo nghỉ lễ", new DateTime(2025, 4, 21), "Công ty sẽ nghỉ lễ Giỗ tổ Hùng Vương từ ngày 29/4.");
                noti.addNoti("Chính sách mới", new DateTime(2025, 4, 20), "Áp dụng chính sách bảo mật dữ liệu khách hàng mới từ tháng 5.");
                noti.addNoti("Cập nhật giao diện", new DateTime(2025, 4, 19), "Giao diện phần mềm quản lý môi trường đã được cập nhật.");
                noti.addNoti("Sự kiện hội thảo", new DateTime(2025, 4, 18), "Mời tham dự hội thảo 'Công nghệ mới trong xử lý nước thải'.");
                noti.addNoti("Kết quả khảo sát", new DateTime(2025, 4, 17), "Kết quả khảo sát độ hài lòng khách hàng tháng 4 đã có.");
                noti.addNoti("Thông báo hệ thống", new DateTime(2025, 4, 16), "Có bản cập nhật hệ thống mới, vui lòng tải về.");
                noti.addNoti("Thông tin đối tác", new DateTime(2025, 4, 15), "Chúng tôi đã ký hợp tác với Công ty TNHH Môi Trường Xanh.");
                noti.addNoti("Cảnh báo ô nhiễm", new DateTime(2025, 4, 14), "Mức độ ô nhiễm không khí khu vực TP.HCM tăng cao hôm nay.");
                noti.addNoti("Tin tức môi trường", new DateTime(2025, 4, 13), "Chính phủ công bố kế hoạch giảm phát thải khí nhà kính 2030.");
                noti.addNoti("Đổi mật khẩu", new DateTime(2025, 4, 12), "Hệ thống yêu cầu đổi mật khẩu định kỳ mỗi 90 ngày.");
                noti.addNoti("Thông báo bảo trì", new DateTime(2025, 4, 11), "Máy chủ sẽ bảo trì từ 00:00 đến 04:00 sáng ngày 13/4.");
                noti.addNoti("Hướng dẫn sử dụng", new DateTime(2025, 4, 10), "Tài liệu hướng dẫn sử dụng phần mềm mới đã sẵn sàng.");
                noti.addNoti("Cập nhật giá dịch vụ", new DateTime(2025, 4, 9), "Một số dịch vụ sẽ điều chỉnh giá từ tháng 5.");
                noti.addNoti("Thông báo hệ thống", new DateTime(2025, 4, 8), "Ứng dụng di động đã có phiên bản mới trên App Store.");
                noti.addNoti("Tin nội bộ", new DateTime(2025, 4, 7), "Chúc mừng sinh nhật các thành viên có ngày sinh trong tháng 4.");

                Console.WriteLine(" Sample data generate successful!");
            }
        }
    }
}