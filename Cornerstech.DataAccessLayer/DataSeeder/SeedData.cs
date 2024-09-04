using Cornerstech.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cornerstech.DataAccessLayer.DataSeeder
{
    public static class DataSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            // Agreements
            var agreements = new List<Agreement>
            {
                new Agreement { Id = 1, Name = "Yazılım Geliştirme Anlaşması", Description = "Özel yazılım çözümleri geliştirilmesi", StartDate = new DateTime(2024, 1, 1), EndDate = new DateTime(2025, 1, 1), Status = "İptal Edildi", CreatedDate = DateTime.Now, IsActive = true },
                new Agreement { Id = 2, Name = "Veri Analizi Anlaşması", Description = "Büyük veri ve analitik hizmetleri sağlanması", StartDate = new DateTime(2024, 2, 1), EndDate = new DateTime(2025, 2, 1), Status = "Aktif", CreatedDate = DateTime.Now, IsActive = true },
                new Agreement { Id = 3, Name = "Müşteri Hizmetleri Anlaşması", Description = "Müşteri hizmetleri yönetimi", StartDate = new DateTime(2024, 3, 1), EndDate = new DateTime(2025, 3, 1), Status = "Aktif", CreatedDate = DateTime.Now, IsActive = true },
                new Agreement { Id = 4, Name = "Finansal Danışmanlık Anlaşması", Description = "Finansal analiz ve danışmanlık", StartDate = new DateTime(2024, 4, 1), EndDate = new DateTime(2025, 4, 1), Status = "Tamamlandı", CreatedDate = DateTime.Now, IsActive = true },
                new Agreement { Id = 5, Name = "Pazarlama Stratejisi Anlaşması", Description = "Pazarlama ve strateji danışmanlığı", StartDate = new DateTime(2024, 5, 1), EndDate = new DateTime(2025, 5, 1), Status = "Tamamlandı", CreatedDate = DateTime.Now, IsActive = true },
                new Agreement { Id = 6, Name = "Lojistik Yönetimi Anlaşması", Description = "Lojistik süreçlerin yönetimi", StartDate = new DateTime(2024, 6, 1), EndDate = new DateTime(2025, 6, 1), Status = "Aktif", CreatedDate = DateTime.Now, IsActive = true },
            };

            modelBuilder.Entity<Agreement>().HasData(agreements);

            // User
            var users = new List<User>
            {
                new User { Id = 1, UserName = "admin", Email = "beyza@example.com", Password = "1234", Role = "Admin", CreatedDate = DateTime.Now, IsActive = true },
                new User { Id = 2, UserName = "beyza", Email = "beyza@example.com", Password = "1234", Role = "Partner", CreatedDate = DateTime.Now, IsActive = true },
                new User { Id = 3, UserName = "mehmet", Email = "mehmet@example.com", Password = "1234", Role = "Partner", CreatedDate = DateTime.Now, IsActive = true },
                new User { Id = 4, UserName = "asli", Email = "asli@example.com", Password = "1234", Role = "Partner", CreatedDate = DateTime.Now, IsActive = true },
            };

            modelBuilder.Entity<User>().HasData(users);

            // Partners
            var partners = new List<Partner>
            {
                new Partner { Id = 1, Name = "ABC Tedarikçi", ContactEmail = "info@abctedarikci.com", PhoneNumber = "05321234567", City = "İstanbul", Country = "Türkiye", Industry = "Lojistik", UserId = 2},
                new Partner { Id = 2, Name = "XYZ Dağıtım", ContactEmail = "info@xyzdagitim.com", PhoneNumber = "05329876543", City = "Bursa", Country = "Türkiye", Industry = "Dağıtım", UserId = 3 },
                new Partner { Id = 3, Name = "Cornerstech", ContactEmail = "info@cornerstech.com", PhoneNumber = "05444444444", City = "İstanbul", Country = "Türkiye", Industry = "Yazılım", UserId = 4 },
            };

            modelBuilder.Entity<Partner>().HasData(partners);

            // AgreementPartners
            var agreementPartners = new List<AgreementPartner>
            {
                new AgreementPartner { Id = 1, AgreementId = 1, PartnerId = 1 },
                new AgreementPartner { Id = 2, AgreementId = 2, PartnerId = 2 },
                new AgreementPartner { Id = 3, AgreementId = 2, PartnerId = 3 },
            };

            modelBuilder.Entity<AgreementPartner>().HasData(agreementPartners);

            // Notifications
            var notifications = new List<Notification>
            {
                new Notification { Id = 1, Text = "Yeni bir anlaşma oluşturuldu: Tedarikçi Anlaşması" },
                new Notification { Id = 2, Text = "Yeni bir anlaşma oluşturuldu: Dağıtım Anlaşması" },
            };

            modelBuilder.Entity<Notification>().HasData(notifications);

            // NotificationApplicationUsers
            var notificationApplicationUsers = new List<NotificationApplicationUser>
            {
                new NotificationApplicationUser { Id = 1, NotificationId = 1, ApplicationUserId = 1, IsRead = false },
                new NotificationApplicationUser { Id = 2, NotificationId = 2, ApplicationUserId = 1, IsRead = false },
                new NotificationApplicationUser { Id = 3, NotificationId = 1, ApplicationUserId = 2, IsRead = false },
                new NotificationApplicationUser { Id = 4, NotificationId = 1, ApplicationUserId = 3, IsRead = false },
                new NotificationApplicationUser { Id = 5, NotificationId = 2, ApplicationUserId = 2, IsRead = false },
                new NotificationApplicationUser { Id = 6, NotificationId = 2, ApplicationUserId = 3, IsRead = false },
            };

            modelBuilder.Entity<NotificationApplicationUser>().HasData(notificationApplicationUsers);

            // Risks
            var risks = new List<Risk>
            {
                new Risk { Id = 1, Name = "Personel Kaybı Riski", Category = "İnsan Kaynakları", Level = 100, Frequence = 10, Possibility = 10, CreatedDate = DateTime.Now, IsActive = true },
                new Risk { Id = 2, Name = "Veri Kaybı Riski", Category = "Bilgi Güvenliği", Level = 40, Frequence = 6, Possibility = 6, CreatedDate = DateTime.Now, IsActive = true },
                new Risk { Id = 3, Name = "Yasal Uyuşmazlık Riski", Category = "Hukuki", Level = 15, Frequence = 3, Possibility = 1.5, CreatedDate = DateTime.Now, IsActive = true },
                new Risk { Id = 4, Name = "Ürün Kalitesi Riski", Category = "Üretim", Level = 7, Frequence = 1, Possibility = 0.2, CreatedDate = DateTime.Now, IsActive = true },
                new Risk { Id = 5, Name = "Ar-Ge Projesi Başarısızlığı", Category = "Ar-Ge", Level = 3, Frequence = 1, Possibility = 0.2, CreatedDate = DateTime.Now, IsActive = true },
                new Risk { Id = 6, Name = "Kredi Riski", Category = "Finans", Level = 100, Frequence = 10, Possibility = 10, CreatedDate = DateTime.Now, IsActive = true },
                new Risk { Id = 7, Name = "Doğal Afet Riski", Category = "Çevresel", Level = 100, Frequence = 10, Possibility = 10, CreatedDate = DateTime.Now, IsActive = true },
                new Risk { Id = 8, Name = "Tedarikçi İflası Riski", Category = "Tedarik Zinciri", Level = 15, Frequence = 3, Possibility = 1.5, CreatedDate = DateTime.Now, IsActive = true },
                new Risk { Id = 9, Name = "İş Kazası Riski", Category = "İş Sağlığı ve Güvenliği", Level = 7, Frequence = 2, Possibility = 1.5, CreatedDate = DateTime.Now, IsActive = true },
                new Risk { Id = 10, Name = "Yatırım Getirisi Riski", Category = "Finans", Level = 3, Frequence = 1, Possibility = 0.2, CreatedDate = DateTime.Now, IsActive = true },
                new Risk { Id = 11, Name = "Teknolojik Değişiklik Riski", Category = "Teknoloji", Level = 100, Frequence = 10, Possibility = 10, CreatedDate = DateTime.Now, IsActive = true },
                new Risk { Id = 12, Name = "Müşteri Memnuniyeti Riski", Category = "Pazarlama", Level = 40, Frequence = 6, Possibility = 6, CreatedDate = DateTime.Now, IsActive = true },
                new Risk { Id = 13, Name = "Projelerde Gecikme Riski", Category = "Proje Yönetimi", Level = 15, Frequence = 3, Possibility = 1.5, CreatedDate = DateTime.Now, IsActive = true },
                new Risk { Id = 14, Name = "Talep Düşüşü Riski", Category = "Pazarlama", Level = 7, Frequence = 1, Possibility = 0.2, CreatedDate = DateTime.Now, IsActive = true },
                new Risk { Id = 15, Name = "Kurumsal Yolsuzluk Riski", Category = "Kurumsal Yönetim", Level = 3, Frequence = 1, Possibility = 0.2, CreatedDate = DateTime.Now, IsActive = true },
                new Risk { Id = 16, Name = "Pazarlama Başarısızlığı Riski", Category = "Pazarlama", Level = 100, Frequence = 10, Possibility = 10, CreatedDate = DateTime.Now, IsActive = true },
                new Risk { Id = 17, Name = "Fikri Mülkiyet İhlali Riski", Category = "Hukuki", Level = 40, Frequence = 6, Possibility = 6, CreatedDate = DateTime.Now, IsActive = true },
                new Risk { Id = 18, Name = "Çalışan Motivasyon Düşüşü", Category = "İnsan Kaynakları", Level = 15, Frequence = 3, Possibility = 1.5, CreatedDate = DateTime.Now, IsActive = true },
                new Risk { Id = 19, Name = "İklim Değişikliği Riski", Category = "Çevresel", Level = 7, Frequence = 1, Possibility = 0.2, CreatedDate = DateTime.Now, IsActive = true },
                new Risk { Id = 20, Name = "Ürün Geri Çağırma Riski", Category = "Üretim", Level = 100, Frequence = 10, Possibility = 10, CreatedDate = DateTime.Now, IsActive = true },
            };

            modelBuilder.Entity<Risk>().HasData(risks);

            // Subjects
            var subjects = new List<SubjectOfWork>
            {
                new SubjectOfWork { Id = 1, Name = "Yazılım Geliştirme", Description = "Özel yazılım geliştirme hizmetleri.", Category = "BT", CreatedDate = DateTime.Now, IsActive = true },
                new SubjectOfWork { Id = 2, Name = "Lojistik Destek", Description = "Kapsamlı lojistik çözümleri.", Category = "Lojistik", CreatedDate = DateTime.Now, IsActive = true },
                new SubjectOfWork { Id = 3, Name = "Finansal Danışmanlık", Description = "Finansal yönetim ve yatırım danışmanlık hizmetleri.", Category = "Finans", CreatedDate = DateTime.Now, IsActive = true },
                new SubjectOfWork { Id = 4, Name = "Pazarlama Stratejisi", Description = "Pazarlama kampanyaları ve stratejik planlama.", Category = "Pazarlama", CreatedDate = DateTime.Now, IsActive = true },
                new SubjectOfWork { Id = 5, Name = "Hukuki Danışmanlık", Description = "Şirketler için hukuki danışmanlık ve dava desteği.", Category = "Hukuk", CreatedDate = DateTime.Now, IsActive = true },
                new SubjectOfWork { Id = 6, Name = "İnsan Kaynakları Yönetimi", Description = "Personel yönetimi ve organizasyonel gelişim.", Category = "İnsan Kaynakları", CreatedDate = DateTime.Now, IsActive = true },
                new SubjectOfWork { Id = 7, Name = "Üretim Yönetimi", Description = "Üretim süreçlerinin optimizasyonu ve verimliliği.", Category = "Üretim", CreatedDate = DateTime.Now, IsActive = true },
                new SubjectOfWork { Id = 8, Name = "Proje Yönetimi", Description = "Büyük ölçekli projelerin yönetimi ve planlanması.", Category = "Proje Yönetimi", CreatedDate = DateTime.Now, IsActive = true },
                new SubjectOfWork { Id = 9, Name = "Ar-Ge Çalışmaları", Description = "Yeni ürün geliştirme ve inovasyon süreçleri.", Category = "Ar-Ge", CreatedDate = DateTime.Now, IsActive = true },
                new SubjectOfWork { Id = 10, Name = "Kalite Kontrol", Description = "Ürün ve hizmetlerde kalite güvence süreçleri.", Category = "Kalite", CreatedDate = DateTime.Now, IsActive = true },
                new SubjectOfWork { Id = 11, Name = "Dijital Dönüşüm", Description = "Şirketlerin dijital altyapıya geçişi ve modernizasyonu.", Category = "BT", CreatedDate = DateTime.Now, IsActive = true },
                new SubjectOfWork { Id = 12, Name = "Risk Yönetimi", Description = "Şirket risklerinin tespiti ve yönetimi.", Category = "Finans", CreatedDate = DateTime.Now, IsActive = true },
                new SubjectOfWork { Id = 13, Name = "Satın Alma ve Tedarik Zinciri", Description = "Satın alma süreçleri ve tedarik zinciri yönetimi.", Category = "Lojistik", CreatedDate = DateTime.Now, IsActive = true },
                new SubjectOfWork { Id = 14, Name = "Müşteri İlişkileri Yönetimi", Description = "Müşteri memnuniyeti ve sadakat programları.", Category = "Pazarlama", CreatedDate = DateTime.Now, IsActive = true },
                new SubjectOfWork { Id = 15, Name = "Vergi Danışmanlığı", Description = "Vergi planlaması ve uyum hizmetleri.", Category = "Finans", CreatedDate = DateTime.Now, IsActive = true },
                new SubjectOfWork { Id = 16, Name = "Şirket İç İletişim", Description = "İç iletişim stratejileri ve çalışan motivasyonu.", Category = "İnsan Kaynakları", CreatedDate = DateTime.Now, IsActive = true },
                new SubjectOfWork { Id = 17, Name = "Bilişim Güvenliği", Description = "Siber güvenlik ve veri koruma hizmetleri.", Category = "BT", CreatedDate = DateTime.Now, IsActive = true },
                new SubjectOfWork { Id = 18, Name = "Satış Yönetimi", Description = "Satış ekiplerinin yönetimi ve performans takibi.", Category = "Satış", CreatedDate = DateTime.Now, IsActive = true },
                new SubjectOfWork { Id = 19, Name = "Enerji Yönetimi", Description = "Enerji tüketimi ve verimliliği yönetimi.", Category = "Enerji", CreatedDate = DateTime.Now, IsActive = true },
                new SubjectOfWork { Id = 20, Name = "İnovasyon Yönetimi", Description = "Şirketlerde inovasyon kültürünün oluşturulması.", Category = "Ar-Ge", CreatedDate = DateTime.Now, IsActive = true }
            };

            modelBuilder.Entity<SubjectOfWork>().HasData(subjects);

            // AgreementRisks
            var agreementRisks = new List<AgreementRisk>
            {
                new AgreementRisk { Id = 1, AgreementId = 1, RiskId = 1, CreatedDate = DateTime.Now, IsActive = true },
                new AgreementRisk { Id = 2, AgreementId = 1, RiskId = 2, CreatedDate = DateTime.Now, IsActive = true },
                new AgreementRisk { Id = 3, AgreementId = 1, RiskId = 3, CreatedDate = DateTime.Now, IsActive = true },
                new AgreementRisk { Id = 4, AgreementId = 2, RiskId = 4, CreatedDate = DateTime.Now, IsActive = true },
                new AgreementRisk { Id = 5, AgreementId = 2, RiskId = 5, CreatedDate = DateTime.Now, IsActive = true },
                new AgreementRisk { Id = 6, AgreementId = 2, RiskId = 6, CreatedDate = DateTime.Now, IsActive = true },
                new AgreementRisk { Id = 7, AgreementId = 3, RiskId = 7, CreatedDate = DateTime.Now, IsActive = true },
                new AgreementRisk { Id = 8, AgreementId = 4, RiskId = 8, CreatedDate = DateTime.Now, IsActive = true },
                new AgreementRisk { Id = 9, AgreementId = 4, RiskId = 9, CreatedDate = DateTime.Now, IsActive = true },
                new AgreementRisk { Id = 10, AgreementId = 5, RiskId = 1, CreatedDate = DateTime.Now, IsActive = true },
                new AgreementRisk { Id = 11, AgreementId = 5, RiskId = 2, CreatedDate = DateTime.Now, IsActive = true },
                new AgreementRisk { Id = 12, AgreementId = 5, RiskId = 6, CreatedDate = DateTime.Now, IsActive = true },
                new AgreementRisk { Id = 13, AgreementId = 6, RiskId = 20, CreatedDate = DateTime.Now, IsActive = true },
            };

            modelBuilder.Entity<AgreementRisk>().HasData(agreementRisks);


            // AgreementSubjects Table
            var agreementSubjects = new List<AgreementSubject>
            {
                new AgreementSubject { Id = 1, AgreementId = 1, SubjectId = 1, CreatedDate = DateTime.Now, IsActive = true },
                new AgreementSubject { Id = 2, AgreementId = 1, SubjectId = 2, CreatedDate = DateTime.Now, IsActive = true },
                new AgreementSubject { Id = 3, AgreementId = 2, SubjectId = 3, CreatedDate = DateTime.Now, IsActive = true },
                new AgreementSubject { Id = 4, AgreementId = 3, SubjectId = 4, CreatedDate = DateTime.Now, IsActive = true },
                new AgreementSubject { Id = 5, AgreementId = 3, SubjectId = 5, CreatedDate = DateTime.Now, IsActive = true },
                new AgreementSubject { Id = 6, AgreementId = 3, SubjectId = 6, CreatedDate = DateTime.Now, IsActive = true },
                new AgreementSubject { Id = 7, AgreementId = 4, SubjectId = 7, CreatedDate = DateTime.Now, IsActive = true },
                new AgreementSubject { Id = 8, AgreementId = 4, SubjectId = 8, CreatedDate = DateTime.Now, IsActive = true },
                new AgreementSubject { Id = 9, AgreementId = 5, SubjectId = 9, CreatedDate = DateTime.Now, IsActive = true },
                new AgreementSubject { Id = 10, AgreementId = 6, SubjectId = 10, CreatedDate = DateTime.Now, IsActive = true },
                new AgreementSubject { Id = 11, AgreementId = 6, SubjectId = 11, CreatedDate = DateTime.Now, IsActive = true },
                new AgreementSubject { Id = 12, AgreementId = 6, SubjectId = 12, CreatedDate = DateTime.Now, IsActive = true },
                new AgreementSubject { Id = 13, AgreementId = 6, SubjectId = 13, CreatedDate = DateTime.Now, IsActive = true },
            };

            modelBuilder.Entity<AgreementSubject>().HasData(agreementSubjects);

            // RiskManagement
            var riskManagements = new List<RiskManagement>
            {
                new RiskManagement { Id = 1, RiskCategory = "Seviye", RiskDescription = "Birden fazla ölümlü kaza", RiskValue = 100.00m, CreatedDate = DateTime.Now, IsActive = true },
                new RiskManagement { Id = 2, RiskCategory = "Seviye", RiskDescription = "Öldürücü kaza", RiskValue = 40.00m, CreatedDate = DateTime.Now, IsActive = true },
                new RiskManagement { Id = 3, RiskCategory = "Seviye", RiskDescription = "Kalıcı hasar/yaralanma, iş kaybı", RiskValue = 15.00m, CreatedDate = DateTime.Now, IsActive = true },
                new RiskManagement { Id = 4, RiskCategory = "Seviye", RiskDescription = "Önemli hasar/yaralanma", RiskValue = 7.00m, CreatedDate = DateTime.Now, IsActive = true },
                new RiskManagement { Id = 5, RiskCategory = "Seviye", RiskDescription = "Küçük hasar/yaralanma", RiskValue = 3.00m, CreatedDate = DateTime.Now, IsActive = true },
                new RiskManagement { Id = 6, RiskCategory = "Seviye", RiskDescription = "Ucuz atlatma", RiskValue = 0.50m, CreatedDate = DateTime.Now, IsActive = true },
                new RiskManagement { Id = 7, RiskCategory = "Frekans", RiskDescription = "Hemen hemen sürekli", RiskValue = 10.00m, CreatedDate = DateTime.Now, IsActive = true },
                new RiskManagement { Id = 8, RiskCategory = "Frekans", RiskDescription = "Sık", RiskValue = 6.00m, CreatedDate = DateTime.Now, IsActive = true },
                new RiskManagement { Id = 9, RiskCategory = "Frekans", RiskDescription = "Ara sıra", RiskValue = 3.00m, CreatedDate = DateTime.Now, IsActive = true },
                new RiskManagement { Id = 10, RiskCategory = "Frekans", RiskDescription = "Sık değil", RiskValue = 2.00m, CreatedDate = DateTime.Now, IsActive = true },
                new RiskManagement { Id = 11, RiskCategory = "Frekans", RiskDescription = "Seyrek", RiskValue = 1.00m, CreatedDate = DateTime.Now, IsActive = true },
                new RiskManagement { Id = 12, RiskCategory = "Frekans", RiskDescription = "Çok seyrek", RiskValue = 0.50m, CreatedDate = DateTime.Now, IsActive = true },
                new RiskManagement { Id = 13, RiskCategory = "Olasılık", RiskDescription = "Beklenir, kesin", RiskValue = 10.00m, CreatedDate = DateTime.Now, IsActive = true },
                new RiskManagement { Id = 14, RiskCategory = "Olasılık", RiskDescription = "Yüksek / oldukça mümkün", RiskValue = 6.00m, CreatedDate = DateTime.Now, IsActive = true },
                new RiskManagement { Id = 15, RiskCategory = "Olasılık", RiskDescription = "Olası", RiskValue = 3.00m, CreatedDate = DateTime.Now, IsActive = true },
                new RiskManagement { Id = 16, RiskCategory = "Olasılık", RiskDescription = "Mümkün fakat düşük", RiskValue = 2.00m, CreatedDate = DateTime.Now, IsActive = true },
                new RiskManagement { Id = 17, RiskCategory = "Olasılık", RiskDescription = "Beklenmez fakat mümkün", RiskValue = 0.50m, CreatedDate = DateTime.Now, IsActive = true },
                new RiskManagement { Id = 18, RiskCategory = "Olasılık", RiskDescription = "Beklenmez", RiskValue = 0.20m, CreatedDate = DateTime.Now, IsActive = true }
            };

            modelBuilder.Entity<RiskManagement>().HasData(riskManagements);

        }
    }
}
