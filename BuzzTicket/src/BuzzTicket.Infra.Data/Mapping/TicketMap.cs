using BuzzTicket.Domain.TicketAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuzzTicket.Infra.Data.Mapping
{
    public class TicketMap : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            if (builder == null) throw new ArgumentNullException(nameof(builder));

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasDefaultValueSql("NEWID()");

            builder.Property(e => e.Solicitante)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Solicitante");

            builder.Property(e => e.Solicitacao)
                //.IsRequired()
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("Solicitacao");

            builder.Property(e => e.Aberto)
                .IsRequired()
                .HasColumnName("Aberto");

            builder.Property(e => e.Data)
                .IsRequired()
                .HasColumnType("date")
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("Data");

        }
    }
}
