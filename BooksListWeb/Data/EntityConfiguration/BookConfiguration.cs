using BooksListWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace BooksListWeb.Data.EntityConfiguration
{
    public class EntityConfiguration : IEntityTypeConfiguration<Books>
    {
        public void Configure(EntityTypeBuilder<Books> builder)
        {
            builder.ToTable("CardLimits", ExamsContext.DEFAULT_SCHEMA);
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Id).ValueGeneratedNever();
            builder.Property(p => p.LimitDaily);
            builder.Property(p => p.LimitDesk);
            builder.Property(p => p.BookName).HasColumnType("nvarchar(30)");
            builder.Property(p => p.ValidSince).IsRequired();
            builder.HasOne(p => p.ExamTaskGroup)
                .WithMany(x => x.CardLimits)
                .HasForeignKey(p => p.ExamTaskGroupId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(p => p.ExaminerPermission)
                .WithMany(x => x.CardLimits)
                .HasForeignKey(p => p.ExaminerPermissionId)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(p => p.AssessmentSessionProcess)
                .WithMany().HasForeignKey(p => p.AssessmentSessionProcessId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}