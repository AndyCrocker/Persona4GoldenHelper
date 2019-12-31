﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persona4GoldenHelper.Data;

namespace Persona4GoldenHelper.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20191231190638_Add shadows")]
    partial class Addshadows
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Persona4GoldenHelper.Data.Models.Accessory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Effect");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Accessories");
                });

            modelBuilder.Entity("Persona4GoldenHelper.Data.Models.AccessoryObtain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AccessoryId");

                    b.Property<string>("Obtain");

                    b.Property<string>("Price");

                    b.HasKey("Id");

                    b.HasIndex("AccessoryId");

                    b.ToTable("AccessoryObtain");
                });

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

            modelBuilder.Entity("Persona4GoldenHelper.Data.Models.Calculator.ArcanaFusionResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FusionType");

                    b.Property<string>("ResultArcana");

                    b.HasKey("Id");

                    b.ToTable("ArcanaFusionResults");
                });

            modelBuilder.Entity("Persona4GoldenHelper.Data.Models.Calculator.ArcanaRank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArcanaName");

                    b.HasKey("Id");

                    b.ToTable("ArcanaRanks");
                });

            modelBuilder.Entity("Persona4GoldenHelper.Data.Models.Calculator.FusionArcana", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ArcanaFusionResultId");

                    b.Property<string>("ArcanaName");

                    b.HasKey("Id");

                    b.HasIndex("ArcanaFusionResultId");

                    b.ToTable("FusionArcana");
                });

            modelBuilder.Entity("Persona4GoldenHelper.Data.Models.Calculator.FusionPersona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PersonaName");

                    b.Property<int?>("SpecialFusionResultId");

                    b.HasKey("Id");

                    b.HasIndex("SpecialFusionResultId");

                    b.ToTable("FusionPersona");
                });

            modelBuilder.Entity("Persona4GoldenHelper.Data.Models.Calculator.SpecialFusionResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ResultPersona");

                    b.HasKey("Id");

                    b.ToTable("SpecialFusionResults");
                });

            modelBuilder.Entity("Persona4GoldenHelper.Data.Models.Link", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("SourceId");

                    b.Property<string>("URL");

                    b.HasKey("Id");

                    b.HasIndex("SourceId");

                    b.ToTable("Link");
                });

            modelBuilder.Entity("Persona4GoldenHelper.Data.Models.Lunch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Method");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Lunches");
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

            modelBuilder.Entity("Persona4GoldenHelper.Data.Models.Shadow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ElementsId");

                    b.Property<int>("Exp");

                    b.Property<int>("HP");

                    b.Property<int>("Level");

                    b.Property<string>("Name");

                    b.Property<int>("SP");

                    b.Property<int?>("StatsId");

                    b.Property<int>("Type");

                    b.Property<string>("Yen");

                    b.HasKey("Id");

                    b.HasIndex("ElementsId");

                    b.HasIndex("StatsId");

                    b.ToTable("Shadows");
                });

            modelBuilder.Entity("Persona4GoldenHelper.Data.Models.ShadowElements", b =>
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

                    b.ToTable("ShadowElements");
                });

            modelBuilder.Entity("Persona4GoldenHelper.Data.Models.ShadowSkill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int?>("ShadowId");

                    b.HasKey("Id");

                    b.HasIndex("ShadowId");

                    b.ToTable("ShadowSkill");
                });

            modelBuilder.Entity("Persona4GoldenHelper.Data.Models.ShadowStats", b =>
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

                    b.ToTable("ShadowStats");
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

            modelBuilder.Entity("Persona4GoldenHelper.Data.Models.SkillCardLocation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DungeonName");

                    b.Property<int>("RankLowerBound");

                    b.Property<int>("RankUpperBound");

                    b.HasKey("Id");

                    b.ToTable("SkillCardLocations");
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

            modelBuilder.Entity("Persona4GoldenHelper.Data.Models.Source", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Information");

                    b.HasKey("Id");

                    b.ToTable("Sources");
                });

            modelBuilder.Entity("Persona4GoldenHelper.Data.Models.AccessoryObtain", b =>
                {
                    b.HasOne("Persona4GoldenHelper.Data.Models.Accessory")
                        .WithMany("Obtained")
                        .HasForeignKey("AccessoryId");
                });

            modelBuilder.Entity("Persona4GoldenHelper.Data.Models.ArmorObtain", b =>
                {
                    b.HasOne("Persona4GoldenHelper.Data.Models.Armor")
                        .WithMany("Obtained")
                        .HasForeignKey("ArmorId");
                });

            modelBuilder.Entity("Persona4GoldenHelper.Data.Models.Calculator.FusionArcana", b =>
                {
                    b.HasOne("Persona4GoldenHelper.Data.Models.Calculator.ArcanaFusionResult")
                        .WithMany("SourceArcanas")
                        .HasForeignKey("ArcanaFusionResultId");
                });

            modelBuilder.Entity("Persona4GoldenHelper.Data.Models.Calculator.FusionPersona", b =>
                {
                    b.HasOne("Persona4GoldenHelper.Data.Models.Calculator.SpecialFusionResult")
                        .WithMany("SourcePersonas")
                        .HasForeignKey("SpecialFusionResultId");
                });

            modelBuilder.Entity("Persona4GoldenHelper.Data.Models.Link", b =>
                {
                    b.HasOne("Persona4GoldenHelper.Data.Models.Source")
                        .WithMany("Links")
                        .HasForeignKey("SourceId");
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

            modelBuilder.Entity("Persona4GoldenHelper.Data.Models.Shadow", b =>
                {
                    b.HasOne("Persona4GoldenHelper.Data.Models.ShadowElements", "Elements")
                        .WithMany()
                        .HasForeignKey("ElementsId");

                    b.HasOne("Persona4GoldenHelper.Data.Models.ShadowStats", "Stats")
                        .WithMany()
                        .HasForeignKey("StatsId");
                });

            modelBuilder.Entity("Persona4GoldenHelper.Data.Models.ShadowSkill", b =>
                {
                    b.HasOne("Persona4GoldenHelper.Data.Models.Shadow")
                        .WithMany("Skills")
                        .HasForeignKey("ShadowId");
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
