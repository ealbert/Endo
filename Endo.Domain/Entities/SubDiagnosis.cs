namespace Endo.Domain.Entities
{
  public class SubDiagnosis : EntityBase
  {
    #region Constructors

    protected SubDiagnosis(){}

    #endregion
    #region Persisted Properties

    public Diagnosis Diagnosis { get; private set; }
    public string Code { get; private set; }
    public string Name { get; private set; }

    #endregion    
  }
}