using RM.Lib;
using RM.Lib.Server;
using RM.Pep.Shared.Session;
using $prefixoprojeto$.$dominio$.IService.Interface;
using $prefixoprojeto$.$dominio$.IService.Model;
using $safeprojectname$.Mapper;
using $safeprojectname$.Negocio;
using System.Collections.Generic;

namespace $safeprojectname$
{
  public class Pep$dominio$Modulo : RMSModule, IPep$dominio$Modulo
  {
    private IPep$dominio$Servico _servico;

    private IPep$dominio$Servico servico
    {
      get
      {
        if (_servico is null)
        {
          _servico = DI.Pep$dominio$Configuracao.Configure()
            .Resolve < IPep$dominio$Servico > (DBS);
        };

        return _servico;
      }
    }

    public Pep$dominio$UIModel Detalhar(int cod$dominio$)
    {
      return servico.Detalhar(UserServices.Instance.CompanyId, cod$dominio$).ToUIModel();
    }

    public IEnumerable<Pep$dominio$UIModel> Listar$dominio$s(RMSApiQuery apiQuery)
    {
      return _servico.Listar$dominio$s(UserServices.Instance.CompanyId, apiQuery).ToUIModel();            
    }
  }
}