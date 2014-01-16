namespace Endo.Web.Models
{
  using System.Collections.Generic;

  public class PatientSearchModel
  {
    public PatientModel PatientModel { get; set; }
    public List<PatientModel> SearchRecords { get; set; }
  }
}