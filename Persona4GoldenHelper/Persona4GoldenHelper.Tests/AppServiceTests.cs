﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Abstractions;
using NUnit.Framework;
using Persona4GoldenHelper.Data;
using Persona4GoldenHelper.Data.Models;
using Persona4GoldenHelper.Service;
using System.Collections.Generic;
using Persona4GoldenHelper.Data.Enums;

namespace Persona4GoldenHelper.Tests
{
    /// <summary>App API tests.</summary>
    public class AppServiceTests
    {
        /*********
        ** Fields
        *********/
        /// <summary>The database context.</summary>
        private ApplicationDbContext Context;

        /// <summary>Provides basic data apis.</summary>
        private IApp AppService;

        /// <summary>Provides persona apis.</summary>
        private IPersona PersonaService;

        /// <summary>Provides shadow apis.</summary>
        private IShadow ShadowService;


        /*********
        ** Public Methods
        *********/
        /// <summary>Setup initial test state.</summary>
        [SetUp]
        public void SetUp()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "AppDatabase").Options;

            Context = new ApplicationDbContext(options);

            PersonaService = new PersonaService(Context, new NullLogger<PersonaService>());
            ShadowService = new ShadowService(Context, new NullLogger<ShadowService>());
            AppService = new AppService(Context, new NullLogger<AppService>(), PersonaService, ShadowService);
        }

        /// <summary>Test for books api.</summary>
        [Test]
        public void GetAllBooks()
        {
            // arrange
            Context.Books.Add(new Book()
            {
                Title = "First book",
                Effect = "first book effect",
                Requirement = "first book requirement",
                DateAvailable = "first book available date"
            });

            Context.Books.Add(new Book()
            {
                Title = "Second book",
                Effect = "second book effect",
                Requirement = "second book requirement",
                DateAvailable = "second book available date"
            });

            Context.Books.Add(new Book()
            {
                Title = "Third book",
                Effect = "third book effect",
                Requirement = "third book requirement",
                DateAvailable = "third book available date"
            });

            Context.SaveChanges();

            // act
            var books = AppService.GetAllBooks();

            // assert
            Assert.AreEqual(3, books.Count);
        }

        /// <summary>Test for book order api.</summary>
        [Test]
        public void GetBookOrder()
        {
            // arrange
            Context.BookOrder.Add(new BookOrder()
            {
                BookName = "First book order"
            });

            Context.BookOrder.Add(new BookOrder()
            {
                BookName = "Second book order"
            });

            Context.BookOrder.Add(new BookOrder()
            {
                BookName = "Third book order"
            });

            Context.SaveChanges();

            // act
            var bookOrders = AppService.GetBookOrder();

            // assert
            Assert.AreEqual(3, bookOrders.Count);
        }

        /// <summary>Test for exam answers api.</summary>
        [Test]
        public void GetAllExamAnswers()
        {
            // arrange
            Context.ExamAnswers.Add(new Answer()
            {
                Month = Month.April,
                DateAsked = "date asked",
                QuestionAsked = "first question",
                QuestionAnswer = "first answer",
            });

            Context.ExamAnswers.Add(new Answer()
            {
                Month = Month.April,
                DateAsked = "date asked",
                QuestionAsked = "second question",
                QuestionAnswer = "second answer",
            });

            Context.ExamAnswers.Add(new Answer()
            {
                Month = Month.April,
                DateAsked = "date asked",
                QuestionAsked = "second question",
                QuestionAnswer = "second answer",
            });

            Context.SaveChanges();

            // act
            var answers = AppService.GetAllExamAnswers();

            // assert
            Assert.AreEqual(3, answers.Count);
        }

        /// <summary>Test for plants api.</summary>
        [Test]
        public void GetAllPlants()
        {
            // arrange
            Context.Plants.Add(new Plant()
            {
                DateAvailable = "date available",
                Seed = new PlantSeed()
                {
                    Name = "seed name",
                    Cost = "seed price"
                },
                GrowthTime = 4,
                Harvest = 5,
                HarvestWithTending = 6,
                Products = new List<PlantProduct>() {
                    new PlantProduct() {
                        Name = "product name",
                        Effect = "product effect"
                    }
                }
            });

            Context.Plants.Add(new Plant()
            {
                DateAvailable = "date available2",
                Seed = new PlantSeed()
                {
                    Name = "seed name2",
                    Cost = "seed price2"
                },
                GrowthTime = 4,
                Harvest = 5,
                HarvestWithTending = 6,
                Products = new List<PlantProduct>() {
                    new PlantProduct() {
                        Name = "product name2",
                        Effect = "product effect2"
                    }
                }
            });

            Context.Plants.Add(new Plant()
            {
                DateAvailable = "date available3",
                Seed = new PlantSeed()
                {
                    Name = "seed name3",
                    Cost = "seed price3"
                },
                GrowthTime = 4,
                Harvest = 5,
                HarvestWithTending = 6,
                Products = new List<PlantProduct>() {
                    new PlantProduct() {
                        Name = "product name3",
                        Effect = "product effect3"
                    }
                }
            });

            Context.SaveChanges();

            // act
            var answers = AppService.GetAllPlants();

            // assert
            Assert.AreEqual(3, answers.Count);
        }

        /// <summary>Test for skills api.</summary>
        [Test]
        public void GetAllSkills()
        {
            // arrange
            Context.Skills.Add(new Skill()
            {
                Name = "first skill",
                Effect = "first effect",
                Cost = "first cost",
                Personas = new List<SkillPersona>()
                {
                    new SkillPersona()
                    {
                        LevelRequired = 1,
                        Name = "persona name",
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona()
                    {
                        LevelRequired = 2,
                        Name = "persona name",
                        Ultimate = false,
                        NewGame = false
                    }
                }
            });

            Context.Skills.Add(new Skill()
            {
                Name = "second skill",
                Effect = "second effect",
                Cost = "second cost",
                Personas = new List<SkillPersona>()
                {
                    new SkillPersona()
                    {
                        LevelRequired = 3,
                        Name = "persona name",
                        Ultimate = false,
                        NewGame = false
                    },
                    new SkillPersona()
                    {
                        LevelRequired = 4,
                        Name = "persona name",
                        Ultimate = false,
                        NewGame = false
                    }
                }
            });

            Context.SaveChanges();

            // act
            var skills = AppService.GetAllSkills();

            // assert
            Assert.AreEqual(2, skills.Count);

            foreach (var skill in skills)
            {
                Assert.AreEqual(2, skill.Personas.Count);
            }
        }

        /// <summary>Test for get skills by persona name api.</summary>
        /// <param name="name">The persona name to get get skills from.</param>
        [TestCase("HeLeL")]
        public void GetSkillsByPersonaName(string name)
        {
            // arrange
            Context.Personas.Add(new Persona()
            {
                Name = "Helel",
                Arcana = "arcana",
                Level = 23,
                Ultimate = false,
                NewGame = false,
                Stats = new Stats()
                {
                    Strength = 1,
                    Magic = 2,
                    Endurance = 3,
                    Agility = 4,
                    Luck = 5
                },
                Elements = new Elements()
                {
                    Physical = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<PersonaSkill>()
                {
                    new PersonaSkill()
                    {
                        Name = "absorb physical",
                        LevelRequired = 5
                    },
                    new PersonaSkill()
                    {
                        Name = "AbSoRb WiNd",
                        LevelRequired = 78
                    }
                }
            });

            Context.Skills.Add(new Skill()
            {
                Name = "Absorb Physical",
                Effect = "absorb physical damage",
                Cost = "cost"
            });

            Context.Skills.Add(new Skill()
            {
                Name = "Absorb Wind",
                Effect = "absorb wind damage",
                Cost = "cost"
            });

            Context.SaveChanges();

            // act
            var skills = AppService.GetSkillsByPersonaName(name);

            // assert
            Assert.AreEqual(2, skills.Count);
        }

        /// <summary>Test for get skills by shadow name api.</summary>
        /// <param name="name">The shadow name to get skills from.</param>
        /// <param name="shadowType">The shadow type to get skills from.</param>
        [TestCase("WoRlD BalAnCe", "NoRmAl")]
        public void GetSkillsByShadowName(string name, string shadowType)
        {
            // arrange
            Context.Shadows.Add(new Shadow()
            {
                Name = "World Balance",
                HP = 1,
                SP = 4,
                Level = 5,
                Yen = "34",
                Type = ShadowType.Normal,
                Exp = 345,
                Stats = new Stats()
                {
                    Strength = 1,
                    Magic = 2,
                    Endurance = 3,
                    Agility = 4,
                    Luck = 5
                },
                Elements = new Elements()
                {
                    Physical = ElementAffinity.None,
                    Ice = ElementAffinity.None,
                    Fire = ElementAffinity.None,
                    Electricity = ElementAffinity.None,
                    Wind = ElementAffinity.None,
                    Light = ElementAffinity.None,
                    Darkness = ElementAffinity.None
                },
                Skills = new List<ShadowSkill>()
                {
                    new ShadowSkill()
                    {
                        Name = "REFLECT physical"
                    },
                    new ShadowSkill()
                    {
                        Name = "ReFlEcT WiNd"
                    }
                }
            });

            Context.Skills.Add(new Skill()
            {
                Name = "Reflect Physical",
                Effect = "effect",
                Cost = "cost"
            });

            Context.Skills.Add(new Skill()
            {
                Name = "Reflect Wind",
                Effect = "effect",
                Cost = "cost"
            });

            Context.SaveChanges();

            // act
            var skills = AppService.GetSkillsByShadowName(name, shadowType);

            // assert
            Assert.AreEqual(2, skills.Count);
        }

        /// <summary>Test for quests api.</summary>
        [Test]
        public void GetAllQuests()
        {
            // arrange
            Context.Quests.Add(new Quest()
            {
                Number = 1,
                Title = "quest title",
                QuestGiver = "quest giver",
                Location = "quest location",
                Prerequisites = "quest prereq",
                Reward = "quest reward",
                DateAvailable = "quest date",
                Instructions = "quest instructions"
            });

            Context.Quests.Add(new Quest()
            {
                Number = 1,
                Title = "quest title",
                QuestGiver = "quest giver",
                Location = "quest location",
                Prerequisites = "quest prereq",
                Reward = "quest reward",
                DateAvailable = "quest date",
                Instructions = "quest instructions"
            });

            Context.SaveChanges();

            // act
            var quests = AppService.GetAllQuests();

            // assert
            Assert.AreEqual(2, quests.Count);
        }

        /// <summary>Test for skill cards api.<summary>
        [Test]
        public void GetAllSkillCards()
        {
            // arrange
            Context.SkillCards.Add(new SkillCard()
            {
                Name = "skill card name",
                Rank = 1,
                Type = SkillType.Magical
            });

            Context.SkillCards.Add(new SkillCard()
            {
                Name = "skill card name",
                Rank = 2,
                Type = SkillType.Physical
            });

            Context.SkillCards.Add(new SkillCard()
            {
                Name = "skill card name",
                Rank = 3,
                Type = SkillType.Passive
            });

            Context.SaveChanges();

            // act
            var skillCards = AppService.GetAllSkillCards();

            // assert
            Assert.AreEqual(3, skillCards.Count);
        }

        /// <summary>Test for skill card locations api.</summary>
        [Test]
        public void GetAllSkillCardLocations()
        {
            // arrange
            Context.SkillCardLocations.Add(new SkillCardLocation()
            {
                DungeonName = "dungeon name",
                RankLowerBound = 2,
                RankUpperBound = 5
            });

            Context.SkillCardLocations.Add(new SkillCardLocation()
            {
                DungeonName = "dungeon name",
                RankLowerBound = 2,
                RankUpperBound = 5
            });

            Context.SkillCardLocations.Add(new SkillCardLocation()
            {
                DungeonName = "dungeon name",
                RankLowerBound = 2,
                RankUpperBound = 5
            });

            Context.SaveChanges();

            // act
            var skillCardLocations = AppService.GetAllSkillCardLocations();

            // assert
            Assert.AreEqual(3, skillCardLocations.Count);
        }

        /// <summary>Test for lunches api.</summary>
        [Test]
        public void GetAllLunches()
        {
            // arrange
            Context.Lunches.Add(new Lunch()
            {
                Name = "lunch name 1",
                Method = "lunch method"
            });

            Context.Lunches.Add(new Lunch()
            {
                Name = "lunch name 2",
                Method = "lunch method"
            });

            Context.Lunches.Add(new Lunch()
            {
                Name = "lunch name 3",
                Method = "lunch method"
            });

            Context.SaveChanges();

            // act
            var lunches = AppService.GetAllLunches();

            // assert
            Assert.AreEqual(3, lunches.Count);
        }

        /// <summary>Test for accessories api.</summary>
        [Test]
        public void GetAllAccessories()
        {
            // arrange
            Context.Accessories.Add(new Accessory()
            {
                Name = "accessory name",
                Effect = "accessory effect",
                Obtained = new List<ItemObtain>()
                {
                    new ItemObtain()
                    {
                        Obtain = "obtain method 1",
                        Price = "obtain price"
                    },
                    new ItemObtain()
                    {
                        Obtain = "obtain method 2",
                        Price = "obtain price"
                    }
                }
            });

            Context.Accessories.Add(new Accessory()
            {
                Name = "accessory name",
                Effect = "accessory effect",
                Obtained = new List<ItemObtain>()
                {
                    new ItemObtain()
                    {
                        Obtain = "obtain method 1",
                        Price = "obtain price"
                    },
                    new ItemObtain()
                    {
                        Obtain = "obtain method 2",
                        Price = "obtain price"
                    }
                }
            });

            Context.SaveChanges();

            // act
            var accessories = AppService.GetAllAccessories();

            // assert
            Assert.AreEqual(2, accessories.Count);

            foreach (var accessory in accessories)
            {
                Assert.AreEqual(2, accessory.Obtained.Count);
            }
        }

        /// <summary>Test for armor api.</summary>
        [Test]
        public void GetAllArmor()
        {
            // arrange
            Context.Armor.Add(new Armor()
            {
                Name = "armor name",
                Gender = Gender.Male,
                Defense = 44,
                Evade = 32,
                Effect = "armor effect",
                Obtained = new List<ItemObtain>()
                {
                    new ItemObtain()
                    {
                        Obtain = "obtain method 1",
                        Price = "obtain price"
                    },
                    new ItemObtain()
                    {
                        Obtain = "obtain method 2",
                        Price = "obtain price"
                    }
                }
            });

            Context.Armor.Add(new Armor()
            {
                Name = "armor name",
                Gender = Gender.Male,
                Defense = 44,
                Evade = 32,
                Effect = "armor effect",
                Obtained = new List<ItemObtain>()
                {
                    new ItemObtain()
                    {
                        Obtain = "obtain method 1",
                        Price = "obtain price"
                    },
                    new ItemObtain()
                    {
                        Obtain = "obtain method 2",
                        Price = "obtain price"
                    }
                }
            });

            Context.SaveChanges();

            // act
            var armors = AppService.GetAllArmor();

            // assert
            Assert.AreEqual(2, armors.Count);

            foreach (var armor in armors)
            {
                Assert.AreEqual(2, armor.Obtained.Count);
            }
        }

        /// <summary>Test for weapon api.</summary>
        [Test]
        public void GetAllWeapons()
        {
            // arrange
            Context.Weapons.Add(new Weapon()
            {
                Name = "weapon name",
                User = User.Naoto,
                Attack = 44,
                Accuracy = 32,
                Effect = "weapon effect",
                Obtained = new List<ItemObtain>()
                {
                    new ItemObtain()
                    {
                        Obtain = "obtain method 1",
                        Price = "obtain price"
                    },
                    new ItemObtain()
                    {
                        Obtain = "obtain method 2",
                        Price = "obtain price"
                    }
                }
            });

            Context.Weapons.Add(new Weapon()
            {
                Name = "weapon name",
                User = User.Naoto,
                Attack = 45,
                Accuracy = 98,
                Effect = "weapon effect",
                Obtained = new List<ItemObtain>()
                {
                    new ItemObtain()
                    {
                        Obtain = "obtain method 1",
                        Price = "obtain price"
                    },
                    new ItemObtain()
                    {
                        Obtain = "obtain method 2",
                        Price = "obtain price"
                    }
                }
            });

            Context.SaveChanges();

            // act
            var weapons = AppService.GetAllWeapons();

            // assert
            Assert.AreEqual(2, weapons.Count);

            foreach (var weapon in weapons)
            {
                Assert.AreEqual(2, weapon.Obtained.Count);
            }
        }
    }
}
