namespace IMExApi.DTO
{
    public class DTOPlatform
    {
        #region Field Definition

        public Guid Id { get; set; }
        public string Name { get; set; }

        #endregion
    }

    public class DTOLocationOne
    {
        #region Field Definition

        public Guid Id { get; set; }
        public string Name { get; set; }

        #endregion
    }

    public class DTOLocationTwo
    {
        #region Field Definition

        public Guid Id { get; set; }
        public string Name { get; set; }

        #endregion
    }

    public class DTOHACDwgNo
    {
        #region Field Definition

        public Guid Id { get; set; }
        public string Name { get; set; }

        #endregion
    }

    public class DTOCoordinate
    {
        #region Field Definition

        public Guid Id { get; set; }
        public string Name { get; set; }

        #endregion
    }

    public class DTOZone
    {
        #region Field Definition

        public Guid Id { get; set; }
        public string Name { get; set; }

        #endregion
    }

    public class DTOPurpose
    {
        #region Field Definition

        public Guid Id { get; set; }
        public string Name { get; set; }

        #endregion
    }

    public class DTOManufacturer
    {
        #region Field Definition

        public Guid Id { get; set; }
        public string Name { get; set; }

        #endregion
    }

    public class DTOModel
    {
        #region Field Definition

        public Guid Id { get; set; }
        public string Name { get; set; }

        #endregion
    }

    public class DTOSerialNo
    {
        #region Field Definition

        public Guid Id { get; set; }
        public string Name { get; set; }

        #endregion
    }

    public class DTOIECExCertificateAuthority
    {
        #region Field Definition

        public Guid Id { get; set; }
        public string Name { get; set; }

        #endregion
    }

    public class DTOIECExCertificateCategory
    {
        #region Field Definition

        public Guid Id { get; set; }
        public string Name { get; set; }

        #endregion
    }

    public class DTOIECExCertificateNo
    {
        #region Field Definition

        public Guid Id { get; set; }
        public string No { get; set; }

        #endregion
    }

    public class DTOIECExCertificateDetail
    {
        #region Field Definition

        public Guid Id { get; set; }
        public string Name { get; set; }

        #endregion
    }

    public class DTOElectricalRating
    {
        #region Field Definition

        public Guid Id { get; set; }
        public string Name { get; set; }

        #endregion
    }

    public class DTODiscipline
    {
        #region Field Definition

        public Guid Id { get; set; }
        public string Name { get; set; }

        #endregion
    }

    public class DTOProtectionType
    {
        #region Field Definition

        public Guid Id { get; set; }
        public string Name { get; set; }

        #endregion
    }

    public class DTOEquipment
    {
        #region Field Definition

        public Guid Id { get; set; }
        public Guid Id_OPU { get; set; }
        public string OPU { get; set; }
        public Guid Id_Platform { get; set; }
        public string Platform { get; set; }
        public Guid Id_LocationOne { get; set; }
        public string LocationOne { get; set; }
        public Guid Id_LocationTwo { get; set; }
        public string LocationTwo { get; set; }
        public Guid Id_HACDwgNo { get; set; }
        public string HACDwgNo { get; set; }
        public Guid Id_Coordinate { get; set; }
        public string Coordinate { get; set; }
        public Guid Id_Zone { get; set; }
        public string Zone { get; set; }
        public Guid Id_Purpose { get; set; }
        public string Purpose { get; set; }
        public Guid Id_Manufacturer { get; set; }
        public string Manufacturer { get; set; }
        public Guid Id_Model { get; set; }
        public string Model { get; set; }
        public Guid Id_SerialNo { get; set; }
        public string SerialNo { get; set; }
        public Guid Id_IECExCertificateAuthority { get; set; }
        public string IECExCertificateAuthority { get; set; }
        public Guid Id_IECExCertificateCategory { get; set; }
        public string IECExCertificateCategory { get; set; }
        public Guid Id_IECExCertificateNo { get; set; }
        public string IECExCertificateNo { get; set; }
        public Guid Id_IECExCertificateDetail { get; set; }
        public string IECExCertificateDetail { get; set; }
        public Guid Id_ElectricalRating { get; set; }
        public string ElectricalRating { get; set; }
        public Guid Id_Discipline { get; set; }
        public string Discipline { get; set; }
        public Guid Id_ProtectionType { get; set; }
        public string ProtectionType { get; set; }
        public string Name { get; set; }
        public string TagNo { get; set; }
        public bool Active { get; set; }
        public Guid Id_CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid Id_UpdatedBy { get; set; }
        public DateTime DateUpdated { get; set; }
        public Guid Id_DeletedBy { get; set; }
        public DateTime DateDeleted { get; set; }

        #endregion
    }
}
