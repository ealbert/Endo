using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Endo.Web.BusinessProcessors
{
  using System.ComponentModel;
  using System.Security.Principal;
  using AutoMapper;
  using Domain.Entities;
  using Domain.Operations;
  using Domain.Repository;
  using Models;

  public class PatientProcessor : ProcessorBase
  {
    public PatientModel CreatePatient(PatientModel model, IIdentity identity)
    {
      return ExecuteCommand(locator => CreatePatientImpl(locator, model, identity));
    }

    private PatientModel CreatePatientImpl(IRepositoryLocator locator, PatientModel model, IIdentity identity)
    {
      var operation = Mapper.Map<PatientModel, PatientOperation>(model);
      var usrName = identity != null ? identity.Name : "unknown";
      var instance = Patient.Create(locator, operation, usrName);
      return Mapper.Map<Patient, PatientModel>(instance);
    }

    public List<PatientModel> SearchForPatient(PatientModel model)
    {
      return ExecuteCommand(locator => SearchForPatientImpl(locator, model));
    }

    private List<PatientModel> SearchForPatientImpl(IRepositoryLocator locator, PatientModel model)
    {
      var query = locator.FindAll<Patient>();
      if (model.Gender != Gender.Unknown) query = query.Where(p => p.Gender == model.Gender);
      if (!string.IsNullOrEmpty(model.Alias)) query = query.Where(p => p.Alias.Contains(model.Alias));
      if (model.Dob.HasValue) query = query.Where(p => p.Dob == model.Dob);
      if (!string.IsNullOrEmpty(model.Mrn)) query = query.Where(p => p.Mrn.Contains(model.Mrn));
      return Mapper.Map<List<Patient>, List<PatientModel>>(query.ToList());
    }
  }
}
