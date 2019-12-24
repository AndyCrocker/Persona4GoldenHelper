﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persona4GoldenHelper.Data;

namespace Persona4GoldenHelper.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Persona4GoldenHelper.Data.Models.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DateAsked");

                    b.Property<int>("Month");

                    b.Property<string>("QuestionAnswer");

                    b.Property<string>("QuestionAsked");

                    b.HasKey("Id");

                    b.ToTable("ExamAnswers");
                });

            modelBuilder.Entity("Persona4GoldenHelper.Data.Models.Armor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Defense");

                    b.Property<string>("Effect");

                    b.Property<int>("Evade");

                    b.Property<int>("Gender");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Armor");
                });

            modelBuilder.Entity("Persona4GoldenHelper.Data.Models.ArmorObtain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ArmorId");

                    b.Property<string>("Obtain");

                    b.Property<string>("Price");

                    b.HasKey("Id");

                    b.HasIndex("ArmorId");

                    b.ToTable("ArmorObtain");
                });

            modelBuilder.Entity("Persona4GoldenHelper.Data.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DateAvailable");

                    b.Property<string>("Effect");

                    b.Property<string>("Requirement");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Persona4GoldenHelper.Data.Models.BookOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BookName");

                    b.HasKey("Id");

                    b.ToTable("BookOrder");
                });

            modelBuilder.Entity("Persona4GoldenHelper.Data.Models.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Arcana");

                    b.Property<int?>("ElementsId");

                    b.Property<int>("Level");

                    b.Property<string>("Name");

                    b.Property<bool>("NewGame");

                    b.Property<int?>("StatsId");

                    b.Property<bool>("Ultimate");

                    b.HasKey("Id");

                    b.HasIndex("ElementsId");

                    b.HasIndex("StatsId");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("Persona4GoldenHelper.Data.Models.PersonaElements", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Darkness");

                    b.Property<int>("Electricity");

                    b.Property<int>("Fire");

                    b.Property<int>("Ice");

                    b.Property<int>("Light");

                    b.Property<int>("Physical");

                    b.Property<int>("Wind");

                    b.HasKey("Id");

                    b.ToTable("PersonaElements");
                });

            modelBuilder.Entity("Persona4GoldenHelper.Data.Models.PersonaSkill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LevelRequired");

                    b.Property<string>("Name");

                    b.Property<int?>("PersonaId");

                    b.HasKey("Id");

                    b.HasIndex("PersonaId");

                    b.ToTable("PersonaSkill");
                });

            modelBuilder.Entity("Persona4GoldenHelper.Data.Models.PersonaStats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Agility");

                    b.Property<int>("Endurance");

                    b.Property<int>("Luck");

                    b.Property<int>("Magic");

                    b.Property<int>("Strength");

                    b.HasKey("Id");

                    b.ToTable("PersonaStats");
                });

            modelBuilder.Entity("Persona4GoldenHelper.Data.Models.Plant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DateAvailable");

                    b.Property<int>("GrowthTime");

                    b.Property<int>("Harvest");

                    b.Property<int?>("SeedId");

                    b.HasKey("Id");

                    b.HasIndex("SeedId");

                    b.ToTable("Plants");
                });

            modelBuilder.Entity("Persona4GoldenHelper.Data.Models.PlantProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Effect");

                    b.Property<string>("Name");

                    b.Property<int?>("PlantId");

                    b.HasKey("Id");

                    b.HasIndex("PlantId");

                    b.ToTable("PlantProduct");
                });

            modelBuilder.Entity("Persona4GoldenHelper.Data.Models.PlantSeed", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cost");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("PlantSeed");
                });

            modelBuilder.Entity("Persona4GoldenHelper.Data.Models.Quest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DateAvailable");

                    b.Property<string>("Instructions");

                    b.Property<string>("Location");

                    b.Property<int>("Number");

                    b.Property<string>("Prerequisites");

                    b.Property<string>("QuestGiver");

                    b.Property<string>("Reward");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Quests");
                });

            modelBuilder.Entity("Persona4GoldenHelper.Data.Models.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cost");

                    b.Property<string>("Effect");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("Persona4GoldenHelper.Data.Models.SkillCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int>("Rank");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.ToTable("SkillCards");
                });

            modelBuilder.Entity("Persona4GoldenHelper.Data.Models.SkillPersona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LevelRequired");

                    b.Property<string>("Name");

                    b.Property<bool>("NewGame");

                    b.Property<int?>("SkillId");

                    b.Property<bool>("Ultimate");

                    b.HasKey("Id");

                    b.HasIndex("SkillId");

                    b.ToTable("SkillPersona");
                });

            modelBuilder.Entity("Persona4GoldenHelper.Data.Models.ArmorObtain", b =>
                {
                    b.HasOne("Persona4GoldenHelper.Data.Models.Armor")
                        .WithMany("Obtained")
                        .HasForeignKey("ArmorId");
                });

            modelBuilder.Entity("Persona4GoldenHelper.Data.Models.Persona", b =>
                {
                    b.HasOne("Persona4GoldenHelper.Data.Models.PersonaElements", "Elements")
                        .WithMany()
                        .HasForeignKey("ElementsId");

                    b.HasOne("Persona4GoldenHelper.Data.Models.PersonaStats", "Stats")
                        .WithMany()
                        .HasForeignKey("StatsId");
                });

            modelBuilder.Entity("Persona4GoldenHelper.Data.Models.PersonaSkill", b =>
                {
                    b.HasOne("Persona4GoldenHelper.Data.Models.Persona")
                        .WithMany("Skills")
                        .HasForeignKey("PersonaId");
                });

            modelBuilder.Entity("Persona4GoldenHelper.Data.Models.Plant", b =>
                {
                    b.HasOne("Persona4GoldenHelper.Data.Models.PlantSeed", "Seed")
                        .WithMany()
                        .HasForeignKey("SeedId");
                });

            modelBuilder.Entity("Persona4GoldenHelper.Data.Models.PlantProduct", b =>
                {
                    b.HasOne("Persona4GoldenHelper.Data.Models.Plant")
                        .WithMany("Products")
                        .HasForeignKey("PlantId");
                });

            modelBuilder.Entity("Persona4GoldenHelper.Data.Models.SkillPersona", b =>
                {
                    b.HasOne("Persona4GoldenHelper.Data.Models.Skill")
                        .WithMany("Personas")
                        .HasForeignKey("SkillId");
                });
#pragma warning restore 612, 618
        }
    }
}
