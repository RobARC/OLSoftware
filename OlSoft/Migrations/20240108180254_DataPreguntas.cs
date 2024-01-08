using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OlSoft.Migrations
{
    public partial class DataPreguntas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "820c1083-836a-4db6-ae0c-381b58c35170", "4ddb3e82-d252-429f-864d-5fb9324c27f5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f316e7b-57f8-40ad-a765-8fdc3c0d113a", "6c37d2ea-dadf-46f0-b96f-4e1dd20d3b73" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "820c1083-836a-4db6-ae0c-381b58c35170", "76588b1d-43a5-40bf-928b-9c68500b6de2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f316e7b-57f8-40ad-a765-8fdc3c0d113a", "fd3476df-ca02-45e8-82f2-995e78d81a94" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f316e7b-57f8-40ad-a765-8fdc3c0d113a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "820c1083-836a-4db6-ae0c-381b58c35170");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ddb3e82-d252-429f-864d-5fb9324c27f5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6c37d2ea-dadf-46f0-b96f-4e1dd20d3b73");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "76588b1d-43a5-40bf-928b-9c68500b6de2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd3476df-ca02-45e8-82f2-995e78d81a94");

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

            migrationBuilder.InsertData(
                table: "Preguntas",
                columns: new[] { "Id", "FechaActualizacion", "Pregunta1", "PruebaSeleccionId", "Respuesta", "UsuarioId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6040), "Test_SignUpPageValidation_DotNet", 1, "Respuesta Ejemplo2", 1 },
                    { 3, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6044), "Test_ArrayManipulation_JavaScript", 1, "Respuesta Ejemplo4", 1 },
                    { 5, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6045), "Test_AsyncFunction_JavaScript", 1, "Respuesta Ejemplo6", 1 },
                    { 7, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6046), "Test_DatabaseConnection_Python", 1, "Respuesta Ejemplo8", 1 },
                    { 9, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6048), "Test_DataAnalysisFunction_Python", 1, "Respuesta Ejemplo10", 1 },
                    { 11, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6050), "Test_FileCreation_BashScript", 1, "Respuesta Ejemplo12", 1 },
                    { 13, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6051), "Test_DirectoryNavigation_BashScript", 1, "Respuesta Ejemplo14", 1 },
                    { 15, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6052), "Test_FormSubmission_HTML", 1, "Respuesta Ejemplo16", 1 },
                    { 17, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6054), "Test_ResponsiveDesign_HTML", 1, "Respuesta Ejemplo18", 1 },
                    { 19, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6056), "Test_ExceptionHandling_DotNet", 1, "Respuesta Ejemplo20", 1 },
                    { 21, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6057), "Test_CallbackFunction_JavaScript", 1, "Respuesta Ejemplo22", 1 },
                    { 23, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6058), "Test_MachineLearningModel_Python", 1, "Respuesta Ejemplo24", 1 },
                    { 25, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6059), "Test_SystemUpdate_BashScript", 1, "Respuesta Ejemplo26", 1 },
                    { 27, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6060), "Test_LinkNavigation_HTML", 1, "Respuesta Ejemplo28", 1 },
                    { 29, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6062), "Test_SignUpPageValidation_DotNet", 2, "Respuesta Ejemplo30", 1 },
                    { 31, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6063), "Test_ArrayManipulation_JavaScript", 2, "Respuesta Ejemplo32", 1 },
                    { 33, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6065), "Test_AsyncFunction_JavaScript", 2, "Respuesta Ejemplo34", 1 },
                    { 35, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6067), "Test_DatabaseConnection_Python", 2, "Respuesta Ejemplo36", 1 },
                    { 37, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6068), "Test_DataAnalysisFunction_Python", 2, "Respuesta Ejemplo38", 1 }
                });

            migrationBuilder.InsertData(
                table: "Preguntas",
                columns: new[] { "Id", "FechaActualizacion", "Pregunta1", "PruebaSeleccionId", "Respuesta", "UsuarioId" },
                values: new object[,]
                {
                    { 39, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6069), "Test_FileCreation_BashScript", 2, "Respuesta Ejemplo40", 1 },
                    { 41, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6070), "Test_DirectoryNavigation_BashScript", 2, "Respuesta Ejemplo42", 1 },
                    { 43, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6072), "Test_FormSubmission_HTML", 2, "Respuesta Ejemplo44", 1 },
                    { 45, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6073), "Test_ResponsiveDesign_HTML", 2, "Respuesta Ejemplo46", 1 },
                    { 47, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6074), "Test_ExceptionHandling_DotNet", 2, "Respuesta Ejemplo48", 1 },
                    { 49, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6075), "Test_CallbackFunction_JavaScript", 2, "Respuesta Ejemplo50", 1 },
                    { 51, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6076), "Test_MachineLearningModel_Python", 2, "Respuesta Ejemplo52", 1 },
                    { 53, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6089), "Test_SystemUpdate_BashScript", 2, "Respuesta Ejemplo54", 1 },
                    { 55, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6090), "Test_LinkNavigation_HTML", 2, "Respuesta Ejemplo56", 1 },
                    { 57, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6092), "Test_SignUpPageValidation_DotNet", 3, "Respuesta Ejemplo58", 1 },
                    { 59, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6093), "Test_ArrayManipulation_JavaScript", 3, "Respuesta Ejemplo60", 1 },
                    { 61, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6094), "Test_AsyncFunction_JavaScript", 3, "Respuesta Ejemplo62", 1 },
                    { 63, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6095), "Test_DatabaseConnection_Python", 3, "Respuesta Ejemplo64", 1 },
                    { 65, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6097), "Test_DataAnalysisFunction_Python", 3, "Respuesta Ejemplo66", 1 },
                    { 67, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6099), "Test_FileCreation_BashScript", 3, "Respuesta Ejemplo68", 1 },
                    { 69, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6100), "Test_DirectoryNavigation_BashScript", 3, "Respuesta Ejemplo70", 1 },
                    { 71, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6101), "Test_FormSubmission_HTML", 3, "Respuesta Ejemplo72", 1 },
                    { 73, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6102), "Test_ResponsiveDesign_HTML", 3, "Respuesta Ejemplo74", 1 },
                    { 75, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6103), "Test_ExceptionHandling_DotNet", 3, "Respuesta Ejemplo76", 1 },
                    { 77, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6105), "Test_CallbackFunction_JavaScript", 3, "Respuesta Ejemplo78", 1 },
                    { 79, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6106), "Test_MachineLearningModel_Python", 3, "Respuesta Ejemplo80", 1 },
                    { 81, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6107), "Test_SystemUpdate_BashScript", 3, "Respuesta Ejemplo82", 1 },
                    { 83, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6108), "Test_LinkNavigation_HTML", 3, "Respuesta Ejemplo84", 1 },
                    { 85, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6110), "Test_SignUpPageValidation_DotNet", 4, "Respuesta Ejemplo86", 1 },
                    { 87, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6111), "Test_ArrayManipulation_JavaScript", 4, "Respuesta Ejemplo88", 1 },
                    { 89, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6112), "Test_AsyncFunction_JavaScript", 4, "Respuesta Ejemplo90", 1 },
                    { 91, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6113), "Test_DatabaseConnection_Python", 4, "Respuesta Ejemplo92", 1 },
                    { 93, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6114), "Test_DataAnalysisFunction_Python", 4, "Respuesta Ejemplo94", 1 },
                    { 95, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6116), "Test_FileCreation_BashScript", 4, "Respuesta Ejemplo96", 1 },
                    { 97, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6117), "Test_DirectoryNavigation_BashScript", 4, "Respuesta Ejemplo98", 1 },
                    { 99, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6118), "Test_FormSubmission_HTML", 4, "Respuesta Ejemplo100", 1 },
                    { 101, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6119), "Test_ResponsiveDesign_HTML", 4, "Respuesta Ejemplo102", 1 },
                    { 103, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6121), "Test_ExceptionHandling_DotNet", 4, "Respuesta Ejemplo104", 1 },
                    { 105, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6122), "Test_CallbackFunction_JavaScript", 4, "Respuesta Ejemplo106", 1 },
                    { 107, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6123), "Test_MachineLearningModel_Python", 4, "Respuesta Ejemplo108", 1 },
                    { 109, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6124), "Test_SystemUpdate_BashScript", 4, "Respuesta Ejemplo110", 1 },
                    { 111, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6126), "Test_LinkNavigation_HTML", 4, "Respuesta Ejemplo112", 1 },
                    { 113, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6127), "Test_SignUpPageValidation_DotNet", 5, "Respuesta Ejemplo114", 1 },
                    { 115, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6128), "Test_ArrayManipulation_JavaScript", 5, "Respuesta Ejemplo116", 1 },
                    { 117, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6129), "Test_AsyncFunction_JavaScript", 5, "Respuesta Ejemplo118", 1 },
                    { 119, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6131), "Test_DatabaseConnection_Python", 5, "Respuesta Ejemplo120", 1 },
                    { 121, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6132), "Test_DataAnalysisFunction_Python", 5, "Respuesta Ejemplo122", 1 }
                });

            migrationBuilder.InsertData(
                table: "Preguntas",
                columns: new[] { "Id", "FechaActualizacion", "Pregunta1", "PruebaSeleccionId", "Respuesta", "UsuarioId" },
                values: new object[,]
                {
                    { 123, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6133), "Test_FileCreation_BashScript", 5, "Respuesta Ejemplo124", 1 },
                    { 125, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6134), "Test_DirectoryNavigation_BashScript", 5, "Respuesta Ejemplo126", 1 },
                    { 127, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6136), "Test_FormSubmission_HTML", 5, "Respuesta Ejemplo128", 1 },
                    { 129, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6137), "Test_ResponsiveDesign_HTML", 5, "Respuesta Ejemplo130", 1 },
                    { 131, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6144), "Test_ExceptionHandling_DotNet", 5, "Respuesta Ejemplo132", 1 },
                    { 133, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6145), "Test_CallbackFunction_JavaScript", 5, "Respuesta Ejemplo134", 1 },
                    { 135, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6146), "Test_MachineLearningModel_Python", 5, "Respuesta Ejemplo136", 1 },
                    { 137, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6147), "Test_SystemUpdate_BashScript", 5, "Respuesta Ejemplo138", 1 },
                    { 139, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6149), "Test_LinkNavigation_HTML", 5, "Respuesta Ejemplo140", 1 },
                    { 141, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6150), "Test_SignUpPageValidation_DotNet", 6, "Respuesta Ejemplo142", 1 },
                    { 143, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6151), "Test_ArrayManipulation_JavaScript", 6, "Respuesta Ejemplo144", 1 },
                    { 145, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6152), "Test_AsyncFunction_JavaScript", 6, "Respuesta Ejemplo146", 1 },
                    { 147, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6154), "Test_DatabaseConnection_Python", 6, "Respuesta Ejemplo148", 1 },
                    { 149, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6155), "Test_DataAnalysisFunction_Python", 6, "Respuesta Ejemplo150", 1 },
                    { 151, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6156), "Test_FileCreation_BashScript", 6, "Respuesta Ejemplo152", 1 },
                    { 153, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6157), "Test_DirectoryNavigation_BashScript", 6, "Respuesta Ejemplo154", 1 },
                    { 155, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6158), "Test_FormSubmission_HTML", 6, "Respuesta Ejemplo156", 1 },
                    { 157, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6160), "Test_ResponsiveDesign_HTML", 6, "Respuesta Ejemplo158", 1 },
                    { 159, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6161), "Test_ExceptionHandling_DotNet", 6, "Respuesta Ejemplo160", 1 },
                    { 161, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6162), "Test_CallbackFunction_JavaScript", 6, "Respuesta Ejemplo162", 1 },
                    { 163, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6163), "Test_MachineLearningModel_Python", 6, "Respuesta Ejemplo164", 1 },
                    { 165, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6165), "Test_SystemUpdate_BashScript", 6, "Respuesta Ejemplo166", 1 },
                    { 167, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6166), "Test_LinkNavigation_HTML", 6, "Respuesta Ejemplo168", 1 },
                    { 169, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6167), "Test_SignUpPageValidation_DotNet", 7, "Respuesta Ejemplo170", 1 },
                    { 171, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6168), "Test_ArrayManipulation_JavaScript", 7, "Respuesta Ejemplo172", 1 },
                    { 173, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6170), "Test_AsyncFunction_JavaScript", 7, "Respuesta Ejemplo174", 1 },
                    { 175, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6171), "Test_DatabaseConnection_Python", 7, "Respuesta Ejemplo176", 1 },
                    { 177, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6172), "Test_DataAnalysisFunction_Python", 7, "Respuesta Ejemplo178", 1 },
                    { 179, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6173), "Test_FileCreation_BashScript", 7, "Respuesta Ejemplo180", 1 },
                    { 181, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6175), "Test_DirectoryNavigation_BashScript", 7, "Respuesta Ejemplo182", 1 },
                    { 183, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6176), "Test_FormSubmission_HTML", 7, "Respuesta Ejemplo184", 1 },
                    { 185, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6177), "Test_ResponsiveDesign_HTML", 7, "Respuesta Ejemplo186", 1 },
                    { 187, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6178), "Test_ExceptionHandling_DotNet", 7, "Respuesta Ejemplo188", 1 },
                    { 189, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6179), "Test_CallbackFunction_JavaScript", 7, "Respuesta Ejemplo190", 1 },
                    { 191, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6181), "Test_MachineLearningModel_Python", 7, "Respuesta Ejemplo192", 1 },
                    { 193, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6182), "Test_SystemUpdate_BashScript", 7, "Respuesta Ejemplo194", 1 },
                    { 195, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6183), "Test_LinkNavigation_HTML", 7, "Respuesta Ejemplo196", 1 },
                    { 197, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6185), "Test_SignUpPageValidation_DotNet", 8, "Respuesta Ejemplo198", 1 },
                    { 199, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6186), "Test_ArrayManipulation_JavaScript", 8, "Respuesta Ejemplo200", 1 },
                    { 201, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6187), "Test_AsyncFunction_JavaScript", 8, "Respuesta Ejemplo202", 1 },
                    { 203, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6188), "Test_DatabaseConnection_Python", 8, "Respuesta Ejemplo204", 1 },
                    { 205, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6189), "Test_DataAnalysisFunction_Python", 8, "Respuesta Ejemplo206", 1 }
                });

            migrationBuilder.InsertData(
                table: "Preguntas",
                columns: new[] { "Id", "FechaActualizacion", "Pregunta1", "PruebaSeleccionId", "Respuesta", "UsuarioId" },
                values: new object[,]
                {
                    { 207, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6191), "Test_FileCreation_BashScript", 8, "Respuesta Ejemplo208", 1 },
                    { 209, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6192), "Test_DirectoryNavigation_BashScript", 8, "Respuesta Ejemplo210", 1 },
                    { 211, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6193), "Test_FormSubmission_HTML", 8, "Respuesta Ejemplo212", 1 },
                    { 213, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6194), "Test_ResponsiveDesign_HTML", 8, "Respuesta Ejemplo214", 1 },
                    { 215, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6195), "Test_ExceptionHandling_DotNet", 8, "Respuesta Ejemplo216", 1 },
                    { 217, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6197), "Test_CallbackFunction_JavaScript", 8, "Respuesta Ejemplo218", 1 },
                    { 219, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6198), "Test_MachineLearningModel_Python", 8, "Respuesta Ejemplo220", 1 },
                    { 221, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6204), "Test_SystemUpdate_BashScript", 8, "Respuesta Ejemplo222", 1 },
                    { 223, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6205), "Test_LinkNavigation_HTML", 8, "Respuesta Ejemplo224", 1 },
                    { 225, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6207), "Test_SignUpPageValidation_DotNet", 9, "Respuesta Ejemplo226", 1 },
                    { 227, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6208), "Test_ArrayManipulation_JavaScript", 9, "Respuesta Ejemplo228", 1 },
                    { 229, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6209), "Test_AsyncFunction_JavaScript", 9, "Respuesta Ejemplo230", 1 },
                    { 231, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6210), "Test_DatabaseConnection_Python", 9, "Respuesta Ejemplo232", 1 },
                    { 233, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6212), "Test_DataAnalysisFunction_Python", 9, "Respuesta Ejemplo234", 1 },
                    { 235, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6213), "Test_FileCreation_BashScript", 9, "Respuesta Ejemplo236", 1 },
                    { 237, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6214), "Test_DirectoryNavigation_BashScript", 9, "Respuesta Ejemplo238", 1 },
                    { 239, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6215), "Test_FormSubmission_HTML", 9, "Respuesta Ejemplo240", 1 },
                    { 241, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6217), "Test_ResponsiveDesign_HTML", 9, "Respuesta Ejemplo242", 1 },
                    { 243, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6218), "Test_ExceptionHandling_DotNet", 9, "Respuesta Ejemplo244", 1 },
                    { 245, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6219), "Test_CallbackFunction_JavaScript", 9, "Respuesta Ejemplo246", 1 },
                    { 247, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6220), "Test_MachineLearningModel_Python", 9, "Respuesta Ejemplo248", 1 },
                    { 249, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6221), "Test_SystemUpdate_BashScript", 9, "Respuesta Ejemplo250", 1 },
                    { 251, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6223), "Test_LinkNavigation_HTML", 9, "Respuesta Ejemplo252", 1 },
                    { 253, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6224), "Test_SignUpPageValidation_DotNet", 10, "Respuesta Ejemplo254", 1 },
                    { 255, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6225), "Test_ArrayManipulation_JavaScript", 10, "Respuesta Ejemplo256", 1 },
                    { 257, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6226), "Test_AsyncFunction_JavaScript", 10, "Respuesta Ejemplo258", 1 },
                    { 259, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6229), "Test_DatabaseConnection_Python", 10, "Respuesta Ejemplo260", 1 },
                    { 261, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6230), "Test_DataAnalysisFunction_Python", 10, "Respuesta Ejemplo262", 1 },
                    { 263, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6231), "Test_FileCreation_BashScript", 10, "Respuesta Ejemplo264", 1 },
                    { 265, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6233), "Test_DirectoryNavigation_BashScript", 10, "Respuesta Ejemplo266", 1 },
                    { 267, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6234), "Test_FormSubmission_HTML", 10, "Respuesta Ejemplo268", 1 },
                    { 269, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6235), "Test_ResponsiveDesign_HTML", 10, "Respuesta Ejemplo270", 1 },
                    { 271, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6236), "Test_ExceptionHandling_DotNet", 10, "Respuesta Ejemplo272", 1 },
                    { 273, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6237), "Test_CallbackFunction_JavaScript", 10, "Respuesta Ejemplo274", 1 },
                    { 275, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6239), "Test_MachineLearningModel_Python", 10, "Respuesta Ejemplo276", 1 },
                    { 277, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6240), "Test_SystemUpdate_BashScript", 10, "Respuesta Ejemplo278", 1 },
                    { 279, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6241), "Test_LinkNavigation_HTML", 10, "Respuesta Ejemplo280", 1 },
                    { 281, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6243), "Test_SignUpPageValidation_DotNet", 11, "Respuesta Ejemplo282", 1 },
                    { 283, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6244), "Test_ArrayManipulation_JavaScript", 11, "Respuesta Ejemplo284", 1 },
                    { 285, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6245), "Test_AsyncFunction_JavaScript", 11, "Respuesta Ejemplo286", 1 },
                    { 287, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6246), "Test_DatabaseConnection_Python", 11, "Respuesta Ejemplo288", 1 },
                    { 289, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6261), "Test_DataAnalysisFunction_Python", 11, "Respuesta Ejemplo290", 1 }
                });

            migrationBuilder.InsertData(
                table: "Preguntas",
                columns: new[] { "Id", "FechaActualizacion", "Pregunta1", "PruebaSeleccionId", "Respuesta", "UsuarioId" },
                values: new object[,]
                {
                    { 291, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6263), "Test_FileCreation_BashScript", 11, "Respuesta Ejemplo292", 1 },
                    { 293, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6264), "Test_DirectoryNavigation_BashScript", 11, "Respuesta Ejemplo294", 1 },
                    { 295, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6265), "Test_FormSubmission_HTML", 11, "Respuesta Ejemplo296", 1 },
                    { 297, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6266), "Test_ResponsiveDesign_HTML", 11, "Respuesta Ejemplo298", 1 },
                    { 299, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6267), "Test_ExceptionHandling_DotNet", 11, "Respuesta Ejemplo300", 1 },
                    { 301, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6269), "Test_CallbackFunction_JavaScript", 11, "Respuesta Ejemplo302", 1 },
                    { 303, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6270), "Test_MachineLearningModel_Python", 11, "Respuesta Ejemplo304", 1 },
                    { 305, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6271), "Test_SystemUpdate_BashScript", 11, "Respuesta Ejemplo306", 1 },
                    { 307, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6272), "Test_LinkNavigation_HTML", 11, "Respuesta Ejemplo308", 1 },
                    { 309, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6274), "Test_SignUpPageValidation_DotNet", 12, "Respuesta Ejemplo310", 1 },
                    { 311, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6275), "Test_ArrayManipulation_JavaScript", 12, "Respuesta Ejemplo312", 1 },
                    { 313, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6276), "Test_AsyncFunction_JavaScript", 12, "Respuesta Ejemplo314", 1 },
                    { 315, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6277), "Test_DatabaseConnection_Python", 12, "Respuesta Ejemplo316", 1 },
                    { 317, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6279), "Test_DataAnalysisFunction_Python", 12, "Respuesta Ejemplo318", 1 },
                    { 319, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6280), "Test_FileCreation_BashScript", 12, "Respuesta Ejemplo320", 1 },
                    { 321, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6281), "Test_DirectoryNavigation_BashScript", 12, "Respuesta Ejemplo322", 1 },
                    { 323, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6282), "Test_FormSubmission_HTML", 12, "Respuesta Ejemplo324", 1 },
                    { 325, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6284), "Test_ResponsiveDesign_HTML", 12, "Respuesta Ejemplo326", 1 },
                    { 327, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6285), "Test_ExceptionHandling_DotNet", 12, "Respuesta Ejemplo328", 1 },
                    { 329, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6286), "Test_CallbackFunction_JavaScript", 12, "Respuesta Ejemplo330", 1 },
                    { 331, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6287), "Test_MachineLearningModel_Python", 12, "Respuesta Ejemplo332", 1 },
                    { 333, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6288), "Test_SystemUpdate_BashScript", 12, "Respuesta Ejemplo334", 1 },
                    { 335, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6290), "Test_LinkNavigation_HTML", 12, "Respuesta Ejemplo336", 1 },
                    { 337, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6291), "Test_SignUpPageValidation_DotNet", 13, "Respuesta Ejemplo338", 1 },
                    { 339, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6292), "Test_ArrayManipulation_JavaScript", 13, "Respuesta Ejemplo340", 1 },
                    { 341, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6294), "Test_AsyncFunction_JavaScript", 13, "Respuesta Ejemplo342", 1 },
                    { 343, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6295), "Test_DatabaseConnection_Python", 13, "Respuesta Ejemplo344", 1 },
                    { 345, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6296), "Test_DataAnalysisFunction_Python", 13, "Respuesta Ejemplo346", 1 },
                    { 347, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6297), "Test_FileCreation_BashScript", 13, "Respuesta Ejemplo348", 1 },
                    { 349, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6298), "Test_DirectoryNavigation_BashScript", 13, "Respuesta Ejemplo350", 1 },
                    { 351, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6300), "Test_FormSubmission_HTML", 13, "Respuesta Ejemplo352", 1 },
                    { 353, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6301), "Test_ResponsiveDesign_HTML", 13, "Respuesta Ejemplo354", 1 },
                    { 355, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6302), "Test_ExceptionHandling_DotNet", 13, "Respuesta Ejemplo356", 1 },
                    { 357, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6303), "Test_CallbackFunction_JavaScript", 13, "Respuesta Ejemplo358", 1 },
                    { 359, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6304), "Test_MachineLearningModel_Python", 13, "Respuesta Ejemplo360", 1 },
                    { 361, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6306), "Test_SystemUpdate_BashScript", 13, "Respuesta Ejemplo362", 1 },
                    { 363, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6307), "Test_LinkNavigation_HTML", 13, "Respuesta Ejemplo364", 1 },
                    { 365, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6308), "Test_SignUpPageValidation_DotNet", 14, "Respuesta Ejemplo366", 1 },
                    { 367, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6310), "Test_ArrayManipulation_JavaScript", 14, "Respuesta Ejemplo368", 1 },
                    { 369, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6311), "Test_AsyncFunction_JavaScript", 14, "Respuesta Ejemplo370", 1 },
                    { 371, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6312), "Test_DatabaseConnection_Python", 14, "Respuesta Ejemplo372", 1 },
                    { 373, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6313), "Test_DataAnalysisFunction_Python", 14, "Respuesta Ejemplo374", 1 }
                });

            migrationBuilder.InsertData(
                table: "Preguntas",
                columns: new[] { "Id", "FechaActualizacion", "Pregunta1", "PruebaSeleccionId", "Respuesta", "UsuarioId" },
                values: new object[,]
                {
                    { 375, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6314), "Test_FileCreation_BashScript", 14, "Respuesta Ejemplo376", 1 },
                    { 377, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6316), "Test_DirectoryNavigation_BashScript", 14, "Respuesta Ejemplo378", 1 },
                    { 379, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6317), "Test_FormSubmission_HTML", 14, "Respuesta Ejemplo380", 1 },
                    { 381, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6318), "Test_ResponsiveDesign_HTML", 14, "Respuesta Ejemplo382", 1 },
                    { 383, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6329), "Test_ExceptionHandling_DotNet", 14, "Respuesta Ejemplo384", 1 },
                    { 385, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6330), "Test_CallbackFunction_JavaScript", 14, "Respuesta Ejemplo386", 1 },
                    { 387, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6331), "Test_MachineLearningModel_Python", 14, "Respuesta Ejemplo388", 1 },
                    { 389, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6333), "Test_SystemUpdate_BashScript", 14, "Respuesta Ejemplo390", 1 },
                    { 391, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6334), "Test_LinkNavigation_HTML", 14, "Respuesta Ejemplo392", 1 },
                    { 393, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6335), "Test_SignUpPageValidation_DotNet", 15, "Respuesta Ejemplo394", 1 },
                    { 395, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6337), "Test_ArrayManipulation_JavaScript", 15, "Respuesta Ejemplo396", 1 },
                    { 397, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6338), "Test_AsyncFunction_JavaScript", 15, "Respuesta Ejemplo398", 1 },
                    { 399, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6339), "Test_DatabaseConnection_Python", 15, "Respuesta Ejemplo400", 1 },
                    { 401, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6340), "Test_DataAnalysisFunction_Python", 15, "Respuesta Ejemplo402", 1 },
                    { 403, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6342), "Test_FileCreation_BashScript", 15, "Respuesta Ejemplo404", 1 },
                    { 405, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6343), "Test_DirectoryNavigation_BashScript", 15, "Respuesta Ejemplo406", 1 },
                    { 407, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6344), "Test_FormSubmission_HTML", 15, "Respuesta Ejemplo408", 1 },
                    { 409, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6345), "Test_ResponsiveDesign_HTML", 15, "Respuesta Ejemplo410", 1 },
                    { 411, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6346), "Test_ExceptionHandling_DotNet", 15, "Respuesta Ejemplo412", 1 },
                    { 413, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6348), "Test_CallbackFunction_JavaScript", 15, "Respuesta Ejemplo414", 1 },
                    { 415, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6349), "Test_MachineLearningModel_Python", 15, "Respuesta Ejemplo416", 1 },
                    { 417, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6350), "Test_SystemUpdate_BashScript", 15, "Respuesta Ejemplo418", 1 },
                    { 419, new DateTime(2024, 1, 8, 13, 2, 52, 798, DateTimeKind.Local).AddTicks(6351), "Test_LinkNavigation_HTML", 15, "Respuesta Ejemplo420", 1 }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 419);

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2f316e7b-57f8-40ad-a765-8fdc3c0d113a", "3cd9b9d6-68f8-447c-bbb6-f36fa04388d0", "IdentityRole", "Publico", "PUBLICO" },
                    { "820c1083-836a-4db6-ae0c-381b58c35170", "7c741c89-1a9f-4d6b-9af1-060fa949c600", "IdentityRole", "Administrador", "ADMINISTRADOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4ddb3e82-d252-429f-864d-5fb9324c27f5", 0, "cf27cd48-1044-4cc1-876c-7afc1014fa51", "roberth@gmail.com", false, false, null, "ROBERTH@GMAIL.COM", "ROBERTH", "AQAAAAEAACcQAAAAEHXvdo62bORn13YQVSXwj64f9SaPcnl3rkcgLzQ7Y1o8sidaHZQEocr9IogLX5p8rg==", null, false, "e995d423-cd2a-4741-a554-7f6958438b5e", false, "roberth" },
                    { "6c37d2ea-dadf-46f0-b96f-4e1dd20d3b73", 0, "0d06e304-bc1e-4aac-804a-51e2e32627f2", "johnny@gmail.com", false, false, null, "JOHNNY@GMAIL.COM", "JOHNNY", "AQAAAAEAACcQAAAAEEoOk/sQ+2gjD1jt0AGzHsB/suMf6Vdv4NQG3xAHKK22LxXTc2NIwuWFInFe8BF/2g==", null, false, "4f0e399d-88de-424f-b664-b3253464285a", false, "johnny" },
                    { "76588b1d-43a5-40bf-928b-9c68500b6de2", 0, "db15cc02-43e1-43cf-94ff-21bb65111948", "karina@gmail.com", false, false, null, "KARINA@GMAIL.COM", "KARINA", "AQAAAAEAACcQAAAAEAKQanj/FlKSB/MtUwME6MiI7GBGRet5dR30Yx37C/wHTckvpvDiCECeP5o7Fs8vcw==", null, false, "0d7a239a-7cb2-4429-a25a-2d05f0103a6f", false, "karina" },
                    { "fd3476df-ca02-45e8-82f2-995e78d81a94", 0, "a89dffd1-3a1b-42f2-8d11-6a101b70e199", "sofia@yahho.com", false, false, null, "SOFIA@YAHOO.COM", "SOFIA", "AQAAAAEAACcQAAAAEJAI5H7VgMny/7ttWlC1hlAgis0l7J71BFfWVQ6IwGESkd4kB0Ilvlosmr1+lOuGdA==", null, false, "3f208d58-92e4-4ec4-9c53-48290e2f0b18", false, "sofia" }
                });

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4207));

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4209));

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4212));

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4224));

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4225));

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4228));

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 10,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "EstadoPruebas",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4335));

            migrationBuilder.UpdateData(
                table: "EstadoPruebas",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4338));

            migrationBuilder.UpdateData(
                table: "EstadoPruebas",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4339));

            migrationBuilder.UpdateData(
                table: "EstadoPruebas",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "NivelPruebas",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4266));

            migrationBuilder.UpdateData(
                table: "NivelPruebas",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4271));

            migrationBuilder.UpdateData(
                table: "NivelPruebas",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4272));

            migrationBuilder.UpdateData(
                table: "PruebaSeleccions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaActualizacion", "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4367), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4364), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4364) });

            migrationBuilder.UpdateData(
                table: "PruebaSeleccions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaActualizacion", "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4377), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4371), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4370) });

            migrationBuilder.UpdateData(
                table: "PruebaSeleccions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FechaActualizacion", "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4380), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4379), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4378) });

            migrationBuilder.UpdateData(
                table: "PruebaSeleccions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FechaActualizacion", "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4383), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4382), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4381) });

            migrationBuilder.UpdateData(
                table: "PruebaSeleccions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FechaActualizacion", "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4473), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4471), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4470) });

            migrationBuilder.UpdateData(
                table: "PruebaSeleccions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FechaActualizacion", "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4477), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4476), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4475) });

            migrationBuilder.UpdateData(
                table: "PruebaSeleccions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FechaActualizacion", "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4481), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4479), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4479) });

            migrationBuilder.UpdateData(
                table: "PruebaSeleccions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "FechaActualizacion", "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4484), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4482), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4482) });

            migrationBuilder.UpdateData(
                table: "PruebaSeleccions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "FechaActualizacion", "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4487), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4486), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4485) });

            migrationBuilder.UpdateData(
                table: "PruebaSeleccions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "FechaActualizacion", "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4491), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4490), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4489) });

            migrationBuilder.UpdateData(
                table: "PruebaSeleccions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "FechaActualizacion", "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4494), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4493), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4492) });

            migrationBuilder.UpdateData(
                table: "PruebaSeleccions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "FechaActualizacion", "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4497), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4496), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4495) });

            migrationBuilder.UpdateData(
                table: "PruebaSeleccions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "FechaActualizacion", "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4501), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4499), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4499) });

            migrationBuilder.UpdateData(
                table: "PruebaSeleccions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "FechaActualizacion", "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4504), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4502), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4502) });

            migrationBuilder.UpdateData(
                table: "PruebaSeleccions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "FechaActualizacion", "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4507), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4505), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4505) });

            migrationBuilder.UpdateData(
                table: "TipoPruebas",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4301));

            migrationBuilder.UpdateData(
                table: "TipoPruebas",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaActualizacion",
                value: new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4307));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "820c1083-836a-4db6-ae0c-381b58c35170", "4ddb3e82-d252-429f-864d-5fb9324c27f5" },
                    { "2f316e7b-57f8-40ad-a765-8fdc3c0d113a", "6c37d2ea-dadf-46f0-b96f-4e1dd20d3b73" },
                    { "820c1083-836a-4db6-ae0c-381b58c35170", "76588b1d-43a5-40bf-928b-9c68500b6de2" },
                    { "2f316e7b-57f8-40ad-a765-8fdc3c0d113a", "fd3476df-ca02-45e8-82f2-995e78d81a94" }
                });
        }
    }
}
