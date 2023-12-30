﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(SMDbContext))]
    partial class SMDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("API.Models.Account", b =>
                {
                    b.Property<Guid>("Guid")
                        .HasColumnType("char(36)")
                        .HasColumnName("guid");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_date");

                    b.Property<DateTime>("ExpiredTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("expired_time");

                    b.Property<bool>("IsUsed")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_used");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("modified_date");

                    b.Property<int>("Otp")
                        .HasColumnType("int")
                        .HasColumnName("otp");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("password");

                    b.Property<Guid>("RoleGuid")
                        .HasColumnType("char(36)")
                        .HasColumnName("role_guid");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasColumnName("status");

                    b.HasKey("Guid");

                    b.HasIndex("RoleGuid");

                    b.ToTable("tb_m_accounts");

                    b.HasData(
                        new
                        {
                            Guid = new Guid("5cdbb962-a21e-4aba-8fae-4227a37b0878"),
                            ExpiredTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsUsed = false,
                            Otp = 0,
                            Password = "$2a$12$ZdWT4iagxSXhUwHFpMwwi..PiiamL2V3AzMd4sDWbVoMa0jJYOyMq",
                            RoleGuid = new Guid("4ef36046-f48b-40b4-add6-bb1fea6a2490"),
                            Status = 1
                        },
                        new
                        {
                            Guid = new Guid("4e341bd3-69ed-4509-affb-6a738cae37f0"),
                            ExpiredTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsUsed = false,
                            Otp = 0,
                            Password = "$2a$12$pOhiKpjnuqdOn7wTjWccFu6zVVti4cp86HWpogMv0GMH3UtYq/hsG",
                            RoleGuid = new Guid("aa422e40-1310-486e-950b-a8ba98eceedb"),
                            Status = 1
                        });
                });

            modelBuilder.Entity("API.Models.Company", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("guid");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("address");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("email");

                    b.Property<string>("Foto")
                        .HasColumnType("longtext")
                        .HasColumnName("foto");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("modified_date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("name");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("phone_number");

                    b.HasKey("Guid");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("PhoneNumber")
                        .IsUnique();

                    b.ToTable("tb_m_company");

                    b.HasData(
                        new
                        {
                            Guid = new Guid("5cdbb962-a21e-4aba-8fae-4227a37b0878"),
                            Address = "null",
                            CreatedDate = new DateTime(2023, 12, 30, 9, 9, 21, 500, DateTimeKind.Local).AddTicks(2424),
                            Email = "admin2023@mail.com",
                            Foto = "null",
                            Name = "Admin",
                            PhoneNumber = "00000"
                        },
                        new
                        {
                            Guid = new Guid("4e341bd3-69ed-4509-affb-6a738cae37f0"),
                            Address = "null",
                            CreatedDate = new DateTime(2023, 12, 30, 9, 9, 21, 500, DateTimeKind.Local).AddTicks(2457),
                            Email = "manager123@mail.com",
                            Foto = "nul",
                            Name = "Manager Logistic",
                            PhoneNumber = "11111"
                        });
                });

            modelBuilder.Entity("API.Models.Role", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("guid");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_date");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("modified_date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("name");

                    b.HasKey("Guid");

                    b.ToTable("tb_m_roles");

                    b.HasData(
                        new
                        {
                            Guid = new Guid("4ef36046-f48b-40b4-add6-bb1fea6a2490"),
                            Name = "admin"
                        },
                        new
                        {
                            Guid = new Guid("aa422e40-1310-486e-950b-a8ba98eceedb"),
                            Name = "manager"
                        },
                        new
                        {
                            Guid = new Guid("686d0669-9df9-469e-9f5c-b31d10d43f1c"),
                            Name = "vendor"
                        });
                });

            modelBuilder.Entity("API.Models.Vendor", b =>
                {
                    b.Property<Guid>("Guid")
                        .HasColumnType("char(36)")
                        .HasColumnName("guid");

                    b.Property<string>("BidangUsaha")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("bidang_usaha");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_date");

                    b.Property<string>("JenisPerusahaan")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("jenis_perusahaan");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("modified_date");

                    b.Property<int?>("StatusVendor")
                        .HasColumnType("int")
                        .HasColumnName("status_vendor");

                    b.HasKey("Guid");

                    b.ToTable("tb_m_vendor");
                });

            modelBuilder.Entity("API.Models.Account", b =>
                {
                    b.HasOne("API.Models.Company", "Company")
                        .WithOne("Account")
                        .HasForeignKey("API.Models.Account", "Guid")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("API.Models.Role", "Role")
                        .WithMany("Accounts")
                        .HasForeignKey("RoleGuid")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("API.Models.Vendor", b =>
                {
                    b.HasOne("API.Models.Company", "Company")
                        .WithOne("Vendor")
                        .HasForeignKey("API.Models.Vendor", "Guid")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("API.Models.Company", b =>
                {
                    b.Navigation("Account");

                    b.Navigation("Vendor");
                });

            modelBuilder.Entity("API.Models.Role", b =>
                {
                    b.Navigation("Accounts");
                });
#pragma warning restore 612, 618
        }
    }
}
