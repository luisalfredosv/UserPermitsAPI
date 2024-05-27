namespace UserPermitsAPI.Models
{
    public class PermissionType
    {
        public int Id { get; set; }
        public required string Description { get; set; }
        public ICollection<Permission>? Permissions { get; set; }
    }
}