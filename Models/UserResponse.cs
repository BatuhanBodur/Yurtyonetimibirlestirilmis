public class UserResponse
{
    public string Message { get; set; } // Yan�t mesaj�
    public UserDetails User { get; set; } // Kullan�c� detaylar�
}

public class UserDetails
{
    public int UserId { get; set; } // Kullan�c� ID'si
    public string Ad { get; set; } // Kullan�c� ad�
    public string Soyad { get; set; } // Kullan�c� soyad�
    public string Rol { get; set; } // Kullan�c� rol� (�r: ��renci, admin)
}