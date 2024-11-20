using System.ComponentModel.DataAnnotations;

namespace yurtyonetimibackend.models
{
    public class User
    {
       [Key] public int user_id { get; set; }
        public string tc { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string rol { get; set; }
        public string sifre { get; set; }


    }
}
