using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endo.EF.Mappings
{
  using System.Data.Entity;
  using System.Data.Entity.ModelConfiguration.Conventions;
  using Domain.Entities;
  using TransManager;

  public class ModelCreator : IModelCreator
  {
    #region Implementation of IModelCreator

    public void OnModelCreating(DbModelBuilder modelBuilder)
    {
      modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
      modelBuilder.Configurations
                  .Add(new Patient.Mapping())
                  .Add(new Diagnosis.Mapping());

    }

    #endregion
  }
}
