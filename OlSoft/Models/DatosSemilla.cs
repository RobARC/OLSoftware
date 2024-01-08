using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace OLSofwareDos.Models
{
    public static class DatosSemilla
    {
        public static void seed(this ModelBuilder modelBuilder)
        {
            //Create Roles
            List<IdentityRole> roles = new List<IdentityRole>()
            {
                new IdentityRole { Name = "Publico", NormalizedName ="PUBLICO"},
                new IdentityRole { Name = "Administrador", NormalizedName ="ADMINISTRADOR"}

            };

            modelBuilder.Entity<IdentityRole>().HasData(roles);

            //Create Users
            List<ApplicationUser> users = new List<ApplicationUser>()
            {
                 new ApplicationUser
                {
                    UserName = "roberth",
                    NormalizedUserName = "ROBERTH",
                    Email = "roberth@gmail.com",
                    NormalizedEmail = "ROBERTH@GMAIL.COM"
                },
                new ApplicationUser
                {
                    UserName = "karina",
                    NormalizedUserName = "KARINA",
                    Email = "karina@gmail.com",
                    NormalizedEmail = "KARINA@GMAIL.COM"
                },
                 new ApplicationUser
                {
                    UserName = "sofia",
                    NormalizedUserName = "SOFIA",
                    Email = "sofia@yahho.com",
                    NormalizedEmail = "SOFIA@YAHOO.COM"
                },
                  new ApplicationUser
                {
                    UserName = "johnny",
                    NormalizedUserName = "JOHNNY",
                    Email = "johnny@gmail.com",
                    NormalizedEmail = "JOHNNY@GMAIL.COM"
                }

            };
            modelBuilder.Entity<ApplicationUser>().HasData(users);

            //Add passwords to users

            var passwordHasher = new PasswordHasher<ApplicationUser>();
            users[0].PasswordHash = passwordHasher.HashPassword(users[0], "Aa123456!");
            users[1].PasswordHash = passwordHasher.HashPassword(users[1], "Aa123456!");
            users[2].PasswordHash = passwordHasher.HashPassword(users[2], "Aa123456!");
            users[3].PasswordHash = passwordHasher.HashPassword(users[2], "Aa123456!");

            //Add roles to users

            List<IdentityUserRole<string>> userRoles = new List<IdentityUserRole<string>>();
            userRoles.Add(new IdentityUserRole<string>
            {
                UserId = users[0].Id,
                RoleId = roles.FirstOrDefault(q => q.Name == "Administrador").Id

            });
            userRoles.Add(new IdentityUserRole<string>
            {
                UserId = users[1].Id,
                RoleId = roles.FirstOrDefault(q => q.Name == "Administrador").Id

            });
            userRoles.Add(new IdentityUserRole<string>
            {
                UserId = users[2].Id,
                RoleId = roles.FirstOrDefault(q => q.Name == "Publico").Id

            });
            userRoles.Add(new IdentityUserRole<string>
            {
                UserId = users[3].Id,
                RoleId = roles.FirstOrDefault(q => q.Name == "Publico").Id

            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoles);

            //Create Usuarios
            List<Usuario> usuarios = new List<Usuario>()
            {
                new Usuario
                {
                    Id= 1,
                    Username="Roberth",
                    Email="roberth@gmail.com",
                    Password="Aa123456!",
                    RoleId="1"
                }
            };
            modelBuilder.Entity<Usuario>().HasData(usuarios);

            // Create Aspirantes
            List<Aspirante> aspirantes = new List<Aspirante>()
            {
                new Aspirante {
                                Id= 1,
                                Nombre= "Frodo",
                                Apellido= "Baggins",
                                Email= "frodo.baggins@example.com",
                                Telefono= "12345678901",
                                UsuarioId = 1,
                                FechaActualizacion = DateTime.Now
                             },
                new Aspirante {
                                Id= 2,
                                Nombre= "Samwise",
                                Apellido= "Gamgee",
                                Email= "samwise.gamgee@example.com",
                                Telefono= "+12345678902",
                                UsuarioId = 1,
                                FechaActualizacion = DateTime.Now
                            },
                new Aspirante {
                               Id= 3,
                               Nombre= "Meriadoc",
                               Apellido= "Brandybuck",
                               Email= "meriadoc.brandybuck@example.com",
                               Telefono= "+12345678903",
                               UsuarioId = 1,
                               FechaActualizacion = DateTime.Now
                           },
                new Aspirante {
                               Id = 4,
                               Nombre= "Peregrin",
                               Apellido= "Took",
                               Email= "peregrin.took@example.co",
                               Telefono= "+12345678904",
                               UsuarioId = 1,
                               FechaActualizacion = DateTime.Now
                           },
                new Aspirante {
                             Id = 5,
                             Nombre= "Aragorn",
                             Apellido= "Elessar",
                             Email= "aragorn.elessar@example.com",
                             Telefono= "+12345678905",
                             UsuarioId = 1,
                             FechaActualizacion = DateTime.Now
                         },
                new Aspirante {
                             Id = 6,
                             Nombre= "Legolas",
                             Apellido= "Greenleaf",
                             Email= "legolas.greenleaf@example.com",
                             Telefono= "+12345678906",
                             UsuarioId = 1,
                             FechaActualizacion = DateTime.Now
                            },
                new Aspirante {
                           Id = 7,
                           Nombre= "Gimli",
                           Apellido= "SonOfGlóin",
                           Email= "gimli.sonofgloin@example.com",
                           Telefono= " +12345678907",
                           UsuarioId = 1,
                           FechaActualizacion = DateTime.Now
                       },
                new Aspirante {
                          Id = 8,
                          Nombre= "Boromir",
                          Apellido= "OfGondor",
                          Email= "boromir.ofgondor@example.com",
                          Telefono= "+12345678908",
                          UsuarioId = 1,
                          FechaActualizacion = DateTime.Now
                      },
                new Aspirante {
                         Id = 9,
                         Nombre= "Gandalf",
                         Apellido= "TheGrey",
                         Email= "gandalf.thegrey@example.com",
                         Telefono= "+12345678909",
                         UsuarioId = 1,
                         FechaActualizacion = DateTime.Now
                     },
                new Aspirante {
                        Id = 10,
                        Nombre= "Saruman",
                        Apellido= "Baggins",
                        Email= "saruman.thewhite@example.com",
                        Telefono= "+123456789010",
                        UsuarioId = 1,
                        FechaActualizacion = DateTime.Now
                    },

            };

            modelBuilder.Entity<Aspirante>().HasData(aspirantes);

            //Create Niveles Prueba

            List<NivelPrueba> niveles = new List<NivelPrueba>()
            {
                new NivelPrueba
                {   Id= 1,
                    Nivel = "Junior",
                    UsuarioId = 1,
                    FechaActualizacion = DateTime.Now

                },
                 new NivelPrueba
                {   Id = 2,
                    Nivel = "Middle",
                    UsuarioId = 1,
                    FechaActualizacion = DateTime.Now

                },
                  new NivelPrueba
                {   Id = 3,
                    Nivel = "Senior",
                    UsuarioId = 1,
                    FechaActualizacion = DateTime.Now

                }
            };
            modelBuilder.Entity<NivelPrueba>().HasData(niveles);

            //Create Tipos Prueba

            List<TipoPrueba> tipoPruebas = new List<TipoPrueba>()
            {
                new TipoPrueba
                {   Id = 1,
                    Tipo = "Técnica",
                    UsuarioId = 1,
                    FechaActualizacion = DateTime.Now
                },
                 new TipoPrueba
                {   Id = 2,
                    Tipo = "Práctica",
                    UsuarioId = 1,
                    FechaActualizacion = DateTime.Now
                }
            };

            modelBuilder.Entity<TipoPrueba>().HasData(tipoPruebas);

            //Create Estados Prueba

            List<EstadoPrueba> estados = new List<EstadoPrueba>()
            {
                new EstadoPrueba
                {
                    Id= 1,
                    Estado = "Registrada",
                    UsuarioId = 1,
                    FechaActualizacion = DateTime.Now
                },
                new EstadoPrueba
                {
                    Id = 2,
                    Estado = "En Proceso",
                    UsuarioId = 1,
                    FechaActualizacion = DateTime.Now
                },
                new EstadoPrueba
                {
                    Id = 3,
                    Estado = "Terminada",
                    UsuarioId = 1,
                    FechaActualizacion = DateTime.Now
                },
                new EstadoPrueba
                {   Id = 4,
                    Estado = "Anulada",
                    UsuarioId = 1,
                    FechaActualizacion = DateTime.Now
                },
            };
            modelBuilder.Entity<EstadoPrueba>().HasData(estados);

            //Create Pruebas Seleccion

            List<PruebaSeleccion> pruebas = new List<PruebaSeleccion>()
            {
                new PruebaSeleccion
                    {
                    Id= 1,
                    Descripcion = "Test_LoginFunctionality_DotNet",
                    AspiranteId = 1,
                    FechaInicio= DateTime.Now,
                    FechaFin= DateTime.Now,
                    LenguajeProgramacion= "C#",
                    CantidadPreguntas=15,
                    TipoPruebaId =1,
                    NivelPruebaId=1,
                    EstadoPruebaId=2,
                    Calificacion=0,
                    UsuarioId = 1,
                    FechaActualizacion = DateTime.Now

                },
                new PruebaSeleccion
                {   Id= 2,
                    Descripcion = "Test_SignUpPageValidation_DotNet",
                    AspiranteId = 2,
                    FechaInicio= DateTime.Now,
                    FechaFin= DateTime.Now,
                    LenguajeProgramacion= "C#",
                    CantidadPreguntas=15,
                    TipoPruebaId =1,
                    NivelPruebaId=3,
                    EstadoPruebaId=3,
                    Calificacion=95,
                    UsuarioId = 1,
                    FechaActualizacion = DateTime.Now

                },
                new PruebaSeleccion
                {   Id = 3,
                    Descripcion = "Test_ArrayManipulation_JavaScript",
                    AspiranteId = 3,
                    FechaInicio= DateTime.Now,
                    FechaFin= DateTime.Now,
                    LenguajeProgramacion= "JavaScript",
                    CantidadPreguntas=15,
                    TipoPruebaId =2,
                    NivelPruebaId=2,
                    EstadoPruebaId=3,
                    Calificacion=90,
                    UsuarioId = 1,
                    FechaActualizacion = DateTime.Now

                },
                new PruebaSeleccion
                {   Id = 4,
                    Descripcion = "Test_AsyncFunction_JavaScript",
                    AspiranteId = 4,
                    FechaInicio= DateTime.Now,
                    FechaFin= DateTime.Now,
                    LenguajeProgramacion= "JavaScript",
                    CantidadPreguntas=15,
                    TipoPruebaId =2,
                    NivelPruebaId=3,
                    EstadoPruebaId=3,
                    Calificacion=92,
                    UsuarioId = 1,
                    FechaActualizacion = DateTime.Now

                },
                new PruebaSeleccion
                {   Id= 5,
                    Descripcion = "Test_DatabaseConnection_Python",
                    AspiranteId = 5,
                    FechaInicio= DateTime.Now,
                    FechaFin= DateTime.Now,
                    LenguajeProgramacion= "Python",
                    CantidadPreguntas=15,
                    TipoPruebaId =1,
                    NivelPruebaId=3,
                    EstadoPruebaId=3,
                    Calificacion=98,
                    UsuarioId = 1,
                    FechaActualizacion = DateTime.Now

                },
                new PruebaSeleccion
                {   Id = 6,
                    Descripcion = "Test_DataAnalysisFunction_Python",
                    AspiranteId = 6,
                    FechaInicio= DateTime.Now,
                    FechaFin= DateTime.Now,
                    LenguajeProgramacion= "Python",
                    CantidadPreguntas=15,
                    TipoPruebaId =1,
                    NivelPruebaId=1,
                    EstadoPruebaId=3,
                    Calificacion=88,
                    UsuarioId = 1,
                    FechaActualizacion = DateTime.Now

                },
                new PruebaSeleccion
                {   Id= 7,
                    Descripcion = "Test_FileCreation_BashScript",
                    AspiranteId = 7,
                    FechaInicio= DateTime.Now,
                    FechaFin= DateTime.Now,
                    LenguajeProgramacion= "Bash",
                    CantidadPreguntas=15,
                    TipoPruebaId =2,
                    NivelPruebaId=2,
                    EstadoPruebaId=2,
                    Calificacion=0,
                    UsuarioId = 1,
                    FechaActualizacion = DateTime.Now

                },
                 new PruebaSeleccion
                {   Id= 8,
                    Descripcion = "Test_DirectoryNavigation_BashScript",
                    AspiranteId = 8,
                    FechaInicio= DateTime.Now,
                    FechaFin= DateTime.Now,
                    LenguajeProgramacion= "Bash",
                    CantidadPreguntas=15,
                    TipoPruebaId =1,
                    NivelPruebaId=1,
                    EstadoPruebaId=3,
                    Calificacion=97,
                    UsuarioId = 1,
                    FechaActualizacion = DateTime.Now

                },
                new PruebaSeleccion
                {   Id = 9,
                    Descripcion = "Test_FormSubmission_HTML",
                    AspiranteId = 9,
                    FechaInicio= DateTime.Now,
                    FechaFin= DateTime.Now,
                    LenguajeProgramacion= "HTML",
                    CantidadPreguntas=15,
                    TipoPruebaId =1,
                    NivelPruebaId=1,
                    EstadoPruebaId=3,
                    Calificacion=94,
                    UsuarioId = 1,
                    FechaActualizacion = DateTime.Now

                },
                new PruebaSeleccion
                {   Id= 10,
                    Descripcion = "Test_ResponsiveDesign_HTML",
                    AspiranteId = 9,
                    FechaInicio= DateTime.Now,
                    FechaFin= DateTime.Now,
                    LenguajeProgramacion= "HTML",
                    CantidadPreguntas=15,
                    TipoPruebaId =2,
                    NivelPruebaId=2,
                    EstadoPruebaId=3,
                    Calificacion=96,
                    UsuarioId = 1,
                    FechaActualizacion = DateTime.Now

                },
                new PruebaSeleccion
                {   Id= 11,
                    Descripcion = "Test_ExceptionHandling_DotNet",
                    AspiranteId = 10,
                    FechaInicio= DateTime.Now,
                    FechaFin= DateTime.Now,
                    LenguajeProgramacion= "C#",
                    CantidadPreguntas=15,
                    TipoPruebaId =2,
                    NivelPruebaId=3,
                    EstadoPruebaId=3,
                    Calificacion=90,
                    UsuarioId = 1,
                    FechaActualizacion = DateTime.Now

                },
                new PruebaSeleccion
                {   Id=12,
                    Descripcion = "Test_CallbackFunction_JavaScript",
                    AspiranteId = 1,
                    FechaInicio= DateTime.Now,
                    FechaFin= DateTime.Now,
                    LenguajeProgramacion= "JavaScript",
                    CantidadPreguntas=15,
                    TipoPruebaId =2,
                    NivelPruebaId=3,
                    EstadoPruebaId=3,
                    Calificacion=90,
                    UsuarioId = 1,
                    FechaActualizacion = DateTime.Now

                },
                new PruebaSeleccion
                {   Id= 13,
                    Descripcion = "Test_MachineLearningModel_Python",
                    AspiranteId = 2,
                    FechaInicio= DateTime.Now,
                    FechaFin= DateTime.Now,
                    LenguajeProgramacion= "Python",
                    CantidadPreguntas=15,
                    TipoPruebaId =1,
                    NivelPruebaId=1,
                    EstadoPruebaId=3,
                    Calificacion=98,
                    UsuarioId = 1,
                    FechaActualizacion = DateTime.Now

                },
                new PruebaSeleccion
                {   Id= 14,
                    Descripcion = "Test_SystemUpdate_BashScript",
                    AspiranteId = 3,
                    FechaInicio= DateTime.Now,
                    FechaFin= DateTime.Now,
                    LenguajeProgramacion= "Bash",
                    CantidadPreguntas=15,
                    TipoPruebaId =1,
                    NivelPruebaId=2,
                    EstadoPruebaId=3,
                    Calificacion=97,
                    UsuarioId = 1,
                    FechaActualizacion = DateTime.Now

                },
                 new PruebaSeleccion
                {   Id= 15,
                    Descripcion = "Test_LinkNavigation_HTML",
                    AspiranteId = 3,
                    FechaInicio= DateTime.Now,
                    FechaFin= DateTime.Now,
                    LenguajeProgramacion= "HTML",
                    CantidadPreguntas=15,
                    TipoPruebaId =1,
                    NivelPruebaId=3,
                    EstadoPruebaId=3,
                    Calificacion=91,
                    UsuarioId = 1,
                    FechaActualizacion = DateTime.Now

                }
            };

            modelBuilder.Entity<PruebaSeleccion>().HasData(pruebas);

            //Create Preguntas 

            var PreguntasTextos = new List<String>()
            {
                "Test_SignUpPageValidation_DotNet",
                "Test_ArrayManipulation_JavaScript",
                "Test_AsyncFunction_JavaScript",
                "Test_DatabaseConnection_Python",
                "Test_DataAnalysisFunction_Python",
                "Test_FileCreation_BashScript",
                "Test_DirectoryNavigation_BashScript",
                "Test_FormSubmission_HTML",
                "Test_ResponsiveDesign_HTML",
                "Test_ExceptionHandling_DotNet",
                "Test_CallbackFunction_JavaScript",
                "Test_MachineLearningModel_Python",
                "Test_SystemUpdate_BashScript",
                "Test_LinkNavigation_HTML"
            };

            List<Pregunta> preguntas = new List<Pregunta>();

            int preguntaId = 1;
            foreach (var prueba in pruebas)
            {
                foreach (var preguntaTexto in PreguntasTextos)
                {
                    preguntas.Add(new Pregunta
                    {
                        Id = preguntaId++,
                        Pregunta1 = preguntaTexto,
                        PruebaSeleccionId = prueba.Id,
                        Respuesta = "Respuesta Ejemplo" + preguntaId++,
                        UsuarioId = 1,
                        FechaActualizacion = DateTime.Now
                    });
                }
            }
            modelBuilder.Entity<Pregunta>().HasData(preguntas);
        }
    }
}
