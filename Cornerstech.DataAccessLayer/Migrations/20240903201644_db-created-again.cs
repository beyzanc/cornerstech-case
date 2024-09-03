using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cornerstech.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class dbcreatedagain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agreements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agreements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RiskManagements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RiskCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RiskDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RiskValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RiskManagements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Risks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Level = table.Column<double>(type: "float", nullable: true),
                    Frequence = table.Column<double>(type: "float", nullable: true),
                    Possibility = table.Column<double>(type: "float", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Risks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubjectOfWorks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectOfWorks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AgreementRisks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgreementId = table.Column<int>(type: "int", nullable: false),
                    RiskId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgreementRisks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AgreementRisks_Agreements_AgreementId",
                        column: x => x.AgreementId,
                        principalTable: "Agreements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AgreementRisks_Risks_RiskId",
                        column: x => x.RiskId,
                        principalTable: "Risks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AgreementSubjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgreementId = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgreementSubjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AgreementSubjects_Agreements_AgreementId",
                        column: x => x.AgreementId,
                        principalTable: "Agreements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AgreementSubjects_SubjectOfWorks_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "SubjectOfWorks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubjectRisks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    RiskId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectRisks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubjectRisks_Risks_RiskId",
                        column: x => x.RiskId,
                        principalTable: "Risks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubjectRisks_SubjectOfWorks_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "SubjectOfWorks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NotificationApplicationUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NotificationId = table.Column<int>(type: "int", nullable: false),
                    ApplicationUserId = table.Column<int>(type: "int", nullable: false),
                    IsRead = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationApplicationUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NotificationApplicationUsers_Notifications_NotificationId",
                        column: x => x.NotificationId,
                        principalTable: "Notifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NotificationApplicationUsers_Users_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Partners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Industry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partners", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Partners_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AgreementPartners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgreementId = table.Column<int>(type: "int", nullable: false),
                    PartnerId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgreementPartners", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AgreementPartners_Agreements_AgreementId",
                        column: x => x.AgreementId,
                        principalTable: "Agreements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AgreementPartners_Partners_PartnerId",
                        column: x => x.PartnerId,
                        principalTable: "Partners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Agreements",
                columns: new[] { "Id", "CreatedDate", "Description", "EndDate", "IsActive", "Name", "StartDate", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6456), "Özel yazılım çözümleri geliştirilmesi", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Yazılım Geliştirme Anlaşması", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "İptal Edildi", null },
                    { 2, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6462), "Büyük veri ve analitik hizmetleri sağlanması", new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Veri Analizi Anlaşması", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aktif", null },
                    { 3, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6465), "Müşteri hizmetleri yönetimi", new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Müşteri Hizmetleri Anlaşması", new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aktif", null },
                    { 4, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6467), "Finansal analiz ve danışmanlık", new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Finansal Danışmanlık Anlaşması", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tamamlandı", null },
                    { 5, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6469), "Pazarlama ve strateji danışmanlığı", new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Pazarlama Stratejisi Anlaşması", new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tamamlandı", null },
                    { 6, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6473), "Lojistik süreçlerin yönetimi", new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Lojistik Yönetimi Anlaşması", new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aktif", null }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Text" },
                values: new object[,]
                {
                    { 1, "Yeni bir anlaşma oluşturuldu: Tedarikçi Anlaşması" },
                    { 2, "Yeni bir anlaşma oluşturuldu: Dağıtım Anlaşması" }
                });

            migrationBuilder.InsertData(
                table: "RiskManagements",
                columns: new[] { "Id", "CreatedDate", "IsActive", "RiskCategory", "RiskDescription", "RiskValue", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(7019), true, "Seviye", "Birden fazla ölümlü kaza", 100.00m, null },
                    { 2, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(7022), true, "Seviye", "Öldürücü kaza", 40.00m, null },
                    { 3, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(7023), true, "Seviye", "Kalıcı hasar/yaralanma, iş kaybı", 15.00m, null },
                    { 4, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(7025), true, "Seviye", "Önemli hasar/yaralanma", 7.00m, null },
                    { 5, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(7027), true, "Seviye", "Küçük hasar/yaralanma", 3.00m, null },
                    { 6, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(7029), true, "Seviye", "Ucuz atlatma", 0.50m, null },
                    { 7, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(7031), true, "Frekans", "Hemen hemen sürekli", 10.00m, null },
                    { 8, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(7032), true, "Frekans", "Sık", 3.00m, null },
                    { 9, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(7034), true, "Frekans", "Ara sıra", 3.00m, null },
                    { 10, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(7037), true, "Frekans", "Sık değil", 2.00m, null },
                    { 11, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(7038), true, "Frekans", "Seyrek", 1.00m, null },
                    { 12, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(7040), true, "Frekans", "Çok seyrek", 0.50m, null },
                    { 13, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(7042), true, "Frekans", "Beklenir, kesin", 10.00m, null },
                    { 14, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(7043), true, "Olasılık", "Yüksek / oldukça mümkün", 6.00m, null },
                    { 15, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(7045), true, "Olasılık", "Olası", 3.00m, null },
                    { 16, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(7047), true, "Olasılık", "Mümkün fakat düşük", 2.00m, null },
                    { 17, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(7048), true, "Olasılık", "Beklenmez fakat mümkün", 0.50m, null },
                    { 18, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(7051), true, "Olasılık", "Beklenmez", 0.20m, null }
                });

            migrationBuilder.InsertData(
                table: "Risks",
                columns: new[] { "Id", "Category", "CreatedDate", "Frequence", "IsActive", "Level", "Name", "Possibility", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "İnsan Kaynakları", new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6742), 10.0, true, 100.0, "Personel Kaybı Riski", 10.0, null },
                    { 2, "Bilgi Güvenliği", new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6746), 6.0, true, 40.0, "Veri Kaybı Riski", 6.0, null },
                    { 3, "Hukuki", new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6748), 3.0, true, 15.0, "Yasal Uyuşmazlık Riski", 1.5, null },
                    { 4, "Üretim", new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6750), 1.0, true, 7.0, "Ürün Kalitesi Riski", 0.20000000000000001, null },
                    { 5, "Ar-Ge", new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6752), 1.0, true, 3.0, "Ar-Ge Projesi Başarısızlığı", 0.20000000000000001, null },
                    { 6, "Finans", new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6755), 10.0, true, 100.0, "Kredi Riski", 10.0, null },
                    { 7, "Çevresel", new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6757), 10.0, true, 100.0, "Doğal Afet Riski", 10.0, null },
                    { 8, "Tedarik Zinciri", new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6759), 3.0, true, 15.0, "Tedarikçi İflası Riski", 1.5, null },
                    { 9, "İş Sağlığı ve Güvenliği", new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6761), 2.0, true, 7.0, "İş Kazası Riski", 1.5, null },
                    { 10, "Finans", new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6764), 1.0, true, 3.0, "Yatırım Getirisi Riski", 0.20000000000000001, null },
                    { 11, "Teknoloji", new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6767), 10.0, true, 100.0, "Teknolojik Değişiklik Riski", 10.0, null },
                    { 12, "Pazarlama", new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6769), 6.0, true, 40.0, "Müşteri Memnuniyeti Riski", 6.0, null },
                    { 13, "Proje Yönetimi", new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6771), 3.0, true, 15.0, "Projelerde Gecikme Riski", 1.5, null },
                    { 14, "Pazarlama", new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6774), 1.0, true, 7.0, "Talep Düşüşü Riski", 0.20000000000000001, null },
                    { 15, "Kurumsal Yönetim", new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6776), 1.0, true, 3.0, "Kurumsal Yolsuzluk Riski", 0.20000000000000001, null },
                    { 16, "Pazarlama", new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6778), 10.0, true, 100.0, "Pazarlama Başarısızlığı Riski", 10.0, null },
                    { 17, "Hukuki", new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6780), 6.0, true, 40.0, "Fikri Mülkiyet İhlali Riski", 6.0, null },
                    { 18, "İnsan Kaynakları", new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6783), 3.0, true, 15.0, "Çalışan Motivasyon Düşüşü", 1.5, null },
                    { 19, "Çevresel", new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6785), 1.0, true, 7.0, "İklim Değişikliği Riski", 0.20000000000000001, null },
                    { 20, "Üretim", new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6787), 10.0, true, 100.0, "Ürün Geri Çağırma Riski", 10.0, null }
                });

            migrationBuilder.InsertData(
                table: "SubjectOfWorks",
                columns: new[] { "Id", "Category", "CreatedDate", "Description", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "BT", new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6821), "Özel yazılım geliştirme hizmetleri.", true, "Yazılım Geliştirme", null },
                    { 2, "Lojistik", new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6824), "Kapsamlı lojistik çözümleri.", true, "Lojistik Destek", null },
                    { 3, "Finans", new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6825), "Finansal yönetim ve yatırım danışmanlık hizmetleri.", true, "Finansal Danışmanlık", null },
                    { 4, "Pazarlama", new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6827), "Pazarlama kampanyaları ve stratejik planlama.", true, "Pazarlama Stratejisi", null },
                    { 5, "Hukuk", new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6829), "Şirketler için hukuki danışmanlık ve dava desteği.", true, "Hukuki Danışmanlık", null },
                    { 6, "İnsan Kaynakları", new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6831), "Personel yönetimi ve organizasyonel gelişim.", true, "İnsan Kaynakları Yönetimi", null },
                    { 7, "Üretim", new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6833), "Üretim süreçlerinin optimizasyonu ve verimliliği.", true, "Üretim Yönetimi", null },
                    { 8, "Proje Yönetimi", new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6834), "Büyük ölçekli projelerin yönetimi ve planlanması.", true, "Proje Yönetimi", null },
                    { 9, "Ar-Ge", new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6836), "Yeni ürün geliştirme ve inovasyon süreçleri.", true, "Ar-Ge Çalışmaları", null },
                    { 10, "Kalite", new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6838), "Ürün ve hizmetlerde kalite güvence süreçleri.", true, "Kalite Kontrol", null },
                    { 11, "BT", new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6840), "Şirketlerin dijital altyapıya geçişi ve modernizasyonu.", true, "Dijital Dönüşüm", null },
                    { 12, "Finans", new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6842), "Şirket risklerinin tespiti ve yönetimi.", true, "Risk Yönetimi", null },
                    { 13, "Lojistik", new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6843), "Satın alma süreçleri ve tedarik zinciri yönetimi.", true, "Satın Alma ve Tedarik Zinciri", null },
                    { 14, "Pazarlama", new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6845), "Müşteri memnuniyeti ve sadakat programları.", true, "Müşteri İlişkileri Yönetimi", null },
                    { 15, "Finans", new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6847), "Vergi planlaması ve uyum hizmetleri.", true, "Vergi Danışmanlığı", null },
                    { 16, "İnsan Kaynakları", new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6848), "İç iletişim stratejileri ve çalışan motivasyonu.", true, "Şirket İç İletişim", null },
                    { 17, "BT", new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6850), "Siber güvenlik ve veri koruma hizmetleri.", true, "Bilişim Güvenliği", null },
                    { 18, "Satış", new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6853), "Satış ekiplerinin yönetimi ve performans takibi.", true, "Satış Yönetimi", null },
                    { 19, "Enerji", new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6854), "Enerji tüketimi ve verimliliği yönetimi.", true, "Enerji Yönetimi", null },
                    { 20, "Ar-Ge", new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6856), "Şirketlerde inovasyon kültürünün oluşturulması.", true, "İnovasyon Yönetimi", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "Email", "IsActive", "Password", "Role", "UpdatedDate", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6560), "beyza@example.com", true, "1234", "Admin", null, "admin" },
                    { 2, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6564), "beyza@example.com", true, "1234", "Partner", null, "beyza" },
                    { 3, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6566), "mehmet@example.com", true, "1234", "Partner", null, "mehmet" },
                    { 4, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6568), "asli@example.com", true, "1234", "Partner", null, "asli" }
                });

            migrationBuilder.InsertData(
                table: "AgreementRisks",
                columns: new[] { "Id", "AgreementId", "CreatedDate", "IsActive", "RiskId", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6914), true, 1, null },
                    { 2, 1, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6917), true, 2, null },
                    { 3, 1, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6919), true, 3, null },
                    { 4, 2, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6920), true, 4, null },
                    { 5, 2, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6922), true, 5, null },
                    { 6, 2, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6924), true, 6, null },
                    { 7, 3, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6925), true, 7, null },
                    { 8, 4, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6927), true, 8, null },
                    { 9, 4, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6928), true, 9, null },
                    { 10, 5, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6931), true, 1, null },
                    { 11, 5, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6932), true, 2, null },
                    { 12, 5, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6934), true, 6, null },
                    { 13, 6, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6935), true, 20, null }
                });

            migrationBuilder.InsertData(
                table: "AgreementSubjects",
                columns: new[] { "Id", "AgreementId", "CreatedDate", "IsActive", "SubjectId", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6966), true, 1, null },
                    { 2, 1, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6969), true, 2, null },
                    { 3, 2, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6970), true, 3, null },
                    { 4, 3, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6972), true, 4, null },
                    { 5, 3, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6976), true, 5, null },
                    { 6, 3, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6978), true, 6, null },
                    { 7, 4, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6980), true, 7, null },
                    { 8, 4, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6981), true, 8, null },
                    { 9, 5, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6983), true, 9, null },
                    { 10, 6, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6985), true, 10, null },
                    { 11, 6, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6986), true, 11, null },
                    { 12, 6, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6988), true, 12, null },
                    { 13, 6, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6989), true, 13, null }
                });

            migrationBuilder.InsertData(
                table: "NotificationApplicationUsers",
                columns: new[] { "Id", "ApplicationUserId", "CreatedDate", "IsActive", "IsRead", "NotificationId", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6700), true, false, 1, null },
                    { 2, 1, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6703), true, false, 2, null },
                    { 3, 2, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6704), true, false, 1, null },
                    { 4, 3, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6705), true, false, 1, null },
                    { 5, 2, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6706), true, false, 2, null },
                    { 6, 3, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6708), true, false, 2, null }
                });

            migrationBuilder.InsertData(
                table: "Partners",
                columns: new[] { "Id", "City", "ContactEmail", "Country", "CreatedDate", "Industry", "IsActive", "Name", "PhoneNumber", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, "İstanbul", "info@abctedarikci.com", "Türkiye", new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6593), "Lojistik", true, "ABC Tedarikçi", "05321234567", null, 2 },
                    { 2, "Bursa", "info@xyzdagitim.com", "Türkiye", new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6599), "Dağıtım", true, "XYZ Dağıtım", "05329876543", null, 3 },
                    { 3, "İstanbul", "info@cornerstech.com", "Türkiye", new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6600), "Yazılım", true, "Cornerstech", "05444444444", null, 4 }
                });

            migrationBuilder.InsertData(
                table: "AgreementPartners",
                columns: new[] { "Id", "AgreementId", "CreatedDate", "IsActive", "PartnerId", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6622), true, 1, null },
                    { 2, 2, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6625), true, 2, null },
                    { 3, 2, new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6626), true, 3, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AgreementPartners_AgreementId",
                table: "AgreementPartners",
                column: "AgreementId");

            migrationBuilder.CreateIndex(
                name: "IX_AgreementPartners_PartnerId",
                table: "AgreementPartners",
                column: "PartnerId");

            migrationBuilder.CreateIndex(
                name: "IX_AgreementRisks_AgreementId",
                table: "AgreementRisks",
                column: "AgreementId");

            migrationBuilder.CreateIndex(
                name: "IX_AgreementRisks_RiskId",
                table: "AgreementRisks",
                column: "RiskId");

            migrationBuilder.CreateIndex(
                name: "IX_AgreementSubjects_AgreementId",
                table: "AgreementSubjects",
                column: "AgreementId");

            migrationBuilder.CreateIndex(
                name: "IX_AgreementSubjects_SubjectId",
                table: "AgreementSubjects",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationApplicationUsers_ApplicationUserId",
                table: "NotificationApplicationUsers",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationApplicationUsers_NotificationId",
                table: "NotificationApplicationUsers",
                column: "NotificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Partners_UserId",
                table: "Partners",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectRisks_RiskId",
                table: "SubjectRisks",
                column: "RiskId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectRisks_SubjectId",
                table: "SubjectRisks",
                column: "SubjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgreementPartners");

            migrationBuilder.DropTable(
                name: "AgreementRisks");

            migrationBuilder.DropTable(
                name: "AgreementSubjects");

            migrationBuilder.DropTable(
                name: "NotificationApplicationUsers");

            migrationBuilder.DropTable(
                name: "RiskManagements");

            migrationBuilder.DropTable(
                name: "SubjectRisks");

            migrationBuilder.DropTable(
                name: "Partners");

            migrationBuilder.DropTable(
                name: "Agreements");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "Risks");

            migrationBuilder.DropTable(
                name: "SubjectOfWorks");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
