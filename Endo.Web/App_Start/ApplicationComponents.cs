using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Endo.Web.App_Start
{
  using Domain.Mappings;
  using Domain.Services;
  using EF.Mappings;
  using EF.TransManager;
  using Mappings;

  public class ApplicationComponents
  {
    public static void Register()
    {
      EndoContainer.GlobalContext.TransFactory = new TransManagerFactoryEF(new ModelCreator());
      OperationToEntity.Install();      
      EntityToModel.Install();
      ModelToOperation.Install();
    }
  }
}