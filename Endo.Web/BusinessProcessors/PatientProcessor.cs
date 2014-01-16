using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Endo.Web.BusinessProcessors
{
  using System.ComponentModel;
  using AutoMapper;
  using Domain.Entities;
  using Domain.Operations;
  using Domain.Repository;
  using Models;

  public class PatientProcessor : ProcessorBase
  {
    public PatientModel CreatePatient(PatientModel model)
    {
      return ExecuteCommand(locator => CreatePatientImpl(locator, model));
    }

    private PatientModel CreatePatientImpl(IRepositoryLocator locator, PatientModel model)
    {
      var operation = Mapper.Map<PatientModel, PatientOperation>(model);
      var instance = Patient.Create(locator, operation);
      return Mapper.Map<Patient, PatientModel>(instance);
    }
  }
}
