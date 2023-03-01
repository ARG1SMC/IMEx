using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IMExApi.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Businesses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Businesses", x => x.Id);
                    table.UniqueConstraint("Business_Description", x => x.Description);
                    table.UniqueConstraint("Business_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Coordinates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coordinates", x => x.Id);
                    table.UniqueConstraint("Coordinate_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Disciplines",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disciplines", x => x.Id);
                    table.UniqueConstraint("Discipline_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "ElectricalRatings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectricalRatings", x => x.Id);
                    table.UniqueConstraint("ElectricalRating_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Fields",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fields", x => x.Id);
                    table.UniqueConstraint("Field_Description", x => x.Description);
                    table.UniqueConstraint("Field_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "HACDwgNos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HACDwgNos", x => x.Id);
                    table.UniqueConstraint("HACDwgNo_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "IECExCertificateAuthorities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IECExCertificateAuthorities", x => x.Id);
                    table.UniqueConstraint("IECExCertificateAuthority_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "IECExCertificateCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IECExCertificateCategories", x => x.Id);
                    table.UniqueConstraint("IECExCertificateCategory_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "IECExCertificateDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    No = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IECExCertificateDetails", x => x.Id);
                    table.UniqueConstraint("IECExCertificateDetail_Name", x => x.No);
                });

            migrationBuilder.CreateTable(
                name: "IECExCertificateNos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    No = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IECExCertificateNos", x => x.Id);
                    table.UniqueConstraint("IECExCertificateNo_No", x => x.No);
                });

            migrationBuilder.CreateTable(
                name: "InspectionTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InspectionTypes", x => x.Id);
                    table.UniqueConstraint("InspectionType_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "LocationOnes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationOnes", x => x.Id);
                    table.UniqueConstraint("LocationOne_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "LocationTwos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationTwos", x => x.Id);
                    table.UniqueConstraint("LocationTwo_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.Id);
                    table.UniqueConstraint("Manufacturer_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Models",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models", x => x.Id);
                    table.UniqueConstraint("Model_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Platforms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platforms", x => x.Id);
                    table.UniqueConstraint("Platform_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "ProtectionTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProtectionTypes", x => x.Id);
                    table.UniqueConstraint("ProtectionType_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Purposes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purposes", x => x.Id);
                    table.UniqueConstraint("Purpose_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.Id);
                    table.UniqueConstraint("Region_Description", x => x.Description);
                    table.UniqueConstraint("Region_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Risks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Risks", x => x.Id);
                    table.UniqueConstraint("Risk_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                    table.UniqueConstraint("Role_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "SerialNos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(90)", maxLength: 90, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SerialNos", x => x.Id);
                    table.UniqueConstraint("SerialNo_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Zones",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zones", x => x.Id);
                    table.UniqueConstraint("Zone_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "OPUs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdBusiness = table.Column<Guid>(name: "Id_Business", type: "uniqueidentifier", nullable: false),
                    IdRegion = table.Column<Guid>(name: "Id_Region", type: "uniqueidentifier", nullable: false),
                    IdField = table.Column<Guid>(name: "Id_Field", type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPUs", x => x.Id);
                    table.UniqueConstraint("AK_OPUs_Id_Business_Id_Region_Id_Field", x => new { x.IdBusiness, x.IdRegion, x.IdField });
                    table.ForeignKey(
                        name: "FK_OPUs_Businesses_Id_Business",
                        column: x => x.IdBusiness,
                        principalTable: "Businesses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OPUs_Fields_Id_Field",
                        column: x => x.IdField,
                        principalTable: "Fields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OPUs_Regions_Id_Region",
                        column: x => x.IdRegion,
                        principalTable: "Regions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Equipments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdOPU = table.Column<Guid>(name: "Id_OPU", type: "uniqueidentifier", nullable: false),
                    IdPlatform = table.Column<Guid>(name: "Id_Platform", type: "uniqueidentifier", nullable: false),
                    IdLocationOne = table.Column<Guid>(name: "Id_LocationOne", type: "uniqueidentifier", nullable: false),
                    IdLocationTwo = table.Column<Guid>(name: "Id_LocationTwo", type: "uniqueidentifier", nullable: false),
                    IdHACDwgNo = table.Column<Guid>(name: "Id_HACDwgNo", type: "uniqueidentifier", nullable: false),
                    IdCoordinate = table.Column<Guid>(name: "Id_Coordinate", type: "uniqueidentifier", nullable: false),
                    IdZone = table.Column<Guid>(name: "Id_Zone", type: "uniqueidentifier", nullable: false),
                    IdPurpose = table.Column<Guid>(name: "Id_Purpose", type: "uniqueidentifier", nullable: false),
                    IdManufacturer = table.Column<Guid>(name: "Id_Manufacturer", type: "uniqueidentifier", nullable: false),
                    IdModel = table.Column<Guid>(name: "Id_Model", type: "uniqueidentifier", nullable: false),
                    IdSerialNo = table.Column<Guid>(name: "Id_SerialNo", type: "uniqueidentifier", nullable: false),
                    IdIECExCertificateAuthority = table.Column<Guid>(name: "Id_IECExCertificateAuthority", type: "uniqueidentifier", nullable: false),
                    IdIECExCertificateCategory = table.Column<Guid>(name: "Id_IECExCertificateCategory", type: "uniqueidentifier", nullable: false),
                    IdIECExCertificateNo = table.Column<Guid>(name: "Id_IECExCertificateNo", type: "uniqueidentifier", nullable: false),
                    IdIECExCertificateDetail = table.Column<Guid>(name: "Id_IECExCertificateDetail", type: "uniqueidentifier", nullable: false),
                    IdElectricalRating = table.Column<Guid>(name: "Id_ElectricalRating", type: "uniqueidentifier", nullable: false),
                    IdDiscipline = table.Column<Guid>(name: "Id_Discipline", type: "uniqueidentifier", nullable: false),
                    IdProtectionType = table.Column<Guid>(name: "Id_ProtectionType", type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TagNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IdCreatedBy = table.Column<Guid>(name: "Id_CreatedBy", type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUpdatedBy = table.Column<Guid>(name: "Id_UpdatedBy", type: "uniqueidentifier", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdDeletedBy = table.Column<Guid>(name: "Id_DeletedBy", type: "uniqueidentifier", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipments", x => x.Id);
                    table.UniqueConstraint("TagNo", x => x.TagNo);
                    table.ForeignKey(
                        name: "FK_Equipments_Coordinates_Id_Coordinate",
                        column: x => x.IdCoordinate,
                        principalTable: "Coordinates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipments_Disciplines_Id_Discipline",
                        column: x => x.IdDiscipline,
                        principalTable: "Disciplines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipments_ElectricalRatings_Id_ElectricalRating",
                        column: x => x.IdElectricalRating,
                        principalTable: "ElectricalRatings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipments_HACDwgNos_Id_HACDwgNo",
                        column: x => x.IdHACDwgNo,
                        principalTable: "HACDwgNos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipments_IECExCertificateAuthorities_Id_IECExCertificateAuthority",
                        column: x => x.IdIECExCertificateAuthority,
                        principalTable: "IECExCertificateAuthorities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipments_IECExCertificateCategories_Id_IECExCertificateCategory",
                        column: x => x.IdIECExCertificateCategory,
                        principalTable: "IECExCertificateCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipments_IECExCertificateDetails_Id_IECExCertificateDetail",
                        column: x => x.IdIECExCertificateDetail,
                        principalTable: "IECExCertificateDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipments_IECExCertificateNos_Id_IECExCertificateNo",
                        column: x => x.IdIECExCertificateNo,
                        principalTable: "IECExCertificateNos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipments_LocationOnes_Id_LocationOne",
                        column: x => x.IdLocationOne,
                        principalTable: "LocationOnes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipments_LocationTwos_Id_LocationTwo",
                        column: x => x.IdLocationTwo,
                        principalTable: "LocationTwos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipments_Manufacturers_Id_Manufacturer",
                        column: x => x.IdManufacturer,
                        principalTable: "Manufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipments_Models_Id_Model",
                        column: x => x.IdModel,
                        principalTable: "Models",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipments_OPUs_Id_OPU",
                        column: x => x.IdOPU,
                        principalTable: "OPUs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipments_Platforms_Id_Platform",
                        column: x => x.IdPlatform,
                        principalTable: "Platforms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipments_ProtectionTypes_Id_ProtectionType",
                        column: x => x.IdProtectionType,
                        principalTable: "ProtectionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipments_Purposes_Id_Purpose",
                        column: x => x.IdPurpose,
                        principalTable: "Purposes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipments_SerialNos_Id_SerialNo",
                        column: x => x.IdSerialNo,
                        principalTable: "SerialNos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipments_Zones_Id_Zone",
                        column: x => x.IdZone,
                        principalTable: "Zones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdOPU = table.Column<Guid>(name: "Id_OPU", type: "uniqueidentifier", nullable: false),
                    IdRole = table.Column<Guid>(name: "Id_Role", type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    UserPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateValidStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateValidEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IdCreatedBy = table.Column<Guid>(name: "Id_CreatedBy", type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUpdatedBy = table.Column<Guid>(name: "Id_UpdatedBy", type: "uniqueidentifier", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdDeletedBy = table.Column<Guid>(name: "Id_DeletedBy", type: "uniqueidentifier", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.UniqueConstraint("User_LastName", x => x.LastName);
                    table.UniqueConstraint("User_UserName", x => x.UserName);
                    table.ForeignKey(
                        name: "FK_Users_OPUs_Id_OPU",
                        column: x => x.IdOPU,
                        principalTable: "OPUs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_Roles_Id_Role",
                        column: x => x.IdRole,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inspections",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdOPU = table.Column<Guid>(name: "Id_OPU", type: "uniqueidentifier", nullable: false),
                    IdPlatform = table.Column<Guid>(name: "Id_Platform", type: "uniqueidentifier", nullable: false),
                    IdDiscipline = table.Column<Guid>(name: "Id_Discipline", type: "uniqueidentifier", nullable: false),
                    IdUser = table.Column<Guid>(name: "Id_User", type: "uniqueidentifier", nullable: false),
                    IdInspectionType = table.Column<Guid>(name: "Id_InspectionType", type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DateInspectionStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateInspectionEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IdCreatedBy = table.Column<Guid>(name: "Id_CreatedBy", type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUpdatedBy = table.Column<Guid>(name: "Id_UpdatedBy", type: "uniqueidentifier", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdDeletedBy = table.Column<Guid>(name: "Id_DeletedBy", type: "uniqueidentifier", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inspections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inspections_Disciplines_Id_Discipline",
                        column: x => x.IdDiscipline,
                        principalTable: "Disciplines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inspections_InspectionTypes_Id_InspectionType",
                        column: x => x.IdInspectionType,
                        principalTable: "InspectionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inspections_OPUs_Id_OPU",
                        column: x => x.IdOPU,
                        principalTable: "OPUs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inspections_Platforms_Id_Platform",
                        column: x => x.IdPlatform,
                        principalTable: "Platforms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inspections_Users_Id_User",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "InspectionEquipment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdInspection = table.Column<Guid>(name: "Id_Inspection", type: "uniqueidentifier", nullable: false),
                    IdRisk = table.Column<Guid>(name: "Id_Risk", type: "uniqueidentifier", nullable: false),
                    OPU = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Platform = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LocationOne = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LocationTwo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    HACDwgNo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Coordinate = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Zone = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Purpose = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SerialNo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IECExCertificateAuthority = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IECExCertificateCategory = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IECExCertificateNo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IECExCertificateDetail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ElectricalRating = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Discipline = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ProtectionType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TagNo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IdCreatedBy = table.Column<Guid>(name: "Id_CreatedBy", type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUpdatedBy = table.Column<Guid>(name: "Id_UpdatedBy", type: "uniqueidentifier", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdDeletedBy = table.Column<Guid>(name: "Id_DeletedBy", type: "uniqueidentifier", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InspectionEquipment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InspectionEquipment_Inspections_Id_Inspection",
                        column: x => x.IdInspection,
                        principalTable: "Inspections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InspectionEquipment_Risks_Id_Risk",
                        column: x => x.IdRisk,
                        principalTable: "Risks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("09d96c70-294e-486f-8fb0-624983bcef62"), "PD&T Business", "PD&T" },
                    { new Guid("b42742a6-9a0a-4458-8d74-953874576182"), "Upstream Business", "Upstream" },
                    { new Guid("d9817472-69ee-45ff-b4d9-e7682a8f5c42"), "Gas Business", "Gas" },
                    { new Guid("f57dd90c-8787-4e02-97a9-2a2be301692b"), "Downstream Business", "Downstream" }
                });

            migrationBuilder.InsertData(
                table: "Coordinates",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("938704b5-ae75-40c4-b696-8b102d5a15ae"), "-" },
                    { new Guid("ed5d5d3f-819b-4da3-82f4-19a5dc5eba7d"), "A:1" }
                });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("ac1f5b06-1699-4673-9db8-77f4ea3dd0e8"), "Electrical" });

            migrationBuilder.InsertData(
                table: "ElectricalRatings",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("7cbbc8ca-5779-45c0-a08e-24c6bf8240f6"), "30 VDC 200mA" },
                    { new Guid("938704b5-ae75-40c4-b696-8b102d5a15ae"), "-" }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("0dfdce65-2877-4164-b701-706dc388ec46"), "TGAST Field or Plant", "TGAST" },
                    { new Guid("0ead361b-8bc3-4359-a0e2-05fd27ff6dbc"), "GPP Field or Plant", "GPP" },
                    { new Guid("1134b649-480f-4903-acd4-3a54007b1b23"), "RGTSU Field or Plant", "RGTSU" },
                    { new Guid("126b799f-2cf5-4225-a58d-bdb3731a8a64"), "MLNG Satu Field or Plant", "MLNG Satu" },
                    { new Guid("14c1d824-6155-486f-bdc1-b953a3fb8cfb"), "NC3 Field or Plant", "NC3" },
                    { new Guid("15b9727e-04e1-40c0-b5d2-fb75538e84ed"), "UG Field or Plant", "UG" },
                    { new Guid("2230a41f-5200-4c9e-aa85-5d9bbfed8fc6"), "Baram Field or Plant", "Baram" },
                    { new Guid("23e5527b-d159-46c6-bff7-981ad8651d33"), "PCFK Field or Plant", "PCFK" },
                    { new Guid("254c3a4b-91a1-4077-b89c-757fc69f5910"), "B11 Field or Plant", "B11" },
                    { new Guid("34da4cab-21f5-46bd-b1a2-d8057c0e6b9f"), "UK Field or Plant", "UK" },
                    { new Guid("37927c4f-c9e1-4d92-8b84-09bea547a030"), "MCOT Field or Plant", "MCOT" },
                    { new Guid("467bb9f9-0b77-4987-a530-badcc66be8f5"), "PCMTBE Field or Plant", "PCMTBE" },
                    { new Guid("4a270199-5870-4828-8d7e-2f7ef168d0c4"), "PCEPE Field or Plant", "PCEPE" },
                    { new Guid("50bc7979-4f5e-4cae-87a0-dfd669fb7d46"), "MLNG Tiga Field or Plant", "MLNG Tiga" },
                    { new Guid("5f08d260-2ec0-442b-82e5-33294a46b712"), "RGTP Field or Plant", "RGTP" },
                    { new Guid("6be3a4fd-24a0-4458-9c7d-dd474210b9ec"), "PFLNG1 Field or Plant", "PFLNG1" },
                    { new Guid("6c170d60-884b-422d-b62b-d533dfa97429"), "TCOT Field or Plant", "TCOT" },
                    { new Guid("70baf381-8c58-4e70-b2d9-734764144f6e"), "West Lutong Field or Plant", "West Lutong" },
                    { new Guid("768b2aae-0db8-4cc0-98ad-bf936db2c2f3"), "PFLNG2 Field or Plant", "PFLNG2" },
                    { new Guid("854b8a3b-9c8b-4187-88bf-8967c5a474b2"), "PCOGD Field or Plant", "PCOGD" },
                    { new Guid("87a61711-b6f7-422b-a1f0-82662bb25077"), "Duyong Field or Plant", "Duyong" },
                    { new Guid("8eaccad3-d2aa-4de1-8b26-601d4a912bad"), "Terminal 1 Field or Plant", "Terminal 1" },
                    { new Guid("8f4a8ace-bb24-47f3-9315-604178147aac"), "PIC1 Field or Plant", "PIC1" },
                    { new Guid("8fe930c9-fdf4-4b9b-a2f0-de164b83b5fb"), "KAKG Field or Plant", "KAKG" },
                    { new Guid("9e12080d-f771-41b3-953a-fb6c606775d4"), "PPT Field or Plant", "PPT" },
                    { new Guid("b189b3ed-c6f8-4c49-8b2c-3f5d4dd4a3f6"), "Angsi Field or Plant", "Angsi" },
                    { new Guid("b4efc45c-5349-4c82-9061-5103bb9993b0"), "MRC Field or Plant", "MRC" },
                    { new Guid("b69125e2-89cc-4d96-9db4-9ca9297da146"), "Bayan Field or Plant", "Bayan" },
                    { new Guid("b92ddde2-acdc-40d2-8195-f190f19070ad"), "Kinabalu Field or Plant", "Kinabalu" },
                    { new Guid("ba0c4a91-bdb8-4272-b732-c0817b4f4444"), "PCML Field or Plant", "PCML" },
                    { new Guid("c4d97318-7207-4461-b6d9-0b637c71e091"), "GST1 Field or Plant", "GST1" },
                    { new Guid("c658389e-f146-452f-a7bd-ac90eb42b25d"), "E11 Field or Plant", "E11" },
                    { new Guid("c8ed8f67-cda6-411f-8532-b3559e284448"), "SBGAST Field or Plant", "SBGAST" },
                    { new Guid("d2380672-dd44-49a9-b9a9-3ac0185af368"), "Tangga Barat Field or Plant", "Tangga Barat" },
                    { new Guid("d38692cd-4d6f-4aee-bb32-7dd9a9374244"), "Resak Field or Plant", "Resak" },
                    { new Guid("d6b3ca8d-81d9-44ec-9caf-59a1a0a76254"), "Erb West Field or Plant", "Erb West" },
                    { new Guid("d74fb67e-118f-4a4a-9462-ac85f22106fe"), "MLNG Dua Field or Plant", "MLNG Dua" },
                    { new Guid("d9c7b872-c002-49e8-85ef-14db7a9ca88d"), "Bekok Field or Plant", "Bekok" },
                    { new Guid("e24764d0-3c76-4630-b801-a05ac6a14d1b"), "PRSB Field or Plant", "PRSB" },
                    { new Guid("e7790052-4521-4689-967e-02c2cfc2509a"), "PCLDPE & Ammonia Field or Plant", "PCLDPE & Ammonia" },
                    { new Guid("eed15056-0ce9-4d99-a347-2b88a95e6a9f"), "M1 Field or Plant", "M1" },
                    { new Guid("f156ee0d-d80b-4fb8-8143-56537f8d2520"), "Sumandak Field or Plant", "Sumandak" },
                    { new Guid("fa52eeb7-e89a-45e3-be2c-ff8181b35a23"), "Tiong Field or Plant", "Tiong" },
                    { new Guid("fe9b6b9b-d3e2-40ce-b665-fab93016d274"), "Train 9 Field or Plant", "Train 9" }
                });

            migrationBuilder.InsertData(
                table: "HACDwgNos",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0a5567e3-a8ad-4c3d-a6d5-23996ac27c68"), "BAKP-B-X-0010-0 Rev.0" },
                    { new Guid("1253eedb-95c4-4725-af4c-c664ea9afd57"), "BAKP-B-X-0013-0 Rev.0" },
                    { new Guid("44e41f78-c4a1-4874-919b-7161c9582412"), "BAKP-B-X-0014-0 Rev.Z1" },
                    { new Guid("796557ad-12b6-4bd5-a3d8-902c288bdc78"), "BAKP-B-X-0011-0 Rev.0" },
                    { new Guid("938704b5-ae75-40c4-b696-8b102d5a15ae"), "-" },
                    { new Guid("94983962-7f6a-41b9-95c7-1cf1b28a9b6e"), "BAKP-B-X-0012-0 Rev.0" }
                });

            migrationBuilder.InsertData(
                table: "IECExCertificateAuthorities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("938704b5-ae75-40c4-b696-8b102d5a15ae"), "-" },
                    { new Guid("c93078e3-7067-4493-a5ad-0a312731bae9"), "PTB" }
                });

            migrationBuilder.InsertData(
                table: "IECExCertificateCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("938704b5-ae75-40c4-b696-8b102d5a15ae"), "-" },
                    { new Guid("bec84a12-db91-4cb9-999e-bdf44e74e109"), "Component Cert" }
                });

            migrationBuilder.InsertData(
                table: "IECExCertificateDetails",
                columns: new[] { "Id", "No" },
                values: new object[,]
                {
                    { new Guid("0ee93cef-fd02-4232-aefa-d4b82b651421"), "Det-01" },
                    { new Guid("938704b5-ae75-40c4-b696-8b102d5a15ae"), "-" }
                });

            migrationBuilder.InsertData(
                table: "IECExCertificateNos",
                columns: new[] { "Id", "No" },
                values: new object[,]
                {
                    { new Guid("938704b5-ae75-40c4-b696-8b102d5a15ae"), "-" },
                    { new Guid("db02b94f-6fcf-40ee-8fb4-7da02c74c1b6"), "PTB 02ATEX 3068" }
                });

            migrationBuilder.InsertData(
                table: "InspectionTypes",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("03b223f8-58f5-442a-abf8-4540b4067634"), "Risk-Based Inspection", "Risk-Based Inspection" },
                    { new Guid("11497dcb-0010-408a-b175-b550ba8a421a"), "Initial Inspection", "Initial Inspection" },
                    { new Guid("2afe51d9-2270-4992-8a5f-bf95e002798b"), "Sample Inspection", "Sample Inspection" },
                    { new Guid("7b4413a2-67a3-4a31-843a-b574ce581ddc"), "Full Inspection", "Full Inspection" }
                });

            migrationBuilder.InsertData(
                table: "LocationOnes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("335529ad-04c4-4934-a319-9c3e2d428c02"), "R-301" },
                    { new Guid("938704b5-ae75-40c4-b696-8b102d5a15ae"), "-" }
                });

            migrationBuilder.InsertData(
                table: "LocationTwos",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("938704b5-ae75-40c4-b696-8b102d5a15ae"), "-" },
                    { new Guid("a64c5cab-964f-4c37-9629-d9e35671bc81"), "A-2900" }
                });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("03ddb1e6-7510-46ec-af6a-c4bef07efb02"), "SIEMENS" },
                    { new Guid("938704b5-ae75-40c4-b696-8b102d5a15ae"), "-" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2160fa79-a8d4-4ed0-9583-92bbd572726c"), "IMA6 223-4DC69-Z" },
                    { new Guid("938704b5-ae75-40c4-b696-8b102d5a15ae"), "-" }
                });

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("060128ee-e126-494d-979f-767f203f11a4"), "BAKP-B" });

            migrationBuilder.InsertData(
                table: "ProtectionTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("33bf41bf-8b76-4057-8f51-a8c6ef51c346"), "ex a" },
                    { new Guid("7fbf3205-4bc8-4622-ad4e-f85b4d3c0098"), "ex b" },
                    { new Guid("c21f5c15-addc-4d0b-b273-0c34dfd04504"), "ex c" },
                    { new Guid("d63f18b9-c184-4a3d-a6b2-4acd8846b4fa"), "ex d" },
                    { new Guid("e045fb56-ffae-4e57-b6bf-0b267739c765"), "ex e" }
                });

            migrationBuilder.InsertData(
                table: "Purposes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("274ab1b4-75fc-4a71-babf-fb8101a2634b"), "Motor" },
                    { new Guid("938704b5-ae75-40c4-b696-8b102d5a15ae"), "-" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("054a0a4d-4cc1-4449-9904-e10a80becae0"), "GST Region or Segment", "GST" },
                    { new Guid("0ab107a0-d483-4aa0-a451-7ea62a965975"), "Refinery Region or Segment", "Refinery" },
                    { new Guid("1b019d73-2b4b-468c-a539-242a1bd4917f"), "Petrochemical Region or Segment", "Petrochemical" },
                    { new Guid("29e8d7f6-dc93-4c1a-b419-324f4df84c4c"), "PGB Region or Segment", "PGB" },
                    { new Guid("2b394efe-04c4-460d-937f-6457da94d673"), "MLNG Region or Segment", "MLNG" },
                    { new Guid("45946328-7a29-4731-abfa-a33aea03ed00"), "SKA Region or Segment", "SKA" },
                    { new Guid("543687a8-b584-4d46-a692-2d0b6607a9b0"), "PDB Region or Segment", "PDB" },
                    { new Guid("5c35ccd2-aac8-4b6d-980a-d580766a05a3"), "SBA Region or Segment", "SBA" },
                    { new Guid("67566a97-babe-492c-a14d-0f4b103861d9"), "PIC Region or Segment", "PIC" },
                    { new Guid("7352acb6-9e0d-4919-9f88-36798c487d86"), "PFLNG Satu Region or Segment", "PFLNG Satu" },
                    { new Guid("85617285-d381-4070-be9c-2e0e924d65e0"), "GR&T Region or Segment", "GR&T" },
                    { new Guid("c202adf7-9b3b-429f-b79e-00498235eb0c"), "PMA PlRegion or Segmentant", "PMA" },
                    { new Guid("c2b96baf-1596-467f-befb-b65034cd03b6"), "PFLNG Dua Region or Segment", "PFLNG Dua" }
                });

            migrationBuilder.InsertData(
                table: "Risks",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("1ec4c843-135f-4b46-9418-a81c1ce58b3a"), "Not Applicable", "N/A" },
                    { new Guid("3c088619-e0c6-41c3-b432-36e85ecce964"), "High Risk", "High" },
                    { new Guid("80c71cf4-7da5-4d18-b986-3c423d60bdc6"), "Medium Risk", "Meium" },
                    { new Guid("ae95ff88-5eae-431f-9928-33d5b6820691"), "Low Risk", "Low" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Code", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("2fdd9c02-064b-4ac9-9f64-5ad91be34cf5"), "OE", "OPU Engineer", "OPU Engineer" },
                    { new Guid("6aad1ca6-4e06-4508-ba95-ae8828dd59db"), "IN", "Inspector External", "Inspector External" },
                    { new Guid("6ce8eda9-bde9-4015-b7eb-392d82069ba0"), "ISA", "IMEx System Admin (GTS SMEs, System Admin)", "System Admin" },
                    { new Guid("922c4b00-490b-4a5e-a926-3a34a90f27bf"), "CV", "Central Viewer", "Central Viewer" },
                    { new Guid("ba5b59fb-b934-494b-866a-44d6dec9ef91"), "OA", "OPU Admin", "OPU Admin" },
                    { new Guid("e437bbb9-5be3-4e4b-9501-dc9d80b91e55"), "I", "Inspector Internal", "Inspector Internal" }
                });

            migrationBuilder.InsertData(
                table: "SerialNos",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("938704b5-ae75-40c4-b696-8b102d5a15ae"), "-" },
                    { new Guid("bf8e4e4b-ee85-42f3-a43e-2b84e88b1d1e"), "UC 0506/068036901 IM V3" }
                });

            migrationBuilder.InsertData(
                table: "Zones",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("dc288ecb-841c-4c6a-b34f-91256ee183d8"), "Z2" });

            migrationBuilder.InsertData(
                table: "OPUs",
                columns: new[] { "Id", "Id_Business", "Id_Field", "Id_Region" },
                values: new object[,]
                {
                    { new Guid("0a50c968-85e9-4e58-b587-c9cd3c7aefde"), new Guid("b42742a6-9a0a-4458-8d74-953874576182"), new Guid("d2380672-dd44-49a9-b9a9-3ac0185af368"), new Guid("c202adf7-9b3b-429f-b79e-00498235eb0c") },
                    { new Guid("1f0565ee-1ebd-48d0-adfc-37fcf00c810f"), new Guid("b42742a6-9a0a-4458-8d74-953874576182"), new Guid("0dfdce65-2877-4164-b701-706dc388ec46"), new Guid("c202adf7-9b3b-429f-b79e-00498235eb0c") },
                    { new Guid("29fb2310-06e9-404b-b531-f27866e2aa96"), new Guid("d9817472-69ee-45ff-b4d9-e7682a8f5c42"), new Guid("6be3a4fd-24a0-4458-9c7d-dd474210b9ec"), new Guid("7352acb6-9e0d-4919-9f88-36798c487d86") },
                    { new Guid("2b019bfa-a5b9-4bf0-ae58-1573ab026a64"), new Guid("d9817472-69ee-45ff-b4d9-e7682a8f5c42"), new Guid("0ead361b-8bc3-4359-a0e2-05fd27ff6dbc"), new Guid("29e8d7f6-dc93-4c1a-b419-324f4df84c4c") },
                    { new Guid("2c08a19a-16d5-4434-9d49-39d8c4d6edf9"), new Guid("f57dd90c-8787-4e02-97a9-2a2be301692b"), new Guid("9e12080d-f771-41b3-953a-fb6c606775d4"), new Guid("0ab107a0-d483-4aa0-a451-7ea62a965975") },
                    { new Guid("2cedbbea-1a47-4d76-91e7-54095d5b340b"), new Guid("b42742a6-9a0a-4458-8d74-953874576182"), new Guid("eed15056-0ce9-4d99-a347-2b88a95e6a9f"), new Guid("45946328-7a29-4731-abfa-a33aea03ed00") },
                    { new Guid("322cc61f-ce35-40ae-958a-bc8a902cf500"), new Guid("b42742a6-9a0a-4458-8d74-953874576182"), new Guid("2230a41f-5200-4c9e-aa85-5d9bbfed8fc6"), new Guid("45946328-7a29-4731-abfa-a33aea03ed00") },
                    { new Guid("327688db-ff1a-43a5-ab2c-f723a4fdce1c"), new Guid("d9817472-69ee-45ff-b4d9-e7682a8f5c42"), new Guid("34da4cab-21f5-46bd-b1a2-d8057c0e6b9f"), new Guid("29e8d7f6-dc93-4c1a-b419-324f4df84c4c") },
                    { new Guid("3b80d4ec-a639-41f6-a8cb-595b7e350e8d"), new Guid("d9817472-69ee-45ff-b4d9-e7682a8f5c42"), new Guid("d74fb67e-118f-4a4a-9462-ac85f22106fe"), new Guid("2b394efe-04c4-460d-937f-6457da94d673") },
                    { new Guid("3bc32c28-f7b1-49ae-ab76-d349bed51b27"), new Guid("b42742a6-9a0a-4458-8d74-953874576182"), new Guid("37927c4f-c9e1-4d92-8b84-09bea547a030"), new Guid("45946328-7a29-4731-abfa-a33aea03ed00") },
                    { new Guid("44f4889a-f93c-4587-abc2-508c5493ffb2"), new Guid("d9817472-69ee-45ff-b4d9-e7682a8f5c42"), new Guid("50bc7979-4f5e-4cae-87a0-dfd669fb7d46"), new Guid("2b394efe-04c4-460d-937f-6457da94d673") },
                    { new Guid("4f3b3ce5-4f77-469f-a222-a21fa0da26af"), new Guid("f57dd90c-8787-4e02-97a9-2a2be301692b"), new Guid("e7790052-4521-4689-967e-02c2cfc2509a"), new Guid("1b019d73-2b4b-468c-a539-242a1bd4917f") },
                    { new Guid("508416c3-5770-4f42-9a7f-d5bea42c9e55"), new Guid("d9817472-69ee-45ff-b4d9-e7682a8f5c42"), new Guid("126b799f-2cf5-4225-a58d-bdb3731a8a64"), new Guid("2b394efe-04c4-460d-937f-6457da94d673") },
                    { new Guid("58ef8a4a-ff8d-450a-a5f3-297838299bdb"), new Guid("b42742a6-9a0a-4458-8d74-953874576182"), new Guid("6c170d60-884b-422d-b62b-d533dfa97429"), new Guid("c202adf7-9b3b-429f-b79e-00498235eb0c") },
                    { new Guid("5a8b9879-2621-454d-b99c-105e48a0dcd4"), new Guid("f57dd90c-8787-4e02-97a9-2a2be301692b"), new Guid("854b8a3b-9c8b-4187-88bf-8967c5a474b2"), new Guid("1b019d73-2b4b-468c-a539-242a1bd4917f") },
                    { new Guid("667e644c-2416-47b4-a614-92b8702cd82e"), new Guid("b42742a6-9a0a-4458-8d74-953874576182"), new Guid("8fe930c9-fdf4-4b9b-a2f0-de164b83b5fb"), new Guid("45946328-7a29-4731-abfa-a33aea03ed00") },
                    { new Guid("676534a7-458e-4fdd-9800-12f14ab4005a"), new Guid("d9817472-69ee-45ff-b4d9-e7682a8f5c42"), new Guid("15b9727e-04e1-40c0-b5d2-fb75538e84ed"), new Guid("29e8d7f6-dc93-4c1a-b419-324f4df84c4c") },
                    { new Guid("7b4a12a7-c8cf-4f5f-8ea2-69bc3043ddd3"), new Guid("b42742a6-9a0a-4458-8d74-953874576182"), new Guid("d38692cd-4d6f-4aee-bb32-7dd9a9374244"), new Guid("c202adf7-9b3b-429f-b79e-00498235eb0c") },
                    { new Guid("818b7d56-7080-426e-8a77-42c0337d5b3c"), new Guid("d9817472-69ee-45ff-b4d9-e7682a8f5c42"), new Guid("1134b649-480f-4903-acd4-3a54007b1b23"), new Guid("29e8d7f6-dc93-4c1a-b419-324f4df84c4c") },
                    { new Guid("81e0ea2c-72f1-4532-ada1-57b762afd176"), new Guid("b42742a6-9a0a-4458-8d74-953874576182"), new Guid("254c3a4b-91a1-4077-b89c-757fc69f5910"), new Guid("45946328-7a29-4731-abfa-a33aea03ed00") },
                    { new Guid("831b80b3-033d-42c9-9b05-a23b7f0db8a1"), new Guid("b42742a6-9a0a-4458-8d74-953874576182"), new Guid("d6b3ca8d-81d9-44ec-9caf-59a1a0a76254"), new Guid("5c35ccd2-aac8-4b6d-980a-d580766a05a3") },
                    { new Guid("88924899-cf63-42a6-ad70-13a0a78c6410"), new Guid("b42742a6-9a0a-4458-8d74-953874576182"), new Guid("f156ee0d-d80b-4fb8-8143-56537f8d2520"), new Guid("5c35ccd2-aac8-4b6d-980a-d580766a05a3") },
                    { new Guid("88f4790f-a51f-4c9c-8b30-5c24b7c0113a"), new Guid("09d96c70-294e-486f-8fb0-624983bcef62"), new Guid("e24764d0-3c76-4630-b801-a05ac6a14d1b"), new Guid("85617285-d381-4070-be9c-2e0e924d65e0") },
                    { new Guid("8bdce0f4-e03b-4b54-94aa-ec7aafa7e9c0"), new Guid("f57dd90c-8787-4e02-97a9-2a2be301692b"), new Guid("467bb9f9-0b77-4987-a530-badcc66be8f5"), new Guid("1b019d73-2b4b-468c-a539-242a1bd4917f") },
                    { new Guid("959d01a1-7b02-45d3-b1dc-dcd264c56700"), new Guid("b42742a6-9a0a-4458-8d74-953874576182"), new Guid("c8ed8f67-cda6-411f-8532-b3559e284448"), new Guid("5c35ccd2-aac8-4b6d-980a-d580766a05a3") },
                    { new Guid("9837000c-b846-4753-a1f5-ed3a7f160b31"), new Guid("d9817472-69ee-45ff-b4d9-e7682a8f5c42"), new Guid("768b2aae-0db8-4cc0-98ad-bf936db2c2f3"), new Guid("c2b96baf-1596-467f-befb-b65034cd03b6") },
                    { new Guid("9c15b517-0172-4a62-9c4d-e3ecccae56be"), new Guid("d9817472-69ee-45ff-b4d9-e7682a8f5c42"), new Guid("5f08d260-2ec0-442b-82e5-33294a46b712"), new Guid("29e8d7f6-dc93-4c1a-b419-324f4df84c4c") },
                    { new Guid("9ef829a1-3f7d-4438-941b-7cf2a4535f64"), new Guid("f57dd90c-8787-4e02-97a9-2a2be301692b"), new Guid("ba0c4a91-bdb8-4272-b732-c0817b4f4444"), new Guid("1b019d73-2b4b-468c-a539-242a1bd4917f") },
                    { new Guid("a88deac5-b0fc-448d-bb5f-9e137c4b4f37"), new Guid("b42742a6-9a0a-4458-8d74-953874576182"), new Guid("d9c7b872-c002-49e8-85ef-14db7a9ca88d"), new Guid("c202adf7-9b3b-429f-b79e-00498235eb0c") },
                    { new Guid("ad0e6ce1-2c54-4594-9812-f805f601c13e"), new Guid("f57dd90c-8787-4e02-97a9-2a2be301692b"), new Guid("8f4a8ace-bb24-47f3-9315-604178147aac"), new Guid("67566a97-babe-492c-a14d-0f4b103861d9") },
                    { new Guid("af1674dd-b2f0-4296-821b-18811eca1cef"), new Guid("b42742a6-9a0a-4458-8d74-953874576182"), new Guid("b69125e2-89cc-4d96-9db4-9ca9297da146"), new Guid("45946328-7a29-4731-abfa-a33aea03ed00") },
                    { new Guid("b22dd8bf-cc06-4a92-a564-6aca6383b26a"), new Guid("b42742a6-9a0a-4458-8d74-953874576182"), new Guid("87a61711-b6f7-422b-a1f0-82662bb25077"), new Guid("c202adf7-9b3b-429f-b79e-00498235eb0c") },
                    { new Guid("b981ea97-810c-4d0d-8f09-9e3ef869cea0"), new Guid("b42742a6-9a0a-4458-8d74-953874576182"), new Guid("fa52eeb7-e89a-45e3-be2c-ff8181b35a23"), new Guid("c202adf7-9b3b-429f-b79e-00498235eb0c") },
                    { new Guid("bd72b1e2-e7b4-438c-8edd-77837913f216"), new Guid("b42742a6-9a0a-4458-8d74-953874576182"), new Guid("14c1d824-6155-486f-bdc1-b953a3fb8cfb"), new Guid("45946328-7a29-4731-abfa-a33aea03ed00") },
                    { new Guid("c875803e-2628-463e-8376-d7e6cc828a47"), new Guid("09d96c70-294e-486f-8fb0-624983bcef62"), new Guid("c4d97318-7207-4461-b6d9-0b637c71e091"), new Guid("054a0a4d-4cc1-4449-9904-e10a80becae0") },
                    { new Guid("c8c9366a-3dde-43b9-91e4-58fb2a477718"), new Guid("f57dd90c-8787-4e02-97a9-2a2be301692b"), new Guid("4a270199-5870-4828-8d7e-2f7ef168d0c4"), new Guid("1b019d73-2b4b-468c-a539-242a1bd4917f") },
                    { new Guid("d03cc06f-cbb7-4ff5-a330-f8a79d04577f"), new Guid("b42742a6-9a0a-4458-8d74-953874576182"), new Guid("70baf381-8c58-4e70-b2d9-734764144f6e"), new Guid("45946328-7a29-4731-abfa-a33aea03ed00") },
                    { new Guid("e653aae5-f90d-4481-984f-75284dfc0700"), new Guid("d9817472-69ee-45ff-b4d9-e7682a8f5c42"), new Guid("fe9b6b9b-d3e2-40ce-b665-fab93016d274"), new Guid("2b394efe-04c4-460d-937f-6457da94d673") },
                    { new Guid("e8cbc236-331a-4496-bd86-19874b6d2ec0"), new Guid("f57dd90c-8787-4e02-97a9-2a2be301692b"), new Guid("23e5527b-d159-46c6-bff7-981ad8651d33"), new Guid("1b019d73-2b4b-468c-a539-242a1bd4917f") },
                    { new Guid("f2753c54-35b1-4dbe-9dcc-9b432762d308"), new Guid("b42742a6-9a0a-4458-8d74-953874576182"), new Guid("c658389e-f146-452f-a7bd-ac90eb42b25d"), new Guid("45946328-7a29-4731-abfa-a33aea03ed00") },
                    { new Guid("f3c463c9-d905-4788-9e00-68ab6bce6503"), new Guid("b42742a6-9a0a-4458-8d74-953874576182"), new Guid("b92ddde2-acdc-40d2-8195-f190f19070ad"), new Guid("5c35ccd2-aac8-4b6d-980a-d580766a05a3") },
                    { new Guid("f5e91413-c273-4bd6-a890-e9d252443863"), new Guid("f57dd90c-8787-4e02-97a9-2a2be301692b"), new Guid("8eaccad3-d2aa-4de1-8b26-601d4a912bad"), new Guid("543687a8-b584-4d46-a692-2d0b6607a9b0") },
                    { new Guid("f5ffb83f-0b07-4d55-91ca-00adb692a00a"), new Guid("f57dd90c-8787-4e02-97a9-2a2be301692b"), new Guid("b4efc45c-5349-4c82-9061-5103bb9993b0"), new Guid("0ab107a0-d483-4aa0-a451-7ea62a965975") },
                    { new Guid("fbafc3c9-0d09-4b93-839e-cc1ba7df9997"), new Guid("b42742a6-9a0a-4458-8d74-953874576182"), new Guid("b189b3ed-c6f8-4c49-8b2c-3f5d4dd4a3f6"), new Guid("c202adf7-9b3b-429f-b79e-00498235eb0c") }
                });

            migrationBuilder.InsertData(
                table: "Equipments",
                columns: new[] { "Id", "IsActive", "DateCreated", "DateDeleted", "DateUpdated", "Id_Coordinate", "Id_CreatedBy", "Id_DeletedBy", "Id_Discipline", "Id_ElectricalRating", "Id_HACDwgNo", "Id_IECExCertificateAuthority", "Id_IECExCertificateCategory", "Id_IECExCertificateDetail", "Id_IECExCertificateNo", "Id_LocationOne", "Id_LocationTwo", "Id_Manufacturer", "Id_Model", "Id_OPU", "Id_Platform", "Id_ProtectionType", "Id_Purpose", "Id_SerialNo", "Id_UpdatedBy", "Id_Zone", "Name", "TagNo" },
                values: new object[,]
                {
                    { new Guid("34b0f38e-1603-47fd-bed9-37e254324336"), true, new DateTime(2023, 2, 28, 3, 25, 58, 420, DateTimeKind.Utc).AddTicks(8234), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("938704b5-ae75-40c4-b696-8b102d5a15ae"), new Guid("eb47cb7a-eeae-4867-be98-8566a9ffe208"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("ac1f5b06-1699-4673-9db8-77f4ea3dd0e8"), new Guid("938704b5-ae75-40c4-b696-8b102d5a15ae"), new Guid("938704b5-ae75-40c4-b696-8b102d5a15ae"), new Guid("938704b5-ae75-40c4-b696-8b102d5a15ae"), new Guid("938704b5-ae75-40c4-b696-8b102d5a15ae"), new Guid("938704b5-ae75-40c4-b696-8b102d5a15ae"), new Guid("938704b5-ae75-40c4-b696-8b102d5a15ae"), new Guid("938704b5-ae75-40c4-b696-8b102d5a15ae"), new Guid("938704b5-ae75-40c4-b696-8b102d5a15ae"), new Guid("938704b5-ae75-40c4-b696-8b102d5a15ae"), new Guid("938704b5-ae75-40c4-b696-8b102d5a15ae"), new Guid("1f0565ee-1ebd-48d0-adfc-37fcf00c810f"), new Guid("060128ee-e126-494d-979f-767f203f11a4"), new Guid("e045fb56-ffae-4e57-b6bf-0b267739c765"), new Guid("938704b5-ae75-40c4-b696-8b102d5a15ae"), new Guid("938704b5-ae75-40c4-b696-8b102d5a15ae"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("dc288ecb-841c-4c6a-b34f-91256ee183d8"), "Motor", "E3100A" },
                    { new Guid("b79a0707-5795-41a5-a0b8-28893db58c62"), true, new DateTime(2023, 2, 28, 3, 25, 58, 420, DateTimeKind.Utc).AddTicks(8217), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ed5d5d3f-819b-4da3-82f4-19a5dc5eba7d"), new Guid("eb47cb7a-eeae-4867-be98-8566a9ffe208"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("ac1f5b06-1699-4673-9db8-77f4ea3dd0e8"), new Guid("7cbbc8ca-5779-45c0-a08e-24c6bf8240f6"), new Guid("0a5567e3-a8ad-4c3d-a6d5-23996ac27c68"), new Guid("c93078e3-7067-4493-a5ad-0a312731bae9"), new Guid("bec84a12-db91-4cb9-999e-bdf44e74e109"), new Guid("0ee93cef-fd02-4232-aefa-d4b82b651421"), new Guid("db02b94f-6fcf-40ee-8fb4-7da02c74c1b6"), new Guid("335529ad-04c4-4934-a319-9c3e2d428c02"), new Guid("a64c5cab-964f-4c37-9629-d9e35671bc81"), new Guid("03ddb1e6-7510-46ec-af6a-c4bef07efb02"), new Guid("2160fa79-a8d4-4ed0-9583-92bbd572726c"), new Guid("1f0565ee-1ebd-48d0-adfc-37fcf00c810f"), new Guid("060128ee-e126-494d-979f-767f203f11a4"), new Guid("e045fb56-ffae-4e57-b6bf-0b267739c765"), new Guid("274ab1b4-75fc-4a71-babf-fb8101a2634b"), new Guid("bf8e4e4b-ee85-42f3-a43e-2b84e88b1d1e"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("dc288ecb-841c-4c6a-b34f-91256ee183d8"), "Motor", "E2460A" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "IsActive", "DateCreated", "DateDeleted", "DateUpdated", "DateValidEnd", "DateValidStart", "FirstName", "Id_CreatedBy", "Id_DeletedBy", "Id_OPU", "Id_Role", "Id_UpdatedBy", "LastName", "UserPassword", "UserName" },
                values: new object[,]
                {
                    { new Guid("25991b17-6107-429e-8284-477114e5a0f8"), true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 28, 3, 25, 58, 420, DateTimeKind.Utc).AddTicks(119), new DateTime(2023, 2, 28, 3, 25, 58, 420, DateTimeKind.Utc).AddTicks(117), "Alex", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1f0565ee-1ebd-48d0-adfc-37fcf00c810f"), new Guid("ba5b59fb-b934-494b-866a-44d6dec9ef91"), new Guid("00000000-0000-0000-0000-000000000000"), "Ronald Gomez", "5c30c68af479608433102e2d2ae6ab53eccd2565", "alex.gomez@smartcore.group" },
                    { new Guid("451ffde1-3eae-4455-8e89-78c87c1009f9"), true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 28, 3, 25, 58, 420, DateTimeKind.Utc).AddTicks(136), new DateTime(2023, 2, 28, 3, 25, 58, 420, DateTimeKind.Utc).AddTicks(136), "Nur Hafizah", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1f0565ee-1ebd-48d0-adfc-37fcf00c810f"), new Guid("ba5b59fb-b934-494b-866a-44d6dec9ef91"), new Guid("00000000-0000-0000-0000-000000000000"), "Binti Musa", "5c30c68af479608433102e2d2ae6ab53eccd2565", "hafizah@smartcore.group" },
                    { new Guid("c74611f6-a99f-44b4-88fd-e00e00fcff5a"), true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 28, 3, 25, 58, 420, DateTimeKind.Utc).AddTicks(132), new DateTime(2023, 2, 28, 3, 25, 58, 420, DateTimeKind.Utc).AddTicks(131), "Shahin", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1f0565ee-1ebd-48d0-adfc-37fcf00c810f"), new Guid("ba5b59fb-b934-494b-866a-44d6dec9ef91"), new Guid("00000000-0000-0000-0000-000000000000"), "Bin Hasan", "5c30c68af479608433102e2d2ae6ab53eccd2565", "shahin.hassan@smartcore.group" }
                });

            migrationBuilder.InsertData(
                table: "Inspections",
                columns: new[] { "Id", "IsActive", "DateCreated", "DateDeleted", "DateInspectionEnd", "DateInspectionStart", "DateUpdated", "Description", "Id_CreatedBy", "Id_DeletedBy", "Id_Discipline", "Id_InspectionType", "Id_OPU", "Id_Platform", "Id_UpdatedBy", "Id_User", "Name" },
                values: new object[,]
                {
                    { new Guid("c916d1a9-4592-4b49-bf64-afecd274ab41"), true, new DateTime(2023, 2, 28, 3, 25, 58, 420, DateTimeKind.Utc).AddTicks(9043), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 28, 3, 25, 58, 420, DateTimeKind.Utc).AddTicks(9042), new DateTime(2023, 2, 28, 3, 25, 58, 420, DateTimeKind.Utc).AddTicks(9041), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description 3", new Guid("eb47cb7a-eeae-4867-be98-8566a9ffe208"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("ac1f5b06-1699-4673-9db8-77f4ea3dd0e8"), new Guid("2afe51d9-2270-4992-8a5f-bf95e002798b"), new Guid("1f0565ee-1ebd-48d0-adfc-37fcf00c810f"), new Guid("060128ee-e126-494d-979f-767f203f11a4"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c74611f6-a99f-44b4-88fd-e00e00fcff5a"), "Sample 3" },
                    { new Guid("e26bc764-4b36-4984-9d44-d29acc3d3849"), true, new DateTime(2023, 2, 28, 3, 25, 58, 420, DateTimeKind.Utc).AddTicks(9036), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 28, 3, 25, 58, 420, DateTimeKind.Utc).AddTicks(9035), new DateTime(2023, 2, 28, 3, 25, 58, 420, DateTimeKind.Utc).AddTicks(9034), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description 2", new Guid("eb47cb7a-eeae-4867-be98-8566a9ffe208"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("ac1f5b06-1699-4673-9db8-77f4ea3dd0e8"), new Guid("2afe51d9-2270-4992-8a5f-bf95e002798b"), new Guid("1f0565ee-1ebd-48d0-adfc-37fcf00c810f"), new Guid("060128ee-e126-494d-979f-767f203f11a4"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c74611f6-a99f-44b4-88fd-e00e00fcff5a"), "Sample 2" },
                    { new Guid("f38055b9-c70f-4622-91f5-4493b4be1611"), true, new DateTime(2023, 2, 28, 3, 25, 58, 420, DateTimeKind.Utc).AddTicks(9028), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 28, 3, 25, 58, 420, DateTimeKind.Utc).AddTicks(9026), new DateTime(2023, 2, 28, 3, 25, 58, 420, DateTimeKind.Utc).AddTicks(9026), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description 1", new Guid("eb47cb7a-eeae-4867-be98-8566a9ffe208"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("ac1f5b06-1699-4673-9db8-77f4ea3dd0e8"), new Guid("2afe51d9-2270-4992-8a5f-bf95e002798b"), new Guid("1f0565ee-1ebd-48d0-adfc-37fcf00c810f"), new Guid("060128ee-e126-494d-979f-767f203f11a4"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c74611f6-a99f-44b4-88fd-e00e00fcff5a"), "Sample 1" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_Id_Coordinate",
                table: "Equipments",
                column: "Id_Coordinate");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_Id_Discipline",
                table: "Equipments",
                column: "Id_Discipline");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_Id_ElectricalRating",
                table: "Equipments",
                column: "Id_ElectricalRating");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_Id_HACDwgNo",
                table: "Equipments",
                column: "Id_HACDwgNo");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_Id_IECExCertificateAuthority",
                table: "Equipments",
                column: "Id_IECExCertificateAuthority");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_Id_IECExCertificateCategory",
                table: "Equipments",
                column: "Id_IECExCertificateCategory");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_Id_IECExCertificateDetail",
                table: "Equipments",
                column: "Id_IECExCertificateDetail");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_Id_IECExCertificateNo",
                table: "Equipments",
                column: "Id_IECExCertificateNo");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_Id_LocationOne",
                table: "Equipments",
                column: "Id_LocationOne");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_Id_LocationTwo",
                table: "Equipments",
                column: "Id_LocationTwo");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_Id_Manufacturer",
                table: "Equipments",
                column: "Id_Manufacturer");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_Id_Model",
                table: "Equipments",
                column: "Id_Model");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_Id_OPU",
                table: "Equipments",
                column: "Id_OPU");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_Id_Platform",
                table: "Equipments",
                column: "Id_Platform");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_Id_ProtectionType",
                table: "Equipments",
                column: "Id_ProtectionType");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_Id_Purpose",
                table: "Equipments",
                column: "Id_Purpose");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_Id_SerialNo",
                table: "Equipments",
                column: "Id_SerialNo");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_Id_Zone",
                table: "Equipments",
                column: "Id_Zone");

            migrationBuilder.CreateIndex(
                name: "IX_InspectionEquipment_Id_Inspection",
                table: "InspectionEquipment",
                column: "Id_Inspection");

            migrationBuilder.CreateIndex(
                name: "IX_InspectionEquipment_Id_Risk",
                table: "InspectionEquipment",
                column: "Id_Risk");

            migrationBuilder.CreateIndex(
                name: "IX_Inspections_Id_Discipline",
                table: "Inspections",
                column: "Id_Discipline");

            migrationBuilder.CreateIndex(
                name: "IX_Inspections_Id_InspectionType",
                table: "Inspections",
                column: "Id_InspectionType");

            migrationBuilder.CreateIndex(
                name: "IX_Inspections_Id_OPU",
                table: "Inspections",
                column: "Id_OPU");

            migrationBuilder.CreateIndex(
                name: "IX_Inspections_Id_Platform",
                table: "Inspections",
                column: "Id_Platform");

            migrationBuilder.CreateIndex(
                name: "IX_Inspections_Id_User",
                table: "Inspections",
                column: "Id_User");

            migrationBuilder.CreateIndex(
                name: "IX_OPUs_Id_Field",
                table: "OPUs",
                column: "Id_Field");

            migrationBuilder.CreateIndex(
                name: "IX_OPUs_Id_Region",
                table: "OPUs",
                column: "Id_Region");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Id_OPU",
                table: "Users",
                column: "Id_OPU");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Id_Role",
                table: "Users",
                column: "Id_Role");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Equipments");

            migrationBuilder.DropTable(
                name: "InspectionEquipment");

            migrationBuilder.DropTable(
                name: "Coordinates");

            migrationBuilder.DropTable(
                name: "ElectricalRatings");

            migrationBuilder.DropTable(
                name: "HACDwgNos");

            migrationBuilder.DropTable(
                name: "IECExCertificateAuthorities");

            migrationBuilder.DropTable(
                name: "IECExCertificateCategories");

            migrationBuilder.DropTable(
                name: "IECExCertificateDetails");

            migrationBuilder.DropTable(
                name: "IECExCertificateNos");

            migrationBuilder.DropTable(
                name: "LocationOnes");

            migrationBuilder.DropTable(
                name: "LocationTwos");

            migrationBuilder.DropTable(
                name: "Manufacturers");

            migrationBuilder.DropTable(
                name: "Models");

            migrationBuilder.DropTable(
                name: "ProtectionTypes");

            migrationBuilder.DropTable(
                name: "Purposes");

            migrationBuilder.DropTable(
                name: "SerialNos");

            migrationBuilder.DropTable(
                name: "Zones");

            migrationBuilder.DropTable(
                name: "Inspections");

            migrationBuilder.DropTable(
                name: "Risks");

            migrationBuilder.DropTable(
                name: "Disciplines");

            migrationBuilder.DropTable(
                name: "InspectionTypes");

            migrationBuilder.DropTable(
                name: "Platforms");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "OPUs");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Businesses");

            migrationBuilder.DropTable(
                name: "Fields");

            migrationBuilder.DropTable(
                name: "Regions");
        }
    }
}
