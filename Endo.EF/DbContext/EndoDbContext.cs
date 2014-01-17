namespace Endo.EF.DbContext
{
  using System.Data.Entity;
  using Domain.TransManager;
  using TransManager;

  public class EndoDbContext : DbContext
  {
    public IModelCreator ModelCreator { get; private set; }

    public EndoDbContext(IModelCreator modelCreator)
      : base("EndoDb")
    {
      ModelCreator = modelCreator;
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);
      ModelCreator.OnModelCreating(modelBuilder);      
    }    
  }
}