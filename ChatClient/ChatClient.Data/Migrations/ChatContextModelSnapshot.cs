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

            modelBuilder.Entity("ChatClient.Core.Models.Domain.DisplayImage", b =>
                {
                    b.Property<int>("DisplayImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("DisplayImageId");

                    b.ToTable("DisplayImage");
                });

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

                    b.Property<int?>("GroupImageId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GroupId");

                    b.HasIndex("GroupImageId")
                        .IsUnique()
                        .HasFilter("[GroupImageId] IS NOT NULL");

                    b.ToTable("Groups");
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

                    b.Property<int?>("ProfileImageId")
                        .HasColumnType("int");

                    b.Property<string>("UserCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.HasKey("UserId");

                    b.HasAlternateKey("Email", "UserCode");

                    b.HasIndex("ProfileImageId")
                        .IsUnique()
                        .HasFilter("[ProfileImageId] IS NOT NULL");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ChatClient.Core.Models.Domain.UserRelationship", b =>
                {
                    b.Property<int>("UserRelationshipId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("InitiatorId")
                        .HasColumnType("int");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("TargetId")
                        .HasColumnType("int");

                    b.HasKey("UserRelationshipId");

                    b.HasIndex("InitiatorId");

                    b.HasIndex("TargetId");

                    b.ToTable("UserRelationships");
                });

            modelBuilder.Entity("ChatClient.Core.Models.Domain.Group", b =>
                {
                    b.HasOne("ChatClient.Core.Models.Domain.DisplayImage", "GroupImage")
                        .WithOne("Group")
                        .HasForeignKey("ChatClient.Core.Models.Domain.Group", "GroupImageId");
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

            modelBuilder.Entity("ChatClient.Core.Models.Domain.User", b =>
                {
                    b.HasOne("ChatClient.Core.Models.Domain.DisplayImage", "ProfileImage")
                        .WithOne("User")
                        .HasForeignKey("ChatClient.Core.Models.Domain.User", "ProfileImageId");
                });

            modelBuilder.Entity("ChatClient.Core.Models.Domain.UserRelationship", b =>
                {
                    b.HasOne("ChatClient.Core.Models.Domain.User", "Initiator")
                        .WithMany("InitiatedUserRelationships")
                        .HasForeignKey("InitiatorId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ChatClient.Core.Models.Domain.User", "Target")
                        .WithMany("TargetedUserRelationships")
                        .HasForeignKey("TargetId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
