﻿// <auto-generated />
using bankacc.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace bankacc.Migrations
{
    [DbContext(typeof(UserContext))]
    [Migration("20180615224155_account1")]
    partial class account1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("bankacc.Models.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Amount");

                    b.HasKey("AccountId");

                    b.ToTable("accounts");
                });

            modelBuilder.Entity("bankacc.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("confirmpass")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("PersonId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("bankacc.Models.Transaction", b =>
                {
                    b.Property<int>("TransactionId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CurrentBalance");

                    b.Property<DateTime>("Date");

                    b.Property<int>("Deposit");

                    b.HasKey("TransactionId");

                    b.ToTable("transactions");
                });
#pragma warning restore 612, 618
        }
    }
}