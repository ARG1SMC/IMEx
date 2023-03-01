using IMExApi.DTO;

namespace IMExApi.Repository.Interfaces
{
    public interface IUserRepository
    {
        #region Method Definitions

        Task<IEnumerable<DTOUser>> GetUsers();
        Task<DTOUser> GetUser(Guid id);
        Task<DTOUser> CreateUser(DTOUser dtoUser);
        Task<DTOUser> UpdateUser(Guid id, DTOUser dtoUser);
        Task<Guid> DeleteUser(Guid id);

        #endregion
    }
    public interface IOPURepository
    {
        #region Method Definitions

        Task<IEnumerable<DTOOPU>> GetOPUs();
        Task<DTOOPU> GetOPU(Guid Id);

        #endregion
    }

    public interface IRoleRepository
    {
        #region Method Definitions

        Task<IEnumerable<DTORole>> GetRoles();
        Task<DTORole> GetRole(Guid Id);

        #endregion
    }
}
