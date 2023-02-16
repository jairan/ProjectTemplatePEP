using RM.Lib;
using RM.Lib.Api;
using RM.Lib.Api.Formatting;
using RM.Lib.LicenceServer;
using $prefixoprojeto$.$dominio$.IService.Interface;
using $prefixoprojeto$.$dominio$.IService.Model;
using $prefixoprojeto$.Shared.Session;
using System.Collections.Generic;
using System.Web.Http;

namespace $safeprojectname$
{
  [RoutePrefix("hcg/v1/pep/[rotaaqui]")]//TODO: Ajustar Rota
  [RMSController("Pep$dominio$ApiServer")]
  [RMSLicense(Sistema = CodSistema.Sau)]
  [ApiSecurity(CodSistema.Sau, CodigosPermissao.[codigosegurancaoaqui])]//TODO: Criar codigo de segurança
  public class Pep$dominio$Controller : RMSController<IPep$dominio$ApiServer>
  {
    [HttpGet]
    [Route("")]
    public RMSJsonResult<IEnumerable<Pep$dominio$UIModel>> Listar$dominio$s([FromUri] ApiQuery apiQuery)
    {
      if (apiQuery == null)
        apiQuery = new ApiQuery();
      apiQuery.LoadFilterFromRequest(ControllerContext.Request);

      var $dominio$s = Server.Listar$dominio$s(apiQuery);
      return new RMSJsonResult<IEnumerable<Pep$dominio$UIModel>>(Json($dominio$s, new ApiJsonSerializerSettings()));
    }

    [HttpGet]
    [Route("{id[aquinomeParametro]}")]//TODO: Ajustar nome parametro ROTA
    public RMSJsonResult<Pep$dominio$UIModel> Detalhar(int id$dominio$)
    {
      var $instanciadominio$ = Server.Detalhar(id$dominio$);
      return new RMSJsonResult<Pep$dominio$UIModel>(Json($instanciadominio$, new ApiJsonSerializerSettings()));
    }
  }
}
