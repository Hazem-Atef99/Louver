using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Louver.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AN_Category",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DefaultDescAr = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DefaultDescEn = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    TypeID = table.Column<int>(type: "int", nullable: true),
                    hasLength = table.Column<int>(type: "int", nullable: true),
                    hasWidth = table.Column<int>(type: "int", nullable: true),
                    hasHeight = table.Column<int>(type: "int", nullable: true),
                    hasCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__AN_Categ__19093A2B5C31EEB2", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "AN_CuttingListCatgeory",
                columns: table => new
                {
                    CuttingListCatgeoryID = table.Column<int>(type: "int", nullable: false),
                    DefaultDescAr = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DefaultDescEn = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__AN_Cutti__1814C71B9C7CDFF8", x => x.CuttingListCatgeoryID);
                });

            migrationBuilder.CreateTable(
                name: "AN_HandType",
                columns: table => new
                {
                    HandTypeID = table.Column<int>(type: "int", nullable: false),
                    DefaultDescAr = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DefaultDescEn = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__AN_HandT__3F15E4D4005E487A", x => x.HandTypeID);
                });

            migrationBuilder.CreateTable(
                name: "ClientFileAnalyse",
                columns: table => new
                {
                    DetailID = table.Column<int>(type: "int", nullable: false),
                    ClientFIleiD = table.Column<int>(type: "int", nullable: false),
                    Length = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Width = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    ItemCount = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Color = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    TypeID = table.Column<int>(type: "int", nullable: true),
                    IsManual = table.Column<int>(type: "int", nullable: true),
                    IsGlass = table.Column<int>(type: "int", nullable: true),
                    Notes = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    ItemCategoryID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientFileAnalyse", x => new { x.DetailID, x.ClientFIleiD });
                });

            migrationBuilder.CreateTable(
                name: "ClientFileAttachment",
                columns: table => new
                {
                    ClientFileAttachmentID = table.Column<int>(type: "int", nullable: false),
                    ClientFileID = table.Column<int>(type: "int", nullable: false),
                    AttachmentPath = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Notes = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientFileAttachment", x => new { x.ClientFileAttachmentID, x.ClientFileID });
                });

            migrationBuilder.CreateTable(
                name: "CLientFileITEm20210702",
                columns: table => new
                {
                    ClientFileItemID = table.Column<int>(type: "int", nullable: false),
                    ClientFileID = table.Column<int>(type: "int", nullable: false),
                    ItemID = table.Column<int>(type: "int", nullable: true),
                    ItemCount = table.Column<decimal>(type: "decimal(18,3)", nullable: true),
                    ItemPrice = table.Column<decimal>(type: "decimal(18,5)", nullable: true),
                    ItemPriceAfterDiscount = table.Column<decimal>(type: "decimal(18,5)", nullable: true),
                    ItemTypeID = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Width = table.Column<int>(type: "int", nullable: true),
                    Hieght = table.Column<int>(type: "int", nullable: true),
                    Length = table.Column<int>(type: "int", nullable: true),
                    NOTES = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    DoorTypeID = table.Column<int>(type: "int", nullable: true),
                    Direction = table.Column<int>(type: "int", nullable: true),
                    itemcolor = table.Column<int>(type: "int", nullable: true),
                    ItemColorID = table.Column<int>(type: "int", nullable: true),
                    AccOption = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    CategoryID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ClientFileLog",
                columns: table => new
                {
                    ClientFileID = table.Column<int>(type: "int", nullable: true),
                    DetailID = table.Column<int>(type: "int", nullable: true),
                    FromValue = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    ToValue = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    notes = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    TypeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ClientFilePayments",
                columns: table => new
                {
                    ClientFileID = table.Column<int>(type: "int", nullable: false),
                    PaymentID = table.Column<int>(type: "int", nullable: false),
                    DetailID = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,3)", nullable: true),
                    StatusID = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_clientfilePayment", x => new { x.ClientFileID, x.PaymentID, x.DetailID });
                });

            migrationBuilder.CreateTable(
                name: "ClientFileStatus",
                columns: table => new
                {
                    StatusID = table.Column<int>(type: "int", nullable: true),
                    DefaultDesc = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ClientFileTawseel",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: true),
                    ClientFileID = table.Column<int>(type: "int", nullable: true),
                    PointDescription = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    KitchenHeight = table.Column<decimal>(type: "decimal(18,3)", nullable: true),
                    TarkeebDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ATtachementPath = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Attachment = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Notes = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ClientFileTop",
                columns: table => new
                {
                    DetailID = table.Column<int>(type: "int", nullable: false),
                    ClientFileID = table.Column<int>(type: "int", nullable: false),
                    TypeID = table.Column<int>(type: "int", nullable: true),
                    TopColor = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    PanelTypeID = table.Column<int>(type: "int", nullable: true),
                    TopHieght = table.Column<decimal>(type: "decimal(18,3)", nullable: true),
                    SinkHoleId = table.Column<int>(type: "int", nullable: true),
                    Notes = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Attachment = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientFileTop", x => new { x.DetailID, x.ClientFileID });
                });

            migrationBuilder.CreateTable(
                name: "ClientFileTopDevices",
                columns: table => new
                {
                    DetailID = table.Column<int>(type: "int", nullable: false),
                    ClientFileID = table.Column<int>(type: "int", nullable: false),
                    ID = table.Column<int>(type: "int", nullable: false),
                    Attachment = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Width = table.Column<decimal>(type: "decimal(18,3)", nullable: true),
                    Height = table.Column<decimal>(type: "decimal(18,3)", nullable: true),
                    Length = table.Column<decimal>(type: "decimal(18,3)", nullable: true),
                    Notes = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    AttachmentPath = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientFileTopDevices", x => new { x.DetailID, x.ClientFileID, x.ID });
                });

            migrationBuilder.CreateTable(
                name: "ClientFollow2",
                columns: table => new
                {
                    ClientFileID = table.Column<int>(type: "int", nullable: false),
                    ClientFollow2ID = table.Column<int>(type: "int", nullable: false),
                    Follow2Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Notes = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    TypeID = table.Column<int>(type: "int", nullable: true),
                    AttachmentPath = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Attachment = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ClientFollow2", x => new { x.ClientFileID, x.ClientFollow2ID });
                });

            migrationBuilder.CreateTable(
                name: "Clientmaintainance",
                columns: table => new
                {
                    ClientFileID = table.Column<int>(type: "int", nullable: false),
                    ClientMaintainanceID = table.Column<int>(type: "int", nullable: false),
                    MaintainanceDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Notes = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    TarkeebDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ATTACHMENTPATH = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_Clientmaintainance", x => new { x.ClientFileID, x.ClientMaintainanceID });
                });

            migrationBuilder.CreateTable(
                name: "ClientMaintainanceAttachment",
                columns: table => new
                {
                    ClientFileAttachmentID = table.Column<int>(type: "int", nullable: false),
                    ClientMaintainanceID = table.Column<int>(type: "int", nullable: false),
                    AttachmentPath = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Notes = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientFileMaintainanceATT", x => new { x.ClientFileAttachmentID, x.ClientMaintainanceID });
                });

            migrationBuilder.CreateTable(
                name: "CLIENTS",
                columns: table => new
                {
                    ClientID = table.Column<int>(type: "int", nullable: false),
                    ClientName = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ClientNo = table.Column<int>(type: "int", nullable: true),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Fax = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Mobile = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Tel1 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ClientAddress = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    RefClientID = table.Column<int>(type: "int", nullable: true),
                    ClientStatusID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CLIENTS__E67E1A04EBD6B904", x => x.ClientID);
                });

            migrationBuilder.CreateTable(
                name: "ClientShortage",
                columns: table => new
                {
                    ClientFileID = table.Column<int>(type: "int", nullable: false),
                    ClientShortageID = table.Column<int>(type: "int", nullable: false),
                    ShortageDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Notes = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    TarkeebDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    InternalColor = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    SubColor = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    TarkeebBy = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ClientShortage", x => new { x.ClientFileID, x.ClientShortageID });
                });

            migrationBuilder.CreateTable(
                name: "ClientShortageAttachment",
                columns: table => new
                {
                    ClientFileAttachmentID = table.Column<int>(type: "int", nullable: false),
                    ClientShortageID = table.Column<int>(type: "int", nullable: false),
                    AttachmentPath = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Notes = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientFileShortageATT", x => new { x.ClientFileAttachmentID, x.ClientShortageID });
                });

            migrationBuilder.CreateTable(
                name: "CurrFile",
                columns: table => new
                {
                    CurrDescSingleAR = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CurrDescGroupAR = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CurrSmallUnitAR = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "DayNumber",
                columns: table => new
                {
                    dayid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "DoorDetails",
                columns: table => new
                {
                    DoorID = table.Column<int>(type: "int", nullable: true),
                    Architrave1 = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    Architrave2 = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    Jamb = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    Edges = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    TopRails = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    BottomRails = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    stiles = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    core = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    Face = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    woodveneer = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    Paint = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    rubber = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    DecorativeProfile = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Panels = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ItemDetail",
                columns: table => new
                {
                    ItemDetailID = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    ItemCategoryID = table.Column<int>(type: "int", nullable: true),
                    Lenght = table.Column<decimal>(type: "decimal(18,3)", nullable: true),
                    Width = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ItemCount = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    Hieght = table.Column<decimal>(type: "decimal(18,3)", nullable: true),
                    Length = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Notes = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ItemDetail", x => new { x.ItemId, x.ItemDetailID });
                });

            migrationBuilder.CreateTable(
                name: "ITemTYpePrice20200218",
                columns: table => new
                {
                    ItemTypeID = table.Column<int>(type: "int", nullable: true),
                    ItemID = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,5)", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ITEMTYPEPRICE20220320",
                columns: table => new
                {
                    ItemTypeID = table.Column<int>(type: "int", nullable: true),
                    ItemID = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,5)", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ItemTypePrice20220609",
                columns: table => new
                {
                    ItemTypeID = table.Column<int>(type: "int", nullable: true),
                    ItemID = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,5)", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "itemtypeprice20220616",
                columns: table => new
                {
                    ItemTypeID = table.Column<int>(type: "int", nullable: true),
                    ItemID = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,5)", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Money",
                columns: table => new
                {
                    Money_No = table.Column<int>(type: "int", nullable: false),
                    Money_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Money", x => x.Money_No);
                });

            migrationBuilder.CreateTable(
                name: "NotifciationSetupDetail",
                columns: table => new
                {
                    NotifciationSetupID = table.Column<int>(type: "int", nullable: false),
                    LevelID = table.Column<int>(type: "int", nullable: false),
                    FromApprovalProcessID = table.Column<int>(type: "int", nullable: true),
                    ToApprovalProcessID = table.Column<int>(type: "int", nullable: true),
                    AllowEdit = table.Column<int>(type: "int", nullable: true),
                    AllowDelete = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_NotifciationSetupDetail", x => new { x.NotifciationSetupID, x.LevelID });
                });

            migrationBuilder.CreateTable(
                name: "NotifciationSetupUserType",
                columns: table => new
                {
                    NotifciationSetupID = table.Column<int>(type: "int", nullable: false),
                    LevelID = table.Column<int>(type: "int", nullable: false),
                    UserTypeID = table.Column<int>(type: "int", nullable: false),
                    MessageFormat = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: true),
                    MessageFormatAR = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_NotifciationSetupUsers", x => new { x.NotifciationSetupID, x.LevelID, x.UserTypeID });
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    NotificationID = table.Column<int>(type: "int", nullable: false),
                    DefaultDesc = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Notifica__20CF2E3293C0610D", x => x.NotificationID);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectID = table.Column<int>(type: "int", nullable: false),
                    ProjectName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    KitchenImageFile = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    KitchenPrefix = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DoorPrefix = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Logo = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    LogoBinary = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ValidatePeriod = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    ValidateID = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    WindowPrefix = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ReportFile = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Projects__761ABED04E3EF124", x => x.ProjectID);
                });

            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    QuestionID = table.Column<int>(type: "int", nullable: false),
                    QuestionDesc = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Question__0DC06F8CFBED08A8", x => x.QuestionID);
                });

            migrationBuilder.CreateTable(
                name: "QusetionAnswer",
                columns: table => new
                {
                    AnswerID = table.Column<int>(type: "int", nullable: false),
                    AnswerDesc = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_QusetionAnswer", x => x.AnswerID);
                });

            migrationBuilder.CreateTable(
                name: "Reminders",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeID = table.Column<int>(type: "int", nullable: true),
                    PK = table.Column<int>(type: "int", nullable: true),
                    TypeID = table.Column<int>(type: "int", nullable: true),
                    Notes = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: true),
                    EndDate = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    ProjectID = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Description = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: true),
                    DescriptionAr = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    IsDismissed = table.Column<int>(type: "int", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Reminder__3214EC27F2E91B85", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Status2020",
                columns: table => new
                {
                    StatusID = table.Column<int>(type: "int", nullable: false),
                    DefaultDesc = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    IsDefault = table.Column<int>(type: "int", nullable: true),
                    StatusCategoryID = table.Column<int>(type: "int", nullable: true),
                    OrderID = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    StatusCode = table.Column<int>(type: "int", nullable: true),
                    Country = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Currency = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CurrencyCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ParentID = table.Column<int>(type: "int", nullable: true),
                    CountryID = table.Column<int>(type: "int", nullable: true),
                    CityID = table.Column<int>(type: "int", nullable: true),
                    VacationDays = table.Column<int>(type: "int", nullable: true),
                    Size = table.Column<int>(type: "int", nullable: true),
                    ItemCategoryID = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,5)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    CategoryID = table.Column<int>(type: "int", nullable: true),
                    ItemTypeID = table.Column<int>(type: "int", nullable: true),
                    SubCategoryID = table.Column<int>(type: "int", nullable: true),
                    DescriptionEn = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    ImagePath = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Status20201",
                columns: table => new
                {
                    StatusID = table.Column<int>(type: "int", nullable: false),
                    DefaultDesc = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    IsDefault = table.Column<int>(type: "int", nullable: true),
                    StatusCategoryID = table.Column<int>(type: "int", nullable: true),
                    OrderID = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    StatusCode = table.Column<int>(type: "int", nullable: true),
                    Country = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Currency = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CurrencyCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ParentID = table.Column<int>(type: "int", nullable: true),
                    CountryID = table.Column<int>(type: "int", nullable: true),
                    CityID = table.Column<int>(type: "int", nullable: true),
                    VacationDays = table.Column<int>(type: "int", nullable: true),
                    Size = table.Column<int>(type: "int", nullable: true),
                    ItemCategoryID = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,5)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    CategoryID = table.Column<int>(type: "int", nullable: true),
                    ItemTypeID = table.Column<int>(type: "int", nullable: true),
                    SubCategoryID = table.Column<int>(type: "int", nullable: true),
                    DescriptionEn = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    ImagePath = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Status20210130_1",
                columns: table => new
                {
                    StatusID = table.Column<int>(type: "int", nullable: false),
                    DefaultDesc = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    IsDefault = table.Column<int>(type: "int", nullable: true),
                    StatusCategoryID = table.Column<int>(type: "int", nullable: true),
                    OrderID = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    StatusCode = table.Column<int>(type: "int", nullable: true),
                    Country = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Currency = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CurrencyCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ParentID = table.Column<int>(type: "int", nullable: true),
                    CountryID = table.Column<int>(type: "int", nullable: true),
                    CityID = table.Column<int>(type: "int", nullable: true),
                    VacationDays = table.Column<int>(type: "int", nullable: true),
                    Size = table.Column<int>(type: "int", nullable: true),
                    ItemCategoryID = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,5)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    CategoryID = table.Column<int>(type: "int", nullable: true),
                    ItemTypeID = table.Column<int>(type: "int", nullable: true),
                    SubCategoryID = table.Column<int>(type: "int", nullable: true),
                    DescriptionEn = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    ImagePath = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "StatusCategory",
                columns: table => new
                {
                    StatusCategoryID = table.Column<int>(type: "int", nullable: false),
                    DefaultDesc = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    OrderID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusCategory", x => x.StatusCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    FullName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    UserTypeID = table.Column<int>(type: "int", nullable: true),
                    UserNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsAdmin = table.Column<int>(type: "int", nullable: true),
                    ImageAttachement = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    StatusID = table.Column<int>(type: "int", nullable: true),
                    ProjectID = table.Column<int>(type: "int", nullable: true),
                    TeamID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inv_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "AN_ITEMDETAIL",
                columns: table => new
                {
                    ItemID = table.Column<int>(type: "int", nullable: true),
                    DetailID = table.Column<int>(type: "int", nullable: true),
                    HandTypeID = table.Column<int>(type: "int", nullable: true),
                    CuttingListCatgeoryID = table.Column<int>(type: "int", nullable: true),
                    CategoryID = table.Column<int>(type: "int", nullable: true),
                    Length = table.Column<decimal>(type: "decimal(18,3)", nullable: true),
                    Width = table.Column<decimal>(type: "decimal(18,3)", nullable: true),
                    Quantity = table.Column<decimal>(type: "decimal(18,3)", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "fk_AN_ITEMDETAIL1",
                        column: x => x.HandTypeID,
                        principalTable: "AN_HandType",
                        principalColumn: "HandTypeID");
                    table.ForeignKey(
                        name: "fk_AN_ITEMDETAIL2",
                        column: x => x.CuttingListCatgeoryID,
                        principalTable: "AN_CuttingListCatgeory",
                        principalColumn: "CuttingListCatgeoryID");
                    table.ForeignKey(
                        name: "fk_AN_ITEMDETAIL3",
                        column: x => x.HandTypeID,
                        principalTable: "AN_Category",
                        principalColumn: "CategoryID");
                });

            migrationBuilder.CreateTable(
                name: "ClientPayment",
                columns: table => new
                {
                    PaymentID = table.Column<int>(type: "int", nullable: false),
                    ClientID = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,5)", nullable: true),
                    PaymentDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    PaymentNo = table.Column<int>(type: "int", nullable: true),
                    BankID = table.Column<int>(type: "int", nullable: true),
                    BranchID = table.Column<int>(type: "int", nullable: true),
                    PaidTypeID = table.Column<int>(type: "int", nullable: true),
                    CheckNo = table.Column<int>(type: "int", nullable: true),
                    PaidFor = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Notes = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CheckDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SaleID = table.Column<int>(type: "int", nullable: true),
                    StatusID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ClientPa__9B556A587C82F1C5", x => x.PaymentID);
                    table.ForeignKey(
                        name: "FK_ClientPayment_CLIENTS",
                        column: x => x.ClientID,
                        principalTable: "CLIENTS",
                        principalColumn: "ClientID");
                });

            migrationBuilder.CreateTable(
                name: "ClientShortageDetail",
                columns: table => new
                {
                    ClientShortageID = table.Column<int>(type: "int", nullable: false),
                    DetailID = table.Column<int>(type: "int", nullable: false),
                    ClientFileID = table.Column<int>(type: "int", nullable: true),
                    InternalColor = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    SubColor = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    TarkeebBy = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    Bayan = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    Hieght = table.Column<decimal>(type: "decimal(18,3)", nullable: true),
                    Width = table.Column<decimal>(type: "decimal(18,3)", nullable: true),
                    ItemCount = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: true),
                    QshatColor = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Notes = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ClientShortageDetail", x => new { x.ClientShortageID, x.DetailID });
                    table.ForeignKey(
                        name: "fk_ClientShortageDetail",
                        columns: x => new { x.ClientFileID, x.ClientShortageID },
                        principalTable: "ClientShortage",
                        principalColumns: new[] { "ClientFileID", "ClientShortageID" });
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    StatusID = table.Column<int>(type: "int", nullable: false),
                    DefaultDesc = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    IsDefault = table.Column<int>(type: "int", nullable: true),
                    StatusCategoryID = table.Column<int>(type: "int", nullable: true),
                    OrderID = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    StatusCode = table.Column<int>(type: "int", nullable: true),
                    Country = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Currency = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CurrencyCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ParentID = table.Column<int>(type: "int", nullable: true),
                    CountryID = table.Column<int>(type: "int", nullable: true),
                    CityID = table.Column<int>(type: "int", nullable: true),
                    VacationDays = table.Column<int>(type: "int", nullable: true),
                    Size = table.Column<int>(type: "int", nullable: true),
                    ItemCategoryID = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,5)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    CategoryID = table.Column<int>(type: "int", nullable: true),
                    ItemTypeID = table.Column<int>(type: "int", nullable: true),
                    SubCategoryID = table.Column<int>(type: "int", nullable: true),
                    DescriptionEn = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    ImagePath = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    HasLegs = table.Column<int>(type: "int", nullable: true),
                    HasDorj = table.Column<int>(type: "int", nullable: true),
                    HasFassaleh = table.Column<int>(type: "int", nullable: true),
                    HasAcc = table.Column<int>(type: "int", nullable: true),
                    HasHand = table.Column<int>(type: "int", nullable: true),
                    HalqEquation = table.Column<string>(type: "varchar(8000)", unicode: false, maxLength: 8000, nullable: true),
                    DarfehEquationWidth = table.Column<string>(type: "varchar(8000)", unicode: false, maxLength: 8000, nullable: true),
                    DarfehEquation = table.Column<string>(type: "varchar(8000)", unicode: false, maxLength: 8000, nullable: true),
                    MonkholEquationWidth = table.Column<string>(type: "varchar(8000)", unicode: false, maxLength: 8000, nullable: true),
                    MonkholEquation = table.Column<string>(type: "varchar(8000)", unicode: false, maxLength: 8000, nullable: true),
                    GlassEquationWidth = table.Column<string>(type: "varchar(8000)", unicode: false, maxLength: 8000, nullable: true),
                    GlassEquation = table.Column<string>(type: "varchar(8000)", unicode: false, maxLength: 8000, nullable: true),
                    AluminiumEquation = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    ApajurEquation = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    AluminiumEquationWidth = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    ApajurEquationWidth = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    HalqEquationWidth = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    DetailCount = table.Column<int>(type: "int", nullable: true),
                    IsFarez = table.Column<int>(type: "int", nullable: true),
                    IsGlass = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.StatusID);
                    table.ForeignKey(
                        name: "FK_Status_StatusCategory",
                        column: x => x.StatusCategoryID,
                        principalTable: "StatusCategory",
                        principalColumn: "StatusCategoryID");
                });

            migrationBuilder.CreateTable(
                name: "ItemTypePrice",
                columns: table => new
                {
                    ItemTypeID = table.Column<int>(type: "int", nullable: true),
                    ItemID = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,5)", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_ItemTypePrice_Status",
                        column: x => x.ItemID,
                        principalTable: "Status",
                        principalColumn: "StatusID");
                    table.ForeignKey(
                        name: "FK_ItemTypePrice_Status1",
                        column: x => x.ItemTypeID,
                        principalTable: "Status",
                        principalColumn: "StatusID");
                });

            migrationBuilder.CreateTable(
                name: "AN_ClientFileDetail",
                columns: table => new
                {
                    DetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientFIleitemID = table.Column<int>(type: "int", nullable: true),
                    TypeID = table.Column<int>(type: "int", nullable: true),
                    CatgeoryID = table.Column<int>(type: "int", nullable: true),
                    Width = table.Column<decimal>(type: "decimal(18,3)", nullable: true),
                    Hieght = table.Column<decimal>(type: "decimal(18,3)", nullable: true),
                    Length = table.Column<decimal>(type: "decimal(18,3)", nullable: true),
                    QTY = table.Column<decimal>(type: "decimal(18,3)", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__AN_Clien__135C314DA845EAC6", x => x.DetailID);
                    table.ForeignKey(
                        name: "FK_AN_ClientFileDetail_AN_Category",
                        column: x => x.CatgeoryID,
                        principalTable: "AN_Category",
                        principalColumn: "CategoryID");
                    table.ForeignKey(
                        name: "FK_AN_ClientFileDetail_FK5",
                        column: x => x.TypeID,
                        principalTable: "AN_CuttingListCatgeory",
                        principalColumn: "CuttingListCatgeoryID");
                });

            migrationBuilder.CreateTable(
                name: "AN_ClientFileItem",
                columns: table => new
                {
                    ClientFIleitemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientFIleiD = table.Column<int>(type: "int", nullable: true),
                    UnitID = table.Column<int>(type: "int", nullable: true),
                    MaterialID = table.Column<int>(type: "int", nullable: true),
                    Color = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    FinalStatusID = table.Column<int>(type: "int", nullable: true),
                    Grain = table.Column<int>(type: "int", nullable: true),
                    Notes = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    CuttingListCategoryID = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__AN_Clien__92F51EADAFFAAC1C", x => x.ClientFIleitemID);
                    table.ForeignKey(
                        name: "FK_AN_ClientFileDetail_FK1",
                        column: x => x.CuttingListCategoryID,
                        principalTable: "AN_CuttingListCatgeory",
                        principalColumn: "CuttingListCatgeoryID");
                    table.ForeignKey(
                        name: "grain",
                        column: x => x.Grain,
                        principalTable: "Status",
                        principalColumn: "StatusID");
                    table.ForeignKey(
                        name: "material",
                        column: x => x.MaterialID,
                        principalTable: "Status",
                        principalColumn: "StatusID");
                    table.ForeignKey(
                        name: "unit",
                        column: x => x.UnitID,
                        principalTable: "Status",
                        principalColumn: "StatusID");
                });

            migrationBuilder.CreateTable(
                name: "An_CuttingListDetail",
                columns: table => new
                {
                    CuttingListDetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientFileID = table.Column<int>(type: "int", nullable: true),
                    DetailID = table.Column<int>(type: "int", nullable: false),
                    TypeID = table.Column<int>(type: "int", nullable: true),
                    MaterialID = table.Column<int>(type: "int", nullable: true),
                    Color1 = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    ThicknessID = table.Column<int>(type: "int", nullable: true),
                    Thickness = table.Column<int>(type: "int", nullable: true),
                    SizeID = table.Column<int>(type: "int", nullable: true),
                    Size = table.Column<int>(type: "int", nullable: true),
                    GrainID = table.Column<int>(type: "int", nullable: true),
                    Grain = table.Column<int>(type: "int", nullable: true),
                    OrderBy = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_An_CuttingListDetail", x => x.CuttingListDetailID);
                    table.ForeignKey(
                        name: "An_CuttingListDetail_Status1_material",
                        column: x => x.MaterialID,
                        principalTable: "Status",
                        principalColumn: "StatusID");
                    table.ForeignKey(
                        name: "Grain_cuttingList",
                        column: x => x.GrainID,
                        principalTable: "Status",
                        principalColumn: "StatusID");
                    table.ForeignKey(
                        name: "Size",
                        column: x => x.SizeID,
                        principalTable: "Status",
                        principalColumn: "StatusID");
                    table.ForeignKey(
                        name: "Thikness",
                        column: x => x.ThicknessID,
                        principalTable: "Status",
                        principalColumn: "StatusID");
                });

            migrationBuilder.CreateTable(
                name: "ClientFile",
                columns: table => new
                {
                    ClientFileID = table.Column<int>(type: "int", nullable: false),
                    FileNo = table.Column<int>(type: "int", nullable: true),
                    FileDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ActionByDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ActionByHour = table.Column<int>(type: "int", nullable: true),
                    ClientNeed = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Modifiedby = table.Column<int>(type: "int", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ClientID = table.Column<int>(type: "int", nullable: true),
                    DeviceNotes = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    Attachment1 = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    Attachment2 = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    KitchenHeight = table.Column<int>(type: "int", nullable: true),
                    Discount = table.Column<decimal>(type: "decimal(18,5)", nullable: true),
                    TarkeebDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DesignerID = table.Column<int>(type: "int", nullable: true),
                    DesignerDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DiscountType = table.Column<int>(type: "int", nullable: true),
                    ContractStatusID = table.Column<int>(type: "int", nullable: true),
                    ContractDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ProjectManager = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Sitet = table.Column<int>(type: "int", nullable: true),
                    Structure = table.Column<int>(type: "int", nullable: true),
                    Remarks = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    FileTypeID = table.Column<int>(type: "int", nullable: true),
                    Project = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Owner = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Contractor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AttentionMr = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ContractorTel = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AttentionMrTel = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    InternalDoorModel = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ExternalDoorModel = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    InternalDoorQuantity = table.Column<int>(type: "int", nullable: true),
                    ExternalDoorQuantity = table.Column<int>(type: "int", nullable: true),
                    Remarks2 = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    Measurmentid = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    MeasurmentDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    KitchecnModelID = table.Column<int>(type: "int", nullable: true),
                    additionaldiscount = table.Column<int>(type: "int", nullable: true),
                    AdditionalNotes = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    AdditionalAmount = table.Column<decimal>(type: "decimal(18,3)", nullable: true),
                    PatternType = table.Column<int>(type: "int", nullable: true),
                    KitchenLocation = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    Notes = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    SalesID = table.Column<int>(type: "int", nullable: true),
                    DesignOrder = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ContractNo = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    OfferNo = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    TopDiscount = table.Column<decimal>(type: "decimal(18,3)", nullable: true),
                    CombinationPeriod = table.Column<int>(type: "int", nullable: true),
                    StatusID = table.Column<int>(type: "int", nullable: true),
                    AccessoryDiscount = table.Column<decimal>(type: "decimal(18,3)", nullable: true),
                    FactoryNotes = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    FactoryConfirmID = table.Column<int>(type: "int", nullable: true),
                    DesignStatusID = table.Column<int>(type: "int", nullable: true),
                    Follow = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    SentToFactoryDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    AllPrice = table.Column<decimal>(type: "decimal(18,3)", nullable: true),
                    StartWeek = table.Column<int>(type: "int", nullable: true),
                    StartMonth = table.Column<int>(type: "int", nullable: true),
                    InvoiceNo = table.Column<int>(type: "int", nullable: true),
                    InvoiceDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    WindowPrefix = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    RelatedClientFileID = table.Column<int>(type: "int", nullable: true),
                    WithTax = table.Column<int>(type: "int", nullable: true),
                    FinalStatusID = table.Column<int>(type: "int", nullable: true),
                    clientFileStatus = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientFile", x => x.ClientFileID);
                    table.ForeignKey(
                        name: "FK_ClientFile_CLIENTS",
                        column: x => x.ClientID,
                        principalTable: "CLIENTS",
                        principalColumn: "ClientID");
                });

            migrationBuilder.CreateTable(
                name: "CLientFileDetail",
                columns: table => new
                {
                    ClientFileDetailID = table.Column<int>(type: "int", nullable: false),
                    ClientFileID = table.Column<int>(type: "int", nullable: false),
                    ClientFileTypeID = table.Column<int>(type: "int", nullable: true),
                    CarkeesTypeID = table.Column<int>(type: "int", nullable: true),
                    Hieght = table.Column<int>(type: "int", nullable: true),
                    MainColorID = table.Column<int>(type: "int", nullable: true),
                    SubColorID = table.Column<int>(type: "int", nullable: true),
                    HandModelID = table.Column<int>(type: "int", nullable: true),
                    GlassTypeID = table.Column<int>(type: "int", nullable: true),
                    FasalehTypeID = table.Column<int>(type: "int", nullable: true),
                    MajlahTypeID = table.Column<int>(type: "int", nullable: true),
                    BaterryTypeID = table.Column<int>(type: "int", nullable: true),
                    BaneltypeID = table.Column<int>(type: "int", nullable: true),
                    MajlehHallID = table.Column<int>(type: "int", nullable: true),
                    TopTypeID = table.Column<int>(type: "int", nullable: true),
                    TopWidth = table.Column<int>(type: "int", nullable: true),
                    TopColorID = table.Column<int>(type: "int", nullable: true),
                    AdditionalSide = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    WaterProofHieght = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLientFileDetail", x => new { x.ClientFileDetailID, x.ClientFileID });
                    table.ForeignKey(
                        name: "FK_CLientFileDetail_ClientFile",
                        column: x => x.ClientFileID,
                        principalTable: "ClientFile",
                        principalColumn: "ClientFileID");
                });

            migrationBuilder.CreateTable(
                name: "ClientFileDevice",
                columns: table => new
                {
                    ClientFileDeviceID = table.Column<int>(type: "int", nullable: false),
                    ClientFileID = table.Column<int>(type: "int", nullable: true),
                    DeviceID = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeviceModelID = table.Column<int>(type: "int", nullable: true),
                    Hieght = table.Column<int>(type: "int", nullable: true),
                    Width = table.Column<int>(type: "int", nullable: true),
                    Length = table.Column<int>(type: "int", nullable: true),
                    Notes = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientFileDevice", x => x.ClientFileDeviceID);
                    table.ForeignKey(
                        name: "FK_ClientFileDevice_ClientFile",
                        column: x => x.ClientFileID,
                        principalTable: "ClientFile",
                        principalColumn: "ClientFileID");
                });

            migrationBuilder.CreateTable(
                name: "ClientFileFollow",
                columns: table => new
                {
                    ClientFileFollowID = table.Column<int>(type: "int", nullable: false),
                    ClientFileID = table.Column<int>(type: "int", nullable: false),
                    NoteDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Notes = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastAction = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ClientFileFollow", x => new { x.ClientFileID, x.ClientFileFollowID });
                    table.ForeignKey(
                        name: "FK_ClientFileFollow_ClientFile",
                        column: x => x.ClientFileID,
                        principalTable: "ClientFile",
                        principalColumn: "ClientFileID");
                });

            migrationBuilder.CreateTable(
                name: "ClientFileItem",
                columns: table => new
                {
                    ClientFileItemID = table.Column<int>(type: "int", nullable: false),
                    ClientFileID = table.Column<int>(type: "int", nullable: false),
                    ItemID = table.Column<int>(type: "int", nullable: true),
                    ItemCount = table.Column<decimal>(type: "decimal(18,3)", nullable: true),
                    ItemPrice = table.Column<decimal>(type: "decimal(18,5)", nullable: true),
                    ItemPriceAfterDiscount = table.Column<decimal>(type: "decimal(18,5)", nullable: true),
                    ItemTypeID = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Width = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    Hieght = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    Length = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    NOTES = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    DoorTypeID = table.Column<int>(type: "int", nullable: true),
                    Direction = table.Column<int>(type: "int", nullable: true),
                    itemcolor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ItemColorID = table.Column<int>(type: "int", nullable: true),
                    AccOption = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    CategoryID = table.Column<int>(type: "int", nullable: true),
                    WithAbajur = table.Column<int>(type: "int", nullable: true),
                    WithMotor = table.Column<int>(type: "int", nullable: true),
                    NoOfRoof = table.Column<int>(type: "int", nullable: true),
                    KaabTypeID = table.Column<int>(type: "int", nullable: true),
                    LenghtSection = table.Column<int>(type: "int", nullable: true),
                    WidthSection = table.Column<int>(type: "int", nullable: true),
                    DoorHole = table.Column<int>(type: "int", nullable: true),
                    Serial = table.Column<int>(type: "int", nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ItemName = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientFileItem", x => new { x.ClientFileItemID, x.ClientFileID });
                    table.ForeignKey(
                        name: "FK_ClientFileItem_ClientFile",
                        column: x => x.ClientFileID,
                        principalTable: "ClientFile",
                        principalColumn: "ClientFileID");
                });

            migrationBuilder.CreateTable(
                name: "CLientFileProperties",
                columns: table => new
                {
                    ClientFileDetailID = table.Column<int>(type: "int", nullable: false),
                    ClientFileID = table.Column<int>(type: "int", nullable: false),
                    ClientFileTypeID = table.Column<int>(type: "int", nullable: true),
                    CarkeesTypeID = table.Column<int>(type: "int", nullable: true),
                    Hieght = table.Column<int>(type: "int", nullable: true),
                    MainColorID = table.Column<int>(type: "int", nullable: true),
                    SubColorID = table.Column<int>(type: "int", nullable: true),
                    HandModelID = table.Column<int>(type: "int", nullable: true),
                    GlassTypeID = table.Column<int>(type: "int", nullable: true),
                    FasalehTypeID = table.Column<int>(type: "int", nullable: true),
                    MajlahTypeID = table.Column<int>(type: "int", nullable: true),
                    BaterryTypeID = table.Column<int>(type: "int", nullable: true),
                    BaneltypeID = table.Column<int>(type: "int", nullable: true),
                    MajlehHallID = table.Column<int>(type: "int", nullable: true),
                    TopTypeID = table.Column<int>(type: "int", nullable: true),
                    TopWidth = table.Column<int>(type: "int", nullable: true),
                    TopColorID = table.Column<int>(type: "int", nullable: true),
                    AdditionalSide = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    WaterProofHieght = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    KitchenTypeID = table.Column<int>(type: "int", nullable: true),
                    HandCount = table.Column<int>(type: "int", nullable: true),
                    BanelCount = table.Column<int>(type: "int", nullable: true),
                    TopCount = table.Column<int>(type: "int", nullable: true),
                    ShaffatID = table.Column<int>(type: "int", nullable: true),
                    HoleID = table.Column<int>(type: "int", nullable: true),
                    HoleCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLientFileProperties", x => new { x.ClientFileDetailID, x.ClientFileID });
                    table.ForeignKey(
                        name: "FK_CLientFileProperties_ClientFile",
                        column: x => x.ClientFileID,
                        principalTable: "ClientFile",
                        principalColumn: "ClientFileID");
                });

            migrationBuilder.CreateTable(
                name: "ClientSurvey",
                columns: table => new
                {
                    ClientSurveyID = table.Column<int>(type: "int", nullable: false),
                    SurveyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    AwardCertificate = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ClientFileID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ClientSu__88BE9D53ECDFD072", x => x.ClientSurveyID);
                    table.ForeignKey(
                        name: "FK_ClientSurvey_ClientFile",
                        column: x => x.ClientFileID,
                        principalTable: "ClientFile",
                        principalColumn: "ClientFileID");
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    teamName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    teamType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ClientFileId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.id);
                    table.ForeignKey(
                        name: "FK_Teams_ClientFile",
                        column: x => x.ClientFileId,
                        principalTable: "ClientFile",
                        principalColumn: "ClientFileID");
                });

            migrationBuilder.CreateTable(
                name: "ClientSurveyAnswer",
                columns: table => new
                {
                    ClientSurveyID = table.Column<int>(type: "int", nullable: false),
                    QuestionID = table.Column<int>(type: "int", nullable: false),
                    AnswerID = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ClientSurveyAnswer", x => new { x.QuestionID, x.ClientSurveyID });
                    table.ForeignKey(
                        name: "FK_ClientSurveyAnswer_ClientSurvey",
                        column: x => x.ClientSurveyID,
                        principalTable: "ClientSurvey",
                        principalColumn: "ClientSurveyID");
                    table.ForeignKey(
                        name: "FK_ClientSurveyAnswer_Question",
                        column: x => x.QuestionID,
                        principalTable: "Question",
                        principalColumn: "QuestionID");
                    table.ForeignKey(
                        name: "FK_ClientSurveyAnswer_QusetionAnswer",
                        column: x => x.AnswerID,
                        principalTable: "QusetionAnswer",
                        principalColumn: "AnswerID");
                });

            migrationBuilder.CreateTable(
                name: "ClientSurveyDetail",
                columns: table => new
                {
                    DetailID = table.Column<int>(type: "int", nullable: false),
                    ClientSurveyID = table.Column<int>(type: "int", nullable: false),
                    SurveyNotes = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ClientSurveyDetail", x => new { x.DetailID, x.ClientSurveyID });
                    table.ForeignKey(
                        name: "FK_ClientSurveyDetail_ClientSurvey",
                        column: x => x.ClientSurveyID,
                        principalTable: "ClientSurvey",
                        principalColumn: "ClientSurveyID");
                });

            migrationBuilder.CreateTable(
                name: "ClientFileRelatedDates",
                columns: table => new
                {
                    ClientFileID = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "date", nullable: true),
                    FinishDate = table.Column<DateTime>(type: "date", nullable: true),
                    StartPaintDate = table.Column<DateTime>(type: "date", nullable: true),
                    ProductionEndDate = table.Column<DateTime>(type: "date", nullable: true),
                    ProductiorStartDate = table.Column<DateTime>(type: "date", nullable: true),
                    ProductionAnalyzeDate = table.Column<DateTime>(type: "date", nullable: true),
                    FormalID = table.Column<int>(type: "int", nullable: true),
                    paintFormalId = table.Column<int>(type: "int", nullable: true),
                    operatorFormalId = table.Column<int>(type: "int", nullable: true),
                    paintTeamId = table.Column<int>(type: "int", nullable: true),
                    operationTeamId = table.Column<int>(type: "int", nullable: true),
                    assempleTeamId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientFileRelatedDates", x => x.ClientFileID);
                    table.ForeignKey(
                        name: "FK_ClientFileRelatedDates_Teams",
                        column: x => x.paintTeamId,
                        principalTable: "Teams",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_ClientFileRelatedDates_Teams1",
                        column: x => x.operationTeamId,
                        principalTable: "Teams",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_ClientFileRelatedDates_Teams2",
                        column: x => x.assempleTeamId,
                        principalTable: "Teams",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Users_Teams",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users_Teams", x => x.id);
                    table.ForeignKey(
                        name: "FK_Users_Teams_Teams",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Users_Teams_Users",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AN_ClientFileDetail_CatgeoryID",
                table: "AN_ClientFileDetail",
                column: "CatgeoryID");

            migrationBuilder.CreateIndex(
                name: "IX_AN_ClientFileDetail_ClientFIleitemID",
                table: "AN_ClientFileDetail",
                column: "ClientFIleitemID");

            migrationBuilder.CreateIndex(
                name: "IX_AN_ClientFileDetail_TypeID",
                table: "AN_ClientFileDetail",
                column: "TypeID");

            migrationBuilder.CreateIndex(
                name: "IX_AN_ClientFileItem_ClientFIleiD",
                table: "AN_ClientFileItem",
                column: "ClientFIleiD");

            migrationBuilder.CreateIndex(
                name: "IX_AN_ClientFileItem_CuttingListCategoryID",
                table: "AN_ClientFileItem",
                column: "CuttingListCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_AN_ClientFileItem_Grain",
                table: "AN_ClientFileItem",
                column: "Grain");

            migrationBuilder.CreateIndex(
                name: "IX_AN_ClientFileItem_MaterialID",
                table: "AN_ClientFileItem",
                column: "MaterialID");

            migrationBuilder.CreateIndex(
                name: "IX_AN_ClientFileItem_UnitID",
                table: "AN_ClientFileItem",
                column: "UnitID");

            migrationBuilder.CreateIndex(
                name: "IX_An_CuttingListDetail_ClientFileID",
                table: "An_CuttingListDetail",
                column: "ClientFileID");

            migrationBuilder.CreateIndex(
                name: "IX_An_CuttingListDetail_GrainID",
                table: "An_CuttingListDetail",
                column: "GrainID");

            migrationBuilder.CreateIndex(
                name: "IX_An_CuttingListDetail_MaterialID",
                table: "An_CuttingListDetail",
                column: "MaterialID");

            migrationBuilder.CreateIndex(
                name: "IX_An_CuttingListDetail_SizeID",
                table: "An_CuttingListDetail",
                column: "SizeID");

            migrationBuilder.CreateIndex(
                name: "IX_An_CuttingListDetail_ThicknessID",
                table: "An_CuttingListDetail",
                column: "ThicknessID");

            migrationBuilder.CreateIndex(
                name: "IX_AN_ITEMDETAIL_CuttingListCatgeoryID",
                table: "AN_ITEMDETAIL",
                column: "CuttingListCatgeoryID");

            migrationBuilder.CreateIndex(
                name: "IX_AN_ITEMDETAIL_HandTypeID",
                table: "AN_ITEMDETAIL",
                column: "HandTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientFile_ClientID",
                table: "ClientFile",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_CLientFileDetail_ClientFileID",
                table: "CLientFileDetail",
                column: "ClientFileID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientFileDevice_ClientFileID",
                table: "ClientFileDevice",
                column: "ClientFileID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientFileItem_ClientFileID",
                table: "ClientFileItem",
                column: "ClientFileID");

            migrationBuilder.CreateIndex(
                name: "ix_ClientFileLog",
                table: "ClientFileLog",
                column: "ClientFileID");

            migrationBuilder.CreateIndex(
                name: "IX_CLientFileProperties_ClientFileID",
                table: "CLientFileProperties",
                column: "ClientFileID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientFileRelatedDates_assempleTeamId",
                table: "ClientFileRelatedDates",
                column: "assempleTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientFileRelatedDates_operationTeamId",
                table: "ClientFileRelatedDates",
                column: "operationTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientFileRelatedDates_paintTeamId",
                table: "ClientFileRelatedDates",
                column: "paintTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientPayment_ClientID",
                table: "ClientPayment",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientShortageDetail_ClientFileID_ClientShortageID",
                table: "ClientShortageDetail",
                columns: new[] { "ClientFileID", "ClientShortageID" });

            migrationBuilder.CreateIndex(
                name: "IX_ClientSurvey_ClientFileID",
                table: "ClientSurvey",
                column: "ClientFileID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientSurveyAnswer_AnswerID",
                table: "ClientSurveyAnswer",
                column: "AnswerID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientSurveyAnswer_ClientSurveyID",
                table: "ClientSurveyAnswer",
                column: "ClientSurveyID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientSurveyDetail_ClientSurveyID",
                table: "ClientSurveyDetail",
                column: "ClientSurveyID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemTypePrice_ItemID",
                table: "ItemTypePrice",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemTypePrice_ItemTypeID",
                table: "ItemTypePrice",
                column: "ItemTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Status_StatusCategoryID",
                table: "Status",
                column: "StatusCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_ClientFileId",
                table: "Teams",
                column: "ClientFileId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Teams_TeamId",
                table: "Users_Teams",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Teams_UserId",
                table: "Users_Teams",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AN_ClientFileDetail_AN_ClientFileItem",
                table: "AN_ClientFileDetail",
                column: "ClientFIleitemID",
                principalTable: "AN_ClientFileItem",
                principalColumn: "ClientFIleitemID");

            migrationBuilder.AddForeignKey(
                name: "FK_AN_ClientFileDetail_ClientFile",
                table: "AN_ClientFileItem",
                column: "ClientFIleiD",
                principalTable: "ClientFile",
                principalColumn: "ClientFileID");

            migrationBuilder.AddForeignKey(
                name: "FK_An_CuttingListDetail_ClientFile",
                table: "An_CuttingListDetail",
                column: "ClientFileID",
                principalTable: "ClientFile",
                principalColumn: "ClientFileID",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientFile_ClientFileRelatedDates",
                table: "ClientFile",
                column: "ClientFileID",
                principalTable: "ClientFileRelatedDates",
                principalColumn: "ClientFileID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_ClientFile",
                table: "Teams");

            migrationBuilder.DropTable(
                name: "AN_ClientFileDetail");

            migrationBuilder.DropTable(
                name: "An_CuttingListDetail");

            migrationBuilder.DropTable(
                name: "AN_ITEMDETAIL");

            migrationBuilder.DropTable(
                name: "ClientFileAnalyse");

            migrationBuilder.DropTable(
                name: "ClientFileAttachment");

            migrationBuilder.DropTable(
                name: "CLientFileDetail");

            migrationBuilder.DropTable(
                name: "ClientFileDevice");

            migrationBuilder.DropTable(
                name: "ClientFileFollow");

            migrationBuilder.DropTable(
                name: "ClientFileItem");

            migrationBuilder.DropTable(
                name: "CLientFileITEm20210702");

            migrationBuilder.DropTable(
                name: "ClientFileLog");

            migrationBuilder.DropTable(
                name: "ClientFilePayments");

            migrationBuilder.DropTable(
                name: "CLientFileProperties");

            migrationBuilder.DropTable(
                name: "ClientFileStatus");

            migrationBuilder.DropTable(
                name: "ClientFileTawseel");

            migrationBuilder.DropTable(
                name: "ClientFileTop");

            migrationBuilder.DropTable(
                name: "ClientFileTopDevices");

            migrationBuilder.DropTable(
                name: "ClientFollow2");

            migrationBuilder.DropTable(
                name: "Clientmaintainance");

            migrationBuilder.DropTable(
                name: "ClientMaintainanceAttachment");

            migrationBuilder.DropTable(
                name: "ClientPayment");

            migrationBuilder.DropTable(
                name: "ClientShortageAttachment");

            migrationBuilder.DropTable(
                name: "ClientShortageDetail");

            migrationBuilder.DropTable(
                name: "ClientSurveyAnswer");

            migrationBuilder.DropTable(
                name: "ClientSurveyDetail");

            migrationBuilder.DropTable(
                name: "CurrFile");

            migrationBuilder.DropTable(
                name: "DayNumber");

            migrationBuilder.DropTable(
                name: "DoorDetails");

            migrationBuilder.DropTable(
                name: "ItemDetail");

            migrationBuilder.DropTable(
                name: "ItemTypePrice");

            migrationBuilder.DropTable(
                name: "ITemTYpePrice20200218");

            migrationBuilder.DropTable(
                name: "ITEMTYPEPRICE20220320");

            migrationBuilder.DropTable(
                name: "ItemTypePrice20220609");

            migrationBuilder.DropTable(
                name: "itemtypeprice20220616");

            migrationBuilder.DropTable(
                name: "Money");

            migrationBuilder.DropTable(
                name: "NotifciationSetupDetail");

            migrationBuilder.DropTable(
                name: "NotifciationSetupUserType");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Reminders");

            migrationBuilder.DropTable(
                name: "Status2020");

            migrationBuilder.DropTable(
                name: "Status20201");

            migrationBuilder.DropTable(
                name: "Status20210130_1");

            migrationBuilder.DropTable(
                name: "Users_Teams");

            migrationBuilder.DropTable(
                name: "AN_ClientFileItem");

            migrationBuilder.DropTable(
                name: "AN_HandType");

            migrationBuilder.DropTable(
                name: "AN_Category");

            migrationBuilder.DropTable(
                name: "ClientShortage");

            migrationBuilder.DropTable(
                name: "Question");

            migrationBuilder.DropTable(
                name: "QusetionAnswer");

            migrationBuilder.DropTable(
                name: "ClientSurvey");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "AN_CuttingListCatgeory");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "StatusCategory");

            migrationBuilder.DropTable(
                name: "ClientFile");

            migrationBuilder.DropTable(
                name: "CLIENTS");

            migrationBuilder.DropTable(
                name: "ClientFileRelatedDates");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
