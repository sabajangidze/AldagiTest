using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClientName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ClientCode = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    ContrAgentType = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    ClientType = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PolicyDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SchedulePay = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    PaymentLeft = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    Source = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SellSegment = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    OldPolicyNumber = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CurrentPaid = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: true),
                    CancellDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LossCount = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: true),
                    PaidLoss = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: true),
                    Rateprojected = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: true),
                    ArchiveStatus = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PolicyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolicyDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Schemes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schemes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Licenses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Percent = table.Column<double>(type: "float", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    CascoType = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    TravelProduct = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SchemeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Licenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Licenses_Schemes_SchemeId",
                        column: x => x.SchemeId,
                        principalTable: "Schemes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Policies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PolicyNumber = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EventDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsLoss = table.Column<bool>(type: "bit", nullable: false),
                    PremiumCurrency = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LimitCurrency = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CurName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    SumInsured = table.Column<decimal>(type: "decimal(10,2)", maxLength: 25, precision: 10, scale: 2, nullable: false),
                    Intallment = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    EventOrderNo = table.Column<int>(type: "int", nullable: false),
                    PayType = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Comission = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Segment = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SellSpot = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LicenseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PolicyDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Policies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Policies_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Policies_Licenses_LicenseId",
                        column: x => x.LicenseId,
                        principalTable: "Licenses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Policies_PolicyDetails_PolicyDetailId",
                        column: x => x.PolicyDetailId,
                        principalTable: "PolicyDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Hierarchy = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LicenseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Roles_Licenses_LicenseId",
                        column: x => x.LicenseId,
                        principalTable: "Licenses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PolicyScheme",
                columns: table => new
                {
                    PoliciesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SchemesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolicyScheme", x => new { x.PoliciesId, x.SchemesId });
                    table.ForeignKey(
                        name: "FK_PolicyScheme_Policies_PoliciesId",
                        column: x => x.PoliciesId,
                        principalTable: "Policies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PolicyScheme_Schemes_SchemesId",
                        column: x => x.SchemesId,
                        principalTable: "Schemes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PersonalId = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    AccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsEmployee = table.Column<bool>(type: "bit", nullable: false),
                    IsTaxPayer = table.Column<bool>(type: "bit", nullable: false),
                    IsPensioPayer = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Plans",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClientType = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LicenseId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Plans_Licenses_LicenseId",
                        column: x => x.LicenseId,
                        principalTable: "Licenses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Plans_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PolicyUser",
                columns: table => new
                {
                    PoliciesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolicyUser", x => new { x.PoliciesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_PolicyUser_Policies_PoliciesId",
                        column: x => x.PoliciesId,
                        principalTable: "Policies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PolicyUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SchemeUser",
                columns: table => new
                {
                    SchemesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchemeUser", x => new { x.SchemesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_SchemeUser_Schemes_SchemesId",
                        column: x => x.SchemesId,
                        principalTable: "Schemes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SchemeUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnnualPlans",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Month = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PlanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnnualPlans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnnualPlans_Plans_PlanId",
                        column: x => x.PlanId,
                        principalTable: "Plans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnnualPlans_PlanId",
                table: "AnnualPlans",
                column: "PlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Licenses_SchemeId",
                table: "Licenses",
                column: "SchemeId");

            migrationBuilder.CreateIndex(
                name: "IX_Plans_LicenseId",
                table: "Plans",
                column: "LicenseId");

            migrationBuilder.CreateIndex(
                name: "IX_Plans_UserId",
                table: "Plans",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Policies_ClientId",
                table: "Policies",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Policies_LicenseId",
                table: "Policies",
                column: "LicenseId");

            migrationBuilder.CreateIndex(
                name: "IX_Policies_PolicyDetailId",
                table: "Policies",
                column: "PolicyDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PolicyScheme_SchemesId",
                table: "PolicyScheme",
                column: "SchemesId");

            migrationBuilder.CreateIndex(
                name: "IX_PolicyUser_UsersId",
                table: "PolicyUser",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_LicenseId",
                table: "Roles",
                column: "LicenseId");

            migrationBuilder.CreateIndex(
                name: "IX_SchemeUser_UsersId",
                table: "SchemeUser",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnnualPlans");

            migrationBuilder.DropTable(
                name: "PolicyScheme");

            migrationBuilder.DropTable(
                name: "PolicyUser");

            migrationBuilder.DropTable(
                name: "SchemeUser");

            migrationBuilder.DropTable(
                name: "Plans");

            migrationBuilder.DropTable(
                name: "Policies");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "PolicyDetails");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Licenses");

            migrationBuilder.DropTable(
                name: "Schemes");
        }
    }
}
