using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endo.Domain.Operations
{
  using Entities;

  public class PatientOperation
  {
    public long Id { get; set; }
    public string Mrn { get; set; }
    public DateTime Dob { get; set; }
    public string Alias { get; set; }
    public Gender Gender { get; set; }
  }
}
