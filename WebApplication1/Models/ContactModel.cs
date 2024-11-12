using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplication1.Models;

public class ContactModel
{
    [HiddenInput]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Musisz wpisać imie!")]
    [MaxLength(length:20, ErrorMessage = "Imie zbyt długie")]
    [Display(Name = "Imię")]
    public string FirstName { get; set; }
    
    [Required(ErrorMessage = "Musisz wpisać nazwisko!")]
    [MaxLength(length:50, ErrorMessage = "Nazwisko zbyt długie zbyt długie")]
    [Display(Name = "Nazwisko")]
    public string LastName { get; set; }
    
    [EmailAddress(ErrorMessage = "Niepoprawny format adresu email!")]
    [Display(Name = "Email")]
    public string Email { get; set; }
    
    [Phone(ErrorMessage = "Wpisz poprawny numer telefonu")]
    [RegularExpression("\\d\\d\\d \\d\\d\\d \\d\\d\\d", ErrorMessage = "Wpisz numer w formacie XXX XXX XXX!")]
    [Display(Name = "Telefon")]
    public string PhoneNumber { get; set; }
    
    [DataType(DataType.Date)]
    [Display(Name = "Data urodzenia")]
    public DateTime BirthDate { get; set; }
    
    [Display(Name = "Kategoria")]
    public Category Category { get; set; }
    
    [HiddenInput] public int OrganizationId { get; set; }
    
    [ValidateNever] public List<SelectListItem>? Organizations { get; set; }
}