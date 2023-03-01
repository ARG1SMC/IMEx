using Microsoft.EntityFrameworkCore;
using IMExApi.Models;

namespace IMExApi.Data
{
    public class IMExDbContext : DbContext
    {
        public IMExDbContext(DbContextOptions options) : base(options)
        {
        }

        #region DBSet Definition

        public DbSet<Business> Businesses { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Field> Fields { get; set; }
        public DbSet<OPU> OPUs { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<InspectionType> InspectionTypes { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Risk> Risks { get; set; }
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<LocationOne> LocationOnes { get; set; }
        public DbSet<LocationTwo> LocationTwos { get; set; }
        public DbSet<HACDwgNo> HACDwgNos { get; set; }
        public DbSet<Coordinate> Coordinates { get; set; }
        public DbSet<Zone> Zones { get; set; }
        public DbSet<Purpose> Purposes { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<SerialNo> SerialNos { get; set; }
        public DbSet<IECExCertificateAuthority> IECExCertificateAuthorities { get; set; }
        public DbSet<IECExCertificateCategory> IECExCertificateCategories { get; set; }
        public DbSet<IECExCertificateNo> IECExCertificateNos { get; set; }
        public DbSet<IECExCertificateDetail> IECExCertificateDetails { get; set; }
        public DbSet<ElectricalRating> ElectricalRatings { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<ProtectionType> ProtectionTypes { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Inspection> Inspections { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region BusinessSeed

            modelBuilder.Entity<Business>()
                .HasData (
                    new Business { Id = new Guid("f57dd90c-8787-4e02-97a9-2a2be301692b"), Name = "Downstream", Description = "Downstream Business" },
                    new Business { Id = new Guid("d9817472-69ee-45ff-b4d9-e7682a8f5c42"), Name = "Gas", Description = "Gas Business" },
                    new Business { Id = new Guid("09d96c70-294e-486f-8fb0-624983bcef62"), Name = "PD&T", Description = "PD&T Business" },
                    new Business { Id = new Guid("b42742a6-9a0a-4458-8d74-953874576182"), Name = "Upstream", Description = "Upstream Business" }
            );

            modelBuilder.Entity<Business>().HasAlternateKey(c => c.Name).HasName("Business_Name");
            modelBuilder.Entity<Business>().HasAlternateKey(c => c.Description).HasName("Business_Description");

            #endregion

            #region RegionSeed

            modelBuilder.Entity<Region>().HasData(
                new Region { Id = new Guid("85617285-d381-4070-be9c-2e0e924d65e0"), Name = "GR&T", Description = "GR&T Region or Segment" },
                new Region { Id = new Guid("054a0a4d-4cc1-4449-9904-e10a80becae0"), Name = "GST", Description = "GST Region or Segment" },
                new Region { Id = new Guid("2b394efe-04c4-460d-937f-6457da94d673"), Name = "MLNG", Description = "MLNG Region or Segment" },
                new Region { Id = new Guid("543687a8-b584-4d46-a692-2d0b6607a9b0"), Name = "PDB", Description = "PDB Region or Segment" },
                new Region { Id = new Guid("1b019d73-2b4b-468c-a539-242a1bd4917f"), Name = "Petrochemical", Description = "Petrochemical Region or Segment" },
                new Region { Id = new Guid("c2b96baf-1596-467f-befb-b65034cd03b6"), Name = "PFLNG Dua", Description = "PFLNG Dua Region or Segment" },
                new Region { Id = new Guid("7352acb6-9e0d-4919-9f88-36798c487d86"), Name = "PFLNG Satu", Description = "PFLNG Satu Region or Segment" },
                new Region { Id = new Guid("29e8d7f6-dc93-4c1a-b419-324f4df84c4c"), Name = "PGB", Description = "PGB Region or Segment" },
                new Region { Id = new Guid("67566a97-babe-492c-a14d-0f4b103861d9"), Name = "PIC", Description = "PIC Region or Segment" },
                new Region { Id = new Guid("c202adf7-9b3b-429f-b79e-00498235eb0c"), Name = "PMA", Description = "PMA PlRegion or Segmentant" },
                new Region { Id = new Guid("0ab107a0-d483-4aa0-a451-7ea62a965975"), Name = "Refinery", Description = "Refinery Region or Segment" },
                new Region { Id = new Guid("5c35ccd2-aac8-4b6d-980a-d580766a05a3"), Name = "SBA", Description = "SBA Region or Segment" },
                new Region { Id = new Guid("45946328-7a29-4731-abfa-a33aea03ed00"), Name = "SKA", Description = "SKA Region or Segment" }
            );

            modelBuilder.Entity<Region>().HasAlternateKey(c => c.Name).HasName("Region_Name");
            modelBuilder.Entity<Region>().HasAlternateKey(c => c.Description).HasName("Region_Description");

            #endregion

            #region FieldSeed

            modelBuilder.Entity<Field>().HasData(
                new Field { Id = new Guid("b189b3ed-c6f8-4c49-8b2c-3f5d4dd4a3f6"), Name = "Angsi", Description = "Angsi Field or Plant" },
                new Field { Id = new Guid("254c3a4b-91a1-4077-b89c-757fc69f5910"), Name = "B11", Description = "B11 Field or Plant" },
                new Field { Id = new Guid("2230a41f-5200-4c9e-aa85-5d9bbfed8fc6"), Name = "Baram", Description = "Baram Field or Plant" },
                new Field { Id = new Guid("b69125e2-89cc-4d96-9db4-9ca9297da146"), Name = "Bayan", Description = "Bayan Field or Plant" },
                new Field { Id = new Guid("d9c7b872-c002-49e8-85ef-14db7a9ca88d"), Name = "Bekok", Description = "Bekok Field or Plant" },
                new Field { Id = new Guid("87a61711-b6f7-422b-a1f0-82662bb25077"), Name = "Duyong", Description = "Duyong Field or Plant" },
                new Field { Id = new Guid("c658389e-f146-452f-a7bd-ac90eb42b25d"), Name = "E11", Description = "E11 Field or Plant" },
                new Field { Id = new Guid("d6b3ca8d-81d9-44ec-9caf-59a1a0a76254"), Name = "Erb West", Description = "Erb West Field or Plant" },
                new Field { Id = new Guid("0ead361b-8bc3-4359-a0e2-05fd27ff6dbc"), Name = "GPP", Description = "GPP Field or Plant" },
                new Field { Id = new Guid("c4d97318-7207-4461-b6d9-0b637c71e091"), Name = "GST1", Description = "GST1 Field or Plant" },
                new Field { Id = new Guid("8fe930c9-fdf4-4b9b-a2f0-de164b83b5fb"), Name = "KAKG", Description = "KAKG Field or Plant" },
                new Field { Id = new Guid("b92ddde2-acdc-40d2-8195-f190f19070ad"), Name = "Kinabalu", Description = "Kinabalu Field or Plant" },
                new Field { Id = new Guid("eed15056-0ce9-4d99-a347-2b88a95e6a9f"), Name = "M1", Description = "M1 Field or Plant" },
                new Field { Id = new Guid("37927c4f-c9e1-4d92-8b84-09bea547a030"), Name = "MCOT", Description = "MCOT Field or Plant" },
                new Field { Id = new Guid("d74fb67e-118f-4a4a-9462-ac85f22106fe"), Name = "MLNG Dua", Description = "MLNG Dua Field or Plant" },
                new Field { Id = new Guid("126b799f-2cf5-4225-a58d-bdb3731a8a64"), Name = "MLNG Satu", Description = "MLNG Satu Field or Plant" },
                new Field { Id = new Guid("50bc7979-4f5e-4cae-87a0-dfd669fb7d46"), Name = "MLNG Tiga", Description = "MLNG Tiga Field or Plant" },
                new Field { Id = new Guid("b4efc45c-5349-4c82-9061-5103bb9993b0"), Name = "MRC", Description = "MRC Field or Plant" },
                new Field { Id = new Guid("14c1d824-6155-486f-bdc1-b953a3fb8cfb"), Name = "NC3", Description = "NC3 Field or Plant" },
                new Field { Id = new Guid("4a270199-5870-4828-8d7e-2f7ef168d0c4"), Name = "PCEPE", Description = "PCEPE Field or Plant" },
                new Field { Id = new Guid("23e5527b-d159-46c6-bff7-981ad8651d33"), Name = "PCFK", Description = "PCFK Field or Plant" },
                new Field { Id = new Guid("e7790052-4521-4689-967e-02c2cfc2509a"), Name = "PCLDPE & Ammonia", Description = "PCLDPE & Ammonia Field or Plant" },
                new Field { Id = new Guid("ba0c4a91-bdb8-4272-b732-c0817b4f4444"), Name = "PCML", Description = "PCML Field or Plant" },
                new Field { Id = new Guid("467bb9f9-0b77-4987-a530-badcc66be8f5"), Name = "PCMTBE", Description = "PCMTBE Field or Plant" },
                new Field { Id = new Guid("854b8a3b-9c8b-4187-88bf-8967c5a474b2"), Name = "PCOGD", Description = "PCOGD Field or Plant" },
                new Field { Id = new Guid("6be3a4fd-24a0-4458-9c7d-dd474210b9ec"), Name = "PFLNG1", Description = "PFLNG1 Field or Plant" },
                new Field { Id = new Guid("768b2aae-0db8-4cc0-98ad-bf936db2c2f3"), Name = "PFLNG2", Description = "PFLNG2 Field or Plant" },
                new Field { Id = new Guid("8f4a8ace-bb24-47f3-9315-604178147aac"), Name = "PIC1", Description = "PIC1 Field or Plant" },
                new Field { Id = new Guid("9e12080d-f771-41b3-953a-fb6c606775d4"), Name = "PPT", Description = "PPT Field or Plant" },
                new Field { Id = new Guid("e24764d0-3c76-4630-b801-a05ac6a14d1b"), Name = "PRSB", Description = "PRSB Field or Plant" },
                new Field { Id = new Guid("d38692cd-4d6f-4aee-bb32-7dd9a9374244"), Name = "Resak", Description = "Resak Field or Plant" },
                new Field { Id = new Guid("5f08d260-2ec0-442b-82e5-33294a46b712"), Name = "RGTP", Description = "RGTP Field or Plant" },
                new Field { Id = new Guid("1134b649-480f-4903-acd4-3a54007b1b23"), Name = "RGTSU", Description = "RGTSU Field or Plant" },
                new Field { Id = new Guid("c8ed8f67-cda6-411f-8532-b3559e284448"), Name = "SBGAST", Description = "SBGAST Field or Plant" },
                new Field { Id = new Guid("f156ee0d-d80b-4fb8-8143-56537f8d2520"), Name = "Sumandak", Description = "Sumandak Field or Plant" },
                new Field { Id = new Guid("d2380672-dd44-49a9-b9a9-3ac0185af368"), Name = "Tangga Barat", Description = "Tangga Barat Field or Plant" },
                new Field { Id = new Guid("6c170d60-884b-422d-b62b-d533dfa97429"), Name = "TCOT", Description = "TCOT Field or Plant" },
                new Field { Id = new Guid("8eaccad3-d2aa-4de1-8b26-601d4a912bad"), Name = "Terminal 1", Description = "Terminal 1 Field or Plant" },
                new Field { Id = new Guid("0dfdce65-2877-4164-b701-706dc388ec46"), Name = "TGAST", Description = "TGAST Field or Plant" },
                new Field { Id = new Guid("fa52eeb7-e89a-45e3-be2c-ff8181b35a23"), Name = "Tiong", Description = "Tiong Field or Plant" },
                new Field { Id = new Guid("fe9b6b9b-d3e2-40ce-b665-fab93016d274"), Name = "Train 9", Description = "Train 9 Field or Plant" },
                new Field { Id = new Guid("15b9727e-04e1-40c0-b5d2-fb75538e84ed"), Name = "UG", Description = "UG Field or Plant" },
                new Field { Id = new Guid("34da4cab-21f5-46bd-b1a2-d8057c0e6b9f"), Name = "UK", Description = "UK Field or Plant" },
                new Field { Id = new Guid("70baf381-8c58-4e70-b2d9-734764144f6e"), Name = "West Lutong", Description = "West Lutong Field or Plant" }
            );

            modelBuilder.Entity<Field>().HasAlternateKey(c => c.Name).HasName("Field_Name");
            modelBuilder.Entity<Field>().HasAlternateKey(c => c.Description).HasName("Field_Description");

            #endregion

            #region OPUSeed

            modelBuilder.Entity<OPU>()
                .HasData(
                    new OPU { Id = new Guid("f5ffb83f-0b07-4d55-91ca-00adb692a00a"), Id_Business = new Guid("f57dd90c-8787-4e02-97a9-2a2be301692b"), Id_Region = new Guid("0ab107a0-d483-4aa0-a451-7ea62a965975"), Id_Field = new Guid("b4efc45c-5349-4c82-9061-5103bb9993b0") },
                    new OPU { Id = new Guid("2c08a19a-16d5-4434-9d49-39d8c4d6edf9"), Id_Business = new Guid("f57dd90c-8787-4e02-97a9-2a2be301692b"), Id_Region = new Guid("0ab107a0-d483-4aa0-a451-7ea62a965975"), Id_Field = new Guid("9e12080d-f771-41b3-953a-fb6c606775d4") },
                    new OPU { Id = new Guid("c8c9366a-3dde-43b9-91e4-58fb2a477718"), Id_Business = new Guid("f57dd90c-8787-4e02-97a9-2a2be301692b"), Id_Region = new Guid("1b019d73-2b4b-468c-a539-242a1bd4917f"), Id_Field = new Guid("4a270199-5870-4828-8d7e-2f7ef168d0c4") },
                    new OPU { Id = new Guid("e8cbc236-331a-4496-bd86-19874b6d2ec0"), Id_Business = new Guid("f57dd90c-8787-4e02-97a9-2a2be301692b"), Id_Region = new Guid("1b019d73-2b4b-468c-a539-242a1bd4917f"), Id_Field = new Guid("23e5527b-d159-46c6-bff7-981ad8651d33") },
                    new OPU { Id = new Guid("4f3b3ce5-4f77-469f-a222-a21fa0da26af"), Id_Business = new Guid("f57dd90c-8787-4e02-97a9-2a2be301692b"), Id_Region = new Guid("1b019d73-2b4b-468c-a539-242a1bd4917f"), Id_Field = new Guid("e7790052-4521-4689-967e-02c2cfc2509a") },
                    new OPU { Id = new Guid("9ef829a1-3f7d-4438-941b-7cf2a4535f64"), Id_Business = new Guid("f57dd90c-8787-4e02-97a9-2a2be301692b"), Id_Region = new Guid("1b019d73-2b4b-468c-a539-242a1bd4917f"), Id_Field = new Guid("ba0c4a91-bdb8-4272-b732-c0817b4f4444") },
                    new OPU { Id = new Guid("8bdce0f4-e03b-4b54-94aa-ec7aafa7e9c0"), Id_Business = new Guid("f57dd90c-8787-4e02-97a9-2a2be301692b"), Id_Region = new Guid("1b019d73-2b4b-468c-a539-242a1bd4917f"), Id_Field = new Guid("467bb9f9-0b77-4987-a530-badcc66be8f5") },
                    new OPU { Id = new Guid("5a8b9879-2621-454d-b99c-105e48a0dcd4"), Id_Business = new Guid("f57dd90c-8787-4e02-97a9-2a2be301692b"), Id_Region = new Guid("1b019d73-2b4b-468c-a539-242a1bd4917f"), Id_Field = new Guid("854b8a3b-9c8b-4187-88bf-8967c5a474b2") },
                    new OPU { Id = new Guid("f5e91413-c273-4bd6-a890-e9d252443863"), Id_Business = new Guid("f57dd90c-8787-4e02-97a9-2a2be301692b"), Id_Region = new Guid("543687a8-b584-4d46-a692-2d0b6607a9b0"), Id_Field = new Guid("8eaccad3-d2aa-4de1-8b26-601d4a912bad") },
                    new OPU { Id = new Guid("ad0e6ce1-2c54-4594-9812-f805f601c13e"), Id_Business = new Guid("f57dd90c-8787-4e02-97a9-2a2be301692b"), Id_Region = new Guid("67566a97-babe-492c-a14d-0f4b103861d9"), Id_Field = new Guid("8f4a8ace-bb24-47f3-9315-604178147aac") }, 
                    new OPU { Id = new Guid("3b80d4ec-a639-41f6-a8cb-595b7e350e8d"), Id_Business = new Guid("d9817472-69ee-45ff-b4d9-e7682a8f5c42"), Id_Region = new Guid("2b394efe-04c4-460d-937f-6457da94d673"), Id_Field = new Guid("d74fb67e-118f-4a4a-9462-ac85f22106fe") },
                    new OPU { Id = new Guid("508416c3-5770-4f42-9a7f-d5bea42c9e55"), Id_Business = new Guid("d9817472-69ee-45ff-b4d9-e7682a8f5c42"), Id_Region = new Guid("2b394efe-04c4-460d-937f-6457da94d673"), Id_Field = new Guid("126b799f-2cf5-4225-a58d-bdb3731a8a64") },
                    new OPU { Id = new Guid("44f4889a-f93c-4587-abc2-508c5493ffb2"), Id_Business = new Guid("d9817472-69ee-45ff-b4d9-e7682a8f5c42"), Id_Region = new Guid("2b394efe-04c4-460d-937f-6457da94d673"), Id_Field = new Guid("50bc7979-4f5e-4cae-87a0-dfd669fb7d46") },
                    new OPU { Id = new Guid("e653aae5-f90d-4481-984f-75284dfc0700"), Id_Business = new Guid("d9817472-69ee-45ff-b4d9-e7682a8f5c42"), Id_Region = new Guid("2b394efe-04c4-460d-937f-6457da94d673"), Id_Field = new Guid("fe9b6b9b-d3e2-40ce-b665-fab93016d274") },
                    new OPU { Id = new Guid("9837000c-b846-4753-a1f5-ed3a7f160b31"), Id_Business = new Guid("d9817472-69ee-45ff-b4d9-e7682a8f5c42"), Id_Region = new Guid("c2b96baf-1596-467f-befb-b65034cd03b6"), Id_Field = new Guid("768b2aae-0db8-4cc0-98ad-bf936db2c2f3") }, 
                    new OPU { Id = new Guid("29fb2310-06e9-404b-b531-f27866e2aa96"), Id_Business = new Guid("d9817472-69ee-45ff-b4d9-e7682a8f5c42"), Id_Region = new Guid("7352acb6-9e0d-4919-9f88-36798c487d86"), Id_Field = new Guid("6be3a4fd-24a0-4458-9c7d-dd474210b9ec") },
                    new OPU { Id = new Guid("2b019bfa-a5b9-4bf0-ae58-1573ab026a64"), Id_Business = new Guid("d9817472-69ee-45ff-b4d9-e7682a8f5c42"), Id_Region = new Guid("29e8d7f6-dc93-4c1a-b419-324f4df84c4c"), Id_Field = new Guid("0ead361b-8bc3-4359-a0e2-05fd27ff6dbc") },
                    new OPU { Id = new Guid("9c15b517-0172-4a62-9c4d-e3ecccae56be"), Id_Business = new Guid("d9817472-69ee-45ff-b4d9-e7682a8f5c42"), Id_Region = new Guid("29e8d7f6-dc93-4c1a-b419-324f4df84c4c"), Id_Field = new Guid("5f08d260-2ec0-442b-82e5-33294a46b712") },
                    new OPU { Id = new Guid("818b7d56-7080-426e-8a77-42c0337d5b3c"), Id_Business = new Guid("d9817472-69ee-45ff-b4d9-e7682a8f5c42"), Id_Region = new Guid("29e8d7f6-dc93-4c1a-b419-324f4df84c4c"), Id_Field = new Guid("1134b649-480f-4903-acd4-3a54007b1b23") },
                    new OPU { Id = new Guid("676534a7-458e-4fdd-9800-12f14ab4005a"), Id_Business = new Guid("d9817472-69ee-45ff-b4d9-e7682a8f5c42"), Id_Region = new Guid("29e8d7f6-dc93-4c1a-b419-324f4df84c4c"), Id_Field = new Guid("15b9727e-04e1-40c0-b5d2-fb75538e84ed") }, 
                    new OPU { Id = new Guid("327688db-ff1a-43a5-ab2c-f723a4fdce1c"), Id_Business = new Guid("d9817472-69ee-45ff-b4d9-e7682a8f5c42"), Id_Region = new Guid("29e8d7f6-dc93-4c1a-b419-324f4df84c4c"), Id_Field = new Guid("34da4cab-21f5-46bd-b1a2-d8057c0e6b9f") },
                    new OPU { Id = new Guid("88f4790f-a51f-4c9c-8b30-5c24b7c0113a"), Id_Business = new Guid("09d96c70-294e-486f-8fb0-624983bcef62"), Id_Region = new Guid("85617285-d381-4070-be9c-2e0e924d65e0"), Id_Field = new Guid("e24764d0-3c76-4630-b801-a05ac6a14d1b") },
                    new OPU { Id = new Guid("c875803e-2628-463e-8376-d7e6cc828a47"), Id_Business = new Guid("09d96c70-294e-486f-8fb0-624983bcef62"), Id_Region = new Guid("054a0a4d-4cc1-4449-9904-e10a80becae0"), Id_Field = new Guid("c4d97318-7207-4461-b6d9-0b637c71e091") },
                    new OPU { Id = new Guid("fbafc3c9-0d09-4b93-839e-cc1ba7df9997"), Id_Business = new Guid("b42742a6-9a0a-4458-8d74-953874576182"), Id_Region = new Guid("c202adf7-9b3b-429f-b79e-00498235eb0c"), Id_Field = new Guid("b189b3ed-c6f8-4c49-8b2c-3f5d4dd4a3f6") },
                    new OPU { Id = new Guid("a88deac5-b0fc-448d-bb5f-9e137c4b4f37"), Id_Business = new Guid("b42742a6-9a0a-4458-8d74-953874576182"), Id_Region = new Guid("c202adf7-9b3b-429f-b79e-00498235eb0c"), Id_Field = new Guid("d9c7b872-c002-49e8-85ef-14db7a9ca88d") }, 
                    new OPU { Id = new Guid("b22dd8bf-cc06-4a92-a564-6aca6383b26a"), Id_Business = new Guid("b42742a6-9a0a-4458-8d74-953874576182"), Id_Region = new Guid("c202adf7-9b3b-429f-b79e-00498235eb0c"), Id_Field = new Guid("87a61711-b6f7-422b-a1f0-82662bb25077") },
                    new OPU { Id = new Guid("7b4a12a7-c8cf-4f5f-8ea2-69bc3043ddd3"), Id_Business = new Guid("b42742a6-9a0a-4458-8d74-953874576182"), Id_Region = new Guid("c202adf7-9b3b-429f-b79e-00498235eb0c"), Id_Field = new Guid("d38692cd-4d6f-4aee-bb32-7dd9a9374244") },
                    new OPU { Id = new Guid("0a50c968-85e9-4e58-b587-c9cd3c7aefde"), Id_Business = new Guid("b42742a6-9a0a-4458-8d74-953874576182"), Id_Region = new Guid("c202adf7-9b3b-429f-b79e-00498235eb0c"), Id_Field = new Guid("d2380672-dd44-49a9-b9a9-3ac0185af368") },
                    new OPU { Id = new Guid("1f0565ee-1ebd-48d0-adfc-37fcf00c810f"), Id_Business = new Guid("b42742a6-9a0a-4458-8d74-953874576182"), Id_Region = new Guid("c202adf7-9b3b-429f-b79e-00498235eb0c"), Id_Field = new Guid("0dfdce65-2877-4164-b701-706dc388ec46") },
                    new OPU { Id = new Guid("b981ea97-810c-4d0d-8f09-9e3ef869cea0"), Id_Business = new Guid("b42742a6-9a0a-4458-8d74-953874576182"), Id_Region = new Guid("c202adf7-9b3b-429f-b79e-00498235eb0c"), Id_Field = new Guid("fa52eeb7-e89a-45e3-be2c-ff8181b35a23") }, 
                    new OPU { Id = new Guid("58ef8a4a-ff8d-450a-a5f3-297838299bdb"), Id_Business = new Guid("b42742a6-9a0a-4458-8d74-953874576182"), Id_Region = new Guid("c202adf7-9b3b-429f-b79e-00498235eb0c"), Id_Field = new Guid("6c170d60-884b-422d-b62b-d533dfa97429") },
                    new OPU { Id = new Guid("831b80b3-033d-42c9-9b05-a23b7f0db8a1"), Id_Business = new Guid("b42742a6-9a0a-4458-8d74-953874576182"), Id_Region = new Guid("5c35ccd2-aac8-4b6d-980a-d580766a05a3"), Id_Field = new Guid("d6b3ca8d-81d9-44ec-9caf-59a1a0a76254") },
                    new OPU { Id = new Guid("f3c463c9-d905-4788-9e00-68ab6bce6503"), Id_Business = new Guid("b42742a6-9a0a-4458-8d74-953874576182"), Id_Region = new Guid("5c35ccd2-aac8-4b6d-980a-d580766a05a3"), Id_Field = new Guid("b92ddde2-acdc-40d2-8195-f190f19070ad") },
                    new OPU { Id = new Guid("959d01a1-7b02-45d3-b1dc-dcd264c56700"), Id_Business = new Guid("b42742a6-9a0a-4458-8d74-953874576182"), Id_Region = new Guid("5c35ccd2-aac8-4b6d-980a-d580766a05a3"), Id_Field = new Guid("c8ed8f67-cda6-411f-8532-b3559e284448") },
                    new OPU { Id = new Guid("88924899-cf63-42a6-ad70-13a0a78c6410"), Id_Business = new Guid("b42742a6-9a0a-4458-8d74-953874576182"), Id_Region = new Guid("5c35ccd2-aac8-4b6d-980a-d580766a05a3"), Id_Field = new Guid("f156ee0d-d80b-4fb8-8143-56537f8d2520") },
                    new OPU { Id = new Guid("81e0ea2c-72f1-4532-ada1-57b762afd176"), Id_Business = new Guid("b42742a6-9a0a-4458-8d74-953874576182"), Id_Region = new Guid("45946328-7a29-4731-abfa-a33aea03ed00"), Id_Field = new Guid("254c3a4b-91a1-4077-b89c-757fc69f5910") },
                    new OPU { Id = new Guid("322cc61f-ce35-40ae-958a-bc8a902cf500"), Id_Business = new Guid("b42742a6-9a0a-4458-8d74-953874576182"), Id_Region = new Guid("45946328-7a29-4731-abfa-a33aea03ed00"), Id_Field = new Guid("2230a41f-5200-4c9e-aa85-5d9bbfed8fc6") },
                    new OPU { Id = new Guid("af1674dd-b2f0-4296-821b-18811eca1cef"), Id_Business = new Guid("b42742a6-9a0a-4458-8d74-953874576182"), Id_Region = new Guid("45946328-7a29-4731-abfa-a33aea03ed00"), Id_Field = new Guid("b69125e2-89cc-4d96-9db4-9ca9297da146") },
                    new OPU { Id = new Guid("f2753c54-35b1-4dbe-9dcc-9b432762d308"), Id_Business = new Guid("b42742a6-9a0a-4458-8d74-953874576182"), Id_Region = new Guid("45946328-7a29-4731-abfa-a33aea03ed00"), Id_Field = new Guid("c658389e-f146-452f-a7bd-ac90eb42b25d") }, 
                    new OPU { Id = new Guid("667e644c-2416-47b4-a614-92b8702cd82e"), Id_Business = new Guid("b42742a6-9a0a-4458-8d74-953874576182"), Id_Region = new Guid("45946328-7a29-4731-abfa-a33aea03ed00"), Id_Field = new Guid("8fe930c9-fdf4-4b9b-a2f0-de164b83b5fb") },
                    new OPU { Id = new Guid("2cedbbea-1a47-4d76-91e7-54095d5b340b"), Id_Business = new Guid("b42742a6-9a0a-4458-8d74-953874576182"), Id_Region = new Guid("45946328-7a29-4731-abfa-a33aea03ed00"), Id_Field = new Guid("eed15056-0ce9-4d99-a347-2b88a95e6a9f") },
                    new OPU { Id = new Guid("3bc32c28-f7b1-49ae-ab76-d349bed51b27"), Id_Business = new Guid("b42742a6-9a0a-4458-8d74-953874576182"), Id_Region = new Guid("45946328-7a29-4731-abfa-a33aea03ed00"), Id_Field = new Guid("37927c4f-c9e1-4d92-8b84-09bea547a030") },
                    new OPU { Id = new Guid("bd72b1e2-e7b4-438c-8edd-77837913f216"), Id_Business = new Guid("b42742a6-9a0a-4458-8d74-953874576182"), Id_Region = new Guid("45946328-7a29-4731-abfa-a33aea03ed00"), Id_Field = new Guid("14c1d824-6155-486f-bdc1-b953a3fb8cfb") }, 
                    new OPU { Id = new Guid("d03cc06f-cbb7-4ff5-a330-f8a79d04577f"), Id_Business = new Guid("b42742a6-9a0a-4458-8d74-953874576182"), Id_Region = new Guid("45946328-7a29-4731-abfa-a33aea03ed00"), Id_Field = new Guid("70baf381-8c58-4e70-b2d9-734764144f6e") }
            );

            modelBuilder.Entity<OPU>().HasAlternateKey(c => new { c.Id_Business, c.Id_Region, c.Id_Field });

            #endregion

            #region User

            modelBuilder.Entity<User>()
                .HasData(
                    new User { Id = new Guid("25991b17-6107-429e-8284-477114e5a0f8"), Id_OPU = new Guid("1f0565ee-1ebd-48d0-adfc-37fcf00c810f"), Id_Role = new Guid("ba5b59fb-b934-494b-866a-44d6dec9ef91"), FirstName = "Alex", LastName = "Ronald Gomez", UserName = "alex.gomez@smartcore.group", Password = "5c30c68af479608433102e2d2ae6ab53eccd2565", Active = true, DateValidStart = DateTime.UtcNow, DateValidEnd = DateTime.UtcNow.AddYears(3) },
                    new User { Id = new Guid("c74611f6-a99f-44b4-88fd-e00e00fcff5a"), Id_OPU = new Guid("1f0565ee-1ebd-48d0-adfc-37fcf00c810f"), Id_Role = new Guid("ba5b59fb-b934-494b-866a-44d6dec9ef91"), FirstName = "Shahin", LastName = "Bin Hasan", UserName = "shahin.hassan@smartcore.group", Password = "5c30c68af479608433102e2d2ae6ab53eccd2565", Active = true, DateValidStart = DateTime.UtcNow, DateValidEnd = DateTime.UtcNow.AddYears(3) },
                    new User { Id = new Guid("451ffde1-3eae-4455-8e89-78c87c1009f9"), Id_OPU = new Guid("1f0565ee-1ebd-48d0-adfc-37fcf00c810f"), Id_Role = new Guid("ba5b59fb-b934-494b-866a-44d6dec9ef91"), FirstName = "Nur Hafizah", LastName = "Binti Musa", UserName = "hafizah@smartcore.group", Password = "5c30c68af479608433102e2d2ae6ab53eccd2565", Active = true, DateValidStart = DateTime.UtcNow, DateValidEnd = DateTime.UtcNow.AddYears(3) }
            );

            modelBuilder.Entity<User>().HasAlternateKey(c => c.LastName).HasName("User_LastName");
            modelBuilder.Entity<User>().HasAlternateKey(c => c.UserName).HasName("User_UserName");

            #endregion

            #region InspectionTypeSeed

            modelBuilder.Entity<InspectionType>()
                .HasData(
                    new InspectionType { Id = new Guid("11497dcb-0010-408a-b175-b550ba8a421a"), Name = "Initial Inspection", Description = "Initial Inspection" },
                    new InspectionType { Id = new Guid("7b4413a2-67a3-4a31-843a-b574ce581ddc"), Name = "Full Inspection", Description = "Full Inspection" },
                    new InspectionType { Id = new Guid("03b223f8-58f5-442a-abf8-4540b4067634"), Name = "Risk-Based Inspection", Description = "Risk-Based Inspection" },
                    new InspectionType { Id = new Guid("2afe51d9-2270-4992-8a5f-bf95e002798b"), Name = "Sample Inspection", Description = "Sample Inspection" }
            );

            modelBuilder.Entity<InspectionType>().HasAlternateKey(c => c.Name).HasName("InspectionType_Name");

            #endregion

            #region RiskSeed

            modelBuilder.Entity<Risk>()
                .HasData(
                    new Risk { Id = new Guid("1ec4c843-135f-4b46-9418-a81c1ce58b3a"), Name = "N/A", Description = "Not Applicable" },
                    new Risk { Id = new Guid("ae95ff88-5eae-431f-9928-33d5b6820691"), Name = "Low", Description = "Low Risk" },
                    new Risk { Id = new Guid("80c71cf4-7da5-4d18-b986-3c423d60bdc6"), Name = "Meium", Description = "Medium Risk" },
                    new Risk { Id = new Guid("3c088619-e0c6-41c3-b432-36e85ecce964"), Name = "High", Description = "High Risk" }
            );

            modelBuilder.Entity<Risk>().HasAlternateKey(c => c.Name).HasName("Risk_Name");

            #endregion

            #region RoleSeed

            modelBuilder.Entity<Role>()
                .HasData(
                    new Role { Id = new Guid("6ce8eda9-bde9-4015-b7eb-392d82069ba0"), Code = "ISA", Name = "System Admin", Description = "IMEx System Admin (GTS SMEs, System Admin)" },
                    new Role { Id = new Guid("922c4b00-490b-4a5e-a926-3a34a90f27bf"), Code = "CV", Name = "Central Viewer", Description = "Central Viewer" },
                    new Role { Id = new Guid("ba5b59fb-b934-494b-866a-44d6dec9ef91"), Code = "OA", Name = "OPU Admin", Description = "OPU Admin" },
                    new Role { Id = new Guid("2fdd9c02-064b-4ac9-9f64-5ad91be34cf5"), Code = "OE", Name = "OPU Engineer", Description = "OPU Engineer" },
                    new Role { Id = new Guid("e437bbb9-5be3-4e4b-9501-dc9d80b91e55"), Code = "I", Name = "Inspector Internal", Description = "Inspector Internal" },
                    new Role { Id = new Guid("6aad1ca6-4e06-4508-ba95-ae8828dd59db"), Code = "IN", Name = "Inspector External", Description = "Inspector External" }
            );

            modelBuilder.Entity<Role>().HasAlternateKey(c => c.Name).HasName("Role_Name");

            #endregion

            #region PlatformSeed

            modelBuilder.Entity<Platform>()
                .HasData(
                    new Platform { Id = new Guid("060128ee-e126-494d-979f-767f203f11a4"), Name = "BAKP-B" }
            );

            modelBuilder.Entity<Platform>().HasAlternateKey(c => c.Name).HasName("Platform_Name");

            #endregion

            #region LocationOneSeed

            modelBuilder.Entity<LocationOne>()
                .HasData(
                    new LocationOne { Id = new Guid("938704b5-ae75-40c4-b696-8b102d5a15ae"), Name = "-" },
                    new LocationOne { Id = new Guid("335529ad-04c4-4934-a319-9c3e2d428c02"), Name = "R-301" }
            );

            modelBuilder.Entity<LocationOne>().HasAlternateKey(c => c.Name).HasName("LocationOne_Name");

            #endregion

            #region LocationTwoSeed

            modelBuilder.Entity<LocationTwo>()
                .HasData(
                    new LocationOne { Id = new Guid("938704b5-ae75-40c4-b696-8b102d5a15ae"), Name = "-" },
                    new LocationOne { Id = new Guid("a64c5cab-964f-4c37-9629-d9e35671bc81"), Name = "A-2900" }
            );

            modelBuilder.Entity<LocationTwo>().HasAlternateKey(c => c.Name).HasName("LocationTwo_Name");

            #endregion

            #region HACDwgNoSeed

            modelBuilder.Entity<HACDwgNo>()
                .HasData(
                    new HACDwgNo { Id = new Guid("938704b5-ae75-40c4-b696-8b102d5a15ae"), Name = "-" },
                    new HACDwgNo { Id = new Guid("0a5567e3-a8ad-4c3d-a6d5-23996ac27c68"), Name = "BAKP-B-X-0010-0 Rev.0" },
                    new HACDwgNo { Id = new Guid("796557ad-12b6-4bd5-a3d8-902c288bdc78"), Name = "BAKP-B-X-0011-0 Rev.0" },
                    new HACDwgNo { Id = new Guid("94983962-7f6a-41b9-95c7-1cf1b28a9b6e"), Name = "BAKP-B-X-0012-0 Rev.0" },
                    new HACDwgNo { Id = new Guid("1253eedb-95c4-4725-af4c-c664ea9afd57"), Name = "BAKP-B-X-0013-0 Rev.0" },
                    new HACDwgNo { Id = new Guid("44e41f78-c4a1-4874-919b-7161c9582412"), Name = "BAKP-B-X-0014-0 Rev.Z1" }
            );

            modelBuilder.Entity<HACDwgNo>().HasAlternateKey(c => c.Name).HasName("HACDwgNo_Name");

            #endregion

            #region CoordinateSeed

            modelBuilder.Entity<Coordinate>()
                .HasData(
                    new Coordinate { Id = new Guid("938704b5-ae75-40c4-b696-8b102d5a15ae"), Name = "-" },
                    new Coordinate { Id = new Guid("ed5d5d3f-819b-4da3-82f4-19a5dc5eba7d"), Name = "A:1" }
            );

            modelBuilder.Entity<Coordinate>().HasAlternateKey(c => c.Name).HasName("Coordinate_Name");

            #endregion

            #region ZoneSeed

            modelBuilder.Entity<Zone>()
                .HasData(
                    new Zone { Id = new Guid("dc288ecb-841c-4c6a-b34f-91256ee183d8"), Name = "Z2" }
            );

            modelBuilder.Entity<Zone>().HasAlternateKey(c => c.Name).HasName("Zone_Name");

            #endregion

            #region PurposeSeed

            modelBuilder.Entity<Purpose>()
                .HasData(
                    new Purpose { Id = new Guid("938704b5-ae75-40c4-b696-8b102d5a15ae"), Name = "-" },
                    new Purpose { Id = new Guid("274ab1b4-75fc-4a71-babf-fb8101a2634b"), Name = "Motor" }
            );

            modelBuilder.Entity<Purpose>().HasAlternateKey(c => c.Name).HasName("Purpose_Name");

            #endregion

            #region ManufacturerSeed

            modelBuilder.Entity<Manufacturer>()
                .HasData(
                    new Manufacturer { Id = new Guid("938704b5-ae75-40c4-b696-8b102d5a15ae"), Name = "-" },
                    new Manufacturer { Id = new Guid("03ddb1e6-7510-46ec-af6a-c4bef07efb02"), Name = "SIEMENS" }
            );

            modelBuilder.Entity<Manufacturer>().HasAlternateKey(c => c.Name).HasName("Manufacturer_Name");

            #endregion

            #region ModelSeed

            modelBuilder.Entity<Model>()
                .HasData(
                    new Model { Id = new Guid("938704b5-ae75-40c4-b696-8b102d5a15ae"), Name = "-" },
                    new Model { Id = new Guid("2160fa79-a8d4-4ed0-9583-92bbd572726c"), Name = "IMA6 223-4DC69-Z" }
            );

            modelBuilder.Entity<Model>().HasAlternateKey(c => c.Name).HasName("Model_Name");

            #endregion

            #region SerialNoSeed

            modelBuilder.Entity<SerialNo>()
                .HasData(
                    new Model { Id = new Guid("938704b5-ae75-40c4-b696-8b102d5a15ae"), Name = "-" },
                    new Model { Id = new Guid("bf8e4e4b-ee85-42f3-a43e-2b84e88b1d1e"), Name = "UC 0506/068036901 IM V3" }
            );

            modelBuilder.Entity<SerialNo>().HasAlternateKey(c => c.Name).HasName("SerialNo_Name");

            #endregion

            #region IECExCertificateAuthoritySeed

            modelBuilder.Entity<IECExCertificateAuthority>()
                .HasData(
                    new IECExCertificateAuthority { Id = new Guid("938704b5-ae75-40c4-b696-8b102d5a15ae"), Name = "-" },
                    new IECExCertificateAuthority { Id = new Guid("c93078e3-7067-4493-a5ad-0a312731bae9"), Name = "PTB" }
            );

            modelBuilder.Entity<IECExCertificateAuthority>().HasAlternateKey(c => c.Name).HasName("IECExCertificateAuthority_Name");

            #endregion

            #region IECExCertificateCategorySeed

            modelBuilder.Entity<IECExCertificateCategory>()
                .HasData(
                    new IECExCertificateCategory { Id = new Guid("938704b5-ae75-40c4-b696-8b102d5a15ae"), Name = "-" },
                    new IECExCertificateCategory { Id = new Guid("bec84a12-db91-4cb9-999e-bdf44e74e109"), Name = "Component Cert" }
            );

            modelBuilder.Entity<IECExCertificateCategory>().HasAlternateKey(c => c.Name).HasName("IECExCertificateCategory_Name");

            #endregion

            #region IECExCertificateNoSeed

            modelBuilder.Entity<IECExCertificateNo>()
                .HasData(
                    new IECExCertificateNo { Id = new Guid("938704b5-ae75-40c4-b696-8b102d5a15ae"), No = "-" },
                    new IECExCertificateNo { Id = new Guid("db02b94f-6fcf-40ee-8fb4-7da02c74c1b6"), No = "PTB 02ATEX 3068" }
            );

            modelBuilder.Entity<IECExCertificateNo>().HasAlternateKey(c => c.No).HasName("IECExCertificateNo_No");

            #endregion

            #region IECExCertificateDetailSeed

            modelBuilder.Entity<IECExCertificateDetail>()
                .HasData(
                    new IECExCertificateDetail { Id = new Guid("938704b5-ae75-40c4-b696-8b102d5a15ae"), Name = "-" },
                    new IECExCertificateDetail { Id = new Guid("0ee93cef-fd02-4232-aefa-d4b82b651421"), Name = "Det-01" }
            );

            modelBuilder.Entity<IECExCertificateDetail>().HasAlternateKey(c => c.Name).HasName("IECExCertificateDetail_Name");

            #endregion

            #region ElectricalRatingSeed

            modelBuilder.Entity<ElectricalRating>()
                .HasData(
                    new ElectricalRating { Id = new Guid("938704b5-ae75-40c4-b696-8b102d5a15ae"), Name = "-" },
                    new ElectricalRating { Id = new Guid("7cbbc8ca-5779-45c0-a08e-24c6bf8240f6"), Name = "30 VDC 200mA" }
            );

            modelBuilder.Entity<ElectricalRating>().HasAlternateKey(c => c.Name).HasName("ElectricalRating_Name");

            #endregion

            #region DisciplineSeed

            modelBuilder.Entity<Discipline>()
                .HasData(
                    new Discipline { Id = new Guid("ac1f5b06-1699-4673-9db8-77f4ea3dd0e8"), Name = "Electrical" }
            );

            modelBuilder.Entity<Discipline>().HasAlternateKey(c => c.Name).HasName("Discipline_Name");

            #endregion

            #region ProtectionTypeSeed

            modelBuilder.Entity<ProtectionType>()
                .HasData(
                    new ProtectionType { Id = new Guid("33bf41bf-8b76-4057-8f51-a8c6ef51c346"), Name = "ex a" },
                    new ProtectionType { Id = new Guid("7fbf3205-4bc8-4622-ad4e-f85b4d3c0098"), Name = "ex b" },
                    new ProtectionType { Id = new Guid("c21f5c15-addc-4d0b-b273-0c34dfd04504"), Name = "ex c" },
                    new ProtectionType { Id = new Guid("d63f18b9-c184-4a3d-a6b2-4acd8846b4fa"), Name = "ex d" },
                    new ProtectionType { Id = new Guid("e045fb56-ffae-4e57-b6bf-0b267739c765"), Name = "ex e" }
            );

            modelBuilder.Entity<ProtectionType>().HasAlternateKey(c => c.Name).HasName("ProtectionType_Name");

            #endregion

            #region EquipmentSeed

            modelBuilder.Entity<Equipment>()
                .HasData(
                    new Equipment { 
                        Id = new Guid("b79a0707-5795-41a5-a0b8-28893db58c62"),
                        Id_OPU = new Guid("1f0565ee-1ebd-48d0-adfc-37fcf00c810f"),
                        Id_Platform = new Guid("060128ee-e126-494d-979f-767f203f11a4"),
                        Id_LocationOne = new Guid("335529ad-04c4-4934-a319-9c3e2d428c02"),
                        Id_LocationTwo = new Guid("a64c5cab-964f-4c37-9629-d9e35671bc81"),
                        Id_HACDwgNo = new Guid("0a5567e3-a8ad-4c3d-a6d5-23996ac27c68"),
                        Id_Coordinate = new Guid("ed5d5d3f-819b-4da3-82f4-19a5dc5eba7d"),
                        Id_Zone = new Guid("dc288ecb-841c-4c6a-b34f-91256ee183d8"),
                        Id_Purpose = new Guid("274ab1b4-75fc-4a71-babf-fb8101a2634b"),
                        Id_Manufacturer = new Guid("03ddb1e6-7510-46ec-af6a-c4bef07efb02"),
                        Id_Model = new Guid("2160fa79-a8d4-4ed0-9583-92bbd572726c"),
                        Id_SerialNo = new Guid("bf8e4e4b-ee85-42f3-a43e-2b84e88b1d1e"),
                        Id_IECExCertificateAuthority = new Guid("c93078e3-7067-4493-a5ad-0a312731bae9"),
                        Id_IECExCertificateCategory = new Guid("bec84a12-db91-4cb9-999e-bdf44e74e109"),
                        Id_IECExCertificateNo = new Guid("db02b94f-6fcf-40ee-8fb4-7da02c74c1b6"),
                        Id_IECExCertificateDetail = new Guid("0ee93cef-fd02-4232-aefa-d4b82b651421"),
                        Id_ElectricalRating = new Guid("7cbbc8ca-5779-45c0-a08e-24c6bf8240f6"),
                        Id_Discipline = new Guid("ac1f5b06-1699-4673-9db8-77f4ea3dd0e8"),
                        Id_ProtectionType = new Guid("e045fb56-ffae-4e57-b6bf-0b267739c765"),
                        Name = "Motor",
                        TagNo = "E2460A",
                        Active = true,
                        Id_CreatedBy = new Guid("eb47cb7a-eeae-4867-be98-8566a9ffe208"),
                        DateCreated = DateTime.UtcNow
                    },
                    new Equipment
                    {
                        Id = new Guid("34b0f38e-1603-47fd-bed9-37e254324336"),
                        Id_OPU = new Guid("1f0565ee-1ebd-48d0-adfc-37fcf00c810f"),
                        Id_Platform = new Guid("060128ee-e126-494d-979f-767f203f11a4"),
                        Id_LocationOne = new Guid("938704b5-ae75-40c4-b696-8b102d5a15ae"),
                        Id_LocationTwo = new Guid("938704b5-ae75-40c4-b696-8b102d5a15ae"),
                        Id_HACDwgNo = new Guid("938704b5-ae75-40c4-b696-8b102d5a15ae"),
                        Id_Coordinate = new Guid("938704b5-ae75-40c4-b696-8b102d5a15ae"),
                        Id_Zone = new Guid("dc288ecb-841c-4c6a-b34f-91256ee183d8"),
                        Id_Purpose = new Guid("938704b5-ae75-40c4-b696-8b102d5a15ae"),
                        Id_Manufacturer = new Guid("938704b5-ae75-40c4-b696-8b102d5a15ae"),
                        Id_Model = new Guid("938704b5-ae75-40c4-b696-8b102d5a15ae"),
                        Id_SerialNo = new Guid("938704b5-ae75-40c4-b696-8b102d5a15ae"),
                        Id_IECExCertificateAuthority = new Guid("938704b5-ae75-40c4-b696-8b102d5a15ae"),
                        Id_IECExCertificateCategory = new Guid("938704b5-ae75-40c4-b696-8b102d5a15ae"),
                        Id_IECExCertificateNo = new Guid("938704b5-ae75-40c4-b696-8b102d5a15ae"),
                        Id_IECExCertificateDetail = new Guid("938704b5-ae75-40c4-b696-8b102d5a15ae"),
                        Id_ElectricalRating = new Guid("938704b5-ae75-40c4-b696-8b102d5a15ae"),
                        Id_Discipline = new Guid("ac1f5b06-1699-4673-9db8-77f4ea3dd0e8"),
                        Id_ProtectionType = new Guid("e045fb56-ffae-4e57-b6bf-0b267739c765"),
                        Name = "Motor",
                        TagNo = "E3100A",
                        Active = true,
                        Id_CreatedBy = new Guid("eb47cb7a-eeae-4867-be98-8566a9ffe208"),
                        DateCreated = DateTime.UtcNow
                    }
            );

            modelBuilder.Entity<Equipment>().HasAlternateKey(c => c.TagNo).HasName("TagNo");

            #endregion

            #region InspectionSeed

            modelBuilder.Entity<Inspection>()
                .HasData(
                    new Inspection
                    {
                        Id = new Guid("f38055b9-c70f-4622-91f5-4493b4be1611"),
                        Id_OPU = new Guid("1f0565ee-1ebd-48d0-adfc-37fcf00c810f"),
                        Id_Platform = new Guid("060128ee-e126-494d-979f-767f203f11a4"),
                        Id_Discipline = new Guid("ac1f5b06-1699-4673-9db8-77f4ea3dd0e8"),
                        Id_User = new Guid("c74611f6-a99f-44b4-88fd-e00e00fcff5a"),
                        Id_InspectionType = new Guid("2afe51d9-2270-4992-8a5f-bf95e002798b"),
                        Name = "Sample 1",
                        Description = "Description 1",
                        DateInspectionStart = DateTime.UtcNow,
                        DateInspectionEnd = DateTime.UtcNow,
                        Active = true,
                        Id_CreatedBy = new Guid("eb47cb7a-eeae-4867-be98-8566a9ffe208"),
                        DateCreated = DateTime.UtcNow
                    },
                    new Inspection
                    {
                        Id = new Guid("e26bc764-4b36-4984-9d44-d29acc3d3849"),
                        Id_OPU = new Guid("1f0565ee-1ebd-48d0-adfc-37fcf00c810f"),
                        Id_Platform = new Guid("060128ee-e126-494d-979f-767f203f11a4"),
                        Id_Discipline = new Guid("ac1f5b06-1699-4673-9db8-77f4ea3dd0e8"),
                        Id_User = new Guid("c74611f6-a99f-44b4-88fd-e00e00fcff5a"),
                        Id_InspectionType = new Guid("2afe51d9-2270-4992-8a5f-bf95e002798b"),
                        Name = "Sample 2",
                        Description = "Description 2",
                        DateInspectionStart = DateTime.UtcNow,
                        DateInspectionEnd = DateTime.UtcNow,
                        Active = true,
                        Id_CreatedBy = new Guid("eb47cb7a-eeae-4867-be98-8566a9ffe208"),
                        DateCreated = DateTime.UtcNow
                    },
                    new Inspection
                    {
                        Id = new Guid("c916d1a9-4592-4b49-bf64-afecd274ab41"),
                        Id_OPU = new Guid("1f0565ee-1ebd-48d0-adfc-37fcf00c810f"),
                        Id_Platform = new Guid("060128ee-e126-494d-979f-767f203f11a4"),
                        Id_Discipline = new Guid("ac1f5b06-1699-4673-9db8-77f4ea3dd0e8"),
                        Id_User = new Guid("c74611f6-a99f-44b4-88fd-e00e00fcff5a"),
                        Id_InspectionType = new Guid("2afe51d9-2270-4992-8a5f-bf95e002798b"),
                        Name = "Sample 3",
                        Description = "Description 3",
                        DateInspectionStart = DateTime.UtcNow,
                        DateInspectionEnd = DateTime.UtcNow,
                        Active = true,
                        Id_CreatedBy = new Guid("eb47cb7a-eeae-4867-be98-8566a9ffe208"),
                        DateCreated = DateTime.UtcNow
                    }
            );

            modelBuilder.Entity<Inspection>()
                .HasOne<User>(e => e.User)
                .WithMany(d => d.Inspections)
                .HasForeignKey(e => e.Id_User)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.NoAction);

            #endregion
        }
    }
}
