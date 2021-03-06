﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Silk.Core.Database;

namespace Silk.Core.Migrations
{
    [DbContext(typeof(SilkDbContext))]
    [Migration("20210122214512_Infractions_DbSet")]
    partial class Infractions_DbSet
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Silk.Core.Database.Models.BlackListedWord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int>("GuildId")
                        .HasColumnType("integer");

                    b.Property<string>("Word")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("GuildId");

                    b.ToTable("BlackListedWord");
                });

            modelBuilder.Entity("Silk.Core.Database.Models.ChangelogModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Additions")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Authors")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("ChangeTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Removals")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Version")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ChangeLogs");
                });

            modelBuilder.Entity("Silk.Core.Database.Models.GlobalUserModel", b =>
                {
                    b.Property<decimal>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric(20,0)");

                    b.Property<int>("Cash")
                        .HasColumnType("integer");

                    b.Property<DateTime>("LastCashOut")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("GlobalUsers");
                });

            modelBuilder.Entity("Silk.Core.Database.Models.GuildConfigModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<bool>("AutoDehoist")
                        .HasColumnType("boolean");

                    b.Property<bool>("BlacklistInvites")
                        .HasColumnType("boolean");

                    b.Property<bool>("BlacklistWords")
                        .HasColumnType("boolean");

                    b.Property<bool>("DeleteMessageOnMatchedInvite")
                        .HasColumnType("boolean");

                    b.Property<decimal>("GeneralLoggingChannel")
                        .HasColumnType("numeric(20,0)");

                    b.Property<bool>("GreetMembers")
                        .HasColumnType("boolean");

                    b.Property<decimal>("GreetingChannel")
                        .HasColumnType("numeric(20,0)");

                    b.Property<decimal>("GuildId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<string>("InfractionFormat")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsPremium")
                        .HasColumnType("boolean");

                    b.Property<bool>("LogMessageChanges")
                        .HasColumnType("boolean");

                    b.Property<int>("MaxRoleMentions")
                        .HasColumnType("integer");

                    b.Property<int>("MaxUserMentions")
                        .HasColumnType("integer");

                    b.Property<decimal>("MuteRoleId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<bool>("ScanInvites")
                        .HasColumnType("boolean");

                    b.Property<bool>("UseAggressiveRegex")
                        .HasColumnType("boolean");

                    b.Property<bool>("WarnOnMatchedInvite")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("GuildId")
                        .IsUnique();

                    b.ToTable("GuildConfigs");
                });

            modelBuilder.Entity("Silk.Core.Database.Models.GuildInfractionModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int>("ConfigId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("Expiration")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ConfigId");

                    b.ToTable("GuildInfractionModel");
                });

            modelBuilder.Entity("Silk.Core.Database.Models.GuildInviteModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int?>("GuildConfigModelId")
                        .HasColumnType("integer");

                    b.Property<string>("GuildName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("VanityURL")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("GuildConfigModelId");

                    b.ToTable("GuildInviteModel");
                });

            modelBuilder.Entity("Silk.Core.Database.Models.GuildModel", b =>
                {
                    b.Property<decimal>("Id")
                        .HasColumnType("numeric(20,0)");

                    b.Property<string>("Prefix")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("character varying(5)");

                    b.HasKey("Id");

                    b.ToTable("Guilds");
                });

            modelBuilder.Entity("Silk.Core.Database.Models.ItemModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<decimal>("OwnerId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("jsonb");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Silk.Core.Database.Models.SelfAssignableRole", b =>
                {
                    b.Property<decimal>("Id")
                        .HasColumnType("numeric(20,0)");

                    b.Property<int?>("GuildConfigModelId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("GuildConfigModelId");

                    b.ToTable("SelfAssignableRole");
                });

            modelBuilder.Entity("Silk.Core.Database.Models.TicketMessageHistoryModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Sender")
                        .HasColumnType("numeric(20,0)");

                    b.Property<int>("TicketModelId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("TicketModelId");

                    b.ToTable("TicketMessageHistoryModel");
                });

            modelBuilder.Entity("Silk.Core.Database.Models.TicketModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<DateTime>("Closed")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsOpen")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("Opened")
                        .HasColumnType("timestamp without time zone");

                    b.Property<decimal>("Opener")
                        .HasColumnType("numeric(20,0)");

                    b.HasKey("Id");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("Silk.Core.Database.Models.TicketResponderModel", b =>
                {
                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("ResponderId")
                        .HasColumnType("numeric(20,0)");

                    b.ToTable("TicketResponderModel");
                });

            modelBuilder.Entity("Silk.Core.Database.Models.UserInfractionModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<decimal>("Enforcer")
                        .HasColumnType("numeric(20,0)");

                    b.Property<DateTime?>("Expiration")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("HeldAgainstUser")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("InfractionTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("InfractionType")
                        .HasColumnType("integer");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("UserDatabaseId")
                        .HasColumnType("bigint");

                    b.Property<decimal>("UserId")
                        .HasColumnType("numeric(20,0)");

                    b.HasKey("Id");

                    b.HasIndex("UserDatabaseId");

                    b.ToTable("Infractions");
                });

            modelBuilder.Entity("Silk.Core.Database.Models.UserModel", b =>
                {
                    b.Property<long>("DatabaseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityByDefaultColumn();

                    b.Property<int>("Flags")
                        .HasColumnType("integer");

                    b.Property<decimal>("GuildId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<decimal>("Id")
                        .HasColumnType("numeric(20,0)");

                    b.HasKey("DatabaseId");

                    b.HasIndex("GuildId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Silk.Core.Database.Models.BlackListedWord", b =>
                {
                    b.HasOne("Silk.Core.Database.Models.GuildConfigModel", "Guild")
                        .WithMany("BlackListedWords")
                        .HasForeignKey("GuildId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Guild");
                });

            modelBuilder.Entity("Silk.Core.Database.Models.GuildConfigModel", b =>
                {
                    b.HasOne("Silk.Core.Database.Models.GuildModel", "Guild")
                        .WithOne("Configuration")
                        .HasForeignKey("Silk.Core.Database.Models.GuildConfigModel", "GuildId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Guild");
                });

            modelBuilder.Entity("Silk.Core.Database.Models.GuildInfractionModel", b =>
                {
                    b.HasOne("Silk.Core.Database.Models.GuildConfigModel", "Config")
                        .WithMany("InfractionDictionary")
                        .HasForeignKey("ConfigId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Config");
                });

            modelBuilder.Entity("Silk.Core.Database.Models.GuildInviteModel", b =>
                {
                    b.HasOne("Silk.Core.Database.Models.GuildConfigModel", null)
                        .WithMany("AllowedInvites")
                        .HasForeignKey("GuildConfigModelId");
                });

            modelBuilder.Entity("Silk.Core.Database.Models.ItemModel", b =>
                {
                    b.HasOne("Silk.Core.Database.Models.GlobalUserModel", "Owner")
                        .WithMany("Items")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("Silk.Core.Database.Models.SelfAssignableRole", b =>
                {
                    b.HasOne("Silk.Core.Database.Models.GuildConfigModel", null)
                        .WithMany("SelfAssignableRoles")
                        .HasForeignKey("GuildConfigModelId");
                });

            modelBuilder.Entity("Silk.Core.Database.Models.TicketMessageHistoryModel", b =>
                {
                    b.HasOne("Silk.Core.Database.Models.TicketModel", "TicketModel")
                        .WithMany("History")
                        .HasForeignKey("TicketModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TicketModel");
                });

            modelBuilder.Entity("Silk.Core.Database.Models.UserInfractionModel", b =>
                {
                    b.HasOne("Silk.Core.Database.Models.UserModel", "User")
                        .WithMany("Infractions")
                        .HasForeignKey("UserDatabaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Silk.Core.Database.Models.UserModel", b =>
                {
                    b.HasOne("Silk.Core.Database.Models.GuildModel", "Guild")
                        .WithMany("Users")
                        .HasForeignKey("GuildId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Guild");
                });

            modelBuilder.Entity("Silk.Core.Database.Models.GlobalUserModel", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("Silk.Core.Database.Models.GuildConfigModel", b =>
                {
                    b.Navigation("AllowedInvites");

                    b.Navigation("BlackListedWords");

                    b.Navigation("InfractionDictionary");

                    b.Navigation("SelfAssignableRoles");
                });

            modelBuilder.Entity("Silk.Core.Database.Models.GuildModel", b =>
                {
                    b.Navigation("Configuration")
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Silk.Core.Database.Models.TicketModel", b =>
                {
                    b.Navigation("History");
                });

            modelBuilder.Entity("Silk.Core.Database.Models.UserModel", b =>
                {
                    b.Navigation("Infractions");
                });
#pragma warning restore 612, 618
        }
    }
}
