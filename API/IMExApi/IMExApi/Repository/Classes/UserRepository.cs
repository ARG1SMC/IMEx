using Microsoft.EntityFrameworkCore;
using IMExApi.Data;
using IMExApi.DTO;
using IMExApi.Repository.Interfaces;
using IMExApi.Models;

namespace IMExApi.Repository.Classes
{
    public class UserRepository : IUserRepository
    {
        private readonly IMExDbContext _imexDbContext;

        public UserRepository(IMExDbContext imexDbContext)
        {
            _imexDbContext = imexDbContext ?? throw new ArgumentNullException(nameof(imexDbContext));
        }

        #region Methods

        public async Task<IEnumerable<DTOUser>> GetUsers()
        {
            List<DTOUser> dtoUsers = await
                _imexDbContext.Users
                .Include(b => b.OPU)
                .Include(b => b.Role)
                .Where(b => b.Active == true)
                .Select(b =>
                new DTOUser()
                {
                    Id = b.Id,
                    Id_OPU = b.Id_OPU,
                    OPU = b.OPU.Field.Name,
                    Id_Role = b.Id_Role,
                    Role = b.Role.Name,
                    FirstName = b.FirstName,
                    LastName = b.LastName,
                    UserName = b.UserName,
                    Password = b.Password,
                    DateValidStart = b.DateValidStart,
                    DateValidEnd = b.DateValidEnd,
                    Active = b.Active,
                    Id_CreatedBy = b.Id_CreatedBy,
                    DateCreated = b.DateCreated,
                    Id_UpdatedBy = b.Id_UpdatedBy,
                    DateUpdated = b.DateUpdated,
                    Id_DeletedBy = b.Id_DeletedBy,
                    DateDeleted = b.DateDeleted
                }
            ).ToListAsync();

            return dtoUsers;
        }

        public async Task<DTOUser> GetUser(Guid Id)
        {
            DTOUser? dtoUser = await
                _imexDbContext.Users
                .Include(b => b.OPU)
                .Include(b => b.Role)
                .Where(b => b.Active == true)
                .Select(b =>
                new DTOUser()
                {
                    Id = b.Id,
                    Id_OPU = b.Id_OPU,
                    OPU = b.OPU.Field.Name,
                    Id_Role = b.Id_Role,
                    Role = b.Role.Name,
                    FirstName = b.FirstName,
                    LastName = b.LastName,
                    UserName = b.UserName,
                    Password = b.Password,
                    DateValidStart = b.DateValidStart,
                    DateValidEnd = b.DateValidEnd,
                    Active = b.Active,
                    Id_CreatedBy = b.Id_CreatedBy,
                    DateCreated = b.DateCreated,
                    Id_UpdatedBy = b.Id_UpdatedBy,
                    DateUpdated = b.DateUpdated,
                    Id_DeletedBy = b.Id_DeletedBy,
                    DateDeleted = b.DateDeleted
                }
            ).SingleOrDefaultAsync(s => s.Id == Id);

            return dtoUser;
        }

        public async Task<DTOUser> CreateUser(DTOUser dtoUser)
        {
            dtoUser.Id = Guid.NewGuid();

            User user = new User()
            {
                Id = dtoUser.Id,
                Id_OPU = dtoUser.Id_OPU,
                Id_Role = dtoUser.Id_Role,
                FirstName = dtoUser.FirstName,
                LastName = dtoUser.LastName,
                UserName = dtoUser.UserName,
                Password = dtoUser.Password,
                DateValidStart = dtoUser.DateValidStart,
                DateValidEnd = dtoUser.DateValidEnd,
                Active = true,
                Id_CreatedBy = dtoUser.Id_CreatedBy,
                DateCreated = DateTime.UtcNow
            };

            await _imexDbContext.AddAsync(user);
            await _imexDbContext.SaveChangesAsync();

            return dtoUser;
        }

        public async Task<DTOUser> UpdateUser(Guid Id, DTOUser dtoUser)
        {
            User? curUser = await
                _imexDbContext.Users
                .Where(b => b.Active == true)
                .FirstOrDefaultAsync(x => x.Id == Id);

            if (curUser != null)
            {
                if (dtoUser.Id_OPU != curUser.Id_OPU) { curUser.Id_OPU = dtoUser.Id_OPU; };
                if (dtoUser.Id_Role != curUser.Id_Role) { curUser.Id_Role = dtoUser.Id_Role; };
                if (dtoUser.FirstName != curUser.FirstName) { curUser.FirstName = dtoUser.FirstName; };
                if (dtoUser.LastName != curUser.LastName) { curUser.LastName = dtoUser.LastName; };
                if (dtoUser.UserName != curUser.UserName) { curUser.UserName = dtoUser.UserName; };
                if (dtoUser.Password != curUser.Password) { curUser.Password = dtoUser.Password; };
                if (dtoUser.DateValidStart != curUser.DateValidStart) { curUser.DateValidStart = dtoUser.DateValidStart; };
                if (dtoUser.DateValidEnd != curUser.DateValidEnd) { curUser.DateValidEnd = dtoUser.DateValidEnd; };
                curUser.Id_UpdatedBy = dtoUser.Id_UpdatedBy;
                curUser.DateUpdated = DateTime.UtcNow;

                _imexDbContext.Entry(curUser).State = EntityState.Modified;

                await _imexDbContext.SaveChangesAsync();
            }

            return dtoUser;
        }

        public async Task<Guid> DeleteUser(Guid Id)
        {
            User? curUser = await
                _imexDbContext.Users
                .Where(b => b.Active == true)
                .FirstOrDefaultAsync(x => x.Id == Id);

            if (curUser != null)
            {
                curUser.Active = false;
                curUser.Id_DeletedBy = new Guid("eb47cb7a-eeae-4867-be98-8566a9ffe208"); // To Update
                curUser.DateDeleted = DateTime.UtcNow;

                _imexDbContext.Entry(curUser).State = EntityState.Modified;

                await _imexDbContext.SaveChangesAsync();

                return Id;
            }

            return Guid.Empty;
        }

        #endregion
    }

    public class OPURepository : IOPURepository
    {
        private readonly IMExDbContext _imexDBContext;

        public OPURepository(IMExDbContext imexDbContext)
        {
            _imexDBContext = imexDbContext ?? throw new ArgumentNullException(nameof(imexDbContext));
        }

        #region Methods

        public async Task<IEnumerable<DTOOPU>> GetOPUs()
        {
            List<DTOOPU> dtoOPUs = await
                _imexDBContext.OPUs
                .Select(b =>
                new DTOOPU()
                {
                    Id = b.Id,
                    Name = b.Field.Name
                }
            ).ToListAsync();

            return dtoOPUs;
        }

        public async Task<DTOOPU> GetOPU(Guid Id)
        {
            DTOOPU? dtoOPU = await
                _imexDBContext.OPUs
                .Select(b =>
                new DTOOPU()
                {
                    Id = b.Id,
                    Name = b.Field.Name
                }
            ).SingleOrDefaultAsync(s => s.Id == Id);

            return dtoOPU;
        }

        #endregion
    }

    public class RoleRepository : IRoleRepository
    {
        private readonly IMExDbContext _imexDBContext;

        public RoleRepository(IMExDbContext imexDbContext)
        {
            _imexDBContext = imexDbContext ?? throw new ArgumentNullException(nameof(imexDbContext));
        }

        #region Methods

        public async Task<IEnumerable<DTORole>> GetRoles()
        {
            List<DTORole> dtoRoles = await
                _imexDBContext.Roles
                .Select(b =>
                new DTORole()
                {
                    Id = b.Id,
                    Name = b.Name
                }
            ).ToListAsync();

            return dtoRoles;
        }

        public async Task<DTORole> GetRole(Guid Id)
        {
            DTORole? dtoRole = await
                _imexDBContext.Roles
                .Select(b =>
                new DTORole()
                {
                    Id = b.Id,
                    Name = b.Name
                }
            ).SingleOrDefaultAsync(s => s.Id == Id);

            return dtoRole;
        }

        #endregion
    }
}
