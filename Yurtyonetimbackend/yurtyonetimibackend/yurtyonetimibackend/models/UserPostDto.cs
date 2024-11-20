using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace yurtyonetimibackend.models
{
    
    public class UserPostDto 
    {
        public string tc { get; set; }
        public string UserPassword { get; set; }
    }
}
