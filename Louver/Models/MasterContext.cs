using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Louver.Models;

public partial class MasterContext : DbContext
{
    public MasterContext()
    {
    }

    public MasterContext(DbContextOptions<MasterContext> options)
        : base(options)
    {
    }
    public virtual ObjectResult<AnClientFileItem> fillClientIemsTable(Nullable<int> clientFileId, Nullable<int> createdBy)
    {
        var pclientFlileId = clientFileId.HasValue ?
            new ObjectParameter("pClientFileID", clientFileId) :
            new ObjectParameter("pClientFileID", typeof(int));
        var pCreatedBy = createdBy.HasValue ?
          new ObjectParameter("pCreatedBy", createdBy) :
          new ObjectParameter(" pCreatedBy", typeof(int));
        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AnClientFileItem>("AN_SaveClientFileItem", pclientFlileId, pCreatedBy);
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=tcp:194.163.132.242\\\\\\\\SQLEXPRESS,56773 Initial Catalog=Louver;User ID=kitchen1;Password=kitchen1;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("guest");

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
