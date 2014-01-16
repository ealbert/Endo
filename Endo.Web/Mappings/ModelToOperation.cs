using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Endo.Web.Mappings
{
  using AutoMapper;
  using Domain.Operations;
  using Models;

  public class ModelToOperation
  {
    public static void Install()
    {
      Mapper.CreateMap<PatientModel, PatientOperation>();
    }
  }
}