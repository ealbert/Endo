namespace Endo.EF.TransManager
{
  using Endo.Domain.TransManager;
  using Endo.EF.DbContext;

  public class TransManagerFactoryEF
    : ITransFactory
  {
    public IModelCreator ModelCreator { get; private set; }

    public TransManagerFactoryEF(IModelCreator modelCreator)
    {
      ModelCreator = modelCreator;
    }

    #region Implementation of ITransFactory

    public ITransManager CreateManager()
    {
      return new TransManagerEF(new EndoDbContext(ModelCreator));
    }

    #endregion
  }
}
