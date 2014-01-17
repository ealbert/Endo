using System;
using System.Linq;
using System.Web;

namespace Endo.Web.Models
{
  using System.ComponentModel.DataAnnotations;
  using Domain.Entities;

  public class PatientModel
  {

    public PatientModel()
    {
      // Default values
      Gender = Gender.Unknown;
    }

    public long Id { get; set; }

    [StringLength(10), Required, Display(Name = "Medical Record Number")]
    public string Mrn { get; set; }    

    [Required, Display(Name = "Date of Birth")]
    [DataType(DataType.Date)]
    public DateTime? Dob { get; set; }

    [StringLength(30), Required, Display(Name = "Patient Alias", Description = "A tag that helps to identify the patient")]
    public string Alias { get; set; }

    [Required]
    public Gender Gender { get; set; }

    [Required, Display(Name = "First Visit Date") ]
    [DataType(DataType.Date)]
    public DateTime FirstVisitDate { get; set; }


    public string Comment { get; set; }
  }
}