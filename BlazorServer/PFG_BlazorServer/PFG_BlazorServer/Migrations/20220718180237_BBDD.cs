using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PFG_BlazorServer.Migrations
{
    public partial class BBDD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ADMINISTRADOR",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ADMINISTRADOR", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                name: "EMPRESA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Industry = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Pais = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Ciudad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Calle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CodigoPostal = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    AdminId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMPRESA", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EMPRESA_ADMINISTRADOR_AdminId",
                        column: x => x.AdminId,
                        principalTable: "ADMINISTRADOR",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
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
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
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
                name: "ESTUDIANTE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    FechaDeNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HasCV = table.Column<bool>(type: "bit", nullable: false),
                    HasPhoto = table.Column<bool>(type: "bit", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pais = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Ciudad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Foto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    AdminId = table.Column<int>(type: "int", nullable: true),
                    InscripcionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ESTUDIANTE", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ESTUDIANTE_ADMINISTRADOR_AdminId",
                        column: x => x.AdminId,
                        principalTable: "ADMINISTRADOR",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ESTUDIO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameCurso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InicioCurso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FinCurso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    NameCentro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescripcionCurso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstudianteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ESTUDIO", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ESTUDIO_ESTUDIANTE_EstudianteId",
                        column: x => x.EstudianteId,
                        principalTable: "ESTUDIANTE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EXPERIENCIA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameTrabajo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InicioTrabajo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FinTrabajo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NameEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PuestoTrabajo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstudianteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EXPERIENCIA", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EXPERIENCIA_ESTUDIANTE_EstudianteId",
                        column: x => x.EstudianteId,
                        principalTable: "ESTUDIANTE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FICHERO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Extension = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpresaId = table.Column<int>(type: "int", nullable: true),
                    EstudianteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FICHERO", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FICHERO_EMPRESA_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "EMPRESA",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FICHERO_ESTUDIANTE_EstudianteId",
                        column: x => x.EstudianteId,
                        principalTable: "ESTUDIANTE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OFERTA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Puesto = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EmpresaId = table.Column<int>(type: "int", nullable: false),
                    TipoContrato = table.Column<int>(type: "int", nullable: false),
                    MinSalario = table.Column<int>(type: "int", nullable: false),
                    MaxSalario = table.Column<int>(type: "int", nullable: false),
                    Pais = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DisponibilidadViajar = table.Column<bool>(type: "bit", nullable: false),
                    DuracionContrato = table.Column<int>(type: "int", nullable: false),
                    PublicacionOferta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CaducidadOferta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NivelEstudios = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Experiencia = table.Column<int>(type: "int", nullable: false),
                    Titulacion = table.Column<int>(type: "int", nullable: false),
                    FicheroAdjuntoId = table.Column<int>(type: "int", nullable: true),
                    EstadoOferta = table.Column<int>(type: "int", nullable: false),
                    NombreContacto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailContacto = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TelefonoContacto = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    AdminId = table.Column<int>(type: "int", nullable: true),
                    EstudianteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OFERTA", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OFERTA_ADMINISTRADOR_AdminId",
                        column: x => x.AdminId,
                        principalTable: "ADMINISTRADOR",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OFERTA_EMPRESA_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "EMPRESA",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OFERTA_ESTUDIANTE_EstudianteId",
                        column: x => x.EstudianteId,
                        principalTable: "ESTUDIANTE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OFERTA_FICHERO_FicheroAdjuntoId",
                        column: x => x.FicheroAdjuntoId,
                        principalTable: "FICHERO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IDIOMA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nivel = table.Column<int>(type: "int", nullable: false),
                    EstudianteId = table.Column<int>(type: "int", nullable: true),
                    OfertaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IDIOMA", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IDIOMA_ESTUDIANTE_EstudianteId",
                        column: x => x.EstudianteId,
                        principalTable: "ESTUDIANTE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IDIOMA_OFERTA_OfertaId",
                        column: x => x.OfertaId,
                        principalTable: "OFERTA",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "INSCRIPCION",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OfertaId = table.Column<int>(type: "int", nullable: true),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INSCRIPCION", x => x.Id);
                    table.ForeignKey(
                        name: "FK_INSCRIPCION_OFERTA_OfertaId",
                        column: x => x.OfertaId,
                        principalTable: "OFERTA",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SKILL",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkillName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstudianteId = table.Column<int>(type: "int", nullable: true),
                    OfertaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SKILL", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SKILL_ESTUDIANTE_EstudianteId",
                        column: x => x.EstudianteId,
                        principalTable: "ESTUDIANTE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SKILL_OFERTA_OfertaId",
                        column: x => x.OfertaId,
                        principalTable: "OFERTA",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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
                name: "IX_EMPRESA_AdminId",
                table: "EMPRESA",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_ESTUDIANTE_AdminId",
                table: "ESTUDIANTE",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_ESTUDIANTE_InscripcionId",
                table: "ESTUDIANTE",
                column: "InscripcionId");

            migrationBuilder.CreateIndex(
                name: "IX_ESTUDIO_EstudianteId",
                table: "ESTUDIO",
                column: "EstudianteId");

            migrationBuilder.CreateIndex(
                name: "IX_EXPERIENCIA_EstudianteId",
                table: "EXPERIENCIA",
                column: "EstudianteId");

            migrationBuilder.CreateIndex(
                name: "IX_FICHERO_EmpresaId",
                table: "FICHERO",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_FICHERO_EstudianteId",
                table: "FICHERO",
                column: "EstudianteId");

            migrationBuilder.CreateIndex(
                name: "IX_IDIOMA_EstudianteId",
                table: "IDIOMA",
                column: "EstudianteId");

            migrationBuilder.CreateIndex(
                name: "IX_IDIOMA_OfertaId",
                table: "IDIOMA",
                column: "OfertaId");

            migrationBuilder.CreateIndex(
                name: "IX_INSCRIPCION_OfertaId",
                table: "INSCRIPCION",
                column: "OfertaId");

            migrationBuilder.CreateIndex(
                name: "IX_OFERTA_AdminId",
                table: "OFERTA",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_OFERTA_EmpresaId",
                table: "OFERTA",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_OFERTA_EstudianteId",
                table: "OFERTA",
                column: "EstudianteId");

            migrationBuilder.CreateIndex(
                name: "IX_OFERTA_FicheroAdjuntoId",
                table: "OFERTA",
                column: "FicheroAdjuntoId");

            migrationBuilder.CreateIndex(
                name: "IX_SKILL_EstudianteId",
                table: "SKILL",
                column: "EstudianteId");

            migrationBuilder.CreateIndex(
                name: "IX_SKILL_OfertaId",
                table: "SKILL",
                column: "OfertaId");

            migrationBuilder.AddForeignKey(
                name: "FK_ESTUDIANTE_INSCRIPCION_InscripcionId",
                table: "ESTUDIANTE",
                column: "InscripcionId",
                principalTable: "INSCRIPCION",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EMPRESA_ADMINISTRADOR_AdminId",
                table: "EMPRESA");

            migrationBuilder.DropForeignKey(
                name: "FK_ESTUDIANTE_ADMINISTRADOR_AdminId",
                table: "ESTUDIANTE");

            migrationBuilder.DropForeignKey(
                name: "FK_OFERTA_ADMINISTRADOR_AdminId",
                table: "OFERTA");

            migrationBuilder.DropForeignKey(
                name: "FK_ESTUDIANTE_INSCRIPCION_InscripcionId",
                table: "ESTUDIANTE");

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
                name: "ESTUDIO");

            migrationBuilder.DropTable(
                name: "EXPERIENCIA");

            migrationBuilder.DropTable(
                name: "IDIOMA");

            migrationBuilder.DropTable(
                name: "SKILL");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ADMINISTRADOR");

            migrationBuilder.DropTable(
                name: "INSCRIPCION");

            migrationBuilder.DropTable(
                name: "OFERTA");

            migrationBuilder.DropTable(
                name: "FICHERO");

            migrationBuilder.DropTable(
                name: "EMPRESA");

            migrationBuilder.DropTable(
                name: "ESTUDIANTE");
        }
    }
}
