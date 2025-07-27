using System.ComponentModel.DataAnnotations;

namespace OOPPartialTypes;

public class StudentMetaData
{
    [Display(Name = "Student Name")]
    [StringLength(50,MinimumLength = 2,ErrorMessage = "Invalid Name")]
    public string StudentName { get; set; }
    
    [Display(Name = "Home Address")] 
    [StringLength(50,MinimumLength = 2,ErrorMessage = "Invalid Address")] 
    public string HomeAddress { get; set; }
    
    [Display(Name = "Base Country")] 
    [StringLength(50,MinimumLength = 2,ErrorMessage = "Invalid Country")] 
    public string BaseCountry { get; set; }
}