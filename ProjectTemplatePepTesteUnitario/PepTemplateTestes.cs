using Microsoft.VisualStudio.TestTools.UnitTesting;
using $prefixoprojeto$.$dominio$.Server.Mapper;
using $prefixoprojeto$.$dominio$.Server.Negocio.Model;
using RM.Pep.Shared;


namespace $safeprojectname$
{
  [TestClass]
  public class Pep$dominio$Testes
  {
    [TestMethod]
    public void DeveMapear_Negocio_Para_UIModel()
    {
      var objNegocio = TesteUnitarioHelper.PreencherObj<Pep$dominio$Negocio>();
      var objUIModel = objNegocio.ToUIModel();

      Assert.AreEqual(objUIModel.Codigo, objNegocio.Codigo);
    }
  }
}
