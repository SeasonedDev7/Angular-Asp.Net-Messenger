﻿using ChatClient.Core.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChatClient.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(user => user.UserId);

            builder.HasAlternateKey(user => new
            {
                user.Email,
                user.UserCode,
            });

            builder.Property(user => user.UserCode)
                .IsRequired()
                .HasMaxLength(6);

            builder.Property(user => user.DisplayName)
                .IsRequired();

            builder.Property(user => user.Email)
                .IsRequired();

            builder.Property(user => user.PasswordHash)
                .IsRequired();

            builder.Property(user => user.PasswordSalt)
                .IsRequired();

            builder.Property(user => user.CreatedAt)
                .IsRequired();

            builder.HasMany(user => user.AuthoredMessages)
                .WithOne(message => message.Author);

            builder.HasMany(user => user.GroupMemberships)
                .WithOne(membership => membership.User);

            builder.HasMany(user => user.ReceivedPrivateMessages)
                .WithOne(recipient => recipient.RecipientUser);
        }
    }
}