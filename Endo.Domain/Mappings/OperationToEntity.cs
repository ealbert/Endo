using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endo.Domain.Mappings
{
  using AutoMapper;
  using Entities;
  using Operations;

  public static class OperationToEntity
  {
    public static void Install()
    {
      Mapper.CreateMap<PatientOperation, Patient>();
    }
  }
}
