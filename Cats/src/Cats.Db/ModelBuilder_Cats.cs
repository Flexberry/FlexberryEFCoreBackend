using Cats.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace Cats.Db
{
    internal class ModelBuilder_Cats
    {
        internal static void BuildModel(ModelBuilder modelBuilder)
        {
            AddInitialValues(modelBuilder);
        }

        private static void AddInitialValues(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Breed>().HasData(
                new Breed()
                {
                    Id = new Guid("{BA015AD2-44FE-45EB-9BF5-313603E9F775}"),
                    Name = "Aphrodite Giant",
                    Rare = false,
                });

            modelBuilder.Entity<Cat>().HasData(
                new Cat()
                {
                    Id = new Guid("{5D5689ED-B864-4DA6-94F3-F036AB83D0D6}"),
                    Name = "Муська",
                    Birthday = new DateTime(2015, 12, 20),
                    BreedId = new Guid("{BA015AD2-44FE-45EB-9BF5-313603E9F775}"),
                },
                new Cat()
                {
                    Id = new Guid("{A64EA9D9-3FE2-4556-9483-914138B79703}"),
                    Name = "Васька",
                    Birthday = new DateTime(2017, 10, 30),
                });

            modelBuilder.Entity<Paw>().HasData(
                new Paw()
                {
                    Id = new Guid("{9644FA54-B4E6-41F6-9765-D9AB888E2B0E}"),
                    Type = PawType.LeftFront,
                    CatId = new Guid("{5D5689ED-B864-4DA6-94F3-F036AB83D0D6}"),
                },
                new Paw()
                {
                    Id = new Guid("{BED52CCA-EE24-49E6-9F20-84F069C151E8}"),
                    Type = PawType.RightFront,
                    CatId = new Guid("{5D5689ED-B864-4DA6-94F3-F036AB83D0D6}"),
                },
                new Paw()
                {
                    Id = new Guid("{160A6376-16ED-4597-B769-F1203C588FCF}"),
                    Type = PawType.LeftRear,
                    CatId = new Guid("{5D5689ED-B864-4DA6-94F3-F036AB83D0D6}"),
                },
                new Paw()
                {
                    Id = new Guid("{2C0361FC-B8B7-4599-8937-A081390AEC60}"),
                    Type = PawType.RightRear,
                    CatId = new Guid("{5D5689ED-B864-4DA6-94F3-F036AB83D0D6}"),
                },
                new Paw()
                {
                    Id = new Guid("{758D5931-531B-4ED2-AC9D-7C1142CF3792}"),
                    Type = PawType.LeftFront,
                    CatId = new Guid("{A64EA9D9-3FE2-4556-9483-914138B79703}"),
                },
                new Paw()
                {
                    Id = new Guid("{C9AFD7ED-B6FF-4C79-AA38-654C55370CA3}"),
                    Type = PawType.RightFront,
                    CatId = new Guid("{A64EA9D9-3FE2-4556-9483-914138B79703}"),
                },
                new Paw()
                {
                    Id = new Guid("{6BC3A507-B8A4-40A2-AC60-ADCAF8DA9916}"),
                    Type = PawType.LeftRear,
                    CatId = new Guid("{A64EA9D9-3FE2-4556-9483-914138B79703}"),
                },
                new Paw()
                {
                    Id = new Guid("{BF97D85F-F273-42F9-B1D4-6E99BFE23CCA}"),
                    Type = PawType.RightRear,
                    CatId = new Guid("{A64EA9D9-3FE2-4556-9483-914138B79703}"),
                });
        }
    }
}