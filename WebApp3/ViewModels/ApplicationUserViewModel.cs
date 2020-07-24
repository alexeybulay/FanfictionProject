using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using WebApp3.Models;

namespace WebApp3.ViewModels
{
    public class ApplicationUserViewModel
    {
        public string Name { get; set; }
        public IFormFile ProfileImage { get; set; }
        private UserManager<ApplicationUser> _userManager;

        public ApplicationUserViewModel(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            Name = "3e076cd4-4411-409c-8353-5684fce5aa12-fonstola.ru-173068 (1).jpg";
        }
    }
}
