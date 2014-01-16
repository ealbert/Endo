namespace Endo.Web.Mappings
{
  using AutoMapper;
  using Domain.Entities;
  using Models;

  public class EntityToModel
  {
    public static void Install()
    {
      Mapper.CreateMap<Patient, PatientModel>();
    }
  }
}