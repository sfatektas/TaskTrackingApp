﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Select.TaskTrackingApp.DataAccess.Context;

namespace Select.TaskTrackingApp.DataAccess.Migrations
{
    [DbContext(typeof(TaskTrackingContext))]
    [Migration("20221203203212_appUserTaskfixxed")]
    partial class appUserTaskfixxed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Select.TaskTrackingApp.Entities.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Defination")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("AppRoles");
                });

            modelBuilder.Entity("Select.TaskTrackingApp.Entities.AppTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreatedTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Defination")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("EndDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("PriortryId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("PriortryId");

                    b.ToTable("AppTasks");
                });

            modelBuilder.Entity("Select.TaskTrackingApp.Entities.AppTaskStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Defination")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("TaskStatuses");
                });

            modelBuilder.Entity("Select.TaskTrackingApp.Entities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("DegreeId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("DegreeId");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("AppUsers");
                });

            modelBuilder.Entity("Select.TaskTrackingApp.Entities.AppUserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AppRoleId")
                        .HasColumnType("int");

                    b.Property<int>("AppUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("AppRoleId", "AppUserId")
                        .IsUnique();

                    b.ToTable("AppUserRoles");
                });

            modelBuilder.Entity("Select.TaskTrackingApp.Entities.AppUserTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AppTaskId")
                        .HasColumnType("int");

                    b.Property<int>("AppUserId")
                        .HasColumnType("int");

                    b.Property<string>("CompleteDocumentDefination")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CompletedTaskDate")
                        .HasColumnType("smalldatetime");

                    b.Property<string>("DocumentPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TaskEndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TaskStatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AppTaskId")
                        .IsUnique();

                    b.HasIndex("TaskStatusId");

                    b.HasIndex("AppUserId", "AppTaskId")
                        .IsUnique();

                    b.ToTable("AppUserTasks");
                });

            modelBuilder.Entity("Select.TaskTrackingApp.Entities.Degree", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Defination")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Degrees");
                });

            modelBuilder.Entity("Select.TaskTrackingApp.Entities.Priortry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Defination")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Priortries");
                });

            modelBuilder.Entity("Select.TaskTrackingApp.Entities.AppTask", b =>
                {
                    b.HasOne("Select.TaskTrackingApp.Entities.Priortry", "Priortry")
                        .WithMany("AppTasks")
                        .HasForeignKey("PriortryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Priortry");
                });

            modelBuilder.Entity("Select.TaskTrackingApp.Entities.AppUser", b =>
                {
                    b.HasOne("Select.TaskTrackingApp.Entities.Degree", "Degree")
                        .WithMany("AppUsers")
                        .HasForeignKey("DegreeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Degree");
                });

            modelBuilder.Entity("Select.TaskTrackingApp.Entities.AppUserRole", b =>
                {
                    b.HasOne("Select.TaskTrackingApp.Entities.AppRole", "AppRole")
                        .WithMany("AppUserRoles")
                        .HasForeignKey("AppRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Select.TaskTrackingApp.Entities.AppUser", "AppUser")
                        .WithMany("AppUserRoles")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppRole");

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("Select.TaskTrackingApp.Entities.AppUserTask", b =>
                {
                    b.HasOne("Select.TaskTrackingApp.Entities.AppTask", "AppTask")
                        .WithOne("AppUserTask")
                        .HasForeignKey("Select.TaskTrackingApp.Entities.AppUserTask", "AppTaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Select.TaskTrackingApp.Entities.AppUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Select.TaskTrackingApp.Entities.AppTaskStatus", "TaskStatus")
                        .WithMany("AppUserTasks")
                        .HasForeignKey("TaskStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppTask");

                    b.Navigation("AppUser");

                    b.Navigation("TaskStatus");
                });

            modelBuilder.Entity("Select.TaskTrackingApp.Entities.AppRole", b =>
                {
                    b.Navigation("AppUserRoles");
                });

            modelBuilder.Entity("Select.TaskTrackingApp.Entities.AppTask", b =>
                {
                    b.Navigation("AppUserTask");
                });

            modelBuilder.Entity("Select.TaskTrackingApp.Entities.AppTaskStatus", b =>
                {
                    b.Navigation("AppUserTasks");
                });

            modelBuilder.Entity("Select.TaskTrackingApp.Entities.AppUser", b =>
                {
                    b.Navigation("AppUserRoles");
                });

            modelBuilder.Entity("Select.TaskTrackingApp.Entities.Degree", b =>
                {
                    b.Navigation("AppUsers");
                });

            modelBuilder.Entity("Select.TaskTrackingApp.Entities.Priortry", b =>
                {
                    b.Navigation("AppTasks");
                });
#pragma warning restore 612, 618
        }
    }
}