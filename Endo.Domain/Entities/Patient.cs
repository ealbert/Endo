using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endo.Domain.Entities
{
  using AutoMapper;
  using Operations;
  using Repository;

  public class Patient : EntityBase
  {
    #region Constructors

    protected Patient(){}

    public static Patient Create(IRepositoryLocator locator, PatientOperation operation, string usrName)
    {
      var instance = Mapper.Map<PatientOperation, Patient>(operation);
      return locator.Save(instance);
    }

    #endregion
    #region Persisted Properties

    public string Mrn { get; private set; }
    public DateTime Dob { get; private set; }
    public string Alias { get; private set; }
    public Gender Gender { get; private set; }

    public DateTime FirstVisitDate { get; private set; }
    public string Comment { get; private set; }

    #endregion
    #region EF Model

    public class Mapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Patient>
    {
      public Mapping()
      {
      }
    }

    #endregion
  }
}
