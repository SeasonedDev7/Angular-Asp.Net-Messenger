﻿using ChatClient.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChatClient.Data.Configurations
{
    public class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.HasKey(group => group.GroupId);

            builder.Property(group => group.Name)
                .IsRequired();

            builder.Property(group => group.CreatedAt)
                .IsRequired();

            builder.HasMany(group => group.GroupMemberships)
                .WithOne(membership => membership.Group);
        }
    }
}
