using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endo.Domain.Entities
{
  using Repository;

  public class Diagnosis : EntityBase
  {
    #region Constructors

    protected Diagnosis()
    {
      SubDiagnosisSet = new HashSet<SubDiagnosis>();
    }

    public static Diagnosis Create(IRepositoryLocator locator, string name)
    {
      var instance = new Diagnosis {Name = name};
      return locator.Save(instance);
    }

    #endregion    
    #region Persisted Properties

    public string Name { get; protected set; }
    protected virtual ICollection<SubDiagnosis> SubDiagnosisSet { get; set; }

    #endregion
    #region Public Methods

    public IEnumerable<SubDiagnosis> SubDiagnoses()
    {
      return SubDiagnosisSet;
    }

    #endregion

    public class Mapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Diagnosis>
    {
      public Mapping()
      {
        HasMany(d => d.SubDiagnosisSet).WithRequired(sd => sd.Diagnosis);
      }
    }
  }
}
