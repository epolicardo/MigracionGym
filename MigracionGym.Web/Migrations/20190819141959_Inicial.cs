using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MigracionGym.Web.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_AspNetUsers_usuarioId",
                table: "Productos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Provincias",
                table: "Provincias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Productos",
                table: "Productos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Localidades",
                table: "Localidades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Estados",
                table: "Estados");

            migrationBuilder.DropPrimaryKey(
                name: "PK_parametro",
                table: "parametro");

            migrationBuilder.RenameTable(
                name: "Provincias",
                newName: "provincias");

            migrationBuilder.RenameTable(
                name: "Productos",
                newName: "productos");

            migrationBuilder.RenameTable(
                name: "Localidades",
                newName: "localidades");

            migrationBuilder.RenameTable(
                name: "Estados",
                newName: "estados");

            migrationBuilder.RenameTable(
                name: "parametro",
                newName: "parametrosSistemas");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "provincias",
                newName: "nombre");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "provincias",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UltimaVenta",
                table: "productos",
                newName: "ultimaVenta");

            migrationBuilder.RenameColumn(
                name: "UltimaCompra",
                table: "productos",
                newName: "ultimaCompra");

            migrationBuilder.RenameColumn(
                name: "Precio",
                table: "productos",
                newName: "precio");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "productos",
                newName: "nombre");

            migrationBuilder.RenameColumn(
                name: "IsAvailable",
                table: "productos",
                newName: "isAvailable");

            migrationBuilder.RenameColumn(
                name: "ImageURL",
                table: "productos",
                newName: "imageURL");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "productos",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Stock",
                table: "productos",
                newName: "stockOptimo");

            migrationBuilder.RenameIndex(
                name: "IX_Productos_usuarioId",
                table: "productos",
                newName: "IX_productos_usuarioId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "localidades",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "localidades",
                newName: "nombre");

            migrationBuilder.RenameColumn(
                name: "Estado",
                table: "estados",
                newName: "estado");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "estados",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "AspNetUsers",
                newName: "nombre");

            migrationBuilder.RenameColumn(
                name: "Apellido",
                table: "AspNetUsers",
                newName: "apellido");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "parametrosSistemas",
                newName: "id");

            migrationBuilder.AddColumn<double>(
                name: "stockActual",
                table: "productos",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "stockMinimo",
                table: "productos",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_provincias",
                table: "provincias",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_productos",
                table: "productos",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_localidades",
                table: "localidades",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_estados",
                table: "estados",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_parametrosSistemas",
                table: "parametrosSistemas",
                column: "id");

            migrationBuilder.CreateTable(
                name: "actividades",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_actividades", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "actividadesSociosTurnos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_actividadesSociosTurnos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "clientes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "detalleComprobantes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detalleComprobantes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "domicilios",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    calle = table.Column<string>(nullable: true),
                    nro = table.Column<string>(nullable: true),
                    piso = table.Column<string>(nullable: true),
                    dpto = table.Column<string>(nullable: true),
                    barrio = table.Column<string>(nullable: true),
                    codigoPostal = table.Column<string>(nullable: true),
                    localidadid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_domicilios", x => x.id);
                    table.ForeignKey(
                        name: "FK_domicilios_localidades_localidadid",
                        column: x => x.localidadid,
                        principalTable: "localidades",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "entity",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_entity", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "estadoCivils",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estadoCivils", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "formaPagos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    codigo = table.Column<int>(nullable: false),
                    nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_formaPagos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gastos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    fecha = table.Column<DateTime>(nullable: false),
                    concepto = table.Column<string>(nullable: true),
                    importe = table.Column<decimal>(nullable: false),
                    tipo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gastos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "horarios",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_horarios", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "marcas",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_marcas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "personas",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(nullable: true),
                    apellido = table.Column<string>(nullable: true),
                    dni = table.Column<string>(nullable: true),
                    fechaNacimiento = table.Column<DateTime>(nullable: false),
                    lugarNacimientoid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personas", x => x.id);
                    table.ForeignKey(
                        name: "FK_personas_localidades_lugarNacimientoid",
                        column: x => x.lugarNacimientoid,
                        principalTable: "localidades",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "profesores",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_profesores", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "proveedores",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_proveedores", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "relaciones",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_relaciones", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "socios",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_socios", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ventas",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ventas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "asistencias",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    fecha = table.Column<DateTime>(nullable: false),
                    asistenciaid = table.Column<int>(nullable: true),
                    actividadid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asistencias", x => x.id);
                    table.ForeignKey(
                        name: "FK_asistencias_actividades_actividadid",
                        column: x => x.actividadid,
                        principalTable: "actividades",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_asistencias_asistencias_asistenciaid",
                        column: x => x.asistenciaid,
                        principalTable: "asistencias",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "cheques",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    clienteid = table.Column<int>(nullable: true),
                    banco = table.Column<string>(nullable: true),
                    plaza = table.Column<string>(nullable: true),
                    fechaCobro = table.Column<DateTime>(nullable: false),
                    importe = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cheques", x => x.id);
                    table.ForeignKey(
                        name: "FK_cheques_clientes_clienteid",
                        column: x => x.clienteid,
                        principalTable: "clientes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "comprobantes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    fechaEmision = table.Column<DateTime>(nullable: false),
                    nroComprobante = table.Column<int>(nullable: false),
                    detalleComprobantesid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comprobantes", x => x.id);
                    table.ForeignKey(
                        name: "FK_comprobantes_detalleComprobantes_detalleComprobantesid",
                        column: x => x.detalleComprobantesid,
                        principalTable: "detalleComprobantes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "cajaDiarias",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    fecha = table.Column<DateTime>(nullable: false),
                    categoria = table.Column<int>(nullable: false),
                    concepto = table.Column<string>(nullable: true),
                    formaPagoid = table.Column<int>(nullable: true),
                    debe = table.Column<float>(nullable: false),
                    haber = table.Column<decimal>(nullable: false),
                    saldo = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cajaDiarias", x => x.id);
                    table.ForeignKey(
                        name: "FK_cajaDiarias_formaPagos_formaPagoid",
                        column: x => x.formaPagoid,
                        principalTable: "formaPagos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "registroCuotas",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    fecha = table.Column<DateTime>(nullable: false),
                    importe = table.Column<decimal>(nullable: false),
                    observaciones = table.Column<string>(nullable: true),
                    formaPagoid = table.Column<int>(nullable: true),
                    socioid = table.Column<int>(nullable: true),
                    vencimientoAbonado = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_registroCuotas", x => x.id);
                    table.ForeignKey(
                        name: "FK_registroCuotas_formaPagos_formaPagoid",
                        column: x => x.formaPagoid,
                        principalTable: "formaPagos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_registroCuotas_socios_socioid",
                        column: x => x.socioid,
                        principalTable: "socios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "compras",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    fecha = table.Column<DateTime>(nullable: false),
                    cantItem = table.Column<int>(nullable: false),
                    formaPagoid = table.Column<int>(nullable: true),
                    comprobantesid = table.Column<int>(nullable: true),
                    importeTotal = table.Column<decimal>(nullable: false),
                    proveedoresid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_compras", x => x.id);
                    table.ForeignKey(
                        name: "FK_compras_comprobantes_comprobantesid",
                        column: x => x.comprobantesid,
                        principalTable: "comprobantes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_compras_formaPagos_formaPagoid",
                        column: x => x.formaPagoid,
                        principalTable: "formaPagos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_compras_proveedores_proveedoresid",
                        column: x => x.proveedoresid,
                        principalTable: "proveedores",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_asistencias_actividadid",
                table: "asistencias",
                column: "actividadid");

            migrationBuilder.CreateIndex(
                name: "IX_asistencias_asistenciaid",
                table: "asistencias",
                column: "asistenciaid");

            migrationBuilder.CreateIndex(
                name: "IX_cajaDiarias_formaPagoid",
                table: "cajaDiarias",
                column: "formaPagoid");

            migrationBuilder.CreateIndex(
                name: "IX_cheques_clienteid",
                table: "cheques",
                column: "clienteid");

            migrationBuilder.CreateIndex(
                name: "IX_compras_comprobantesid",
                table: "compras",
                column: "comprobantesid");

            migrationBuilder.CreateIndex(
                name: "IX_compras_formaPagoid",
                table: "compras",
                column: "formaPagoid");

            migrationBuilder.CreateIndex(
                name: "IX_compras_proveedoresid",
                table: "compras",
                column: "proveedoresid");

            migrationBuilder.CreateIndex(
                name: "IX_comprobantes_detalleComprobantesid",
                table: "comprobantes",
                column: "detalleComprobantesid");

            migrationBuilder.CreateIndex(
                name: "IX_domicilios_localidadid",
                table: "domicilios",
                column: "localidadid");

            migrationBuilder.CreateIndex(
                name: "IX_personas_lugarNacimientoid",
                table: "personas",
                column: "lugarNacimientoid");

            migrationBuilder.CreateIndex(
                name: "IX_registroCuotas_formaPagoid",
                table: "registroCuotas",
                column: "formaPagoid");

            migrationBuilder.CreateIndex(
                name: "IX_registroCuotas_socioid",
                table: "registroCuotas",
                column: "socioid");

            migrationBuilder.AddForeignKey(
                name: "FK_productos_AspNetUsers_usuarioId",
                table: "productos",
                column: "usuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_productos_AspNetUsers_usuarioId",
                table: "productos");

            migrationBuilder.DropTable(
                name: "actividadesSociosTurnos");

            migrationBuilder.DropTable(
                name: "asistencias");

            migrationBuilder.DropTable(
                name: "cajaDiarias");

            migrationBuilder.DropTable(
                name: "cheques");

            migrationBuilder.DropTable(
                name: "compras");

            migrationBuilder.DropTable(
                name: "domicilios");

            migrationBuilder.DropTable(
                name: "entity");

            migrationBuilder.DropTable(
                name: "estadoCivils");

            migrationBuilder.DropTable(
                name: "gastos");

            migrationBuilder.DropTable(
                name: "horarios");

            migrationBuilder.DropTable(
                name: "marcas");

            migrationBuilder.DropTable(
                name: "personas");

            migrationBuilder.DropTable(
                name: "profesores");

            migrationBuilder.DropTable(
                name: "registroCuotas");

            migrationBuilder.DropTable(
                name: "relaciones");

            migrationBuilder.DropTable(
                name: "ventas");

            migrationBuilder.DropTable(
                name: "actividades");

            migrationBuilder.DropTable(
                name: "clientes");

            migrationBuilder.DropTable(
                name: "comprobantes");

            migrationBuilder.DropTable(
                name: "proveedores");

            migrationBuilder.DropTable(
                name: "formaPagos");

            migrationBuilder.DropTable(
                name: "socios");

            migrationBuilder.DropTable(
                name: "detalleComprobantes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_provincias",
                table: "provincias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_productos",
                table: "productos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_localidades",
                table: "localidades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_estados",
                table: "estados");

            migrationBuilder.DropPrimaryKey(
                name: "PK_parametrosSistemas",
                table: "parametrosSistemas");

            migrationBuilder.DropColumn(
                name: "stockActual",
                table: "productos");

            migrationBuilder.DropColumn(
                name: "stockMinimo",
                table: "productos");

            migrationBuilder.RenameTable(
                name: "provincias",
                newName: "Provincias");

            migrationBuilder.RenameTable(
                name: "productos",
                newName: "Productos");

            migrationBuilder.RenameTable(
                name: "localidades",
                newName: "Localidades");

            migrationBuilder.RenameTable(
                name: "estados",
                newName: "Estados");

            migrationBuilder.RenameTable(
                name: "parametrosSistemas",
                newName: "parametro");

            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "Provincias",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Provincias",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ultimaVenta",
                table: "Productos",
                newName: "UltimaVenta");

            migrationBuilder.RenameColumn(
                name: "ultimaCompra",
                table: "Productos",
                newName: "UltimaCompra");

            migrationBuilder.RenameColumn(
                name: "precio",
                table: "Productos",
                newName: "Precio");

            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "Productos",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "isAvailable",
                table: "Productos",
                newName: "IsAvailable");

            migrationBuilder.RenameColumn(
                name: "imageURL",
                table: "Productos",
                newName: "ImageURL");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Productos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "stockOptimo",
                table: "Productos",
                newName: "Stock");

            migrationBuilder.RenameIndex(
                name: "IX_productos_usuarioId",
                table: "Productos",
                newName: "IX_Productos_usuarioId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Localidades",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "Localidades",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "estado",
                table: "Estados",
                newName: "Estado");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Estados",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "AspNetUsers",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "apellido",
                table: "AspNetUsers",
                newName: "Apellido");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "parametro",
                newName: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Provincias",
                table: "Provincias",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Productos",
                table: "Productos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Localidades",
                table: "Localidades",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Estados",
                table: "Estados",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_parametro",
                table: "parametro",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_AspNetUsers_usuarioId",
                table: "Productos",
                column: "usuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
