using System.Collections.Generic;
using RM.Lib;
using RM.Lib.Server;
using RM.Pep.Shared.Session;
using RM.Pep.Extensions
using $prefixoprojeto$.$dominio$.IService.Interface;
using $prefixoprojeto$.$dominio$.IService.Model;
using $safeprojectname$.DI;
using $safeprojectname$.Mapper;
using $safeprojectname$.Negocio;
using Res = $safeprojectname$.Properties.Resources;


namespace $safeprojectname$
{
  [RM.Lib.RMSServerInfo(typeof(Res), nameof(Res.PEP$dominio$), RM.Lib.CodSistema.Sau)]
  public class Pep$dominio$ApiServer : RMSServer, IPep$dominio$ApiServer
  {
    private readonly IPep$dominio$Servico _servico;

    public Pep$dominio$ApiServer()
    {
      InitServer();
      _servico = Pep$dominio$Configuracao.Configure().Resolve < IPep$dominio$Servico > (DBS);
    }

    public Pep$dominio$UIModel Detalhar(int cod$dominio$)
    {
      return _servico
        .Detalhar(UserServices.Instance.CompanyId, cod$dominio$).ToUIModel();
    }

    public IEnumerable<Pep$dominio$UIModel> Listar$dominio$s(RMSApiQuery apiQuery)
    {
      return _servico.Listar$dominio$s(UserServices.Instance.CompanyId, apiQuery).ToUIModel();
    }

    public Pep$dominio$UIModel Inserir$dominio$(Pep$dominio$UIModel)
    {
      return this.ExecutarMetodoServico(() =>
      {
        return _servico.Inserir$dominio$(Pep$dominio$UIModel.ToNegocio()).ToUIModel();
      });
    }
  }
}
