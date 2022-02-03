namespace Data.DTOs
{
    public class AuthResponse
    {
        public string Token { get; set; }
        public AppUserDTO User { get; set; }
    }
}