using Microsoft.EntityFrameworkCore;
using IMExApi.Data;
using IMExApi.DTO;
using IMExApi.Repository.Interfaces;
using IMExApi.Models;

namespace IMExApi.Repository.Classes
{
    public class InspectionRepository : IInspectionRepository
    {
        private readonly IMExDbContext _imexDBContext;

        public InspectionRepository(IMExDbContext imexDbContext)
        {
            _imexDBContext = imexDbContext ?? throw new ArgumentNullException(nameof(imexDbContext));
        }

        #region Methods

        public async Task<IEnumerable<DTOInspection>> GetInspections()
        {
            List<DTOInspection> dtoInspections = await
                _imexDBContext.Inspections
                .Include(b => b.OPU)
                .Include(b => b.Platform)
                .Include(b => b.Discipline)
                .Include(b => b.User)
                .Include(b => b.InspectionType)
                .Where(b => b.Active == true)
                .Select(b =>
                new DTOInspection()
                {
                    Id = b.Id,
                    Id_OPU = b.Id_OPU,
                    OPU = b.OPU.Field.Name,
                    Id_Platform = b.Id_Platform,
                    Platform = b.Platform.Name,
                    Id_Discipline = b.Id_Discipline,
                    Discipline = b.Discipline.Name,
                    Id_User = b.Id_User,
                    User = b.User.UserName,
                    Id_InspectionType = b.Id_InspectionType,
                    InspectionType = b.InspectionType.Name,
                    Name = b.Name,
                    Description = b.Description,
                    DateInspectionStart = b.DateInspectionStart,
                    DateInspectionEnd = b.DateInspectionEnd,
                    Active = b.Active,
                    Id_CreatedBy = b.Id_CreatedBy,
                    DateCreated = b.DateCreated,
                    Id_UpdatedBy = b.Id_UpdatedBy,
                    DateUpdated = b.DateUpdated,
                    Id_DeletedBy = b.Id_DeletedBy,
                    DateDeleted = b.DateDeleted
                }
            ).ToListAsync();

            return dtoInspections;
        }

        public async Task<DTOInspection> GetInspection(Guid Id)
        {
            DTOInspection? dtoInspection = await
                _imexDBContext.Inspections
                .Include(b => b.OPU)
                .Include(b => b.Platform)
                .Include(b => b.Discipline)
                .Include(b => b.User)
                .Include(b => b.InspectionType)
                .Where(b => b.Active == true)
                .Select(b =>
                new DTOInspection()
                {
                    Id = b.Id,
                    Id_OPU = b.Id_OPU,
                    OPU = b.OPU.Field.Name,
                    Id_Platform = b.Id_Platform,
                    Platform = b.Platform.Name,
                    Id_Discipline = b.Id_Discipline,
                    Discipline = b.Discipline.Name,
                    Id_User = b.Id_User,
                    User = b.User.UserName,
                    Id_InspectionType = b.Id_InspectionType,
                    InspectionType = b.InspectionType.Name,
                    Name = b.Name,
                    Description = b.Description,
                    DateInspectionStart = b.DateInspectionStart,
                    DateInspectionEnd = b.DateInspectionEnd,
                    Active = b.Active,
                    Id_CreatedBy = b.Id_CreatedBy,
                    DateCreated = b.DateCreated,
                    Id_UpdatedBy = b.Id_UpdatedBy,
                    DateUpdated = b.DateUpdated,
                    Id_DeletedBy = b.Id_DeletedBy,
                    DateDeleted = b.DateDeleted
                }
            ).SingleOrDefaultAsync(s => s.Id == Id);

            return dtoInspection;
        }

        public async Task<DTOInspection> CreateInspection(DTOInspection dtoInspection)
        {
            dtoInspection.Id = Guid.NewGuid();

            Inspection inspection = new Inspection()
            {
                Id = dtoInspection.Id,
                Id_OPU = dtoInspection.Id_OPU,
                Id_Platform = dtoInspection.Id_Platform,
                Id_Discipline = dtoInspection.Id_Discipline,
                Id_User = dtoInspection.Id_User,
                Id_InspectionType = dtoInspection.Id_InspectionType,
                Name = dtoInspection.Name,
                Description = dtoInspection.Description,
                DateInspectionStart = dtoInspection.DateInspectionStart,
                DateInspectionEnd = dtoInspection.DateInspectionEnd,
                Active = true,
                Id_CreatedBy = dtoInspection.Id_CreatedBy,
                DateCreated = DateTime.UtcNow
            };

            await _imexDBContext.AddAsync(inspection);
            await _imexDBContext.SaveChangesAsync();

            return dtoInspection;
        }

        public async Task<DTOInspection> UpdateInspection(Guid Id, DTOInspection dtoInspection)
        {
            Inspection? curInspection = await
                _imexDBContext.Inspections
                .Where(b => b.Active == true)
                .FirstOrDefaultAsync(x => x.Id == Id);

            if (curInspection != null)
            {
                if (dtoInspection.Id_OPU != curInspection.Id_OPU) { curInspection.Id_OPU = dtoInspection.Id_OPU; };
                if (dtoInspection.Id_Platform != curInspection.Id_Platform) { curInspection.Id_Platform = dtoInspection.Id_Platform; };
                if (dtoInspection.Id_Discipline != curInspection.Id_Discipline) { curInspection.Id_Discipline = dtoInspection.Id_Discipline; };
                if (dtoInspection.Id_User != curInspection.Id_User) { curInspection.Id_User = dtoInspection.Id_User; };
                if (dtoInspection.Id_InspectionType != curInspection.Id_InspectionType) { curInspection.Id_InspectionType = dtoInspection.Id_InspectionType; };
                if (dtoInspection.Name != curInspection.Name) { curInspection.Name = dtoInspection.Name; };
                if (dtoInspection.Description != curInspection.Name) { curInspection.Name = dtoInspection.Name; };
                if (dtoInspection.DateInspectionStart != curInspection.DateInspectionStart) { curInspection.DateInspectionStart = dtoInspection.DateInspectionStart; };
                if (dtoInspection.DateInspectionEnd != curInspection.DateInspectionEnd) { curInspection.DateInspectionEnd = dtoInspection.DateInspectionEnd; };

                curInspection.Id_UpdatedBy = dtoInspection.Id_UpdatedBy;
                curInspection.DateUpdated = DateTime.UtcNow;

                _imexDBContext.Entry(curInspection).State = EntityState.Modified;

                await _imexDBContext.SaveChangesAsync();
            }

            return dtoInspection;
        }

        public async Task<Guid> DeleteInspection(Guid Id)
        {
            Inspection? curInspection = await
                _imexDBContext.Inspections
                .Where(b => b.Active == true)
                .FirstOrDefaultAsync(x => x.Id == Id);

            if (curInspection != null)
            {
                curInspection.Active = false;
                curInspection.Id_DeletedBy = new Guid("eb47cb7a-eeae-4867-be98-8566a9ffe208"); // To Update
                curInspection.DateDeleted = DateTime.UtcNow;

                _imexDBContext.Entry(curInspection).State = EntityState.Modified;

                await _imexDBContext.SaveChangesAsync();

                return Id;
            }

            return Guid.Empty;
        }

        #endregion
    }

    public class InspectionTypeRepository : IInspectionTypeRepository
    {
        private readonly IMExDbContext _imexDBContext;

        public InspectionTypeRepository(IMExDbContext imexDbContext)
        {
            _imexDBContext = imexDbContext ?? throw new ArgumentNullException(nameof(imexDbContext));
        }

        #region Methods

        public async Task<IEnumerable<DTOInspectionType>> GetInspectionTypes()
        {
            List<DTOInspectionType> dtoInspectionTypes = await
                _imexDBContext.InspectionTypes
                .Select(b =>
                new DTOInspectionType()
                {
                    Id = b.Id,
                    Name = b.Name,
                }
            ).ToListAsync();

            return dtoInspectionTypes;
        }

        #endregion
    }
}
