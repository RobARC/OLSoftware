using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OlSoft.Migrations
{
    public partial class AddEmailToUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c6c90410-6b55-4bfe-bd04-2aac2609e2a8", "44a87a52-126a-4313-9f73-4efcf59b1e7d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c70ebbc3-4f5a-44be-a8eb-9aebf10630e3", "a77685bf-40bb-4902-aee8-8a00815e2183" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c6c90410-6b55-4bfe-bd04-2aac2609e2a8", "c4aabea7-02ef-4603-b65f-501df8f21ec0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c70ebbc3-4f5a-44be-a8eb-9aebf10630e3", "d7a96ab2-ecbe-40cc-a97a-8a3670df3d88" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c6c90410-6b55-4bfe-bd04-2aac2609e2a8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c70ebbc3-4f5a-44be-a8eb-9aebf10630e3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44a87a52-126a-4313-9f73-4efcf59b1e7d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a77685bf-40bb-4902-aee8-8a00815e2183");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c4aabea7-02ef-4603-b65f-501df8f21ec0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d7a96ab2-ecbe-40cc-a97a-8a3670df3d88");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2008ab23-6edd-4131-a372-3c3b0ca756ff", "8a0d40f8-b93e-4e0a-b0ba-d269d4914b85", "IdentityRole", "Administrador", "ADMINISTRADOR" },
                    { "6285164c-c760-4163-b00f-a4e6607de5de", "153bafa1-a5af-4913-a38e-273ed8c45505", "IdentityRole", "Publico", "PUBLICO" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5e196790-066d-4eef-a61d-7ea0addf39e7", 0, "3461b9b0-2449-4001-bf4b-af5af90625c2", "roberth@gmail.com", false, false, null, "ROBERTH@GMAIL.COM", "ROBERTH", "AQAAAAEAACcQAAAAEES4fsIkFsKvIRydHvS9sRrPCuj8+KwLokaPiLyMNqd6P8V13344QZ/jVYU96trQpA==", null, false, "9ecd41f2-7983-4a16-b913-2c04b5677389", false, "roberth" },
                    { "6f3d29a5-2625-4451-92a2-6381cfc032f3", 0, "84aecb22-3f35-4ccf-8987-fddbd17d619b", "sofia@yahho.com", false, false, null, "SOFIA@YAHOO.COM", "SOFIA", "AQAAAAEAACcQAAAAEKJna6EvZ/SiEaGiVS7tiTl6yuxY5QebSMvCogcNRN8m5bHzwVq5dtd6hdVswuC/nw==", null, false, "2d729b75-0c10-46aa-aaef-d721dcec92d0", false, "sofia" },
                    { "ad648959-b9d1-46d1-8713-5caa972495fa", 0, "1c97de34-56d6-4df2-a8fb-b7e08dc10de9", "karina@gmail.com", false, false, null, "KARINA@GMAIL.COM", "KARINA", "AQAAAAEAACcQAAAAED4H0nYoyAnWxzbZe/UZE7GC4dPRDpu0XK5RjK399wvLvNX5pev9C4/2SSS1MeHpKA==", null, false, "76158df6-be8f-4a20-9204-6a9fccccb50c", false, "karina" },
                    { "e39e8467-6042-4fe8-aaea-fe0e5bf5d648", 0, "b5669c5d-0316-4a59-87e1-5cab6b5fc053", "johnny@gmail.com", false, false, null, "JOHNNY@GMAIL.COM", "JOHNNY", "AQAAAAEAACcQAAAAEEvsO39NhOoNYqhUKLiZ0BeBDKch2vSeUonArk08tYA31jtEgdmUsx5WBS+7OCVsqg==", null, false, "f054f2a2-5b4c-43c5-bf61-f06493048c91", false, "johnny" }
                });

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8044));

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8046));

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8048));

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8061));

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8062));

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8064));

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8065));

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 10,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "EstadoPruebas",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8348));

            migrationBuilder.UpdateData(
                table: "EstadoPruebas",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "EstadoPruebas",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "EstadoPruebas",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "NivelPruebas",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "NivelPruebas",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8207));

            migrationBuilder.UpdateData(
                table: "NivelPruebas",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8514));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8517));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8518));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8558));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 11,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8561));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 13,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8563));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 15,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 17,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8566));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 19,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 21,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 23,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 25,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8573));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 27,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 29,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 31,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 33,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8581));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 35,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8584));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 37,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8585));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 39,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8587));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 41,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 43,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 45,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 47,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 49,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 51,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 53,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 55,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 57,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8602));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 59,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 61,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 63,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 65,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 67,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 69,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 71,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 73,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8616));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 75,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 77,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8619));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 79,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8621));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 81,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8622));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 83,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8624));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 85,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 87,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8628));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 89,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8672));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 91,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8675));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 93,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8676));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 95,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 97,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8679));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 99,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8681));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 101,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 103,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 105,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 107,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 109,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 111,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 113,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 115,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8695));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 117,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 119,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8698));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 121,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 123,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 125,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8703));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 127,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8704));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 129,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 131,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 133,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 135,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8712));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 137,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 139,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8715));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 141,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8717));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 143,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 145,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8721));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 147,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8722));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 149,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8724));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 151,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8726));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 153,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8727));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 155,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8729));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 157,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8731));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 159,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 161,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8734));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 163,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 165,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8737));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 167,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 169,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8741));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 171,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 173,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8782));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 175,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 177,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8785));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 179,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 181,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8788));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 183,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 185,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 187,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 189,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 191,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 193,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 195,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 197,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 199,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8804));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 201,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8805));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 203,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 205,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 207,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 209,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 211,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 213,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 215,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 217,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8818));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 219,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 221,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 223,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 225,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 227,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 229,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 231,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 233,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 235,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 237,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8835));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 239,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8836));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 241,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8838));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 243,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 245,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 247,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8843));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 249,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8845));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 251,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8846));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 253,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8848));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 255,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 257,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8851));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 259,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8897));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 261,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8899));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 263,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 265,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8902));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 267,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8904));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 269,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8905));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 271,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8907));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 273,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8909));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 275,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 277,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8912));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 279,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8913));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 281,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 283,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8917));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 285,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8919));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 287,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 289,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8922));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 291,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8924));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 293,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 295,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8927));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 297,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8929));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 299,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 301,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8932));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 303,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8933));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 305,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8935));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 307,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8937));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 309,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 311,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 313,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8942));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 315,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8944));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 317,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8945));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 319,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8947));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 321,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 323,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 325,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 327,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8953));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 329,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 331,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 333,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8987));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 335,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8989));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 337,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8991));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 339,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8993));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 341,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8994));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 343,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8996));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 345,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8997));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 347,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8999));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 349,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(9001));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 351,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(9002));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 353,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 355,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(9006));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 357,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(9007));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 359,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(9009));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 361,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(9011));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 363,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(9012));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 365,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 367,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 369,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 371,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 373,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 375,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(9022));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 377,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 379,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 381,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 383,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(9029));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 385,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 387,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 389,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(9034));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 391,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(9035));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 393,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(9037));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 395,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(9039));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 397,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 399,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(9042));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 401,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(9044));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 403,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(9045));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 405,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(9047));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 407,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 409,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 411,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(9052));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 413,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 415,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(9055));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 417,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(9057));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 419,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(9058));

            migrationBuilder.UpdateData(
                table: "PruebaSeleccions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaActualizacion", "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8381), new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8377), new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8377) });

            migrationBuilder.UpdateData(
                table: "PruebaSeleccions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaActualizacion", "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8390), new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8385), new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8384) });

            migrationBuilder.UpdateData(
                table: "PruebaSeleccions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FechaActualizacion", "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8394), new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8392), new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8391) });

            migrationBuilder.UpdateData(
                table: "PruebaSeleccions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FechaActualizacion", "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8397), new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8396), new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8395) });

            migrationBuilder.UpdateData(
                table: "PruebaSeleccions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FechaActualizacion", "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8401), new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8399), new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8399) });

            migrationBuilder.UpdateData(
                table: "PruebaSeleccions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FechaActualizacion", "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8406), new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8405), new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8404) });

            migrationBuilder.UpdateData(
                table: "PruebaSeleccions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FechaActualizacion", "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8410), new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8408), new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8408) });

            migrationBuilder.UpdateData(
                table: "PruebaSeleccions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "FechaActualizacion", "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8414), new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8412), new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8412) });

            migrationBuilder.UpdateData(
                table: "PruebaSeleccions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "FechaActualizacion", "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8418), new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8416), new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8415) });

            migrationBuilder.UpdateData(
                table: "PruebaSeleccions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "FechaActualizacion", "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8423), new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8421), new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8420) });

            migrationBuilder.UpdateData(
                table: "PruebaSeleccions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "FechaActualizacion", "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8426), new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8425), new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8424) });

            migrationBuilder.UpdateData(
                table: "PruebaSeleccions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "FechaActualizacion", "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8430), new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8428), new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8428) });

            migrationBuilder.UpdateData(
                table: "PruebaSeleccions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "FechaActualizacion", "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8434), new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8432), new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8432) });

            migrationBuilder.UpdateData(
                table: "PruebaSeleccions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "FechaActualizacion", "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8439), new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8436), new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8435) });

            migrationBuilder.UpdateData(
                table: "PruebaSeleccions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "FechaActualizacion", "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8442), new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8441), new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8440) });

            migrationBuilder.UpdateData(
                table: "TipoPruebas",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "TipoPruebas",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 16, 21, 32, 525, DateTimeKind.Local).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "Email",
                value: "roberth@gmail.com");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2008ab23-6edd-4131-a372-3c3b0ca756ff", "5e196790-066d-4eef-a61d-7ea0addf39e7" },
                    { "6285164c-c760-4163-b00f-a4e6607de5de", "6f3d29a5-2625-4451-92a2-6381cfc032f3" },
                    { "2008ab23-6edd-4131-a372-3c3b0ca756ff", "ad648959-b9d1-46d1-8713-5caa972495fa" },
                    { "6285164c-c760-4163-b00f-a4e6607de5de", "e39e8467-6042-4fe8-aaea-fe0e5bf5d648" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2008ab23-6edd-4131-a372-3c3b0ca756ff", "5e196790-066d-4eef-a61d-7ea0addf39e7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6285164c-c760-4163-b00f-a4e6607de5de", "6f3d29a5-2625-4451-92a2-6381cfc032f3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2008ab23-6edd-4131-a372-3c3b0ca756ff", "ad648959-b9d1-46d1-8713-5caa972495fa" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6285164c-c760-4163-b00f-a4e6607de5de", "e39e8467-6042-4fe8-aaea-fe0e5bf5d648" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2008ab23-6edd-4131-a372-3c3b0ca756ff");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6285164c-c760-4163-b00f-a4e6607de5de");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e196790-066d-4eef-a61d-7ea0addf39e7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f3d29a5-2625-4451-92a2-6381cfc032f3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad648959-b9d1-46d1-8713-5caa972495fa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e39e8467-6042-4fe8-aaea-fe0e5bf5d648");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Usuarios");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c6c90410-6b55-4bfe-bd04-2aac2609e2a8", "d2818f1e-708a-4224-959e-3f6c9c8ae14b", "IdentityRole", "Administrador", "ADMINISTRADOR" },
                    { "c70ebbc3-4f5a-44be-a8eb-9aebf10630e3", "78950089-fd04-406e-8acc-01ad09457c1e", "IdentityRole", "Publico", "PUBLICO" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "44a87a52-126a-4313-9f73-4efcf59b1e7d", 0, "fe321f82-6c54-4831-aec6-276fad55f7af", "karina@gmail.com", false, false, null, "KARINA@GMAIL.COM", "KARINA", "AQAAAAEAACcQAAAAEJKK25WUd53jaiO7U5hwtgPHLVVkV9eaALS6Nqw1hzRLWBRMFCRzKBgayZFzimRS3w==", null, false, "2c7631f1-f621-4ddb-9ff6-407021341d11", false, "karina" },
                    { "a77685bf-40bb-4902-aee8-8a00815e2183", 0, "c5ee05ce-c9a3-4aac-86c5-96e6d2549f21", "sofia@yahho.com", false, false, null, "SOFIA@YAHOO.COM", "SOFIA", "AQAAAAEAACcQAAAAEITzIdb3YEs4PhuQo/0k1Of6RTwIQ/MhQh8+WZmN8YJNz8vAUxpquxrVC4e+BklkhA==", null, false, "b74d374e-0099-4f24-bb10-7db64cc69d13", false, "sofia" },
                    { "c4aabea7-02ef-4603-b65f-501df8f21ec0", 0, "0ed2a232-e9e1-4aec-acb5-76e776c6e5ba", "roberth@gmail.com", false, false, null, "ROBERTH@GMAIL.COM", "ROBERTH", "AQAAAAEAACcQAAAAEI7BKy+eiGrdstruae8DG1Z7BCfPkNLnR2XiLaResQJ70CtSd8G5PjzxfiwyUNhswQ==", null, false, "4f8e519d-20f3-4609-9fcf-78083bc4cd1f", false, "roberth" },
                    { "d7a96ab2-ecbe-40cc-a97a-8a3670df3d88", 0, "0d5cab45-4c3a-4ee9-a0dc-6a411b424f09", "johnny@gmail.com", false, false, null, "JOHNNY@GMAIL.COM", "JOHNNY", "AQAAAAEAACcQAAAAEBSq9NMr8sdO1ChIzGNvNen7HpT36xMyHLHtJrTOdy+CC6Znn6gSNzBtpNH2t5LNVg==", null, false, "359e31ac-e8a0-43c4-b296-36584262642a", false, "johnny" }
                });

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5777));

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5792));

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5794));

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5795));

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5796));

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5802));

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5805));

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5806));

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 10,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5809));

            migrationBuilder.UpdateData(
                table: "EstadoPruebas",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5897));

            migrationBuilder.UpdateData(
                table: "EstadoPruebas",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5901));

            migrationBuilder.UpdateData(
                table: "EstadoPruebas",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5902));

            migrationBuilder.UpdateData(
                table: "EstadoPruebas",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5903));

            migrationBuilder.UpdateData(
                table: "NivelPruebas",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5842));

            migrationBuilder.UpdateData(
                table: "NivelPruebas",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5848));

            migrationBuilder.UpdateData(
                table: "NivelPruebas",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6044));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6045));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6046));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6048));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 11,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 13,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 15,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6052));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 17,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6054));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 19,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6056));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 21,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6057));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 23,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6058));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 25,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6059));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 27,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 29,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6062));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 31,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6063));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 33,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6065));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 35,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6067));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 37,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6068));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 39,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6069));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 41,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 43,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6072));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 45,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 47,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6074));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 49,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6075));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 51,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6076));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 53,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 55,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6090));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 57,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6092));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 59,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6093));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 61,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6094));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 63,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6095));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 65,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6097));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 67,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6099));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 69,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 71,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6101));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 73,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6102));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 75,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6103));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 77,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6105));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 79,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6106));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 81,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6107));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 83,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6108));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 85,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 87,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6111));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 89,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6112));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 91,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6113));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 93,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6114));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 95,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6116));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 97,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6117));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 99,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6118));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 101,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6119));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 103,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6121));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 105,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6122));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 107,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6123));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 109,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6124));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 111,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6126));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 113,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6127));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 115,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6128));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 117,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6129));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 119,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6131));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 121,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6132));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 123,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6133));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 125,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6134));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 127,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6136));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 129,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6137));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 131,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 133,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6145));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 135,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6146));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 137,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6147));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 139,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6149));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 141,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 143,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6151));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 145,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 147,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6154));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 149,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6155));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 151,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6156));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 153,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6157));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 155,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6158));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 157,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 159,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6161));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 161,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6162));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 163,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6163));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 165,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6165));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 167,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6166));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 169,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6167));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 171,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6168));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 173,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 175,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6171));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 177,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6172));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 179,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6173));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 181,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6175));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 183,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6176));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 185,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6177));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 187,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6178));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 189,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6179));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 191,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6181));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 193,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6182));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 195,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 197,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6185));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 199,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6186));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 201,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6187));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 203,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6188));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 205,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6189));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 207,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6191));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 209,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6192));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 211,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 213,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6194));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 215,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6195));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 217,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6197));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 219,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6198));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 221,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6204));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 223,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6205));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 225,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6207));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 227,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6208));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 229,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6209));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 231,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 233,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 235,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6213));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 237,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6214));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 239,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 241,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6217));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 243,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6218));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 245,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6219));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 247,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6220));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 249,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6221));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 251,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6223));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 253,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6224));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 255,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6225));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 257,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6226));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 259,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6229));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 261,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 263,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6231));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 265,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6233));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 267,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6234));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 269,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6235));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 271,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6236));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 273,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6237));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 275,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6239));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 277,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 279,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6241));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 281,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6243));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 283,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6244));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 285,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6245));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 287,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6246));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 289,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 291,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6263));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 293,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6264));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 295,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6265));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 297,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 299,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6267));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 301,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6269));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 303,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 305,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6271));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 307,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 309,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6274));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 311,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6275));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 313,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6276));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 315,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6277));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 317,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6279));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 319,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 321,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 323,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6282));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 325,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6284));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 327,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6285));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 329,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6286));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 331,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6287));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 333,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6288));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 335,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 337,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6291));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 339,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6292));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 341,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6294));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 343,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6295));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 345,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6296));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 347,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6297));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 349,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6298));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 351,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 353,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6301));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 355,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6302));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 357,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6303));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 359,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 361,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6306));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 363,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6307));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 365,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6308));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 367,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6310));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 369,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 371,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6312));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 373,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6313));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 375,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6314));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 377,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6316));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 379,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 381,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6318));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 383,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6329));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 385,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6330));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 387,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6331));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 389,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6333));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 391,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6334));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 393,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6335));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 395,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6337));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 397,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6338));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 399,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6339));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 401,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6340));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 403,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6342));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 405,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6343));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 407,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6344));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 409,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6345));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 411,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 413,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6348));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 415,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6349));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 417,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 419,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6351));

            migrationBuilder.UpdateData(
                table: "PruebaSeleccions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaActualizacion", "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5925), new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5922), new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5922) });

            migrationBuilder.UpdateData(
                table: "PruebaSeleccions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaActualizacion", "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5934), new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5929), new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5928) });

            migrationBuilder.UpdateData(
                table: "PruebaSeleccions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FechaActualizacion", "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5939), new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5936), new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5936) });

            migrationBuilder.UpdateData(
                table: "PruebaSeleccions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FechaActualizacion", "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5942), new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5940), new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5940) });

            migrationBuilder.UpdateData(
                table: "PruebaSeleccions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FechaActualizacion", "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5945), new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5944), new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5943) });

            migrationBuilder.UpdateData(
                table: "PruebaSeleccions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FechaActualizacion", "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5950), new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5948), new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5947) });

            migrationBuilder.UpdateData(
                table: "PruebaSeleccions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FechaActualizacion", "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5959), new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5958), new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5957) });

            migrationBuilder.UpdateData(
                table: "PruebaSeleccions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "FechaActualizacion", "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5964), new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5961), new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5961) });

            migrationBuilder.UpdateData(
                table: "PruebaSeleccions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "FechaActualizacion", "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5968), new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5966), new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5965) });

            migrationBuilder.UpdateData(
                table: "PruebaSeleccions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "FechaActualizacion", "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5974), new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5973), new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5972) });

            migrationBuilder.UpdateData(
                table: "PruebaSeleccions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "FechaActualizacion", "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5978), new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5976), new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5976) });

            migrationBuilder.UpdateData(
                table: "PruebaSeleccions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "FechaActualizacion", "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5981), new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5979), new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5979) });

            migrationBuilder.UpdateData(
                table: "PruebaSeleccions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "FechaActualizacion", "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5984), new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5983), new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5982) });

            migrationBuilder.UpdateData(
                table: "PruebaSeleccions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "FechaActualizacion", "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5988), new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5986), new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5985) });

            migrationBuilder.UpdateData(
                table: "PruebaSeleccions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "FechaActualizacion", "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5991), new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5989), new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5989) });

            migrationBuilder.UpdateData(
                table: "TipoPruebas",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5870));

            migrationBuilder.UpdateData(
                table: "TipoPruebas",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(5873));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "c6c90410-6b55-4bfe-bd04-2aac2609e2a8", "44a87a52-126a-4313-9f73-4efcf59b1e7d" },
                    { "c70ebbc3-4f5a-44be-a8eb-9aebf10630e3", "a77685bf-40bb-4902-aee8-8a00815e2183" },
                    { "c6c90410-6b55-4bfe-bd04-2aac2609e2a8", "c4aabea7-02ef-4603-b65f-501df8f21ec0" },
                    { "c70ebbc3-4f5a-44be-a8eb-9aebf10630e3", "d7a96ab2-ecbe-40cc-a97a-8a3670df3d88" }
                });
        }
    }
}
