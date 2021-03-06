﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Silk.Core.Database.Models;

namespace Silk.Core.Database.ModelConfigurations.cs
{
    public class GuildModelConfig : IEntityTypeConfiguration<GuildModel>
    {

        public void Configure(EntityTypeBuilder<GuildModel> builder)
        {
            builder.Property(g => g.Id).ValueGeneratedNever();
            builder.HasMany(u => u.Users).WithOne(u => u.Guild);
            builder.HasOne(g => g.Configuration).WithOne(g => g.Guild).HasForeignKey<GuildConfigModel>(g => g.GuildId);
        }
    }
}