using IMExApi.DTO;

namespace IMExApi.Repository.Interfaces
{
    public interface IPlatformRepository
    {
        #region Method Definitions

        Task<IEnumerable<DTOPlatform>> GetPlatforms();
        Task<DTOPlatform> CreatePlatform(DTOPlatform dtoPlatform);

        #endregion
    }

    public interface ILocationOneRepository
    {
        #region Method Definitions

        Task<IEnumerable<DTOLocationOne>> GetLocationOnes();
        Task<DTOLocationOne> CreateLocationOne(DTOLocationOne dtoLocationOne);

        #endregion
    }

    public interface ILocationTwoRepository
    {
        #region Method Definitions

        Task<IEnumerable<DTOLocationTwo>> GetLocationTwos();
        Task<DTOLocationTwo> CreateLocationTwo(DTOLocationTwo dtoLocationTwo);

        #endregion
    }

    public interface IHACDwgNoRepository
    {
        #region Method Definitions

        Task<IEnumerable<DTOHACDwgNo>> GetHACDwgNos();
        Task<DTOHACDwgNo> CreateHACDwgNo(DTOHACDwgNo dtoHACDwgNo);

        #endregion
    }

    public interface ICoordinateRepository
    {
        #region Method Definitions

        Task<IEnumerable<DTOCoordinate>> GetCoordinates();
        Task<DTOCoordinate> GetCoordinate(Guid Id);
        Task<DTOCoordinate> CreateCoordinate(DTOCoordinate dtoCoordinate);

        #endregion
    }

    public interface IZoneRepository
    {
        #region Method Definitions

        Task<IEnumerable<DTOZone>> GetZones();

        #endregion
    }

    public interface IPurposeRepository
    {
        #region Method Definitions

        Task<IEnumerable<DTOPurpose>> GetPurposes();
        Task<DTOPurpose> CreatePurpose(DTOPurpose dtoPurpose);

        #endregion
    }

    public interface IManufacturerRepository
    {
        #region Method Definitions

        Task<IEnumerable<DTOManufacturer>> GetManufacturers();
        Task<DTOManufacturer> CreateManufacturer(DTOManufacturer dtoManufacturer);

        #endregion
    }

    public interface IModelRepository
    {
        #region Method Definitions

        Task<IEnumerable<DTOModel>> GetModels();
        Task<DTOModel> CreateModel(DTOModel dtoModel);

        #endregion
    }

    public interface ISerialNoRepository
    {
        #region Method Definitions

        Task<IEnumerable<DTOSerialNo>> GetSerialNos();
        Task<DTOSerialNo> CreateSerialNo(DTOSerialNo dtoSerialNo);

        #endregion
    }

    public interface IIECExCertificateAuthorityRepository
    {
        #region Method Definitions

        Task<IEnumerable<DTOIECExCertificateAuthority>> GetIECExCertificateAuthorities();

        #endregion
    }

    public interface IIECExCertificateCategoryRepository
    {
        #region Method Definitions

        Task<IEnumerable<DTOIECExCertificateCategory>> GetIECExCertificateCategories();
        Task<DTOIECExCertificateCategory> CreateIECExCertificateCategory(DTOIECExCertificateCategory dtoIECExCertificateCategory);

        #endregion
    }

    public interface IIECExCertificateNoRepository
    {
        #region Method Definitions

        Task<IEnumerable<DTOIECExCertificateNo>> GetIECExCertificateNos();
        Task<DTOIECExCertificateNo> CreateIECExCertificateNo(DTOIECExCertificateNo dtoIECExCertificateNo);

        #endregion
    }

    public interface IIECExCertificateDetailRepository
    {
        #region Method Definitions

        Task<IEnumerable<DTOIECExCertificateDetail>> GetIECExCertificateDetails();
        Task<DTOIECExCertificateDetail> CreateIECExCertificateDetail(DTOIECExCertificateDetail dtoIECExCertificateDetail);

        #endregion
    }

    public interface IElectricalRatingRepository
    {
        #region Method Definitions

        Task<IEnumerable<DTOElectricalRating>> GetElectricalRatings();
        Task<DTOElectricalRating> CreateElectricalRating(DTOElectricalRating dtoElectricalRating);

        #endregion
    }

    public interface IDisciplineRepository
    {
        #region Method Definitions

        Task<IEnumerable<DTODiscipline>> GetDisciplines();

        #endregion
    }

    public interface IProtectionTypeRepository
    {
        #region Method Definitions

        Task<IEnumerable<DTOProtectionType>> GetProtectionTypes();

        #endregion
    }

    public interface IEquipmentRepository
    {
        #region Method Definitions

        Task<IEnumerable<DTOEquipment>> GetEquipments();
        Task<DTOEquipment> GetEquipment(Guid id);
        Task<DTOEquipment> CreateEquipment(DTOEquipment dtoEquipment);
        Task<DTOEquipment> UpdateEquipment(Guid id, DTOEquipment dtoEquipment);
        Task<Guid> DeleteEquipment(Guid id);

        #endregion
    }
}
