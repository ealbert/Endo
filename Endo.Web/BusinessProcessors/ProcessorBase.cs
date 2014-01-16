namespace Endo.Web.BusinessProcessors
{
  using System;
  using Domain.Repository;
  using Domain.Services;

  public abstract class ProcessorBase
  {
    protected TResult ExecuteCommand<TResult>(Func<IRepositoryLocator, TResult> command) where TResult : class
    {
      using (var transManager = EndoContainer.GlobalContext.TransFactory.CreateManager())
      {
        return transManager.ExecuteCommand(command);
      }
    }
  }
}