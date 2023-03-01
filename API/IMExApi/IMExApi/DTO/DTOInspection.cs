namespace IMExApi.DTO
{
    public class DTOInspection
    {
        #region Field Definition

        public Guid Id { get; set; }
        public Guid Id_OPU { get; set; }
        public string OPU { get; set; }
        public Guid Id_Platform { get; set; }
        public string Platform { get; set; }
        public Guid Id_Discipline { get; set; }
        public string Discipline { get; set; }
        public Guid Id_User { get; set; }
        public string User { get; set; }
        public Guid Id_InspectionType { get; set; }
        public string InspectionType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateInspectionStart { get; set; }
        public DateTime DateInspectionEnd { get; set; }
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
