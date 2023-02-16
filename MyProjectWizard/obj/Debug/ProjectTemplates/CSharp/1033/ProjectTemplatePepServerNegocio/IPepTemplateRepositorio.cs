using RM.Lib;
using System.Collections.Generic;
using $safeprojectname$.Model;

namespace $safeprojectname$
{
  public interface IPep$dominio$Repositorio
  {
    IEnumerable<Pep$dominio$Negocio> Listar$dominio$s(int codColigada, RMSApiQuery apiQuery);
    Pep$dominio$Negocio Detalhar(int codColigada, int cod$dominio$);
  }
}
