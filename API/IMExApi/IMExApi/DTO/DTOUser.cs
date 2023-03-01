namespace IMExApi.DTO
{
    public class DTOUser
    {
        #region Field Definition

        public Guid Id { get; set; }
        public Guid Id_OPU { get; set; }
        public string OPU { get; set; }
        public Guid Id_Role { get; set; }
        public string Role { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime DateValidStart { get; set; }
        public DateTime DateValidEnd { get; set; }
        public bool Active { get; set; }
        public Guid Id_CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid Id_UpdatedBy { get; set; }
        public DateTime DateUpdated { get; set; }
        public Guid Id_DeletedBy { get; set; }
        public DateTime DateDeleted { get; set; }

        #endregion
    }

    public class DTOOPU
    {
        #region Field Definition

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        #endregion
    }

    public class DTORole
    {
        #region Field Definition

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        #endregion
    }
}
