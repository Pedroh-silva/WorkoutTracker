﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Workout_Tracker.Data;

#nullable disable

namespace Workout_Tracker.Migrations
{
    [DbContext(typeof(WorkoutTrackerDbContext))]
    [Migration("20220706132012_seedMuscle")]
    partial class seedMuscle
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ExerciseMuscle", b =>
                {
                    b.Property<int>("ExercisesId")
                        .HasColumnType("int");

                    b.Property<int>("MusclesId")
                        .HasColumnType("int");

                    b.HasKey("ExercisesId", "MusclesId");

                    b.HasIndex("MusclesId");

                    b.ToTable("ExerciseMuscle");
                });

            modelBuilder.Entity("ExerciseWorkout", b =>
                {
                    b.Property<int>("ExercisesId")
                        .HasColumnType("int");

                    b.Property<int>("WorkoutsId")
                        .HasColumnType("int");

                    b.HasKey("ExercisesId", "WorkoutsId");

                    b.HasIndex("WorkoutsId");

                    b.ToTable("ExerciseWorkout");
                });

            modelBuilder.Entity("Workout_Tracker.Models.Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Exercise");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Barra Fixa"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Flexão de braço"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Agachamento"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Dips"
                        });
                });

            modelBuilder.Entity("Workout_Tracker.Models.Muscle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Muscle");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImagePath = "~/lib/Images/Muscle/costas.png",
                            Name = "Costas"
                        },
                        new
                        {
                            Id = 2,
                            ImagePath = "/lib/Images/Muscle/peito.png",
                            Name = "Peito"
                        },
                        new
                        {
                            Id = 3,
                            ImagePath = "/lib/Images/Muscle/pernas.png",
                            Name = "Pernas"
                        },
                        new
                        {
                            Id = 4,
                            ImagePath = "/lib/Images/Muscle/triceps.png",
                            Name = "Triceps"
                        });
                });

            modelBuilder.Entity("Workout_Tracker.Models.Workout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("time(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Workout");
                });

            modelBuilder.Entity("ExerciseMuscle", b =>
                {
                    b.HasOne("Workout_Tracker.Models.Exercise", null)
                        .WithMany()
                        .HasForeignKey("ExercisesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Workout_Tracker.Models.Muscle", null)
                        .WithMany()
                        .HasForeignKey("MusclesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ExerciseWorkout", b =>
                {
                    b.HasOne("Workout_Tracker.Models.Exercise", null)
                        .WithMany()
                        .HasForeignKey("ExercisesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Workout_Tracker.Models.Workout", null)
                        .WithMany()
                        .HasForeignKey("WorkoutsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
