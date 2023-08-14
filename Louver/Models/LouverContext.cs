using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Louver.Models;

public partial class LouverContext : DbContext
{
    public LouverContext()
    {
    }

    public LouverContext(DbContextOptions<LouverContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AnCategory> AnCategories { get; set; }

    public virtual DbSet<AnClientFileDetail> AnClientFileDetails { get; set; }

    public virtual DbSet<AnClientFileItem> AnClientFileItems { get; set; }

    public virtual DbSet<AnCuttingListCatgeory> AnCuttingListCatgeories { get; set; }

    public virtual DbSet<AnCuttingListDetail> AnCuttingListDetails { get; set; }

    public virtual DbSet<AnHandType> AnHandTypes { get; set; }

    public virtual DbSet<AnItemdetail> AnItemdetails { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<ClientFile> ClientFiles { get; set; }

    public virtual DbSet<ClientFileAnalyse> ClientFileAnalyses { get; set; }

    public virtual DbSet<ClientFileAttachment> ClientFileAttachments { get; set; }

    public virtual DbSet<ClientFileDetail> ClientFileDetails { get; set; }

    public virtual DbSet<ClientFileDevice> ClientFileDevices { get; set; }

    public virtual DbSet<ClientFileFollow> ClientFileFollows { get; set; }

    public virtual DbSet<ClientFileItem> ClientFileItems { get; set; }

    public virtual DbSet<ClientFileItem20210702> ClientFileItem20210702s { get; set; }

    public virtual DbSet<ClientFileLog> ClientFileLogs { get; set; }

    public virtual DbSet<ClientFilePayment> ClientFilePayments { get; set; }

    public virtual DbSet<ClientFileProperty> ClientFileProperties { get; set; }

    public virtual DbSet<ClientFileProperty1> ClientFileProperties1 { get; set; }

    public virtual DbSet<ClientFileStatus> ClientFileStatuses { get; set; }

    public virtual DbSet<ClientFileTawseel> ClientFileTawseels { get; set; }

    public virtual DbSet<ClientFileTop> ClientFileTops { get; set; }

    public virtual DbSet<ClientFileTopDevice> ClientFileTopDevices { get; set; }

    public virtual DbSet<ClientFollow2> ClientFollow2s { get; set; }

    public virtual DbSet<ClientMaintainanceAttachment> ClientMaintainanceAttachments { get; set; }

    public virtual DbSet<ClientPayment> ClientPayments { get; set; }

    public virtual DbSet<ClientShortage> ClientShortages { get; set; }

    public virtual DbSet<ClientShortageAttachment> ClientShortageAttachments { get; set; }

    public virtual DbSet<ClientShortageDetail> ClientShortageDetails { get; set; }

    public virtual DbSet<ClientSurvey> ClientSurveys { get; set; }

    public virtual DbSet<ClientSurveyAnswer> ClientSurveyAnswers { get; set; }

    public virtual DbSet<ClientSurveyDetail> ClientSurveyDetails { get; set; }

    public virtual DbSet<Clientmaintainance> Clientmaintainances { get; set; }

    public virtual DbSet<CurrFile> CurrFiles { get; set; }

    public virtual DbSet<DayNumber> DayNumbers { get; set; }

    public virtual DbSet<DoorDetail> DoorDetails { get; set; }

    public virtual DbSet<ItemDetail> ItemDetails { get; set; }

    public virtual DbSet<ItemTypePrice> ItemTypePrices { get; set; }

    public virtual DbSet<ItemTypePrice20200218> ItemTypePrice20200218s { get; set; }

    public virtual DbSet<ItemTypePrice20220609> ItemTypePrice20220609s { get; set; }

    public virtual DbSet<Itemtypeprice20220320> Itemtypeprice20220320s { get; set; }

    public virtual DbSet<Itemtypeprice20220616> Itemtypeprice20220616s { get; set; }

    public virtual DbSet<Money> Money { get; set; }

    public virtual DbSet<NotifciationSetupDetail> NotifciationSetupDetails { get; set; }

    public virtual DbSet<NotifciationSetupUserType> NotifciationSetupUserTypes { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<Question> Questions { get; set; }

    public virtual DbSet<QusetionAnswer> QusetionAnswers { get; set; }

    public virtual DbSet<Reminder> Reminders { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<Status2020> Status2020s { get; set; }

    public virtual DbSet<Status20201> Status20201s { get; set; }

    public virtual DbSet<Status202101301> Status202101301s { get; set; }

    public virtual DbSet<StatusCategory> StatusCategories { get; set; }

    public virtual DbSet<User> Users { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=tcp:194.163.132.242\\SQLEXPRESS,56773;Initial Catalog=Louver;User ID=kitchen1;Password=kitchen1;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Arabic_CI_AS");

        modelBuilder.Entity<AnCategory>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__AN_Categ__19093A2B5C31EEB2");

            entity.ToTable("AN_Category");

            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.DefaultDescAr)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DefaultDescEn)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.HasCount).HasColumnName("hasCount");
            entity.Property(e => e.HasHeight).HasColumnName("hasHeight");
            entity.Property(e => e.HasLength).HasColumnName("hasLength");
            entity.Property(e => e.HasWidth).HasColumnName("hasWidth");
            entity.Property(e => e.TypeId).HasColumnName("TypeID");
        });

        modelBuilder.Entity<AnClientFileDetail>(entity =>
        {
            entity.HasKey(e => e.DetailId).HasName("PK__AN_Clien__135C314DA845EAC6");

            entity.ToTable("AN_ClientFileDetail");

            entity.Property(e => e.DetailId).HasColumnName("DetailID");
            entity.Property(e => e.CatgeoryId).HasColumnName("CatgeoryID");
            entity.Property(e => e.ClientFileitemId).HasColumnName("ClientFIleitemID");
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.Hieght).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Length).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.ModificationDate).HasColumnType("datetime");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("QTY");
            entity.Property(e => e.TypeId).HasColumnName("TypeID");
            entity.Property(e => e.Width).HasColumnType("decimal(18, 3)");

            entity.HasOne(d => d.Catgeory).WithMany(p => p.AnClientFileDetails)
                .HasForeignKey(d => d.CatgeoryId)
                .HasConstraintName("FK_AN_ClientFileDetail_AN_Category");

            entity.HasOne(d => d.ClientFileitem).WithMany(p => p.AnClientFileDetails)
                .HasForeignKey(d => d.ClientFileitemId)
                .HasConstraintName("FK_AN_ClientFileDetail_AN_ClientFileItem");

            entity.HasOne(d => d.Type).WithMany(p => p.AnClientFileDetails)
                .HasForeignKey(d => d.TypeId)
                .HasConstraintName("FK_AN_ClientFileDetail_FK5");
        });

        modelBuilder.Entity<AnClientFileItem>(entity =>
        {
            entity.HasKey(e => e.ClientFileitemId).HasName("PK__AN_Clien__92F51EADAFFAAC1C");

            entity.ToTable("AN_ClientFileItem");

            entity.Property(e => e.ClientFileitemId).HasColumnName("ClientFIleitemID");
            entity.Property(e => e.ClientFileiD).HasColumnName("ClientFIleiD");
            entity.Property(e => e.Color)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.CuttingListCategoryId).HasColumnName("CuttingListCategoryID");
            entity.Property(e => e.FinalStatusId).HasColumnName("FinalStatusID");
            entity.Property(e => e.MaterialId).HasColumnName("MaterialID");
            entity.Property(e => e.ModificationDate).HasColumnType("datetime");
            entity.Property(e => e.Notes)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.UnitId).HasColumnName("UnitID");

            entity.HasOne(d => d.ClientFile).WithMany(p => p.AnClientFileItems)
                .HasForeignKey(d => d.ClientFileiD)
                .HasConstraintName("FK_AN_ClientFileDetail_ClientFile");

            entity.HasOne(d => d.CuttingListCategory).WithMany(p => p.AnClientFileItems)
                .HasForeignKey(d => d.CuttingListCategoryId)
                .HasConstraintName("FK_AN_ClientFileDetail_FK1");

            entity.HasOne(d => d.GrainNavigation).WithMany(p => p.AnClientFileItemGrainNavigations)
                .HasForeignKey(d => d.Grain)
                .HasConstraintName("grain");

            entity.HasOne(d => d.Material).WithMany(p => p.AnClientFileItemMaterials)
                .HasForeignKey(d => d.MaterialId)
                .HasConstraintName("material");

            entity.HasOne(d => d.Unit).WithMany(p => p.AnClientFileItemUnits)
                .HasForeignKey(d => d.UnitId)
                .HasConstraintName("unit");
        });

        modelBuilder.Entity<AnCuttingListCatgeory>(entity =>
        {
            entity.HasKey(e => e.CuttingListCatgeoryId).HasName("PK__AN_Cutti__1814C71B9C7CDFF8");

            entity.ToTable("AN_CuttingListCatgeory");

            entity.Property(e => e.CuttingListCatgeoryId)
                .ValueGeneratedNever()
                .HasColumnName("CuttingListCatgeoryID");
            entity.Property(e => e.DefaultDescAr)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DefaultDescEn)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AnCuttingListDetail>(entity =>
        {
            entity.HasKey(e => e.CuttingListDetailId);

            entity.ToTable("An_CuttingListDetail");

            entity.Property(e => e.CuttingListDetailId).HasColumnName("CuttingListDetailID");
            entity.Property(e => e.ClientFileId).HasColumnName("ClientFileID");
            entity.Property(e => e.Color1)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.DetailId).HasColumnName("DetailID");
            entity.Property(e => e.MaterialId).HasColumnName("MaterialID");
            entity.Property(e => e.ModificationDate).HasColumnType("datetime");
            entity.Property(e => e.TypeId).HasColumnName("TypeID");

            entity.HasOne(d => d.ClientFile).WithMany(p => p.AnCuttingListDetails)
                .HasForeignKey(d => d.ClientFileId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_An_CuttingListDetail_ClientFile");
        });

        modelBuilder.Entity<AnHandType>(entity =>
        {
            entity.HasKey(e => e.HandTypeId).HasName("PK__AN_HandT__3F15E4D4005E487A");

            entity.ToTable("AN_HandType");

            entity.Property(e => e.HandTypeId)
                .ValueGeneratedNever()
                .HasColumnName("HandTypeID");
            entity.Property(e => e.DefaultDescAr)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DefaultDescEn)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AnItemdetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AN_ITEMDETAIL");

            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CuttingListCatgeoryId).HasColumnName("CuttingListCatgeoryID");
            entity.Property(e => e.DetailId).HasColumnName("DetailID");
            entity.Property(e => e.HandTypeId).HasColumnName("HandTypeID");
            entity.Property(e => e.ItemId).HasColumnName("ItemID");
            entity.Property(e => e.Length).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Width).HasColumnType("decimal(18, 3)");

            entity.HasOne(d => d.CuttingListCatgeory).WithMany()
                .HasForeignKey(d => d.CuttingListCatgeoryId)
                .HasConstraintName("fk_AN_ITEMDETAIL2");

            entity.HasOne(d => d.HandType).WithMany()
                .HasForeignKey(d => d.HandTypeId)
                .HasConstraintName("fk_AN_ITEMDETAIL3");

            entity.HasOne(d => d.HandTypeNavigation).WithMany()
                .HasForeignKey(d => d.HandTypeId)
                .HasConstraintName("fk_AN_ITEMDETAIL1");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.ClientId).HasName("PK__CLIENTS__E67E1A04EBD6B904");

            entity.ToTable("CLIENTS");

            entity.Property(e => e.ClientId)
                .ValueGeneratedNever()
                .HasColumnName("ClientID");
            entity.Property(e => e.ClientAddress)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.ClientName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ClientStatusId).HasColumnName("ClientStatusID");
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Fax)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Mobile)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ModificationDate).HasColumnType("datetime");
            entity.Property(e => e.RefClientId).HasColumnName("RefClientID");
            entity.Property(e => e.Tel1)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ClientFile>(entity =>
        {
            entity.ToTable("ClientFile");

            entity.Property(e => e.ClientFileId)
                .ValueGeneratedNever()
                .HasColumnName("ClientFileID");
            entity.Property(e => e.AccessoryDiscount).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.ActionByDate).HasColumnType("datetime");
            entity.Property(e => e.AdditionalAmount).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.AdditionalNotes)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Additionaldiscount).HasColumnName("additionaldiscount");
            entity.Property(e => e.AllPrice).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Attachment1)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Attachment2)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.AttentionMr)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AttentionMrTel)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ClientId).HasColumnName("ClientID");
            entity.Property(e => e.ClientNeed)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.ContractDate).HasColumnType("datetime");
            entity.Property(e => e.ContractNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ContractStatusId).HasColumnName("ContractStatusID");
            entity.Property(e => e.Contractor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ContractorTel)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.DesignOrder)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DesignStatusId).HasColumnName("DesignStatusID");
            entity.Property(e => e.DesignerDate).HasColumnType("datetime");
            entity.Property(e => e.DesignerId).HasColumnName("DesignerID");
            entity.Property(e => e.DeviceNotes)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.ExternalDoorModel)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FactoryConfirmId).HasColumnName("FactoryConfirmID");
            entity.Property(e => e.FactoryNotes)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.FileDate).HasColumnType("datetime");
            entity.Property(e => e.FileTypeId).HasColumnName("FileTypeID");
            entity.Property(e => e.FinalStatusId).HasColumnName("FinalStatusID");
            entity.Property(e => e.Follow)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.InternalDoorModel)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
            entity.Property(e => e.KitchecnModelId).HasColumnName("KitchecnModelID");
            entity.Property(e => e.KitchenLocation)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.MeasurmentDate).HasColumnType("datetime");
            entity.Property(e => e.Measurmentid)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ModificationDate).HasColumnType("datetime");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.OfferNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Owner)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Project)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ProjectManager)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RelatedClientFileId).HasColumnName("RelatedClientFileID");
            entity.Property(e => e.Remarks)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Remarks2)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.SalesId).HasColumnName("SalesID");
            entity.Property(e => e.SentToFactoryDate).HasColumnType("datetime");
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.TarkeebDate).HasColumnType("datetime");
            entity.Property(e => e.TopDiscount).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.WindowPrefix)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Client).WithMany(p => p.ClientFiles)
                .HasForeignKey(d => d.ClientId)
                .HasConstraintName("FK_ClientFile_CLIENTS");
        });

        modelBuilder.Entity<ClientFileAnalyse>(entity =>
        {
            entity.HasKey(e => new { e.DetailId, e.ClientFileiD });

            entity.ToTable("ClientFileAnalyse");

            entity.Property(e => e.DetailId).HasColumnName("DetailID");
            entity.Property(e => e.ClientFileiD).HasColumnName("ClientFIleiD");
            entity.Property(e => e.Color)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.ItemCategoryId).HasColumnName("ItemCategoryID");
            entity.Property(e => e.ItemCount)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Length)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Notes)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.TypeId).HasColumnName("TypeID");
            entity.Property(e => e.Width)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ClientFileAttachment>(entity =>
        {
            entity.HasKey(e => new { e.ClientFileAttachmentId, e.ClientFileId });

            entity.ToTable("ClientFileAttachment");

            entity.Property(e => e.ClientFileAttachmentId).HasColumnName("ClientFileAttachmentID");
            entity.Property(e => e.ClientFileId).HasColumnName("ClientFileID");
            entity.Property(e => e.AttachmentPath)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.ModificationDate).HasColumnType("datetime");
            entity.Property(e => e.Notes)
                .HasMaxLength(1000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ClientFileDetail>(entity =>
        {
            entity.HasKey(e => new { e.ClientFileDetailId, e.ClientFileId });

            entity.ToTable("CLientFileDetail");

            entity.Property(e => e.ClientFileDetailId).HasColumnName("ClientFileDetailID");
            entity.Property(e => e.ClientFileId).HasColumnName("ClientFileID");
            entity.Property(e => e.AdditionalSide)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.BaneltypeId).HasColumnName("BaneltypeID");
            entity.Property(e => e.BaterryTypeId).HasColumnName("BaterryTypeID");
            entity.Property(e => e.CarkeesTypeId).HasColumnName("CarkeesTypeID");
            entity.Property(e => e.ClientFileTypeId).HasColumnName("ClientFileTypeID");
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.FasalehTypeId).HasColumnName("FasalehTypeID");
            entity.Property(e => e.GlassTypeId).HasColumnName("GlassTypeID");
            entity.Property(e => e.HandModelId).HasColumnName("HandModelID");
            entity.Property(e => e.MainColorId).HasColumnName("MainColorID");
            entity.Property(e => e.MajlahTypeId).HasColumnName("MajlahTypeID");
            entity.Property(e => e.MajlehHallId).HasColumnName("MajlehHallID");
            entity.Property(e => e.ModificationDate).HasColumnType("datetime");
            entity.Property(e => e.SubColorId).HasColumnName("SubColorID");
            entity.Property(e => e.TopColorId).HasColumnName("TopColorID");
            entity.Property(e => e.TopTypeId).HasColumnName("TopTypeID");

            entity.HasOne(d => d.ClientFile).WithMany(p => p.ClientFileDetails)
                .HasForeignKey(d => d.ClientFileId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CLientFileDetail_ClientFile");
        });

        modelBuilder.Entity<ClientFileDevice>(entity =>
        {
            entity.ToTable("ClientFileDevice");

            entity.Property(e => e.ClientFileDeviceId)
                .ValueGeneratedNever()
                .HasColumnName("ClientFileDeviceID");
            entity.Property(e => e.ClientFileId).HasColumnName("ClientFileID");
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.DeviceId).HasColumnName("DeviceID");
            entity.Property(e => e.DeviceModelId).HasColumnName("DeviceModelID");
            entity.Property(e => e.ModificationDate).HasColumnType("datetime");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.ClientFile).WithMany(p => p.ClientFileDevices)
                .HasForeignKey(d => d.ClientFileId)
                .HasConstraintName("FK_ClientFileDevice_ClientFile");
        });

        modelBuilder.Entity<ClientFileFollow>(entity =>
        {
            entity.HasKey(e => new { e.ClientFileId, e.ClientFileFollowId }).HasName("pk_ClientFileFollow");

            entity.ToTable("ClientFileFollow");

            entity.Property(e => e.ClientFileId).HasColumnName("ClientFileID");
            entity.Property(e => e.ClientFileFollowId).HasColumnName("ClientFileFollowID");
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.ModificationDate).HasColumnType("datetime");
            entity.Property(e => e.NoteDate).HasColumnType("datetime");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.ClientFile).WithMany(p => p.ClientFileFollows)
                .HasForeignKey(d => d.ClientFileId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ClientFileFollow_ClientFile");
        });

        modelBuilder.Entity<ClientFileItem>(entity =>
        {
            entity.HasKey(e => new { e.ClientFileItemId, e.ClientFileId });

            entity.ToTable("ClientFileItem");

            entity.Property(e => e.ClientFileItemId).HasColumnName("ClientFileItemID");
            entity.Property(e => e.ClientFileId).HasColumnName("ClientFileID");
            entity.Property(e => e.AccOption)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.DoorTypeId).HasColumnName("DoorTypeID");
            entity.Property(e => e.Hieght).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ItemColorId).HasColumnName("ItemColorID");
            entity.Property(e => e.ItemCount).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.ItemId).HasColumnName("ItemID");
            entity.Property(e => e.ItemName)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.ItemPrice).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.ItemPriceAfterDiscount).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.ItemTypeId).HasColumnName("ItemTypeID");
            entity.Property(e => e.Itemcolor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("itemcolor");
            entity.Property(e => e.KaabTypeId).HasColumnName("KaabTypeID");
            entity.Property(e => e.Length).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ModificationDate).HasColumnType("datetime");
            entity.Property(e => e.Notes)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("NOTES");
            entity.Property(e => e.Width).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.ClientFile).WithMany(p => p.ClientFileItems)
                .HasForeignKey(d => d.ClientFileId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ClientFileItem_ClientFile");
        });

        modelBuilder.Entity<ClientFileItem20210702>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CLientFileITEm20210702");

            entity.Property(e => e.AccOption)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.ClientFileId).HasColumnName("ClientFileID");
            entity.Property(e => e.ClientFileItemId).HasColumnName("ClientFileItemID");
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.DoorTypeId).HasColumnName("DoorTypeID");
            entity.Property(e => e.ItemColorId).HasColumnName("ItemColorID");
            entity.Property(e => e.ItemCount).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.ItemId).HasColumnName("ItemID");
            entity.Property(e => e.ItemPrice).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.ItemPriceAfterDiscount).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.ItemTypeId).HasColumnName("ItemTypeID");
            entity.Property(e => e.Itemcolor).HasColumnName("itemcolor");
            entity.Property(e => e.ModificationDate).HasColumnType("datetime");
            entity.Property(e => e.Notes)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("NOTES");
        });

        modelBuilder.Entity<ClientFileLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ClientFileLog");

            entity.HasIndex(e => e.ClientFileId, "ix_ClientFileLog");

            entity.Property(e => e.ClientFileId).HasColumnName("ClientFileID");
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.DetailId).HasColumnName("DetailID");
            entity.Property(e => e.FromValue)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Notes)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.ToValue)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.TypeId).HasColumnName("TypeID");
        });

        modelBuilder.Entity<ClientFilePayment>(entity =>
        {
            entity.HasKey(e => new { e.ClientFileId, e.PaymentId, e.DetailId }).HasName("pk_clientfilePayment");

            entity.Property(e => e.ClientFileId).HasColumnName("ClientFileID");
            entity.Property(e => e.PaymentId).HasColumnName("PaymentID");
            entity.Property(e => e.DetailId).HasColumnName("DetailID");
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
        });

        modelBuilder.Entity<ClientFileProperty>(entity =>
        {
            entity.HasKey(e => new { e.ClientFileDetailId, e.ClientFileId });

            entity.ToTable("CLientFileProperties");

            entity.Property(e => e.ClientFileDetailId).HasColumnName("ClientFileDetailID");
            entity.Property(e => e.ClientFileId).HasColumnName("ClientFileID");
            entity.Property(e => e.AdditionalSide)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.BaneltypeId).HasColumnName("BaneltypeID");
            entity.Property(e => e.BaterryTypeId).HasColumnName("BaterryTypeID");
            entity.Property(e => e.CarkeesTypeId).HasColumnName("CarkeesTypeID");
            entity.Property(e => e.ClientFileTypeId).HasColumnName("ClientFileTypeID");
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.FasalehTypeId).HasColumnName("FasalehTypeID");
            entity.Property(e => e.GlassTypeId).HasColumnName("GlassTypeID");
            entity.Property(e => e.HandModelId).HasColumnName("HandModelID");
            entity.Property(e => e.HoleId).HasColumnName("HoleID");
            entity.Property(e => e.KitchenTypeId).HasColumnName("KitchenTypeID");
            entity.Property(e => e.MainColorId).HasColumnName("MainColorID");
            entity.Property(e => e.MajlahTypeId).HasColumnName("MajlahTypeID");
            entity.Property(e => e.MajlehHallId).HasColumnName("MajlehHallID");
            entity.Property(e => e.ModificationDate).HasColumnType("datetime");
            entity.Property(e => e.ShaffatId).HasColumnName("ShaffatID");
            entity.Property(e => e.SubColorId).HasColumnName("SubColorID");
            entity.Property(e => e.TopColorId).HasColumnName("TopColorID");
            entity.Property(e => e.TopTypeId).HasColumnName("TopTypeID");

            entity.HasOne(d => d.ClientFile).WithMany(p => p.ClientFileProperties)
                .HasForeignKey(d => d.ClientFileId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CLientFileProperties_ClientFile");
        });

        modelBuilder.Entity<ClientFileProperty1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ClientFileProperty");

            entity.Property(e => e.AccessoriesDesc)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AllAccessoriesDesc)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AnticDesc)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AnticId).HasColumnName("AnticID");
            entity.Property(e => e.BanelCount).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.BanelDesc)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.BanelId).HasColumnName("BanelID");
            entity.Property(e => e.BanelPrice).HasColumnType("decimal(38, 8)");
            entity.Property(e => e.BankDesc)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.BatteryDesc)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.BatteryId).HasColumnName("BatteryID");
            entity.Property(e => e.CarcaseTypeNoteDesc)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CladdingDesc)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CladdingId).HasColumnName("CladdingID");
            entity.Property(e => e.ClientFileId).HasColumnName("ClientFileID");
            entity.Property(e => e.ClientId).HasColumnName("ClientID");
            entity.Property(e => e.Color2Desc)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ColumnTableCount).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.ColumnTableDesc)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ColumnTableId).HasColumnName("ColumnTableID");
            entity.Property(e => e.CovingDesc)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CovingId).HasColumnName("CovingID");
            entity.Property(e => e.CurrentLightPrice).HasColumnType("decimal(38, 8)");
            entity.Property(e => e.DevicesDesc)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.FasalatTypeDesc)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.FasalatTypeId).HasColumnName("FasalatTypeID");
            entity.Property(e => e.FileTypeId).HasColumnName("FileTypeID");
            entity.Property(e => e.FittingDesc)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.FrontDesc)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.FrontTypeNoteDesc)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.GlassTypeDesc)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.GlassTypeId).HasColumnName("GlassTypeID");
            entity.Property(e => e.HandCount).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.HandModelDesc)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.HandModelId).HasColumnName("HandModelID");
            entity.Property(e => e.HandPrice)
                .HasColumnType("decimal(38, 8)")
                .HasColumnName("handPrice");
            entity.Property(e => e.HeightDesc)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.HoleCount).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.HoleDesc)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.IncreaseTopPrice).HasColumnType("decimal(38, 8)");
            entity.Property(e => e.IslandTopCount).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.IslandTopDesc)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.IslandTopId).HasColumnName("IslandTopID");
            entity.Property(e => e.ItemTypeDesc)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.KarcasDesc)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.KitchenHeight).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.KitchenHeightNoteDesc)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.KitchenTypeDesc)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.KitchenTypeId).HasColumnName("KitchenTypeID");
            entity.Property(e => e.KitchenWidth).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.LightDesc)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.MainColorDesc)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.MainColorId).HasColumnName("MainColorID");
            entity.Property(e => e.MajlaDesc)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.MajlaHoleDesc)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.MajlaHoleId).HasColumnName("MajlaHoleID");
            entity.Property(e => e.MajlaId).HasColumnName("MajlaID");
            entity.Property(e => e.MajlahHolePrice).HasColumnType("decimal(38, 8)");
            entity.Property(e => e.MajlahPrice).HasColumnType("decimal(38, 8)");
            entity.Property(e => e.ModelDesc)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PatternTypeDesc)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.SecondaryColorDesc)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.SecondaryColorId).HasColumnName("SecondaryColorID");
            entity.Property(e => e.ServiceDesc)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ServicePrice).HasColumnType("decimal(38, 8)");
            entity.Property(e => e.SideTopCount).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.SideTopDesc)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.SideTopId).HasColumnName("SideTopID");
            entity.Property(e => e.SplashCount).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.SplashDesc)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.SplashId).HasColumnName("SplashID");
            entity.Property(e => e.StripDesc)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.SubColorDesc)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.SubColorId).HasColumnName("SubColorID");
            entity.Property(e => e.SuctionDesc)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.SuctionPrice).HasColumnType("decimal(38, 8)");
            entity.Property(e => e.TableTopCount).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.TableTopDesc)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TableTopId).HasColumnName("TableTopID");
            entity.Property(e => e.TapPrice).HasColumnType("decimal(38, 8)");
            entity.Property(e => e.Tasfee7Wood).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TextureDesc)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TextureId).HasColumnName("TextureID");
            entity.Property(e => e.TheTop).HasColumnName("THeTop");
            entity.Property(e => e.TheTopDesc)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("THeTopDesc");
            entity.Property(e => e.TopCount).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.TopInWallPrice).HasColumnType("decimal(38, 8)");
            entity.Property(e => e.VisibleColor)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.WallTopCount).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.WallTopDesc)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.WallTopId).HasColumnName("WallTopID");
        });

        modelBuilder.Entity<ClientFileStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ClientFileStatus");

            entity.Property(e => e.DefaultDesc)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
        });

        modelBuilder.Entity<ClientFileTawseel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ClientFileTawseel");

            entity.Property(e => e.AttachementPath)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ATtachementPath");
            entity.Property(e => e.ClientFileId).HasColumnName("ClientFileID");
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.KitchenHeight).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.ModificationDate).HasColumnType("datetime");
            entity.Property(e => e.Notes)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.PointDescription)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TarkeebDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ClientFileTop>(entity =>
        {
            entity.HasKey(e => new { e.DetailId, e.ClientFileId });

            entity.ToTable("ClientFileTop");

            entity.Property(e => e.DetailId).HasColumnName("DetailID");
            entity.Property(e => e.ClientFileId).HasColumnName("ClientFileID");
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.ModificationDate).HasColumnType("datetime");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PanelTypeId).HasColumnName("PanelTypeID");
            entity.Property(e => e.TopColor)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TopHieght).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.TypeId).HasColumnName("TypeID");
        });

        modelBuilder.Entity<ClientFileTopDevice>(entity =>
        {
            entity.HasKey(e => new { e.DetailId, e.ClientFileId, e.Id });

            entity.Property(e => e.DetailId).HasColumnName("DetailID");
            entity.Property(e => e.ClientFileId).HasColumnName("ClientFileID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AttachmentPath)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.Height).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Length).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.ModificationDate).HasColumnType("datetime");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Width).HasColumnType("decimal(18, 3)");
        });

        modelBuilder.Entity<ClientFollow2>(entity =>
        {
            entity.HasKey(e => new { e.ClientFileId, e.ClientFollow2Id }).HasName("pk_ClientFollow2");

            entity.ToTable("ClientFollow2");

            entity.Property(e => e.ClientFileId).HasColumnName("ClientFileID");
            entity.Property(e => e.ClientFollow2Id).HasColumnName("ClientFollow2ID");
            entity.Property(e => e.AttachmentPath)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.Follow2Date).HasColumnType("datetime");
            entity.Property(e => e.ModificationDate).HasColumnType("datetime");
            entity.Property(e => e.Notes)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.TypeId).HasColumnName("TypeID");
        });

        modelBuilder.Entity<ClientMaintainanceAttachment>(entity =>
        {
            entity.HasKey(e => new { e.ClientFileAttachmentId, e.ClientMaintainanceId }).HasName("PK_ClientFileMaintainanceATT");

            entity.ToTable("ClientMaintainanceAttachment");

            entity.Property(e => e.ClientFileAttachmentId).HasColumnName("ClientFileAttachmentID");
            entity.Property(e => e.ClientMaintainanceId).HasColumnName("ClientMaintainanceID");
            entity.Property(e => e.AttachmentPath)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.ModificationDate).HasColumnType("datetime");
            entity.Property(e => e.Notes)
                .HasMaxLength(1000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ClientPayment>(entity =>
        {
            entity.HasKey(e => e.PaymentId).HasName("PK__ClientPa__9B556A587C82F1C5");

            entity.ToTable("ClientPayment");

            entity.Property(e => e.PaymentId)
                .ValueGeneratedNever()
                .HasColumnName("PaymentID");
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.BankId).HasColumnName("BankID");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.CheckDate).HasColumnType("datetime");
            entity.Property(e => e.ClientId).HasColumnName("ClientID");
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.ModificationDate).HasColumnType("datetime");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PaidFor)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PaidTypeId).HasColumnName("PaidTypeID");
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.SaleId).HasColumnName("SaleID");
            entity.Property(e => e.StatusId).HasColumnName("StatusID");

            entity.HasOne(d => d.Client).WithMany(p => p.ClientPayments)
                .HasForeignKey(d => d.ClientId)
                .HasConstraintName("FK_ClientPayment_CLIENTS");
        });

        modelBuilder.Entity<ClientShortage>(entity =>
        {
            entity.HasKey(e => new { e.ClientFileId, e.ClientShortageId }).HasName("pk_ClientShortage");

            entity.ToTable("ClientShortage");

            entity.Property(e => e.ClientFileId).HasColumnName("ClientFileID");
            entity.Property(e => e.ClientShortageId).HasColumnName("ClientShortageID");
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.InternalColor)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ModificationDate).HasColumnType("datetime");
            entity.Property(e => e.Notes)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.ShortageDate).HasColumnType("datetime");
            entity.Property(e => e.SubColor)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TarkeebBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TarkeebDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ClientShortageAttachment>(entity =>
        {
            entity.HasKey(e => new { e.ClientFileAttachmentId, e.ClientShortageId }).HasName("PK_ClientFileShortageATT");

            entity.ToTable("ClientShortageAttachment");

            entity.Property(e => e.ClientFileAttachmentId).HasColumnName("ClientFileAttachmentID");
            entity.Property(e => e.ClientShortageId).HasColumnName("ClientShortageID");
            entity.Property(e => e.AttachmentPath)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.ModificationDate).HasColumnType("datetime");
            entity.Property(e => e.Notes)
                .HasMaxLength(1000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ClientShortageDetail>(entity =>
        {
            entity.HasKey(e => new { e.ClientShortageId, e.DetailId }).HasName("pk_ClientShortageDetail");

            entity.ToTable("ClientShortageDetail");

            entity.Property(e => e.ClientShortageId).HasColumnName("ClientShortageID");
            entity.Property(e => e.DetailId).HasColumnName("DetailID");
            entity.Property(e => e.Bayan)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.ClientFileId).HasColumnName("ClientFileID");
            entity.Property(e => e.Hieght).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.InternalColor)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ItemCount)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.Notes)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.QshatColor)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SubColor)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TarkeebBy)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Width).HasColumnType("decimal(18, 3)");

            entity.HasOne(d => d.Client).WithMany(p => p.ClientShortageDetails)
                .HasForeignKey(d => new { d.ClientFileId, d.ClientShortageId })
                .HasConstraintName("fk_ClientShortageDetail");
        });

        modelBuilder.Entity<ClientSurvey>(entity =>
        {
            entity.HasKey(e => e.ClientSurveyId).HasName("PK__ClientSu__88BE9D53ECDFD072");

            entity.ToTable("ClientSurvey");

            entity.Property(e => e.ClientSurveyId)
                .ValueGeneratedNever()
                .HasColumnName("ClientSurveyID");
            entity.Property(e => e.AwardCertificate)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ClientFileId).HasColumnName("ClientFileID");
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.ModificationDate).HasColumnType("datetime");
            entity.Property(e => e.SurveyDate).HasColumnType("datetime");

            entity.HasOne(d => d.ClientFile).WithMany(p => p.ClientSurveys)
                .HasForeignKey(d => d.ClientFileId)
                .HasConstraintName("FK_ClientSurvey_ClientFile");
        });

        modelBuilder.Entity<ClientSurveyAnswer>(entity =>
        {
            entity.HasKey(e => new { e.QuestionId, e.ClientSurveyId }).HasName("pk_ClientSurveyAnswer");

            entity.ToTable("ClientSurveyAnswer");

            entity.Property(e => e.QuestionId).HasColumnName("QuestionID");
            entity.Property(e => e.ClientSurveyId).HasColumnName("ClientSurveyID");
            entity.Property(e => e.AnswerId).HasColumnName("AnswerID");
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.ModificationDate).HasColumnType("datetime");

            entity.HasOne(d => d.Answer).WithMany(p => p.ClientSurveyAnswers)
                .HasForeignKey(d => d.AnswerId)
                .HasConstraintName("FK_ClientSurveyAnswer_QusetionAnswer");

            entity.HasOne(d => d.ClientSurvey).WithMany(p => p.ClientSurveyAnswers)
                .HasForeignKey(d => d.ClientSurveyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ClientSurveyAnswer_ClientSurvey");

            entity.HasOne(d => d.Question).WithMany(p => p.ClientSurveyAnswers)
                .HasForeignKey(d => d.QuestionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ClientSurveyAnswer_Question");
        });

        modelBuilder.Entity<ClientSurveyDetail>(entity =>
        {
            entity.HasKey(e => new { e.DetailId, e.ClientSurveyId }).HasName("pk_ClientSurveyDetail");

            entity.ToTable("ClientSurveyDetail");

            entity.Property(e => e.DetailId).HasColumnName("DetailID");
            entity.Property(e => e.ClientSurveyId).HasColumnName("ClientSurveyID");
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.ModificationDate).HasColumnType("datetime");
            entity.Property(e => e.SurveyNotes)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.ClientSurvey).WithMany(p => p.ClientSurveyDetails)
                .HasForeignKey(d => d.ClientSurveyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ClientSurveyDetail_ClientSurvey");
        });

        modelBuilder.Entity<Clientmaintainance>(entity =>
        {
            entity.HasKey(e => new { e.ClientFileId, e.ClientMaintainanceId }).HasName("pk_Clientmaintainance");

            entity.ToTable("Clientmaintainance");

            entity.Property(e => e.ClientFileId).HasColumnName("ClientFileID");
            entity.Property(e => e.ClientMaintainanceId).HasColumnName("ClientMaintainanceID");
            entity.Property(e => e.Attachmentpath)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("ATTACHMENTPATH");
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.MaintainanceDate).HasColumnType("datetime");
            entity.Property(e => e.ModificationDate).HasColumnType("datetime");
            entity.Property(e => e.Notes)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.TarkeebDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CurrFile>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CurrFile");

            entity.Property(e => e.CurrDescGroupAr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CurrDescGroupAR");
            entity.Property(e => e.CurrDescSingleAr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CurrDescSingleAR");
            entity.Property(e => e.CurrSmallUnitAr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CurrSmallUnitAR");
        });

        modelBuilder.Entity<DayNumber>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DayNumber");

            entity.Property(e => e.Dayid).HasColumnName("dayid");
        });

        modelBuilder.Entity<DoorDetail>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Architrave1)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Architrave2)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.BottomRails)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Core)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("core");
            entity.Property(e => e.DecorativeProfile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DoorId).HasColumnName("DoorID");
            entity.Property(e => e.Edges)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Face)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Jamb)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Paint)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Panels)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Rubber)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("rubber");
            entity.Property(e => e.Stiles)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("stiles");
            entity.Property(e => e.TopRails)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Woodveneer)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("woodveneer");
        });

        modelBuilder.Entity<ItemDetail>(entity =>
        {
            entity.HasKey(e => new { e.ItemId, e.ItemDetailId }).HasName("pk_ItemDetail");

            entity.ToTable("ItemDetail");

            entity.Property(e => e.ItemDetailId).HasColumnName("ItemDetailID");
            entity.Property(e => e.Hieght).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.ItemCategoryId).HasColumnName("ItemCategoryID");
            entity.Property(e => e.ItemCount)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Lenght).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Length)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Notes)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Width)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ItemTypePrice>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ItemTypePrice");

            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.ItemId).HasColumnName("ItemID");
            entity.Property(e => e.ItemTypeId).HasColumnName("ItemTypeID");
            entity.Property(e => e.ModificationDate).HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 5)");

            entity.HasOne(d => d.Item).WithMany()
                .HasForeignKey(d => d.ItemId)
                .HasConstraintName("FK_ItemTypePrice_Status");

            entity.HasOne(d => d.ItemType).WithMany()
                .HasForeignKey(d => d.ItemTypeId)
                .HasConstraintName("FK_ItemTypePrice_Status1");
        });

        modelBuilder.Entity<ItemTypePrice20200218>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ITemTYpePrice20200218");

            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.ItemId).HasColumnName("ItemID");
            entity.Property(e => e.ItemTypeId).HasColumnName("ItemTypeID");
            entity.Property(e => e.ModificationDate).HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 5)");
        });

        modelBuilder.Entity<ItemTypePrice20220609>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ItemTypePrice20220609");

            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.ItemId).HasColumnName("ItemID");
            entity.Property(e => e.ItemTypeId).HasColumnName("ItemTypeID");
            entity.Property(e => e.ModificationDate).HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 5)");
        });

        modelBuilder.Entity<Itemtypeprice20220320>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ITEMTYPEPRICE20220320");

            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.ItemId).HasColumnName("ItemID");
            entity.Property(e => e.ItemTypeId).HasColumnName("ItemTypeID");
            entity.Property(e => e.ModificationDate).HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 5)");
        });

        modelBuilder.Entity<Itemtypeprice20220616>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("itemtypeprice20220616");

            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.ItemId).HasColumnName("ItemID");
            entity.Property(e => e.ItemTypeId).HasColumnName("ItemTypeID");
            entity.Property(e => e.ModificationDate).HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 5)");
        });

        modelBuilder.Entity<Money>(entity =>
        {
            entity.HasKey(e => e.MoneyNo);

            entity.Property(e => e.MoneyNo)
                .ValueGeneratedNever()
                .HasColumnName("Money_No");
            entity.Property(e => e.MoneyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Money_name");
        });

        modelBuilder.Entity<NotifciationSetupDetail>(entity =>
        {
            entity.HasKey(e => new { e.NotifciationSetupId, e.LevelId }).HasName("pk_NotifciationSetupDetail");

            entity.ToTable("NotifciationSetupDetail");

            entity.Property(e => e.NotifciationSetupId).HasColumnName("NotifciationSetupID");
            entity.Property(e => e.LevelId).HasColumnName("LevelID");
            entity.Property(e => e.FromApprovalProcessId).HasColumnName("FromApprovalProcessID");
            entity.Property(e => e.ToApprovalProcessId).HasColumnName("ToApprovalProcessID");
        });

        modelBuilder.Entity<NotifciationSetupUserType>(entity =>
        {
            entity.HasKey(e => new { e.NotifciationSetupId, e.LevelId, e.UserTypeId }).HasName("pk_NotifciationSetupUsers");

            entity.ToTable("NotifciationSetupUserType");

            entity.Property(e => e.NotifciationSetupId).HasColumnName("NotifciationSetupID");
            entity.Property(e => e.LevelId).HasColumnName("LevelID");
            entity.Property(e => e.UserTypeId).HasColumnName("UserTypeID");
            entity.Property(e => e.MessageFormat)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.MessageFormatAr)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("MessageFormatAR");
        });

        modelBuilder.Entity<Notification>(entity =>
        {
            entity.HasKey(e => e.NotificationId).HasName("PK__Notifica__20CF2E3293C0610D");

            entity.Property(e => e.NotificationId)
                .ValueGeneratedNever()
                .HasColumnName("NotificationID");
            entity.Property(e => e.DefaultDesc)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Project>(entity =>
        {
            entity.HasKey(e => e.ProjectId).HasName("PK__Projects__761ABED04E3EF124");

            entity.Property(e => e.ProjectId)
                .ValueGeneratedNever()
                .HasColumnName("ProjectID");
            entity.Property(e => e.DoorPrefix)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.KitchenImageFile)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.KitchenPrefix)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Logo)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ProjectName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ReportFile)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.ValidateId)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ValidateID");
            entity.Property(e => e.ValidatePeriod)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.WindowPrefix)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Question>(entity =>
        {
            entity.HasKey(e => e.QuestionId).HasName("PK__Question__0DC06F8CFBED08A8");

            entity.ToTable("Question");

            entity.Property(e => e.QuestionId)
                .ValueGeneratedNever()
                .HasColumnName("QuestionID");
            entity.Property(e => e.QuestionDesc)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<QusetionAnswer>(entity =>
        {
            entity.HasKey(e => e.AnswerId).HasName("pk_QusetionAnswer");

            entity.ToTable("QusetionAnswer");

            entity.Property(e => e.AnswerId)
                .ValueGeneratedNever()
                .HasColumnName("AnswerID");
            entity.Property(e => e.AnswerDesc)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Reminder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Reminder__3214EC27F2E91B85");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.DescriptionAr)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.ModificationDate).HasColumnType("datetime");
            entity.Property(e => e.Notes)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.Pk).HasColumnName("PK");
            entity.Property(e => e.ProjectId).HasColumnName("ProjectID");
            entity.Property(e => e.TypeId).HasColumnName("TypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.ToTable("Status");

            entity.Property(e => e.StatusId)
                .ValueGeneratedNever()
                .HasColumnName("StatusID");
            entity.Property(e => e.AluminiumEquation)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.AluminiumEquationWidth)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.ApajurEquation)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.ApajurEquationWidth)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CityId).HasColumnName("CityID");
            entity.Property(e => e.Country)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.Currency)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DarfehEquation)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.DarfehEquationWidth)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.DefaultDesc)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.DescriptionEn)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.GlassEquation)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.GlassEquationWidth)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.HalqEquation)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.HalqEquationWidth)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.ImagePath)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ItemCategoryId).HasColumnName("ItemCategoryID");
            entity.Property(e => e.ItemTypeId).HasColumnName("ItemTypeID");
            entity.Property(e => e.ModificationDate).HasColumnType("datetime");
            entity.Property(e => e.MonkholEquation)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.MonkholEquationWidth)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.StatusCategoryId).HasColumnName("StatusCategoryID");
            entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");

            entity.HasOne(d => d.StatusCategory).WithMany(p => p.Statuses)
                .HasForeignKey(d => d.StatusCategoryId)
                .HasConstraintName("FK_Status_StatusCategory");
        });

        modelBuilder.Entity<Status2020>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Status2020");

            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CityId).HasColumnName("CityID");
            entity.Property(e => e.Country)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.Currency)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DefaultDesc)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.DescriptionEn)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ImagePath)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ItemCategoryId).HasColumnName("ItemCategoryID");
            entity.Property(e => e.ItemTypeId).HasColumnName("ItemTypeID");
            entity.Property(e => e.ModificationDate).HasColumnType("datetime");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.StatusCategoryId).HasColumnName("StatusCategoryID");
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");
        });

        modelBuilder.Entity<Status20201>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Status20201");

            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CityId).HasColumnName("CityID");
            entity.Property(e => e.Country)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.Currency)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DefaultDesc)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.DescriptionEn)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ImagePath)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ItemCategoryId).HasColumnName("ItemCategoryID");
            entity.Property(e => e.ItemTypeId).HasColumnName("ItemTypeID");
            entity.Property(e => e.ModificationDate).HasColumnType("datetime");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.StatusCategoryId).HasColumnName("StatusCategoryID");
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");
        });

        modelBuilder.Entity<Status202101301>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Status20210130_1");

            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CityId).HasColumnName("CityID");
            entity.Property(e => e.Country)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.Currency)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DefaultDesc)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.DescriptionEn)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ImagePath)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ItemCategoryId).HasColumnName("ItemCategoryID");
            entity.Property(e => e.ItemTypeId).HasColumnName("ItemTypeID");
            entity.Property(e => e.ModificationDate).HasColumnType("datetime");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.StatusCategoryId).HasColumnName("StatusCategoryID");
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");
        });

        modelBuilder.Entity<StatusCategory>(entity =>
        {
            entity.ToTable("StatusCategory");

            entity.Property(e => e.StatusCategoryId)
                .ValueGeneratedNever()
                .HasColumnName("StatusCategoryID");
            entity.Property(e => e.DefaultDesc)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK_Inv_Users");

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnName("UserID");
            entity.Property(e => e.FullName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ImageAttachement)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Password).HasMaxLength(256);
            entity.Property(e => e.ProjectId).HasColumnName("ProjectID");
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.UserName).HasMaxLength(256);
            entity.Property(e => e.UserNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserTypeId).HasColumnName("UserTypeID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
