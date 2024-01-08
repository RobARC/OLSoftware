using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OlSoft.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Aspirantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    FechaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aspirantes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Aspirantes_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EstadoPruebas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estado = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    FechaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoPruebas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EstadoPruebas_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NivelPruebas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nivel = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: true),
                    FechaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NivelPruebas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NivelPruebas_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TipoPruebas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: true),
                    FechaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPruebas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TipoPruebas_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PruebaSeleccions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AspiranteId = table.Column<int>(type: "int", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LenguajeProgramacion = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    CantidadPreguntas = table.Column<int>(type: "int", nullable: true),
                    TipoPruebaId = table.Column<int>(type: "int", nullable: true),
                    NivelPruebaId = table.Column<int>(type: "int", nullable: true),
                    EstadoPruebaId = table.Column<int>(type: "int", nullable: true),
                    Calificacion = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    UsuarioId = table.Column<int>(type: "int", nullable: true),
                    FechaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PruebaSeleccions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PruebaSeleccions_Aspirantes_AspiranteId",
                        column: x => x.AspiranteId,
                        principalTable: "Aspirantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PruebaSeleccions_EstadoPruebas_EstadoPruebaId",
                        column: x => x.EstadoPruebaId,
                        principalTable: "EstadoPruebas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PruebaSeleccions_NivelPruebas_NivelPruebaId",
                        column: x => x.NivelPruebaId,
                        principalTable: "NivelPruebas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PruebaSeleccions_TipoPruebas_TipoPruebaId",
                        column: x => x.TipoPruebaId,
                        principalTable: "TipoPruebas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PruebaSeleccions_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Preguntas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pregunta1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Respuesta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PruebaSeleccionId = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: true),
                    FechaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Preguntas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Preguntas_PruebaSeleccions_PruebaSeleccionId",
                        column: x => x.PruebaSeleccionId,
                        principalTable: "PruebaSeleccions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Preguntas_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id");
                });

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

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Password", "RoleId", "Username" },
                values: new object[] { 1, "Aa123456!", "1", "Roberth" });

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

            migrationBuilder.InsertData(
                table: "Aspirantes",
                columns: new[] { "Id", "Apellido", "Email", "FechaActualizacion", "Nombre", "Telefono", "UsuarioId" },
                values: new object[,]
                {
                    { 1, "Baggins", "frodo.baggins@example.com", new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4193), "Frodo", "12345678901", 1 },
                    { 2, "Gamgee", "samwise.gamgee@example.com", new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4207), "Samwise", "+12345678902", 1 },
                    { 3, "Brandybuck", "meriadoc.brandybuck@example.com", new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4209), "Meriadoc", "+12345678903", 1 },
                    { 4, "Took", "peregrin.took@example.co", new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4210), "Peregrin", "+12345678904", 1 },
                    { 5, "Elessar", "aragorn.elessar@example.com", new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4212), "Aragorn", "+12345678905", 1 },
                    { 6, "Greenleaf", "legolas.greenleaf@example.com", new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4224), "Legolas", "+12345678906", 1 },
                    { 7, "SonOfGlóin", "gimli.sonofgloin@example.com", new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4225), "Gimli", " +12345678907", 1 },
                    { 8, "OfGondor", "boromir.ofgondor@example.com", new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4227), "Boromir", "+12345678908", 1 },
                    { 9, "TheGrey", "gandalf.thegrey@example.com", new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4228), "Gandalf", "+12345678909", 1 },
                    { 10, "Baggins", "saruman.thewhite@example.com", new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4230), "Saruman", "+123456789010", 1 }
                });

            migrationBuilder.InsertData(
                table: "EstadoPruebas",
                columns: new[] { "Id", "Estado", "FechaActualizacion", "UsuarioId" },
                values: new object[,]
                {
                    { 1, "Registrada", new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4335), 1 },
                    { 2, "En Proceso", new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4338), 1 },
                    { 3, "Terminada", new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4339), 1 },
                    { 4, "Anulada", new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4340), 1 }
                });

            migrationBuilder.InsertData(
                table: "NivelPruebas",
                columns: new[] { "Id", "FechaActualizacion", "Nivel", "UsuarioId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4266), "Junior", 1 },
                    { 2, new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4271), "Middle", 1 },
                    { 3, new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4272), "Senior", 1 }
                });

            migrationBuilder.InsertData(
                table: "TipoPruebas",
                columns: new[] { "Id", "FechaActualizacion", "Tipo", "UsuarioId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4301), "Técnica", 1 },
                    { 2, new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4307), "Práctica", 1 }
                });

            migrationBuilder.InsertData(
                table: "PruebaSeleccions",
                columns: new[] { "Id", "AspiranteId", "Calificacion", "CantidadPreguntas", "Descripcion", "EstadoPruebaId", "FechaActualizacion", "FechaFin", "FechaInicio", "LenguajeProgramacion", "NivelPruebaId", "TipoPruebaId", "UsuarioId" },
                values: new object[,]
                {
                    { 1, 1, 0m, 15, "Test_LoginFunctionality_DotNet", 2, new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4367), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4364), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4364), "C#", 1, 1, 1 },
                    { 2, 2, 95m, 15, "Test_SignUpPageValidation_DotNet", 3, new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4377), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4371), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4370), "C#", 3, 1, 1 },
                    { 3, 3, 90m, 15, "Test_ArrayManipulation_JavaScript", 3, new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4380), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4379), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4378), "JavaScript", 2, 2, 1 },
                    { 4, 4, 92m, 15, "Test_AsyncFunction_JavaScript", 3, new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4383), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4382), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4381), "JavaScript", 3, 2, 1 },
                    { 5, 5, 98m, 15, "Test_DatabaseConnection_Python", 3, new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4473), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4471), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4470), "Python", 3, 1, 1 },
                    { 6, 6, 88m, 15, "Test_DataAnalysisFunction_Python", 3, new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4477), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4476), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4475), "Python", 1, 1, 1 },
                    { 7, 7, 0m, 15, "Test_FileCreation_BashScript", 2, new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4481), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4479), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4479), "Bash", 2, 2, 1 },
                    { 8, 8, 97m, 15, "Test_DirectoryNavigation_BashScript", 3, new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4484), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4482), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4482), "Bash", 1, 1, 1 },
                    { 9, 9, 94m, 15, "Test_FormSubmission_HTML", 3, new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4487), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4486), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4485), "HTML", 1, 1, 1 },
                    { 10, 9, 96m, 15, "Test_ResponsiveDesign_HTML", 3, new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4491), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4490), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4489), "HTML", 2, 2, 1 },
                    { 11, 10, 90m, 15, "Test_ExceptionHandling_DotNet", 3, new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4494), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4493), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4492), "C#", 3, 2, 1 },
                    { 12, 1, 90m, 15, "Test_CallbackFunction_JavaScript", 3, new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4497), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4496), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4495), "JavaScript", 3, 2, 1 },
                    { 13, 2, 98m, 15, "Test_MachineLearningModel_Python", 3, new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4501), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4499), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4499), "Python", 1, 1, 1 },
                    { 14, 3, 97m, 15, "Test_SystemUpdate_BashScript", 3, new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4504), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4502), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4502), "Bash", 2, 1, 1 },
                    { 15, 3, 91m, 15, "Test_LinkNavigation_HTML", 3, new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4507), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4505), new DateTime(2024, 1, 7, 11, 12, 14, 398, DateTimeKind.Local).AddTicks(4505), "HTML", 3, 1, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aspirantes_UsuarioId",
                table: "Aspirantes",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_EstadoPruebas_UsuarioId",
                table: "EstadoPruebas",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_NivelPruebas_UsuarioId",
                table: "NivelPruebas",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Preguntas_PruebaSeleccionId",
                table: "Preguntas",
                column: "PruebaSeleccionId");

            migrationBuilder.CreateIndex(
                name: "IX_Preguntas_UsuarioId",
                table: "Preguntas",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_PruebaSeleccions_AspiranteId",
                table: "PruebaSeleccions",
                column: "AspiranteId");

            migrationBuilder.CreateIndex(
                name: "IX_PruebaSeleccions_EstadoPruebaId",
                table: "PruebaSeleccions",
                column: "EstadoPruebaId");

            migrationBuilder.CreateIndex(
                name: "IX_PruebaSeleccions_NivelPruebaId",
                table: "PruebaSeleccions",
                column: "NivelPruebaId");

            migrationBuilder.CreateIndex(
                name: "IX_PruebaSeleccions_TipoPruebaId",
                table: "PruebaSeleccions",
                column: "TipoPruebaId");

            migrationBuilder.CreateIndex(
                name: "IX_PruebaSeleccions_UsuarioId",
                table: "PruebaSeleccions",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_TipoPruebas_UsuarioId",
                table: "TipoPruebas",
                column: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Preguntas");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "PruebaSeleccions");

            migrationBuilder.DropTable(
                name: "Aspirantes");

            migrationBuilder.DropTable(
                name: "EstadoPruebas");

            migrationBuilder.DropTable(
                name: "NivelPruebas");

            migrationBuilder.DropTable(
                name: "TipoPruebas");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
