using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data;
using DuAnCNPM.Models;

namespace DuAnCNPM.Datas
{
    public class CTQLMTContext : DbContext
    {

        public CTQLMTContext() : base("name=CTQLMTConnectionString")
        {

        }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<HopDong> HopDongs { get; set; }
        public DbSet<ChiTietChiSo> ChiTietChiSos { get; set; }
        public DbSet<ChiSoMoiTruong> ChiSoMoiTruongs { get; set; }
        public DbSet<ThongBao> ThongBaos { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<HopDong>()
                .HasRequired(h => h.KhachHang)
                .WithMany()
                .HasForeignKey(h => h.MA_CONG_TY);

            modelBuilder.Entity<HopDong>()
                .HasRequired(h => h.NhanVien)
                .WithMany()
                .HasForeignKey(h => h.MA_NHAN_VIEN);

            modelBuilder.Entity<ChiTietChiSo>()
                .HasRequired(c => c.HopDong)
                .WithMany()
                .HasForeignKey(c => c.MA_HOP_DONG);

            modelBuilder.Entity<ChiTietChiSo>()
                .HasRequired(c => c.ChiSoMoiTruong)
                .WithMany()
                .HasForeignKey(c => c.MA_CHI_SO);
        }
    }
}
