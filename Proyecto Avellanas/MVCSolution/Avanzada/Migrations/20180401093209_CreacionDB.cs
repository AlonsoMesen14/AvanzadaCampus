using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Avanzada.Migrations
{
    public partial class CreacionDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carreras",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre_Carrera = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carreras", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    PersonaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Apellido = table.Column<string>(nullable: true),
                    Carne = table.Column<int>(nullable: false),
                    Cedula = table.Column<int>(nullable: false),
                    Contraseña = table.Column<string>(nullable: true),
                    Correo = table.Column<string>(nullable: true),
                    FechaNacimiento = table.Column<DateTime>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    Sexo = table.Column<int>(nullable: false),
                    Telefono = table.Column<string>(nullable: true),
                    Usuario = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.PersonaId);
                });

            migrationBuilder.CreateTable(
                name: "Matricula",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CarreraId = table.Column<int>(nullable: true),
                    CreditosMatriculados = table.Column<int>(nullable: false),
                    EstadoCurso = table.Column<int>(nullable: false),
                    IDUsuarioMatriculando = table.Column<int>(nullable: false),
                    IDUsuarioMatriculante = table.Column<int>(nullable: false),
                    Monto = table.Column<int>(nullable: false),
                    PersonaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matricula", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Matricula_Carreras_CarreraId",
                        column: x => x.CarreraId,
                        principalTable: "Carreras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Matricula_Personas_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "Personas",
                        principalColumn: "PersonaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    CursoId = table.Column<string>(nullable: false),
                    Creditos = table.Column<int>(nullable: false),
                    CursoId1 = table.Column<string>(nullable: true),
                    Estado = table.Column<int>(nullable: false),
                    MatriculaId = table.Column<int>(nullable: true),
                    Nombre_Curso = table.Column<string>(nullable: true),
                    Precio = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.CursoId);
                    table.ForeignKey(
                        name: "FK_Cursos_Cursos_CursoId1",
                        column: x => x.CursoId1,
                        principalTable: "Cursos",
                        principalColumn: "CursoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cursos_Matricula_MatriculaId",
                        column: x => x.MatriculaId,
                        principalTable: "Matricula",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Carreras_Cursos",
                columns: table => new
                {
                    CarreraId = table.Column<int>(nullable: false),
                    CursoId = table.Column<int>(nullable: false),
                    CarrerasId = table.Column<int>(nullable: true),
                    CursoId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carreras_Cursos", x => new { x.CarreraId, x.CursoId });
                    table.ForeignKey(
                        name: "FK_Carreras_Cursos_Carreras_CarrerasId",
                        column: x => x.CarrerasId,
                        principalTable: "Carreras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Carreras_Cursos_Cursos_CursoId1",
                        column: x => x.CursoId1,
                        principalTable: "Cursos",
                        principalColumn: "CursoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Grupos",
                columns: table => new
                {
                    GrupoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CursoId = table.Column<int>(nullable: false),
                    CursoId1 = table.Column<string>(nullable: true),
                    Horario = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupos", x => x.GrupoId);
                    table.ForeignKey(
                        name: "FK_Grupos_Cursos_CursoId1",
                        column: x => x.CursoId1,
                        principalTable: "Cursos",
                        principalColumn: "CursoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rubros",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CarreraId = table.Column<int>(nullable: true),
                    CursoId = table.Column<int>(nullable: false),
                    CursoId1 = table.Column<string>(nullable: true),
                    NombreRubro = table.Column<string>(nullable: true),
                    Porcentaje = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rubros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rubros_Carreras_CarreraId",
                        column: x => x.CarreraId,
                        principalTable: "Carreras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rubros_Cursos_CursoId1",
                        column: x => x.CursoId1,
                        principalTable: "Cursos",
                        principalColumn: "CursoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TipoPersona",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CursoId = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    PersonaId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPersona", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TipoPersona_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "CursoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TipoPersona_Personas_PersonaId1",
                        column: x => x.PersonaId1,
                        principalTable: "Personas",
                        principalColumn: "PersonaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Asistencia_Estudiantes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Asistencia = table.Column<int>(nullable: false),
                    CursoId = table.Column<int>(nullable: false),
                    CursoId1 = table.Column<string>(nullable: true),
                    EstudianteId = table.Column<int>(nullable: false),
                    FechaAsistencia = table.Column<DateTime>(nullable: false),
                    GrupoId = table.Column<int>(nullable: false),
                    ProfesorId = table.Column<int>(nullable: false),
                    TipoPersonaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asistencia_Estudiantes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Asistencia_Estudiantes_Cursos_CursoId1",
                        column: x => x.CursoId1,
                        principalTable: "Cursos",
                        principalColumn: "CursoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Asistencia_Estudiantes_Grupos_GrupoId",
                        column: x => x.GrupoId,
                        principalTable: "Grupos",
                        principalColumn: "GrupoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Asistencia_Estudiantes_TipoPersona_TipoPersonaId",
                        column: x => x.TipoPersonaId,
                        principalTable: "TipoPersona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Asistencia_Profesores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Fecha_Ingreso = table.Column<DateTime>(nullable: false),
                    Fecha_Salida = table.Column<DateTime>(nullable: false),
                    ProfesorId = table.Column<int>(nullable: false),
                    TipoPersonaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asistencia_Profesores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Asistencia_Profesores_TipoPersona_TipoPersonaId",
                        column: x => x.TipoPersonaId,
                        principalTable: "TipoPersona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TipoPersona_Carreras",
                columns: table => new
                {
                    CarreraId = table.Column<int>(nullable: false),
                    TipoPersonaId = table.Column<int>(nullable: false),
                    CarrerasId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPersona_Carreras", x => new { x.CarreraId, x.TipoPersonaId });
                    table.ForeignKey(
                        name: "FK_TipoPersona_Carreras_Carreras_CarrerasId",
                        column: x => x.CarrerasId,
                        principalTable: "Carreras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TipoPersona_Carreras_TipoPersona_TipoPersonaId",
                        column: x => x.TipoPersonaId,
                        principalTable: "TipoPersona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Asistencia_Estudiantes_CursoId1",
                table: "Asistencia_Estudiantes",
                column: "CursoId1");

            migrationBuilder.CreateIndex(
                name: "IX_Asistencia_Estudiantes_GrupoId",
                table: "Asistencia_Estudiantes",
                column: "GrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_Asistencia_Estudiantes_TipoPersonaId",
                table: "Asistencia_Estudiantes",
                column: "TipoPersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Asistencia_Profesores_TipoPersonaId",
                table: "Asistencia_Profesores",
                column: "TipoPersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Carreras_Cursos_CarrerasId",
                table: "Carreras_Cursos",
                column: "CarrerasId");

            migrationBuilder.CreateIndex(
                name: "IX_Carreras_Cursos_CursoId1",
                table: "Carreras_Cursos",
                column: "CursoId1");

            migrationBuilder.CreateIndex(
                name: "IX_Cursos_CursoId1",
                table: "Cursos",
                column: "CursoId1");

            migrationBuilder.CreateIndex(
                name: "IX_Cursos_MatriculaId",
                table: "Cursos",
                column: "MatriculaId");

            migrationBuilder.CreateIndex(
                name: "IX_Grupos_CursoId1",
                table: "Grupos",
                column: "CursoId1");

            migrationBuilder.CreateIndex(
                name: "IX_Matricula_CarreraId",
                table: "Matricula",
                column: "CarreraId");

            migrationBuilder.CreateIndex(
                name: "IX_Matricula_PersonaId",
                table: "Matricula",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Rubros_CarreraId",
                table: "Rubros",
                column: "CarreraId");

            migrationBuilder.CreateIndex(
                name: "IX_Rubros_CursoId1",
                table: "Rubros",
                column: "CursoId1");

            migrationBuilder.CreateIndex(
                name: "IX_TipoPersona_CursoId",
                table: "TipoPersona",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_TipoPersona_PersonaId1",
                table: "TipoPersona",
                column: "PersonaId1");

            migrationBuilder.CreateIndex(
                name: "IX_TipoPersona_Carreras_CarrerasId",
                table: "TipoPersona_Carreras",
                column: "CarrerasId");

            migrationBuilder.CreateIndex(
                name: "IX_TipoPersona_Carreras_TipoPersonaId",
                table: "TipoPersona_Carreras",
                column: "TipoPersonaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Asistencia_Estudiantes");

            migrationBuilder.DropTable(
                name: "Asistencia_Profesores");

            migrationBuilder.DropTable(
                name: "Carreras_Cursos");

            migrationBuilder.DropTable(
                name: "Rubros");

            migrationBuilder.DropTable(
                name: "TipoPersona_Carreras");

            migrationBuilder.DropTable(
                name: "Grupos");

            migrationBuilder.DropTable(
                name: "TipoPersona");

            migrationBuilder.DropTable(
                name: "Cursos");

            migrationBuilder.DropTable(
                name: "Matricula");

            migrationBuilder.DropTable(
                name: "Carreras");

            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
