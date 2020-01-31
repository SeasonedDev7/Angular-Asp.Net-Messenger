﻿// <auto-generated />
using System;
using ChatClient.Data.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ChatClient.Data.Migrations
{
    [DbContext(typeof(ChatContext))]
    partial class ChatContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ChatClient.Core.Models.Domain.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GroupId");

                    b.ToTable("Groups");

                    b.HasData(
                        new
                        {
                            GroupId = 1,
                            CreatedAt = new DateTime(2020, 1, 31, 16, 34, 15, 326, DateTimeKind.Utc).AddTicks(849),
                            Description = "Description for Group 1",
                            Name = "Group 1"
                        },
                        new
                        {
                            GroupId = 2,
                            CreatedAt = new DateTime(2020, 1, 31, 16, 34, 15, 326, DateTimeKind.Utc).AddTicks(1844),
                            Description = "Description for Group 2",
                            Name = "Group 2"
                        });
                });

            modelBuilder.Entity("ChatClient.Core.Models.Domain.GroupMembership", b =>
                {
                    b.Property<int>("GroupMembershipId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("GroupMembershipId");

                    b.HasAlternateKey("UserId", "GroupId");

                    b.HasIndex("GroupId");

                    b.ToTable("GroupMemberships");

                    b.HasData(
                        new
                        {
                            GroupMembershipId = 1,
                            CreatedAt = new DateTime(2020, 1, 31, 16, 34, 15, 328, DateTimeKind.Utc).AddTicks(2239),
                            GroupId = 1,
                            IsAdmin = true,
                            UserId = 1
                        },
                        new
                        {
                            GroupMembershipId = 2,
                            CreatedAt = new DateTime(2020, 1, 31, 16, 34, 15, 328, DateTimeKind.Utc).AddTicks(3176),
                            GroupId = 1,
                            IsAdmin = false,
                            UserId = 2
                        },
                        new
                        {
                            GroupMembershipId = 3,
                            CreatedAt = new DateTime(2020, 1, 31, 16, 34, 15, 328, DateTimeKind.Utc).AddTicks(3193),
                            GroupId = 1,
                            IsAdmin = false,
                            UserId = 3
                        },
                        new
                        {
                            GroupMembershipId = 4,
                            CreatedAt = new DateTime(2020, 1, 31, 16, 34, 15, 328, DateTimeKind.Utc).AddTicks(3196),
                            GroupId = 2,
                            IsAdmin = false,
                            UserId = 1
                        },
                        new
                        {
                            GroupMembershipId = 5,
                            CreatedAt = new DateTime(2020, 1, 31, 16, 34, 15, 328, DateTimeKind.Utc).AddTicks(3206),
                            GroupId = 2,
                            IsAdmin = true,
                            UserId = 3
                        },
                        new
                        {
                            GroupMembershipId = 6,
                            CreatedAt = new DateTime(2020, 1, 31, 16, 34, 15, 328, DateTimeKind.Utc).AddTicks(3208),
                            GroupId = 2,
                            IsAdmin = false,
                            UserId = 4
                        });
                });

            modelBuilder.Entity("ChatClient.Core.Models.Domain.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsEdited")
                        .HasColumnType("bit");

                    b.Property<bool>("IsForwarded")
                        .HasColumnType("bit");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<string>("TextContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MessageId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("ParentId")
                        .IsUnique()
                        .HasFilter("[ParentId] IS NOT NULL");

                    b.ToTable("Messages");

                    b.HasData(
                        new
                        {
                            MessageId = 1,
                            AuthorId = 1,
                            CreatedAt = new DateTime(2020, 1, 31, 16, 34, 15, 327, DateTimeKind.Utc).AddTicks(1842),
                            IsEdited = false,
                            IsForwarded = false,
                            TextContent = "Hello User 1"
                        },
                        new
                        {
                            MessageId = 2,
                            AuthorId = 2,
                            CreatedAt = new DateTime(2020, 1, 31, 16, 34, 15, 327, DateTimeKind.Utc).AddTicks(3955),
                            IsEdited = false,
                            IsForwarded = false,
                            TextContent = "Hello AndriWandres"
                        },
                        new
                        {
                            MessageId = 3,
                            AuthorId = 1,
                            CreatedAt = new DateTime(2020, 1, 31, 16, 34, 15, 327, DateTimeKind.Utc).AddTicks(4010),
                            IsEdited = false,
                            IsForwarded = false,
                            TextContent = "Hello Group 1"
                        },
                        new
                        {
                            MessageId = 4,
                            AuthorId = 2,
                            CreatedAt = new DateTime(2020, 1, 31, 16, 34, 15, 327, DateTimeKind.Utc).AddTicks(4014),
                            IsEdited = false,
                            IsForwarded = false,
                            TextContent = "Hello together!"
                        },
                        new
                        {
                            MessageId = 5,
                            AuthorId = 3,
                            CreatedAt = new DateTime(2020, 1, 31, 16, 34, 15, 327, DateTimeKind.Utc).AddTicks(4024),
                            IsEdited = false,
                            IsForwarded = false,
                            TextContent = "Greetings everyone!"
                        },
                        new
                        {
                            MessageId = 6,
                            AuthorId = 2,
                            CreatedAt = new DateTime(2020, 1, 31, 16, 34, 15, 327, DateTimeKind.Utc).AddTicks(4027),
                            IsEdited = false,
                            IsForwarded = false,
                            TextContent = "Hello together!"
                        },
                        new
                        {
                            MessageId = 7,
                            AuthorId = 1,
                            CreatedAt = new DateTime(2020, 1, 31, 16, 34, 15, 327, DateTimeKind.Utc).AddTicks(4029),
                            IsEdited = false,
                            IsForwarded = false,
                            TextContent = "Hi!"
                        });
                });

            modelBuilder.Entity("ChatClient.Core.Models.Domain.MessageRecipient", b =>
                {
                    b.Property<int>("MessageRecipientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsRead")
                        .HasColumnType("bit");

                    b.Property<int>("MessageId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ReadAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("RecipientGroupId")
                        .HasColumnType("int");

                    b.Property<int?>("RecipientUserId")
                        .HasColumnType("int");

                    b.HasKey("MessageRecipientId");

                    b.HasIndex("MessageId");

                    b.HasIndex("RecipientGroupId");

                    b.HasIndex("RecipientUserId");

                    b.ToTable("MessageRecipients");

                    b.HasData(
                        new
                        {
                            MessageRecipientId = 1,
                            IsRead = true,
                            MessageId = 1,
                            ReadAt = new DateTime(2020, 1, 31, 16, 34, 15, 329, DateTimeKind.Utc).AddTicks(7397),
                            RecipientUserId = 2
                        },
                        new
                        {
                            MessageRecipientId = 2,
                            IsRead = false,
                            MessageId = 2,
                            ReadAt = new DateTime(2020, 1, 31, 16, 34, 15, 329, DateTimeKind.Utc).AddTicks(8637),
                            RecipientUserId = 1
                        },
                        new
                        {
                            MessageRecipientId = 3,
                            IsRead = true,
                            MessageId = 3,
                            ReadAt = new DateTime(2020, 1, 31, 16, 34, 15, 329, DateTimeKind.Utc).AddTicks(8673),
                            RecipientGroupId = 2
                        },
                        new
                        {
                            MessageRecipientId = 4,
                            IsRead = true,
                            MessageId = 3,
                            ReadAt = new DateTime(2020, 1, 31, 16, 34, 15, 329, DateTimeKind.Utc).AddTicks(8677),
                            RecipientGroupId = 3
                        },
                        new
                        {
                            MessageRecipientId = 5,
                            IsRead = true,
                            MessageId = 4,
                            ReadAt = new DateTime(2020, 1, 31, 16, 34, 15, 329, DateTimeKind.Utc).AddTicks(8687),
                            RecipientGroupId = 1
                        },
                        new
                        {
                            MessageRecipientId = 6,
                            IsRead = true,
                            MessageId = 4,
                            ReadAt = new DateTime(2020, 1, 31, 16, 34, 15, 329, DateTimeKind.Utc).AddTicks(8690),
                            RecipientGroupId = 3
                        },
                        new
                        {
                            MessageRecipientId = 7,
                            IsRead = true,
                            MessageId = 5,
                            ReadAt = new DateTime(2020, 1, 31, 16, 34, 15, 329, DateTimeKind.Utc).AddTicks(8692),
                            RecipientGroupId = 1
                        },
                        new
                        {
                            MessageRecipientId = 8,
                            IsRead = true,
                            MessageId = 5,
                            ReadAt = new DateTime(2020, 1, 31, 16, 34, 15, 329, DateTimeKind.Utc).AddTicks(8694),
                            RecipientGroupId = 2
                        },
                        new
                        {
                            MessageRecipientId = 9,
                            IsRead = true,
                            MessageId = 6,
                            ReadAt = new DateTime(2020, 1, 31, 16, 34, 15, 329, DateTimeKind.Utc).AddTicks(8700),
                            RecipientGroupId = 4
                        },
                        new
                        {
                            MessageRecipientId = 10,
                            IsRead = true,
                            MessageId = 6,
                            ReadAt = new DateTime(2020, 1, 31, 16, 34, 15, 329, DateTimeKind.Utc).AddTicks(8702),
                            RecipientGroupId = 6
                        },
                        new
                        {
                            MessageRecipientId = 11,
                            IsRead = true,
                            MessageId = 7,
                            ReadAt = new DateTime(2020, 1, 31, 16, 34, 15, 329, DateTimeKind.Utc).AddTicks(8704),
                            RecipientGroupId = 5
                        },
                        new
                        {
                            MessageRecipientId = 12,
                            IsRead = true,
                            MessageId = 7,
                            ReadAt = new DateTime(2020, 1, 31, 16, 34, 15, 329, DateTimeKind.Utc).AddTicks(8706),
                            RecipientGroupId = 6
                        });
                });

            modelBuilder.Entity("ChatClient.Core.Models.Domain.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("UserCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.HasKey("UserId");

                    b.HasAlternateKey("Email", "UserCode");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            CreatedAt = new DateTime(2020, 1, 31, 16, 34, 15, 323, DateTimeKind.Utc).AddTicks(9125),
                            DisplayName = "AndriWandres",
                            Email = "andri.wandres@swisslife.ch",
                            PasswordHash = new byte[] { 194, 80, 251, 139, 60, 78, 94, 71, 158, 250, 144, 223, 172, 162, 67, 211, 126, 195, 180, 52, 243, 217, 140, 162, 208, 78, 100, 45, 28, 2, 245, 111 },
                            PasswordSalt = new byte[] { 160, 47, 34, 131, 215, 219, 8, 193, 186, 221, 222, 203, 9, 130, 252, 168 },
                            UserCode = "A1C4T1"
                        },
                        new
                        {
                            UserId = 2,
                            CreatedAt = new DateTime(2020, 1, 31, 16, 34, 15, 324, DateTimeKind.Utc).AddTicks(178),
                            DisplayName = "User 1",
                            Email = "user1@test.ch",
                            PasswordHash = new byte[] { 194, 80, 251, 139, 60, 78, 94, 71, 158, 250, 144, 223, 172, 162, 67, 211, 126, 195, 180, 52, 243, 217, 140, 162, 208, 78, 100, 45, 28, 2, 245, 111 },
                            PasswordSalt = new byte[] { 160, 47, 34, 131, 215, 219, 8, 193, 186, 221, 222, 203, 9, 130, 252, 168 },
                            UserCode = "T9D5W9"
                        },
                        new
                        {
                            UserId = 3,
                            CreatedAt = new DateTime(2020, 1, 31, 16, 34, 15, 324, DateTimeKind.Utc).AddTicks(200),
                            DisplayName = "User 2",
                            Email = "user2@test.ch",
                            PasswordHash = new byte[] { 194, 80, 251, 139, 60, 78, 94, 71, 158, 250, 144, 223, 172, 162, 67, 211, 126, 195, 180, 52, 243, 217, 140, 162, 208, 78, 100, 45, 28, 2, 245, 111 },
                            PasswordSalt = new byte[] { 160, 47, 34, 131, 215, 219, 8, 193, 186, 221, 222, 203, 9, 130, 252, 168 },
                            UserCode = "S9B2I6"
                        },
                        new
                        {
                            UserId = 4,
                            CreatedAt = new DateTime(2020, 1, 31, 16, 34, 15, 324, DateTimeKind.Utc).AddTicks(207),
                            DisplayName = "User 3",
                            Email = "user3@test.ch",
                            PasswordHash = new byte[] { 194, 80, 251, 139, 60, 78, 94, 71, 158, 250, 144, 223, 172, 162, 67, 211, 126, 195, 180, 52, 243, 217, 140, 162, 208, 78, 100, 45, 28, 2, 245, 111 },
                            PasswordSalt = new byte[] { 160, 47, 34, 131, 215, 219, 8, 193, 186, 221, 222, 203, 9, 130, 252, 168 },
                            UserCode = "E2T8N7"
                        });
                });

            modelBuilder.Entity("ChatClient.Core.Models.Domain.GroupMembership", b =>
                {
                    b.HasOne("ChatClient.Core.Models.Domain.Group", "Group")
                        .WithMany("GroupMemberships")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ChatClient.Core.Models.Domain.User", "User")
                        .WithMany("GroupMemberships")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ChatClient.Core.Models.Domain.Message", b =>
                {
                    b.HasOne("ChatClient.Core.Models.Domain.User", "Author")
                        .WithMany("AuthoredMessages")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ChatClient.Core.Models.Domain.Message", "Parent")
                        .WithOne()
                        .HasForeignKey("ChatClient.Core.Models.Domain.Message", "ParentId");
                });

            modelBuilder.Entity("ChatClient.Core.Models.Domain.MessageRecipient", b =>
                {
                    b.HasOne("ChatClient.Core.Models.Domain.Message", "Message")
                        .WithMany("Recipients")
                        .HasForeignKey("MessageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ChatClient.Core.Models.Domain.GroupMembership", "RecipientGroup")
                        .WithMany("ReceivedGroupMessages")
                        .HasForeignKey("RecipientGroupId");

                    b.HasOne("ChatClient.Core.Models.Domain.User", "RecipientUser")
                        .WithMany("ReceivedPrivateMessages")
                        .HasForeignKey("RecipientUserId");
                });
#pragma warning restore 612, 618
        }
    }
}
