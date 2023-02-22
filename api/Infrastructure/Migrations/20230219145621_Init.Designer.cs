﻿// <auto-generated />
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Domain.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230219145621_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.Entities.Identity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Domain.Entities.Sample.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("Domain.Entities.Sample.Instrument", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Instruments");
                });

            modelBuilder.Entity("Domain.Entities.Sample.Sound", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AudioUrl")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Bpm")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Sounds");
                });

            modelBuilder.Entity("GenreSound", b =>
                {
                    b.Property<int>("GenresId")
                        .HasColumnType("int");

                    b.Property<int>("SoundsId")
                        .HasColumnType("int");

                    b.HasKey("GenresId", "SoundsId");

                    b.HasIndex("SoundsId");

                    b.ToTable("GenreSounds");
                });

            modelBuilder.Entity("InstrumentSound", b =>
                {
                    b.Property<int>("InstrumentsId")
                        .HasColumnType("int");

                    b.Property<int>("SoundsId")
                        .HasColumnType("int");

                    b.HasKey("InstrumentsId", "SoundsId");

                    b.HasIndex("SoundsId");

                    b.ToTable("InstrumentSounds");
                });

            modelBuilder.Entity("SoundUser", b =>
                {
                    b.Property<int>("SoundsId")
                        .HasColumnType("int");

                    b.Property<int>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("SoundsId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("SoundUsers");
                });

            modelBuilder.Entity("Domain.Entities.Sample.Sound", b =>
                {
                    b.OwnsOne("Domain.ValueObjects.Sample.Key", "Key", b1 =>
                        {
                            b1.Property<int>("SoundId")
                                .HasColumnType("int");

                            b1.Property<int>("Form")
                                .HasColumnType("int");

                            b1.Property<int>("Mod")
                                .HasColumnType("int");

                            b1.Property<int>("Root")
                                .HasColumnType("int");

                            b1.HasKey("SoundId");

                            b1.ToTable("Sounds");

                            b1.WithOwner()
                                .HasForeignKey("SoundId");
                        });

                    b.Navigation("Key")
                        .IsRequired();
                });

            modelBuilder.Entity("GenreSound", b =>
                {
                    b.HasOne("Domain.Entities.Sample.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Sample.Sound", null)
                        .WithMany()
                        .HasForeignKey("SoundsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("InstrumentSound", b =>
                {
                    b.HasOne("Domain.Entities.Sample.Instrument", null)
                        .WithMany()
                        .HasForeignKey("InstrumentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Sample.Sound", null)
                        .WithMany()
                        .HasForeignKey("SoundsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SoundUser", b =>
                {
                    b.HasOne("Domain.Entities.Sample.Sound", null)
                        .WithMany()
                        .HasForeignKey("SoundsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
