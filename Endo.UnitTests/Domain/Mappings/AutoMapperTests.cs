using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endo.UnitTests.Domain.Mappings
{
  using AutoMapper;
  using Endo.Domain.Mappings;
  using Microsoft.VisualStudio.TestTools.UnitTesting;
  using Web.Mappings;


  [TestClass]
  public class AutoMapperTests
  {
    [TestMethod]
    public void CheckMappings()
    {
      OperationToEntity.Install();
      ModelToOperation.Install();
      Mapper.AssertConfigurationIsValid();

    }
  }
}
