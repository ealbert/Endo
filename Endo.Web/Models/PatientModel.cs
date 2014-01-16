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

    [StringLength(10), Required]
    public string Mrn { get; set; }    

    [Required]
    [DataType(DataType.Date)]
    public DateTime? Dob { get; set; }

    [StringLength(30), Required]
    public string Alias { get; set; }

    [Required]
    public Gender Gender { get; set; }
  }
}