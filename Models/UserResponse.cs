public class UserResponse
{
    public string Message { get; set; } // Yanýt mesajý
    public UserDetails User { get; set; } // Kullanýcý detaylarý
}

public class UserDetails
{
    public int UserId { get; set; } // Kullanýcý ID'si
    public string Ad { get; set; } // Kullanýcý adý
    public string Soyad { get; set; } // Kullanýcý soyadý
    public string Rol { get; set; } // Kullanýcý rolü (ör: öðrenci, admin)
}