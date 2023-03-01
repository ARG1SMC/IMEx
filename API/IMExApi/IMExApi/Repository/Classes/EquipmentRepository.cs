using Microsoft.EntityFrameworkCore;
using IMExApi.Data;
using IMExApi.DTO;
using IMExApi.Repository.Interfaces;
using IMExApi.Models;

namespace IMExApi.Repository.Classes
{
    public class PlatformRepository : IPlatformRepository
    {
        private readonly IMExDbContext _imexDBContext;

        public PlatformRepository(IMExDbContext imexDbContext)
        {
            _imexDBContext = imexDbContext ?? throw new ArgumentNullException(nameof(imexDbContext));
        }

        #region Methods

        public async Task<IEnumerable<DTOPlatform>> GetPlatforms()
        {
            List<DTOPlatform> dtoPlatforms = await
                _imexDBContext.Platforms
                .Select(b =>
                new DTOPlatform()
                {
                    Id = b.Id,
                    Name = b.Name,
                }
            ).ToListAsync();

            return dtoPlatforms;
        }

        public async Task<DTOPlatform> CreatePlatform(DTOPlatform dtoPlatform)
        {
            //dtoPlatform.Id = Guid.NewGuid();

            Platform platform = new Platform()
            {
                Id = dtoPlatform.Id,
                Name = dtoPlatform.Name
            };

            await _imexDBContext.AddAsync(platform);
            await _imexDBContext.SaveChangesAsync();

            return dtoPlatform;
        }

        #endregion
    }

    public class LocationOneRepository : ILocationOneRepository
    {
        private readonly IMExDbContext _imexDBContext;

        public LocationOneRepository(IMExDbContext imexDbContext)
        {
            _imexDBContext = imexDbContext ?? throw new ArgumentNullException(nameof(imexDbContext));
        }

        #region Methods

        public async Task<IEnumerable<DTOLocationOne>> GetLocationOnes()
        {
            List<DTOLocationOne> dtoLocationOne = await
                _imexDBContext.LocationOnes
                .Select(b =>
                new DTOLocationOne()
                {
                    Id = b.Id,
                    Name = b.Name,
                }
            ).ToListAsync();

            return dtoLocationOne;
        }

        public async Task<DTOLocationOne> CreateLocationOne(DTOLocationOne dtoLocationOne)
        {
            LocationOne locationOne = new LocationOne()
            {
                Id = dtoLocationOne.Id,
                Name = dtoLocationOne.Name
            };

            await _imexDBContext.AddAsync(locationOne);
            await _imexDBContext.SaveChangesAsync();

            return dtoLocationOne;
        }

        #endregion
    }

    public class LocationTwoRepository : ILocationTwoRepository
    {
        private readonly IMExDbContext _imexDBContext;

        public LocationTwoRepository(IMExDbContext imexDbContext)
        {
            _imexDBContext = imexDbContext ?? throw new ArgumentNullException(nameof(imexDbContext));
        }

        #region Methods

        public async Task<IEnumerable<DTOLocationTwo>> GetLocationTwos()
        {
            List<DTOLocationTwo> dtoLocationTwo = await
                _imexDBContext.LocationTwos
                .Select(b =>
                new DTOLocationTwo()
                {
                    Id = b.Id,
                    Name = b.Name,
                }
            ).ToListAsync();

            return dtoLocationTwo;
        }

        public async Task<DTOLocationTwo> CreateLocationTwo(DTOLocationTwo dtoLocationTwo)
        {
            LocationTwo locationTwo = new LocationTwo()
            {
                Id = dtoLocationTwo.Id,
                Name = dtoLocationTwo.Name
            };

            await _imexDBContext.AddAsync(locationTwo);
            await _imexDBContext.SaveChangesAsync();

            return dtoLocationTwo;
        }

        #endregion
    }

    public class HACDwgNoRepository : IHACDwgNoRepository
    {
        private readonly IMExDbContext _imexDBContext;

        public HACDwgNoRepository(IMExDbContext imexDbContext)
        {
            _imexDBContext = imexDbContext ?? throw new ArgumentNullException(nameof(imexDbContext));
        }

        #region Methods

        public async Task<IEnumerable<DTOHACDwgNo>> GetHACDwgNos()
        {
            List<DTOHACDwgNo> dtoHACDwgNo = await
                _imexDBContext.HACDwgNos
                .Select(b =>
                new DTOHACDwgNo()
                {
                    Id = b.Id,
                    Name = b.Name,
                }
            ).ToListAsync();

            return dtoHACDwgNo;
        }

        public async Task<DTOHACDwgNo> CreateHACDwgNo(DTOHACDwgNo dtoHACDwgNo)
        {
            HACDwgNo hacDwgNo = new HACDwgNo()
            {
                Id = dtoHACDwgNo.Id,
                Name = dtoHACDwgNo.Name
            };

            await _imexDBContext.AddAsync(hacDwgNo);
            await _imexDBContext.SaveChangesAsync();

            return dtoHACDwgNo;
        }

        #endregion
    }

    public class CoordinateRepository : ICoordinateRepository
    {
        private readonly IMExDbContext _imexDBContext;

        public CoordinateRepository(IMExDbContext imexDbContext)
        {
            _imexDBContext = imexDbContext ?? throw new ArgumentNullException(nameof(imexDbContext));
        }

        #region Methods

        public async Task<IEnumerable<DTOCoordinate>> GetCoordinates()
        {
            List<DTOCoordinate> dtoCoordinates = await
                _imexDBContext.Coordinates
                .Select(b =>
                new DTOCoordinate()
                {
                    Id = b.Id,
                    Name = b.Name,
                }
            ).ToListAsync();

            return dtoCoordinates;
        }

        public async Task<DTOCoordinate> GetCoordinate(Guid Id)
        {
            DTOCoordinate? dtoCoordinate = await
                _imexDBContext.Coordinates
                .Select(b =>
                new DTOCoordinate()
                {
                    Id = b.Id,
                    Name = b.Name
                }
            ).SingleOrDefaultAsync(s => s.Id == Id);

            return dtoCoordinate;
        }

        public async Task<DTOCoordinate> CreateCoordinate(DTOCoordinate dtoCoordinate)
        {
            Coordinate coordinate = new Coordinate()
            {
                Id = dtoCoordinate.Id,
                Name = dtoCoordinate.Name
            };

            await _imexDBContext.AddAsync(coordinate);
            await _imexDBContext.SaveChangesAsync();

            return dtoCoordinate;
        }

        #endregion
    }

    public class ZoneRepository : IZoneRepository
    {
        private readonly IMExDbContext _imexDBContext;

        public ZoneRepository(IMExDbContext imexDbContext)
        {
            _imexDBContext = imexDbContext ?? throw new ArgumentNullException(nameof(imexDbContext));
        }

        #region Methods

        public async Task<IEnumerable<DTOZone>> GetZones()
        {
            List<DTOZone> dtoZones = await
                _imexDBContext.Zones
                .Select(b =>
                new DTOZone()
                {
                    Id = b.Id,
                    Name = b.Name,
                }
            ).ToListAsync();

            return dtoZones;
        }

        #endregion
    }

    public class PurposeRepository : IPurposeRepository
    {
        private readonly IMExDbContext _imexDBContext;

        public PurposeRepository(IMExDbContext imexDbContext)
        {
            _imexDBContext = imexDbContext ?? throw new ArgumentNullException(nameof(imexDbContext));
        }

        #region Methods

        public async Task<IEnumerable<DTOPurpose>> GetPurposes()
        {
            List<DTOPurpose> dtoPurposes = await
                _imexDBContext.Purposes
                .Select(b =>
                new DTOPurpose()
                {
                    Id = b.Id,
                    Name = b.Name,
                }
            ).ToListAsync();

            return dtoPurposes;
        }

        public async Task<DTOPurpose> CreatePurpose(DTOPurpose dtoPurpose)
        {
            Purpose purpose = new Purpose()
            {
                Id = dtoPurpose.Id,
                Name = dtoPurpose.Name
            };

            await _imexDBContext.AddAsync(purpose);
            await _imexDBContext.SaveChangesAsync();

            return dtoPurpose;
        }

        #endregion
    }

    public class ManufacturerRepository : IManufacturerRepository
    {
        private readonly IMExDbContext _imexDBContext;

        public ManufacturerRepository(IMExDbContext imexDbContext)
        {
            _imexDBContext = imexDbContext ?? throw new ArgumentNullException(nameof(imexDbContext));
        }

        #region Methods

        public async Task<IEnumerable<DTOManufacturer>> GetManufacturers()
        {
            List<DTOManufacturer> dtoManufacturers = await
                _imexDBContext.Manufacturers
                .Select(b =>
                new DTOManufacturer()
                {
                    Id = b.Id,
                    Name = b.Name,
                }
            ).ToListAsync();

            return dtoManufacturers;
        }

        public async Task<DTOManufacturer> CreateManufacturer(DTOManufacturer dtoManufacturer)
        {
            Manufacturer manufacturer = new Manufacturer()
            {
                Id = dtoManufacturer.Id,
                Name = dtoManufacturer.Name
            };

            await _imexDBContext.AddAsync(manufacturer);
            await _imexDBContext.SaveChangesAsync();

            return dtoManufacturer;
        }

        #endregion
    }

    public class ModelRepository : IModelRepository
    {
        private readonly IMExDbContext _imexDBContext;

        public ModelRepository(IMExDbContext imexDbContext)
        {
            _imexDBContext = imexDbContext ?? throw new ArgumentNullException(nameof(imexDbContext));
        }

        #region Methods

        public async Task<IEnumerable<DTOModel>> GetModels()
        {
            List<DTOModel> dtoModels = await
                _imexDBContext.Models
                .Select(b =>
                new DTOModel()
                {
                    Id = b.Id,
                    Name = b.Name,
                }
            ).ToListAsync();

            return dtoModels;
        }

        public async Task<DTOModel> CreateModel(DTOModel dtoModel)
        {
            Model model = new Model()
            {
                Id = dtoModel.Id,
                Name = dtoModel.Name
            };

            await _imexDBContext.AddAsync(model);
            await _imexDBContext.SaveChangesAsync();

            return dtoModel;
        }

        #endregion
    }

    public class SerialNoRepository : ISerialNoRepository
    {
        private readonly IMExDbContext _imexDBContext;

        public SerialNoRepository(IMExDbContext imexDbContext)
        {
            _imexDBContext = imexDbContext ?? throw new ArgumentNullException(nameof(imexDbContext));
        }

        #region Methods

        public async Task<IEnumerable<DTOSerialNo>> GetSerialNos()
        {
            List<DTOSerialNo> dtoSerialNos = await
                _imexDBContext.SerialNos
                .Select(b =>
                new DTOSerialNo()
                {
                    Id = b.Id,
                    Name = b.Name,
                }
            ).ToListAsync();

            return dtoSerialNos;
        }

        public async Task<DTOSerialNo> CreateSerialNo(DTOSerialNo dtoSerialNo)
        {
            SerialNo serialNo = new SerialNo()
            {
                Id = dtoSerialNo.Id,
                Name = dtoSerialNo.Name
            };

            await _imexDBContext.AddAsync(serialNo);
            await _imexDBContext.SaveChangesAsync();

            return dtoSerialNo;
        }

        #endregion
    }

    public class IECExCertificateAuthorityRepository : IIECExCertificateAuthorityRepository
    {
        private readonly IMExDbContext _imexDBContext;

        public IECExCertificateAuthorityRepository(IMExDbContext imexDbContext)
        {
            _imexDBContext = imexDbContext ?? throw new ArgumentNullException(nameof(imexDbContext));
        }

        #region Methods

        public async Task<IEnumerable<DTOIECExCertificateAuthority>> GetIECExCertificateAuthorities()
        {
            List<DTOIECExCertificateAuthority> dtoIECExCertificateAuthorities = await
                _imexDBContext.IECExCertificateAuthorities
                .Select(b =>
                new DTOIECExCertificateAuthority()
                {
                    Id = b.Id,
                    Name = b.Name,
                }
            ).ToListAsync();

            return dtoIECExCertificateAuthorities;
        }

        #endregion
    }

    public class IECExCertificateCategoryRepository : IIECExCertificateCategoryRepository
    {
        private readonly IMExDbContext _imexDBContext;

        public IECExCertificateCategoryRepository(IMExDbContext imexDbContext)
        {
            _imexDBContext = imexDbContext ?? throw new ArgumentNullException(nameof(imexDbContext));
        }

        #region Methods

        public async Task<IEnumerable<DTOIECExCertificateCategory>> GetIECExCertificateCategories()
        {
            List<DTOIECExCertificateCategory> dtoIECExCertificateCategories = await
                _imexDBContext.IECExCertificateCategories
                .Select(b =>
                new DTOIECExCertificateCategory()
                {
                    Id = b.Id,
                    Name = b.Name,
                }
            ).ToListAsync();

            return dtoIECExCertificateCategories;
        }

        public async Task<DTOIECExCertificateCategory> CreateIECExCertificateCategory(DTOIECExCertificateCategory dtoIECExCertificateCategory)
        {
            IECExCertificateCategory iecExCertificateCategory = new IECExCertificateCategory()
            {
                Id = dtoIECExCertificateCategory.Id,
                Name = dtoIECExCertificateCategory.Name
            };

            await _imexDBContext.AddAsync(iecExCertificateCategory);
            await _imexDBContext.SaveChangesAsync();

            return dtoIECExCertificateCategory;
        }

        #endregion
    }

    public class IECExCertificateNoRepository : IIECExCertificateNoRepository
    {
        private readonly IMExDbContext _imexDBContext;

        public IECExCertificateNoRepository(IMExDbContext imexDbContext)
        {
            _imexDBContext = imexDbContext ?? throw new ArgumentNullException(nameof(imexDbContext));
        }

        #region Methods

        public async Task<IEnumerable<DTOIECExCertificateNo>> GetIECExCertificateNos()
        {
            List<DTOIECExCertificateNo> dtoIECExCertificateNos = await
                _imexDBContext.IECExCertificateNos
                .Select(b =>
                new DTOIECExCertificateNo()
                {
                    Id = b.Id,
                    No = b.No,
                }
            ).ToListAsync();

            return dtoIECExCertificateNos;
        }

        public async Task<DTOIECExCertificateNo> CreateIECExCertificateNo(DTOIECExCertificateNo dtoIECExCertificateNo)
        {
            IECExCertificateNo iecExCertificateNo = new IECExCertificateNo()
            {
                Id = dtoIECExCertificateNo.Id,
                No = dtoIECExCertificateNo.No
            };

            await _imexDBContext.AddAsync(iecExCertificateNo);
            await _imexDBContext.SaveChangesAsync();

            return dtoIECExCertificateNo;
        }

        #endregion
    }

    public class IECExCertificateDetailRepository : IIECExCertificateDetailRepository
    {
        private readonly IMExDbContext _imexDBContext;

        public IECExCertificateDetailRepository(IMExDbContext imexDbContext)
        {
            _imexDBContext = imexDbContext ?? throw new ArgumentNullException(nameof(imexDbContext));
        }

        #region Methods

        public async Task<IEnumerable<DTOIECExCertificateDetail>> GetIECExCertificateDetails()
        {
            List<DTOIECExCertificateDetail> dtoIECExCertificateDetails = await
                _imexDBContext.IECExCertificateDetails
                .Select(b =>
                new DTOIECExCertificateDetail()
                {
                    Id = b.Id,
                    Name = b.Name,
                }
            ).ToListAsync();

            return dtoIECExCertificateDetails;
        }

        public async Task<DTOIECExCertificateDetail> CreateIECExCertificateDetail(DTOIECExCertificateDetail dtoIECExCertificateDetail)
        {
            IECExCertificateDetail iecExCertificateDetail = new IECExCertificateDetail()
            {
                Id = dtoIECExCertificateDetail.Id,
                Name = dtoIECExCertificateDetail.Name
            };

            await _imexDBContext.AddAsync(iecExCertificateDetail);
            await _imexDBContext.SaveChangesAsync();

            return dtoIECExCertificateDetail;
        }

        #endregion
    }

    public class ElectricalRatingRepository : IElectricalRatingRepository
    {
        private readonly IMExDbContext _imexDBContext;

        public ElectricalRatingRepository(IMExDbContext imexDbContext)
        {
            _imexDBContext = imexDbContext ?? throw new ArgumentNullException(nameof(imexDbContext));
        }

        #region Methods

        public async Task<IEnumerable<DTOElectricalRating>> GetElectricalRatings()
        {
            List<DTOElectricalRating> dtoElectricalRatings = await
                _imexDBContext.ElectricalRatings
                .Select(b =>
                new DTOElectricalRating()
                {
                    Id = b.Id,
                    Name = b.Name,
                }
            ).ToListAsync();

            return dtoElectricalRatings;
        }

        public async Task<DTOElectricalRating> CreateElectricalRating(DTOElectricalRating dtoElectricalRating)
        {
            ElectricalRating electricalRating = new ElectricalRating()
            {
                Id = dtoElectricalRating.Id,
                Name = dtoElectricalRating.Name
            };

            await _imexDBContext.AddAsync(electricalRating);
            await _imexDBContext.SaveChangesAsync();

            return dtoElectricalRating;
        }

        #endregion
    }

    public class DisciplineRepository : IDisciplineRepository
    {
        private readonly IMExDbContext _imexDBContext;

        public DisciplineRepository(IMExDbContext imexDbContext)
        {
            _imexDBContext = imexDbContext ?? throw new ArgumentNullException(nameof(imexDbContext));
        }

        #region Methods

        public async Task<IEnumerable<DTODiscipline>> GetDisciplines()
        {
            List<DTODiscipline> dtoDisciplines = await
                _imexDBContext.Disciplines
                .Select(b =>
                new DTODiscipline()
                {
                    Id = b.Id,
                    Name = b.Name,
                }
            ).ToListAsync();

            return dtoDisciplines;
        }

        #endregion
    }

    public class ProtectionTypeRepository : IProtectionTypeRepository
    {
        private readonly IMExDbContext _imexDBContext;

        public ProtectionTypeRepository(IMExDbContext imexDbContext)
        {
            _imexDBContext = imexDbContext ?? throw new ArgumentNullException(nameof(imexDbContext));
        }

        #region Methods

        public async Task<IEnumerable<DTOProtectionType>> GetProtectionTypes()
        {
            List<DTOProtectionType> dtoProtectionTypes = await
                _imexDBContext.ProtectionTypes
                .Select(b =>
                new DTOProtectionType()
                {
                    Id = b.Id,
                    Name = b.Name,
                }
            ).ToListAsync();

            return dtoProtectionTypes;
        }

        #endregion
    }

    public class EquipmentRepository : IEquipmentRepository
    {
        private readonly IMExDbContext _imexDBContext;

        public EquipmentRepository(IMExDbContext imexDbContext)
        {
            _imexDBContext = imexDbContext ?? throw new ArgumentNullException(nameof(imexDbContext));
        }

        #region Methods

        public async Task<IEnumerable<DTOEquipment>> GetEquipments()
        {
            List<DTOEquipment> dtoEquipments = await
                _imexDBContext.Equipments
                .Include(b => b.OPU)
                .Include(b => b.OPU.Business)
                .Include(b => b.OPU.Region)
                .Include(b => b.OPU.Field)
                .Include(b => b.Platform)
                .Include(b => b.LocationOne).Include(b => b.LocationTwo)
                .Include(b => b.HACDwgNo).Include(b => b.Coordinate).Include(b => b.Zone)
                .Include(b => b.Purpose)
                .Include(b => b.Manufacturer).Include(b => b.Model).Include(b => b.SerialNo)
                .Include(b => b.IECExCertificateAuthority).Include(b => b.IECExCertificateCategory).Include(b => b.IECExCertificateNo).Include(b => b.IECExCertificateDetail)
                .Include(b => b.ElectricalRating).Include(b => b.Discipline)
                .Include(b => b.ProtectionType)
                .Where(b => b.Active == true)
                .Select(b =>
                new DTOEquipment()
                {
                    Id = b.Id,
                    Id_OPU = b.Id_OPU,
                    OPU = b.OPU.Field.Name,
                    Id_Platform = b.Id_Platform,
                    Platform = b.Platform.Name,
                    Id_LocationOne = b.Id_LocationOne,
                    LocationOne = b.LocationOne.Name,
                    Id_LocationTwo = b.Id_LocationTwo,
                    LocationTwo = b.LocationTwo.Name,
                    Id_HACDwgNo = b.Id_HACDwgNo,
                    HACDwgNo = b.HACDwgNo.Name,
                    Id_Coordinate = b.Id_Coordinate,
                    Coordinate = b.Coordinate.Name,
                    Id_Zone = b.Id_Zone,
                    Zone = b.Zone.Name,
                    Id_Purpose = b.Id_Purpose,
                    Purpose = b.Purpose.Name,
                    Id_Manufacturer = b.Id_Manufacturer,
                    Manufacturer = b.Manufacturer.Name,
                    Id_Model = b.Id_Model,
                    Model = b.Model.Name,
                    Id_SerialNo = b.Id_SerialNo,
                    SerialNo = b.SerialNo.Name,
                    Id_IECExCertificateAuthority = b.Id_IECExCertificateAuthority,
                    IECExCertificateAuthority = b.IECExCertificateAuthority.Name,
                    Id_IECExCertificateCategory = b.Id_IECExCertificateCategory,
                    IECExCertificateCategory = b.IECExCertificateCategory.Name,
                    Id_IECExCertificateNo = b.Id_IECExCertificateNo,
                    IECExCertificateNo = b.IECExCertificateNo.No,
                    Id_IECExCertificateDetail = b.Id_IECExCertificateDetail,
                    IECExCertificateDetail = b.IECExCertificateDetail.Name,
                    Id_ElectricalRating = b.Id_ElectricalRating,
                    ElectricalRating = b.ElectricalRating.Name,
                    Id_Discipline = b.Id_Discipline,
                    Discipline = b.Discipline.Name,
                    Id_ProtectionType = b.Id_ProtectionType,
                    ProtectionType = b.ProtectionType.Name,
                    Name = b.Name,
                    TagNo = b.TagNo,
                    Active = b.Active,
                    Id_CreatedBy = b.Id_CreatedBy,
                    DateCreated = b.DateCreated,
                    Id_UpdatedBy = b.Id_UpdatedBy,
                    DateUpdated = b.DateUpdated,
                    Id_DeletedBy = b.Id_DeletedBy,
                    DateDeleted = b.DateDeleted
                }
            ).ToListAsync();

            return dtoEquipments;
        }

        public async Task<DTOEquipment> GetEquipment(Guid Id)
        {
            DTOEquipment? dtoEquipment = await
                _imexDBContext.Equipments
                .Include(b => b.OPU)
                .Include(b => b.OPU.Business)
                .Include(b => b.OPU.Region)
                .Include(b => b.OPU.Field)
                .Include(b => b.Platform)
                .Include(b => b.LocationOne).Include(b => b.LocationTwo)
                .Include(b => b.HACDwgNo).Include(b => b.Coordinate).Include(b => b.Zone)
                .Include(b => b.Purpose)
                .Include(b => b.Manufacturer).Include(b => b.Model).Include(b => b.SerialNo)
                .Include(b => b.IECExCertificateAuthority).Include(b => b.IECExCertificateCategory).Include(b => b.IECExCertificateNo).Include(b => b.IECExCertificateDetail)
                .Include(b => b.ElectricalRating).Include(b => b.Discipline)
                .Include(b => b.ProtectionType)
                .Where(b => b.Active == true)
                .Select(b =>
                new DTOEquipment()
                {
                    Id = b.Id,
                    Id_OPU = b.Id_OPU,
                    OPU = b.OPU.Field.Name,
                    Id_Platform = b.Id_Platform,
                    Platform = b.Platform.Name,
                    Id_LocationOne = b.Id_LocationOne,
                    LocationOne = b.LocationOne.Name,
                    Id_LocationTwo = b.Id_LocationTwo,
                    LocationTwo = b.LocationTwo.Name,
                    Id_HACDwgNo = b.Id_HACDwgNo,
                    HACDwgNo = b.HACDwgNo.Name,
                    Id_Coordinate = b.Id_Coordinate,
                    Coordinate = b.Coordinate.Name,
                    Id_Zone = b.Id_Zone,
                    Zone = b.Zone.Name,
                    Id_Purpose = b.Id_Purpose,
                    Purpose = b.Purpose.Name,
                    Id_Manufacturer = b.Id_Manufacturer,
                    Manufacturer = b.Manufacturer.Name,
                    Id_Model = b.Id_Model,
                    Model = b.Model.Name,
                    Id_SerialNo = b.Id_SerialNo,
                    SerialNo = b.SerialNo.Name,
                    Id_IECExCertificateAuthority = b.Id_IECExCertificateAuthority,
                    IECExCertificateAuthority = b.IECExCertificateAuthority.Name,
                    Id_IECExCertificateCategory = b.Id_IECExCertificateCategory,
                    IECExCertificateCategory = b.IECExCertificateCategory.Name,
                    Id_IECExCertificateNo = b.Id_IECExCertificateNo,
                    IECExCertificateNo = b.IECExCertificateNo.No,
                    Id_IECExCertificateDetail = b.Id_IECExCertificateDetail,
                    IECExCertificateDetail = b.IECExCertificateDetail.Name,
                    Id_ElectricalRating = b.Id_ElectricalRating,
                    ElectricalRating = b.ElectricalRating.Name,
                    Id_Discipline = b.Id_Discipline,
                    Discipline = b.Discipline.Name,
                    Id_ProtectionType = b.Id_ProtectionType,
                    ProtectionType = b.ProtectionType.Name,
                    Name = b.Name,
                    TagNo = b.TagNo,
                    Active = b.Active,
                    Id_CreatedBy = b.Id_CreatedBy,
                    DateCreated = b.DateCreated,
                    Id_UpdatedBy = b.Id_UpdatedBy,
                    DateUpdated = b.DateUpdated,
                    Id_DeletedBy = b.Id_DeletedBy,
                    DateDeleted = b.DateDeleted
                }
            ).SingleOrDefaultAsync(s => s.Id == Id);

            return dtoEquipment;
        }

        public async Task<DTOEquipment> CreateEquipment(DTOEquipment dtoEquipment)
        {
            dtoEquipment.Id = Guid.NewGuid();

            Equipment equipment = new Equipment()
            {
                Id = dtoEquipment.Id,
                Id_OPU = dtoEquipment.Id_OPU,
                Id_Platform = dtoEquipment.Id_Platform,
                Id_LocationOne = dtoEquipment.Id_LocationOne,
                Id_LocationTwo = dtoEquipment.Id_LocationTwo,
                Id_HACDwgNo = dtoEquipment.Id_HACDwgNo,
                Id_Coordinate = dtoEquipment.Id_Coordinate,
                Id_Zone = dtoEquipment.Id_Zone,
                Id_Purpose = dtoEquipment.Id_Purpose,
                Id_Manufacturer = dtoEquipment.Id_Manufacturer,
                Id_Model = dtoEquipment.Id_Model,
                Id_SerialNo = dtoEquipment.Id_SerialNo,
                Id_IECExCertificateAuthority = dtoEquipment.Id_IECExCertificateAuthority,
                Id_IECExCertificateCategory = dtoEquipment.Id_IECExCertificateCategory,
                Id_IECExCertificateNo = dtoEquipment.Id_IECExCertificateNo,
                Id_IECExCertificateDetail = dtoEquipment.Id_IECExCertificateDetail,
                Id_ElectricalRating = dtoEquipment.Id_ElectricalRating,
                Id_Discipline = dtoEquipment.Id_Discipline,
                Id_ProtectionType = dtoEquipment.Id_ProtectionType,
                Name = dtoEquipment.Name,
                TagNo = dtoEquipment.TagNo,
                Active = true,
                Id_CreatedBy = dtoEquipment.Id_CreatedBy,
                DateCreated = DateTime.UtcNow
            };

            await _imexDBContext.AddAsync(equipment);
            await _imexDBContext.SaveChangesAsync();

            return dtoEquipment;
        }

        public async Task<DTOEquipment> UpdateEquipment(Guid Id, DTOEquipment dtoEquipment)
        {
            Equipment? curEquipment = await 
                _imexDBContext.Equipments
                .Where(b => b.Active == true)
                .FirstOrDefaultAsync(x => x.Id == Id);

            if (curEquipment != null)
            {
                if (dtoEquipment.Id_OPU != curEquipment.Id_OPU) { curEquipment.Id_OPU = dtoEquipment.Id_OPU; };
                if (dtoEquipment.Id_Platform != curEquipment.Id_Platform) { curEquipment.Id_Platform = dtoEquipment.Id_Platform; };
                if (dtoEquipment.Id_LocationOne != curEquipment.Id_LocationOne) { curEquipment.Id_LocationOne = dtoEquipment.Id_LocationOne; };
                if (dtoEquipment.Id_LocationTwo != curEquipment.Id_LocationTwo) { curEquipment.Id_LocationTwo = dtoEquipment.Id_LocationTwo; };
                if (dtoEquipment.Id_HACDwgNo != curEquipment.Id_HACDwgNo) { curEquipment.Id_HACDwgNo = dtoEquipment.Id_HACDwgNo; };
                if (dtoEquipment.Id_Coordinate != curEquipment.Id_Coordinate) { curEquipment.Id_Coordinate = dtoEquipment.Id_Coordinate; };
                if (dtoEquipment.Id_Zone != curEquipment.Id_Zone) { curEquipment.Id_Zone = dtoEquipment.Id_Zone; };
                if (dtoEquipment.Id_Purpose != curEquipment.Id_Purpose) { curEquipment.Id_Purpose = dtoEquipment.Id_Purpose; };
                if (dtoEquipment.Id_Manufacturer != curEquipment.Id_Manufacturer) { curEquipment.Id_Manufacturer = dtoEquipment.Id_Manufacturer; };
                if (dtoEquipment.Id_Model != curEquipment.Id_Model) { curEquipment.Id_Model = dtoEquipment.Id_Model; };
                if (dtoEquipment.Id_SerialNo != curEquipment.Id_SerialNo) { curEquipment.Id_SerialNo = dtoEquipment.Id_SerialNo; };
                if (dtoEquipment.Id_IECExCertificateAuthority != curEquipment.Id_IECExCertificateAuthority) { curEquipment.Id_IECExCertificateAuthority = dtoEquipment.Id_IECExCertificateAuthority; };
                if (dtoEquipment.Id_IECExCertificateCategory != curEquipment.Id_IECExCertificateCategory) { curEquipment.Id_IECExCertificateCategory = dtoEquipment.Id_IECExCertificateCategory; };
                if (dtoEquipment.Id_IECExCertificateNo != curEquipment.Id_IECExCertificateNo) { curEquipment.Id_IECExCertificateNo = dtoEquipment.Id_IECExCertificateNo; };
                if (dtoEquipment.Id_IECExCertificateDetail != curEquipment.Id_IECExCertificateDetail) { curEquipment.Id_IECExCertificateDetail = dtoEquipment.Id_IECExCertificateDetail; };
                if (dtoEquipment.Id_ElectricalRating != curEquipment.Id_ElectricalRating) { curEquipment.Id_ElectricalRating = dtoEquipment.Id_ElectricalRating; };
                if (dtoEquipment.Id_Discipline != curEquipment.Id_Discipline) { curEquipment.Id_Discipline = dtoEquipment.Id_Discipline; };
                if (dtoEquipment.Id_ProtectionType != curEquipment.Id_ProtectionType) { curEquipment.Id_ProtectionType = dtoEquipment.Id_ProtectionType; };
                if (dtoEquipment.Name != curEquipment.Name) { curEquipment.Name = dtoEquipment.Name; };
                if (dtoEquipment.TagNo != curEquipment.TagNo) { curEquipment.TagNo = dtoEquipment.TagNo; };
                curEquipment.Id_UpdatedBy = dtoEquipment.Id_UpdatedBy;
                curEquipment.DateUpdated = DateTime.UtcNow;

                _imexDBContext.Entry(curEquipment).State = EntityState.Modified;

                await _imexDBContext.SaveChangesAsync();
            }

            return dtoEquipment;
        }

        public async Task<Guid> DeleteEquipment(Guid Id)
        {
            Equipment? curEquipment = await 
                _imexDBContext.Equipments
                .Where(b => b.Active == true)
                .FirstOrDefaultAsync(x => x.Id == Id);

            if (curEquipment != null)
            {
                curEquipment.Active = false;
                curEquipment.Id_DeletedBy = new Guid("eb47cb7a-eeae-4867-be98-8566a9ffe208"); // To Update
                curEquipment.DateDeleted = DateTime.UtcNow;

                _imexDBContext.Entry(curEquipment).State = EntityState.Modified;

                await _imexDBContext.SaveChangesAsync();

                return Id;
            }

            return Guid.Empty;
        }

        #endregion
    }
}
