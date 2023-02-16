using RM.Lib;
using RM.Lib.CustomAttributes;
using $safeprojectname$.Model;
using System.Collections.Generic;

namespace $safeprojectname$.Interface
{
  [ConcreteClassNameAtribute("Pep$dominio$ApiServer")]
  public interface IPep$dominio$ApiServer : IRMSServer
  {
    IEnumerable<Pep$dominio$UIModel> Listar$dominio$s(RMSApiQuery apiQuery);
    Pep$dominio$UIModel Detalhar(int cod$dominio$);
  }
}
