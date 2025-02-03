using System.ComponentModel.DataAnnotations;
using HotelierProject.EntityLayer;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HotelierProject.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage = "Ad Alanı Gereklidir")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyad Alanı Gereklidir")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Kullanıcı Adı Alanı Gereklidir")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Mail Alanı Gereklidir")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Şifre Alanı Gereklidir")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre Tekrar Alanı Gereklidir")]
        [Compare("Password", ErrorMessage = "Şifreler Uyuşmuyor")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "cinsiyet Alanı Gereklidir")]
        public string Gender { get; set; }
       
        [Required(ErrorMessage = "Çalışma Lokasyonu Gereklidir")]
        public int WorkLocationID { get; set; }
        public string WorkDepartment { get; set; }
        public string City { get; set; }

    }
}

