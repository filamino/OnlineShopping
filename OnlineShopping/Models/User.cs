using System.ComponentModel.DataAnnotations;

namespace OnlineShopping.Models
{
    public class User
    {
  
            public int Id { get; set; }

            [Required(ErrorMessage = "Please enter your username.")]
            public string? UserName { get; set; }

            [Required(ErrorMessage = "Please enter your email address.")]

            [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Please enter your password.")]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            public string Name { get; set; }
            public string Address {  get; set; }
            public string Phone { get; set; }

        public User(int id, string userName, string email, string password, string name, string address, string phone)
        {
            Id = id;
            Email = email;
            UserName = userName;
            Email = email;
            Password= password;
            Name = name;
            Address = address;
            Phone = phone;

        }
           
            }
}
