using ReflexoterapiasBackEnd.Domain.Enums;


namespace ReflexoterapiasBackEnd.Domain.Entities
{
    public class User : EntityBase
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;

        public RoleEnum Role { get; set; }
    }
}
