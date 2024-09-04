using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cornerstech.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class minorchanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubjectRisks");

            migrationBuilder.UpdateData(
                table: "AgreementPartners",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7299));

            migrationBuilder.UpdateData(
                table: "AgreementPartners",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7302));

            migrationBuilder.UpdateData(
                table: "AgreementPartners",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7303));

            migrationBuilder.UpdateData(
                table: "AgreementRisks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7591));

            migrationBuilder.UpdateData(
                table: "AgreementRisks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7594));

            migrationBuilder.UpdateData(
                table: "AgreementRisks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7596));

            migrationBuilder.UpdateData(
                table: "AgreementRisks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7598));

            migrationBuilder.UpdateData(
                table: "AgreementRisks",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7599));

            migrationBuilder.UpdateData(
                table: "AgreementRisks",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7602));

            migrationBuilder.UpdateData(
                table: "AgreementRisks",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7604));

            migrationBuilder.UpdateData(
                table: "AgreementRisks",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7605));

            migrationBuilder.UpdateData(
                table: "AgreementRisks",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7607));

            migrationBuilder.UpdateData(
                table: "AgreementRisks",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7610));

            migrationBuilder.UpdateData(
                table: "AgreementRisks",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7612));

            migrationBuilder.UpdateData(
                table: "AgreementRisks",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7613));

            migrationBuilder.UpdateData(
                table: "AgreementRisks",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7615));

            migrationBuilder.UpdateData(
                table: "AgreementSubjects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7647));

            migrationBuilder.UpdateData(
                table: "AgreementSubjects",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "AgreementSubjects",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7652));

            migrationBuilder.UpdateData(
                table: "AgreementSubjects",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7654));

            migrationBuilder.UpdateData(
                table: "AgreementSubjects",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7655));

            migrationBuilder.UpdateData(
                table: "AgreementSubjects",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7658));

            migrationBuilder.UpdateData(
                table: "AgreementSubjects",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7687));

            migrationBuilder.UpdateData(
                table: "AgreementSubjects",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "AgreementSubjects",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "AgreementSubjects",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7693));

            migrationBuilder.UpdateData(
                table: "AgreementSubjects",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7694));

            migrationBuilder.UpdateData(
                table: "AgreementSubjects",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7696));

            migrationBuilder.UpdateData(
                table: "AgreementSubjects",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7698));

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7108));

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7115));

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "NotificationApplicationUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7352));

            migrationBuilder.UpdateData(
                table: "NotificationApplicationUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7355));

            migrationBuilder.UpdateData(
                table: "NotificationApplicationUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7356));

            migrationBuilder.UpdateData(
                table: "NotificationApplicationUsers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "NotificationApplicationUsers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "NotificationApplicationUsers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7264));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7272));

            migrationBuilder.UpdateData(
                table: "RiskManagements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "RiskManagements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "RiskManagements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "RiskManagements",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "RiskManagements",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "RiskManagements",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7747));

            migrationBuilder.UpdateData(
                table: "RiskManagements",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7749));

            migrationBuilder.UpdateData(
                table: "RiskManagements",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "RiskValue" },
                values: new object[] { new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7751), 6.00m });

            migrationBuilder.UpdateData(
                table: "RiskManagements",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7753));

            migrationBuilder.UpdateData(
                table: "RiskManagements",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "RiskManagements",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "RiskManagements",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "RiskManagements",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7761));

            migrationBuilder.UpdateData(
                table: "RiskManagements",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7763));

            migrationBuilder.UpdateData(
                table: "RiskManagements",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7765));

            migrationBuilder.UpdateData(
                table: "RiskManagements",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7767));

            migrationBuilder.UpdateData(
                table: "RiskManagements",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7769));

            migrationBuilder.UpdateData(
                table: "RiskManagements",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7771));

            migrationBuilder.UpdateData(
                table: "Risks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "Risks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7395));

            migrationBuilder.UpdateData(
                table: "Risks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7397));

            migrationBuilder.UpdateData(
                table: "Risks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7399));

            migrationBuilder.UpdateData(
                table: "Risks",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7402));

            migrationBuilder.UpdateData(
                table: "Risks",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "Risks",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7407));

            migrationBuilder.UpdateData(
                table: "Risks",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7444));

            migrationBuilder.UpdateData(
                table: "Risks",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7446));

            migrationBuilder.UpdateData(
                table: "Risks",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7449));

            migrationBuilder.UpdateData(
                table: "Risks",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "Risks",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7454));

            migrationBuilder.UpdateData(
                table: "Risks",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7456));

            migrationBuilder.UpdateData(
                table: "Risks",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7459));

            migrationBuilder.UpdateData(
                table: "Risks",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7461));

            migrationBuilder.UpdateData(
                table: "Risks",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7464));

            migrationBuilder.UpdateData(
                table: "Risks",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7466));

            migrationBuilder.UpdateData(
                table: "Risks",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7469));

            migrationBuilder.UpdateData(
                table: "Risks",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7471));

            migrationBuilder.UpdateData(
                table: "Risks",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "SubjectOfWorks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "SubjectOfWorks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7518));

            migrationBuilder.UpdateData(
                table: "SubjectOfWorks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7519));

            migrationBuilder.UpdateData(
                table: "SubjectOfWorks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7521));

            migrationBuilder.UpdateData(
                table: "SubjectOfWorks",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7523));

            migrationBuilder.UpdateData(
                table: "SubjectOfWorks",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7525));

            migrationBuilder.UpdateData(
                table: "SubjectOfWorks",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7527));

            migrationBuilder.UpdateData(
                table: "SubjectOfWorks",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7529));

            migrationBuilder.UpdateData(
                table: "SubjectOfWorks",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7531));

            migrationBuilder.UpdateData(
                table: "SubjectOfWorks",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7534));

            migrationBuilder.UpdateData(
                table: "SubjectOfWorks",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7536));

            migrationBuilder.UpdateData(
                table: "SubjectOfWorks",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7538));

            migrationBuilder.UpdateData(
                table: "SubjectOfWorks",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "SubjectOfWorks",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7541));

            migrationBuilder.UpdateData(
                table: "SubjectOfWorks",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7543));

            migrationBuilder.UpdateData(
                table: "SubjectOfWorks",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "SubjectOfWorks",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7547));

            migrationBuilder.UpdateData(
                table: "SubjectOfWorks",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "SubjectOfWorks",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7551));

            migrationBuilder.UpdateData(
                table: "SubjectOfWorks",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7553));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 4, 3, 16, 20, 145, DateTimeKind.Local).AddTicks(7232));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SubjectRisks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RiskId = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
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

            migrationBuilder.UpdateData(
                table: "AgreementPartners",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6622));

            migrationBuilder.UpdateData(
                table: "AgreementPartners",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6625));

            migrationBuilder.UpdateData(
                table: "AgreementPartners",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6626));

            migrationBuilder.UpdateData(
                table: "AgreementRisks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "AgreementRisks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6917));

            migrationBuilder.UpdateData(
                table: "AgreementRisks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6919));

            migrationBuilder.UpdateData(
                table: "AgreementRisks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "AgreementRisks",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "AgreementRisks",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6924));

            migrationBuilder.UpdateData(
                table: "AgreementRisks",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "AgreementRisks",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6927));

            migrationBuilder.UpdateData(
                table: "AgreementRisks",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "AgreementRisks",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6931));

            migrationBuilder.UpdateData(
                table: "AgreementRisks",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6932));

            migrationBuilder.UpdateData(
                table: "AgreementRisks",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "AgreementRisks",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6935));

            migrationBuilder.UpdateData(
                table: "AgreementSubjects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6966));

            migrationBuilder.UpdateData(
                table: "AgreementSubjects",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6969));

            migrationBuilder.UpdateData(
                table: "AgreementSubjects",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "AgreementSubjects",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "AgreementSubjects",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6976));

            migrationBuilder.UpdateData(
                table: "AgreementSubjects",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6978));

            migrationBuilder.UpdateData(
                table: "AgreementSubjects",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "AgreementSubjects",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6981));

            migrationBuilder.UpdateData(
                table: "AgreementSubjects",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6983));

            migrationBuilder.UpdateData(
                table: "AgreementSubjects",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6985));

            migrationBuilder.UpdateData(
                table: "AgreementSubjects",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6986));

            migrationBuilder.UpdateData(
                table: "AgreementSubjects",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6988));

            migrationBuilder.UpdateData(
                table: "AgreementSubjects",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6989));

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6456));

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6467));

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6469));

            migrationBuilder.UpdateData(
                table: "Agreements",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "NotificationApplicationUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "NotificationApplicationUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "NotificationApplicationUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6704));

            migrationBuilder.UpdateData(
                table: "NotificationApplicationUsers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "NotificationApplicationUsers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "NotificationApplicationUsers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6593));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "RiskManagements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(7019));

            migrationBuilder.UpdateData(
                table: "RiskManagements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(7022));

            migrationBuilder.UpdateData(
                table: "RiskManagements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(7023));

            migrationBuilder.UpdateData(
                table: "RiskManagements",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(7025));

            migrationBuilder.UpdateData(
                table: "RiskManagements",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(7027));

            migrationBuilder.UpdateData(
                table: "RiskManagements",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(7029));

            migrationBuilder.UpdateData(
                table: "RiskManagements",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(7031));

            migrationBuilder.UpdateData(
                table: "RiskManagements",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "RiskValue" },
                values: new object[] { new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(7032), 3.00m });

            migrationBuilder.UpdateData(
                table: "RiskManagements",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "RiskManagements",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(7037));

            migrationBuilder.UpdateData(
                table: "RiskManagements",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "RiskManagements",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "RiskManagements",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(7042));

            migrationBuilder.UpdateData(
                table: "RiskManagements",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(7043));

            migrationBuilder.UpdateData(
                table: "RiskManagements",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(7045));

            migrationBuilder.UpdateData(
                table: "RiskManagements",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "RiskManagements",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(7048));

            migrationBuilder.UpdateData(
                table: "RiskManagements",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(7051));

            migrationBuilder.UpdateData(
                table: "Risks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6742));

            migrationBuilder.UpdateData(
                table: "Risks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "Risks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6748));

            migrationBuilder.UpdateData(
                table: "Risks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "Risks",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6752));

            migrationBuilder.UpdateData(
                table: "Risks",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6755));

            migrationBuilder.UpdateData(
                table: "Risks",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6757));

            migrationBuilder.UpdateData(
                table: "Risks",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6759));

            migrationBuilder.UpdateData(
                table: "Risks",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6761));

            migrationBuilder.UpdateData(
                table: "Risks",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6764));

            migrationBuilder.UpdateData(
                table: "Risks",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6767));

            migrationBuilder.UpdateData(
                table: "Risks",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6769));

            migrationBuilder.UpdateData(
                table: "Risks",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6771));

            migrationBuilder.UpdateData(
                table: "Risks",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6774));

            migrationBuilder.UpdateData(
                table: "Risks",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6776));

            migrationBuilder.UpdateData(
                table: "Risks",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6778));

            migrationBuilder.UpdateData(
                table: "Risks",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "Risks",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6783));

            migrationBuilder.UpdateData(
                table: "Risks",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6785));

            migrationBuilder.UpdateData(
                table: "Risks",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6787));

            migrationBuilder.UpdateData(
                table: "SubjectOfWorks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6821));

            migrationBuilder.UpdateData(
                table: "SubjectOfWorks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6824));

            migrationBuilder.UpdateData(
                table: "SubjectOfWorks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6825));

            migrationBuilder.UpdateData(
                table: "SubjectOfWorks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6827));

            migrationBuilder.UpdateData(
                table: "SubjectOfWorks",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6829));

            migrationBuilder.UpdateData(
                table: "SubjectOfWorks",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6831));

            migrationBuilder.UpdateData(
                table: "SubjectOfWorks",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6833));

            migrationBuilder.UpdateData(
                table: "SubjectOfWorks",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6834));

            migrationBuilder.UpdateData(
                table: "SubjectOfWorks",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6836));

            migrationBuilder.UpdateData(
                table: "SubjectOfWorks",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6838));

            migrationBuilder.UpdateData(
                table: "SubjectOfWorks",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "SubjectOfWorks",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6842));

            migrationBuilder.UpdateData(
                table: "SubjectOfWorks",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6843));

            migrationBuilder.UpdateData(
                table: "SubjectOfWorks",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6845));

            migrationBuilder.UpdateData(
                table: "SubjectOfWorks",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6847));

            migrationBuilder.UpdateData(
                table: "SubjectOfWorks",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6848));

            migrationBuilder.UpdateData(
                table: "SubjectOfWorks",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "SubjectOfWorks",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6853));

            migrationBuilder.UpdateData(
                table: "SubjectOfWorks",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "SubjectOfWorks",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6566));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 3, 23, 16, 43, 824, DateTimeKind.Local).AddTicks(6568));

            migrationBuilder.CreateIndex(
                name: "IX_SubjectRisks_RiskId",
                table: "SubjectRisks",
                column: "RiskId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectRisks_SubjectId",
                table: "SubjectRisks",
                column: "SubjectId");
        }
    }
}
