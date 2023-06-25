﻿using Data_Selecting_Operations_SELECT.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace Data_Selecting_Operations_SELECT.Configurations
{
    public class BookAuthorConfiguration : IEntityTypeConfiguration<BookAuthor>
    {
        public void Configure(EntityTypeBuilder<BookAuthor> builder)
        {
            builder.Ignore(x => x.Id);
            builder.HasKey(x => new { x.BookID, x.AuthorID });
            builder.ToTable("KitapYazar");
            builder.HasOne(ba => ba.Author).WithMany(a => a.BookAuthors).HasForeignKey(ba => ba.AuthorID);
            builder.HasOne(ba => ba.Book).WithMany(b => b.BookAuthors).HasForeignKey(ba => ba.BookID);
        }
    }
}
