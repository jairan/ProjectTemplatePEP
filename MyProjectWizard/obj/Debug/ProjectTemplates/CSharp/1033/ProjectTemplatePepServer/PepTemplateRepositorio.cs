using RM.Lib;
using RM.Lib.Data;
using RM.Lib.Server;
using $safeprojectname$.DBModel;
using $safeprojectname$.Mapper;
using $safeprojectname$.Negocio;
using $safeprojectname$.Negocio.Model;
using $safeprojectname$.Queries;
using System.Collections.Generic;
using System.Linq;

namespace $safeprojectname$
{
  public class Pep$dominio$Repositorio : RMSObject, IPep$dominio$Repositorio
  {
    public Pep$dominio$Repositorio(IDbServices dbs)
    {
      DBS = dbs;
    }

    public IEnumerable<Pep$dominio$Negocio> Listar$dominio$s(int codColigada, RMSApiQuery apiQuery)
    {
      var parameters = new Dictionary<string, object>
      {
        { "CODCOLIGADA", codColigada },
      };
      return DBS.GetAll<Pep$dominio$DBModel>(
        Pep$dominio$Queries.Listar$dominio$s(DBS.Dialect),
        parameters).ToNegocio();
    }

    public Pep$dominio$Negocio Detalhar(int codColigada, int codChecagemOncologia)
    {
      var parameters = new Dictionary<string, object>
      {
        { "CODIGO", cod$dominio$ }
      };

      return DBS.Get<Pep$dominio$DBModel>(
        Pep$dominio$Queries.Detalhar(DBS.Dialect),
        parameters).ToNegocio();
    }
  }
}
