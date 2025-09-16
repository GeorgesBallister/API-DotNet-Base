namespace APIAprendendo.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public bool Is_Active { get; set; } = true;
        public string Created_At { get; set; }
        public string Updated_At { get; set; }

    }
}
