using RM.Lib;
using System.Collections.Generic;
using $safeprojectname$.Model;

namespace $safeprojectname$
{
  public class Pep$dominio$Servico : IPep$dominio$Servico
  {
    private readonly IPep$dominio$Repositorio _repositorio;

    public Pep$dominio$Servico(IPep$dominio$Repositorio repositorio)
    {
      _repositorio = repositorio;
    }

    public IEnumerable<Pep$dominio$Negocio> Listar$dominio$s(int codColigada, RMSApiQuery apiQuery)
    {
      return _repositorio.Listar$dominio$s(codColigada, apiQuery);
    }

    public Pep$dominio$Negocio Detalhar(int codColigada, int cod$dominio$)
  {
      return _repositorio.Detalhar(codColigada, cod$dominio$);
    }
  }
}