using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repopattern.Models
{
    [Table("UserDetails")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(Order=0)]
        public int UserCode { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(10, ErrorMessage = "Maximum 10 characters can be added")]
        [MinLength(6, ErrorMessage = "Min 6 characaters needed")]
        [RegularExpression("[A-Z a-z]+", ErrorMessage = "Only alphabets allowed")]

        [Column("UserName", Order =3)]
        public string Name { get; set; }



        [Column(Order =1)]
        [Required(ErrorMessage = "Manager Name is must")]
        [RegularExpression("[A-Z a-z]+", ErrorMessage = "Only alphabets allowed")]
        public string Manager { get; set; }

        [Column(Order = 2)]
        [Required(ErrorMessage = "JoinigYear Year is Required")]
        [Range(2020, 2024, ErrorMessage = "Range should be in 2020 - 2024")]
        public int JoinigYear { get; set; }

        [Column(Order = 5)]
        [Required(ErrorMessage = "Password is must")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "Passsord is must")]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ReTypePassword { get; set; }

        [Column(Order = 4)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Dob { get; set; }

    }
}
