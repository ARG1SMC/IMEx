using IMExApi.DTO;

namespace IMExApi.Repository.Interfaces
{
    public interface IInspectionRepository
    {
        #region Method Definitions

        Task<IEnumerable<DTOInspection>> GetInspections();
        Task<DTOInspection> GetInspection(Guid id);
        Task<DTOInspection> CreateInspection(DTOInspection dtoInspection);
        Task<DTOInspection> UpdateInspection(Guid id, DTOInspection dtoInspection);
        Task<Guid> DeleteInspection(Guid id);

        #endregion
    }

    public interface IInspectionTypeRepository
    {
        #region Method Definitions

        Task<IEnumerable<DTOInspectionType>> GetInspectionTypes();

        #endregion
    }
}
