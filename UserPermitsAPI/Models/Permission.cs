namespace UserPermitsAPI.Models
{
    public class Permission
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int PermissionTypeId { get; set; }
        public required PermissionType PermissionType { get; set; }
    }
}
