using $safeprojectname$.Negocio;
using RM.Pep.CrossCutting.Contracts;
using RM.Pep.Shared.DI;

namespace $safeprojectname$.DI
{
  public static class Pep$dominio$Configuracao
  {
    public static IResolver Configure()
    {
      return Resolver.Create()
        .AddResolver<IPep$dominio$Repositorio > (x => new Pep$dominio$Repositorio(x.DBS))
        .AddResolver<IPep$dominio$Servico > (x => CriarPep$dominio$Servico(x));
    }

    private static IPep$dominio$Servico CriarPep$dominio$Servico(IResolver resolver)
    {
      var repositorio = resolver.Resolve< IPep$dominio$Repositorio > ();
      return new Pep$dominio$Servico(repositorio);
    }
  }
}

