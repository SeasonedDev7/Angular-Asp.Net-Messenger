﻿// <auto-generated />
using Infrastructure.Persistence.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Infrastructure.Persistence.Migrations
{
    [ExcludeFromCodeCoverage]
    [DbContext(typeof(ChatContext))]
    partial class ChatContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Core.Domain.Entities.ArchivedRecipient", b =>
                {
                    b.Property<int>("ArchivedRecipientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RecipientId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ArchivedRecipientId");

                    b.HasIndex("RecipientId");

                    b.HasIndex("UserId", "RecipientId")
                        .IsUnique();

                    b.ToTable("ArchivedRecipients");
                });

            modelBuilder.Entity("Core.Domain.Entities.Availability", b =>
                {
                    b.Property<int>("AvailabilityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<bool>("ModifiedManually")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("AvailabilityId");

                    b.HasIndex("StatusId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Availabilities");
                });

            modelBuilder.Entity("Core.Domain.Entities.AvailabilityStatus", b =>
                {
                    b.Property<int>("AvailabilityStatusId")
                        .HasColumnType("int");

                    b.Property<string>("IndicatorColor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IndicatorOverlay")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AvailabilityStatusId");

                    b.ToTable("AvailabilityStatuses");
                });

            modelBuilder.Entity("Core.Domain.Entities.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<string>("FlagImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryId");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Core.Domain.Entities.DisplayImage", b =>
                {
                    b.Property<int>("DisplayImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("Bytes")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("DisplayImageId");

                    b.ToTable("DisplayImages");
                });

            modelBuilder.Entity("Core.Domain.Entities.Emoji", b =>
                {
                    b.Property<int>("EmojiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Shortcut")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmojiId");

                    b.ToTable("Emojis");
                });

            modelBuilder.Entity("Core.Domain.Entities.Friendship", b =>
                {
                    b.Property<int>("FriendshipId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddresseeId")
                        .HasColumnType("int");

                    b.Property<int>("RequesterId")
                        .HasColumnType("int");

                    b.HasKey("FriendshipId");

                    b.HasIndex("AddresseeId");

                    b.HasIndex("RequesterId", "AddresseeId")
                        .IsUnique();

                    b.ToTable("Friendships");
                });

            modelBuilder.Entity("Core.Domain.Entities.FriendshipChange", b =>
                {
                    b.Property<int>("FriendshipChangeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("FriendshipId")
                        .HasColumnType("int");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("FriendshipChangeId");

                    b.HasIndex("FriendshipId");

                    b.HasIndex("StatusId");

                    b.ToTable("FriendshipChanges");
                });

            modelBuilder.Entity("Core.Domain.Entities.FriendshipStatus", b =>
                {
                    b.Property<int>("FriendshipStatusId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FriendshipStatusId");

                    b.ToTable("FriendshipStatuses");

                    b.HasData(
                        new
                        {
                            FriendshipStatusId = 1,
                            Name = "Pending"
                        },
                        new
                        {
                            FriendshipStatusId = 2,
                            Name = "Accepted"
                        },
                        new
                        {
                            FriendshipStatusId = 3,
                            Name = "Ignored"
                        },
                        new
                        {
                            FriendshipStatusId = 4,
                            Name = "Blocked"
                        });
                });

            modelBuilder.Entity("Core.Domain.Entities.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GroupImageId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GroupId");

                    b.HasIndex("GroupImageId")
                        .IsUnique()
                        .HasFilter("[GroupImageId] IS NOT NULL");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("Core.Domain.Entities.GroupMembership", b =>
                {
                    b.Property<int>("GroupMembershipId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<bool>("IsAdmin")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("GroupMembershipId");

                    b.HasIndex("GroupId");

                    b.HasIndex("UserId", "GroupId")
                        .IsUnique();

                    b.ToTable("GroupMemberships");
                });

            modelBuilder.Entity("Core.Domain.Entities.Language", b =>
                {
                    b.Property<int>("LanguageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LanguageId");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.HasIndex("CountryId")
                        .IsUnique();

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("Core.Domain.Entities.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("HtmlContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<bool>("IsEdited")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.HasKey("MessageId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("ParentId")
                        .IsUnique()
                        .HasFilter("[ParentId] IS NOT NULL");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("Core.Domain.Entities.MessageReaction", b =>
                {
                    b.Property<int>("MessageReactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmojiId")
                        .HasColumnType("int");

                    b.Property<int>("MessageId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("MessageReactionId");

                    b.HasIndex("EmojiId");

                    b.HasIndex("MessageId");

                    b.HasIndex("UserId", "MessageId", "EmojiId")
                        .IsUnique();

                    b.ToTable("MessageReactions");
                });

            modelBuilder.Entity("Core.Domain.Entities.MessageRecipient", b =>
                {
                    b.Property<int>("MessageRecipientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsForwarded")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<bool>("IsRead")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<int>("MessageId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ReadDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RecipientId")
                        .HasColumnType("int");

                    b.HasKey("MessageRecipientId");

                    b.HasIndex("MessageId");

                    b.HasIndex("RecipientId", "MessageId")
                        .IsUnique();

                    b.ToTable("MessageRecipients");
                });

            modelBuilder.Entity("Core.Domain.Entities.NicknameAssignment", b =>
                {
                    b.Property<int>("NicknameAssignmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddresseeId")
                        .HasColumnType("int");

                    b.Property<string>("NicknameValue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RequesterId")
                        .HasColumnType("int");

                    b.HasKey("NicknameAssignmentId");

                    b.HasIndex("AddresseeId");

                    b.HasIndex("RequesterId", "AddresseeId")
                        .IsUnique();

                    b.ToTable("NicknameAssignments");
                });

            modelBuilder.Entity("Core.Domain.Entities.PinnedRecipient", b =>
                {
                    b.Property<int>("PinnedRecipientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderIndex")
                        .HasColumnType("int");

                    b.Property<int>("RecipientId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("PinnedRecipientId");

                    b.HasIndex("RecipientId");

                    b.HasIndex("UserId", "RecipientId")
                        .IsUnique();

                    b.ToTable("PinnedRecipients");
                });

            modelBuilder.Entity("Core.Domain.Entities.Recipient", b =>
                {
                    b.Property<int>("RecipientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("GroupMembershipId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("RecipientId");

                    b.HasIndex("GroupMembershipId")
                        .IsUnique()
                        .HasFilter("[GroupMembershipId] IS NOT NULL");

                    b.HasIndex("UserId")
                        .IsUnique()
                        .HasFilter("[UserId] IS NOT NULL");

                    b.HasIndex("UserId", "GroupMembershipId")
                        .IsUnique()
                        .HasFilter("[UserId] IS NOT NULL AND [GroupMembershipId] IS NOT NULL");

                    b.ToTable("Recipients");
                });

            modelBuilder.Entity("Core.Domain.Entities.RedeemToken", b =>
                {
                    b.Property<int>("RedeemTokenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsUsed")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<Guid>("Token")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ValidUntil")
                        .HasColumnType("datetime2");

                    b.HasKey("RedeemTokenId");

                    b.HasIndex("TypeId");

                    b.HasIndex("UserId");

                    b.ToTable("RedeemTokens");
                });

            modelBuilder.Entity("Core.Domain.Entities.RedeemTokenType", b =>
                {
                    b.Property<int>("RedeemTokenTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("RedeemTokenTypeId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("RedeemTokenTypes");

                    b.HasData(
                        new
                        {
                            RedeemTokenTypeId = 1,
                            Name = "EmailConfirmation"
                        },
                        new
                        {
                            RedeemTokenTypeId = 2,
                            Name = "PasswordRecovery"
                        });
                });

            modelBuilder.Entity("Core.Domain.Entities.StatusMessage", b =>
                {
                    b.Property<int>("StatusMessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("StatusMessageId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("StatusMessages");
                });

            modelBuilder.Entity("Core.Domain.Entities.Translation", b =>
                {
                    b.Property<int>("TranslationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TranslationId");

                    b.HasIndex("LanguageId", "Key");

                    b.ToTable("Translations");
                });

            modelBuilder.Entity("Core.Domain.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsEmailConfirmed")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<int?>("ProfileImageId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId");

                    b.HasIndex("CountryId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("ProfileImageId")
                        .IsUnique()
                        .HasFilter("[ProfileImageId] IS NOT NULL");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Core.Domain.Entities.ArchivedRecipient", b =>
                {
                    b.HasOne("Core.Domain.Entities.Recipient", "Recipient")
                        .WithMany("Archives")
                        .HasForeignKey("RecipientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Domain.Entities.User", "User")
                        .WithMany("ArchivedRecipients")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Core.Domain.Entities.Availability", b =>
                {
                    b.HasOne("Core.Domain.Entities.AvailabilityStatus", "Status")
                        .WithMany("Availabilities")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Domain.Entities.User", "User")
                        .WithOne("Availability")
                        .HasForeignKey("Core.Domain.Entities.Availability", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Core.Domain.Entities.Friendship", b =>
                {
                    b.HasOne("Core.Domain.Entities.User", "Addressee")
                        .WithMany("AddressedFriendships")
                        .HasForeignKey("AddresseeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Domain.Entities.User", "Requester")
                        .WithMany("RequestedFriendships")
                        .HasForeignKey("RequesterId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Core.Domain.Entities.FriendshipChange", b =>
                {
                    b.HasOne("Core.Domain.Entities.Friendship", "Friendship")
                        .WithMany("StatusChanges")
                        .HasForeignKey("FriendshipId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Domain.Entities.FriendshipStatus", "Status")
                        .WithMany("StatusChanges")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Core.Domain.Entities.Group", b =>
                {
                    b.HasOne("Core.Domain.Entities.DisplayImage", "GroupImage")
                        .WithOne()
                        .HasForeignKey("Core.Domain.Entities.Group", "GroupImageId");
                });

            modelBuilder.Entity("Core.Domain.Entities.GroupMembership", b =>
                {
                    b.HasOne("Core.Domain.Entities.Group", "Group")
                        .WithMany("Memberships")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Domain.Entities.User", "User")
                        .WithMany("GroupMemberships")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Core.Domain.Entities.Language", b =>
                {
                    b.HasOne("Core.Domain.Entities.Country", "Country")
                        .WithOne("Language")
                        .HasForeignKey("Core.Domain.Entities.Language", "CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Core.Domain.Entities.Message", b =>
                {
                    b.HasOne("Core.Domain.Entities.User", "Author")
                        .WithMany("AuthoredMessages")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Domain.Entities.Message", "Parent")
                        .WithOne()
                        .HasForeignKey("Core.Domain.Entities.Message", "ParentId")
                        .OnDelete(DeleteBehavior.NoAction);
                });

            modelBuilder.Entity("Core.Domain.Entities.MessageReaction", b =>
                {
                    b.HasOne("Core.Domain.Entities.Emoji", "Emoji")
                        .WithMany("Reactions")
                        .HasForeignKey("EmojiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Domain.Entities.Message", "Message")
                        .WithMany("Reactions")
                        .HasForeignKey("MessageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Domain.Entities.User", "User")
                        .WithMany("MessageReactions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Core.Domain.Entities.MessageRecipient", b =>
                {
                    b.HasOne("Core.Domain.Entities.Message", "Message")
                        .WithMany("MessageRecipients")
                        .HasForeignKey("MessageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Domain.Entities.Recipient", "Recipient")
                        .WithMany("ReceivedMessages")
                        .HasForeignKey("RecipientId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Core.Domain.Entities.NicknameAssignment", b =>
                {
                    b.HasOne("Core.Domain.Entities.User", "Addressee")
                        .WithMany("AddressedNicknames")
                        .HasForeignKey("AddresseeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Domain.Entities.User", "Requester")
                        .WithMany("RequestedNicknames")
                        .HasForeignKey("RequesterId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Core.Domain.Entities.PinnedRecipient", b =>
                {
                    b.HasOne("Core.Domain.Entities.Recipient", "Recipient")
                        .WithMany("Pins")
                        .HasForeignKey("RecipientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Domain.Entities.User", "User")
                        .WithMany("PinnedRecipients")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Core.Domain.Entities.Recipient", b =>
                {
                    b.HasOne("Core.Domain.Entities.GroupMembership", "GroupMembership")
                        .WithOne("Recipient")
                        .HasForeignKey("Core.Domain.Entities.Recipient", "GroupMembershipId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Core.Domain.Entities.User", "User")
                        .WithOne("Recipient")
                        .HasForeignKey("Core.Domain.Entities.Recipient", "UserId");
                });

            modelBuilder.Entity("Core.Domain.Entities.RedeemToken", b =>
                {
                    b.HasOne("Core.Domain.Entities.RedeemTokenType", "Type")
                        .WithMany("Tokens")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Domain.Entities.User", "User")
                        .WithMany("RedeemTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Core.Domain.Entities.StatusMessage", b =>
                {
                    b.HasOne("Core.Domain.Entities.User", "User")
                        .WithOne("StatusMessage")
                        .HasForeignKey("Core.Domain.Entities.StatusMessage", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Core.Domain.Entities.Translation", b =>
                {
                    b.HasOne("Core.Domain.Entities.Language", "Language")
                        .WithMany("Translations")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Core.Domain.Entities.User", b =>
                {
                    b.HasOne("Core.Domain.Entities.Country", null)
                        .WithMany("Users")
                        .HasForeignKey("CountryId");

                    b.HasOne("Core.Domain.Entities.DisplayImage", "ProfileImage")
                        .WithOne()
                        .HasForeignKey("Core.Domain.Entities.User", "ProfileImageId");
                });
#pragma warning restore 612, 618
        }
    }
}
