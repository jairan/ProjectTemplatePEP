using AutoMapper;
using $prefixoprojeto$.$dominio$.IService.Model;
using $safeprojectname$.Negocio.Model;
using System.Collections.Generic;
using $safeprojectname$.DBModel;

namespace $safeprojectname$.Mapper
{
  public static class Pep$dominio$Mapper
  {
    static Pep$dominio$Mapper()
    {
      Mapper = new MapperConfiguration(cfg =>
      {
        cfg.CreateMap<Pep$dominio$DBModel, Pep$dominio$Negocio>()
          .ForMember(entity => entity.Codigo, map => map.MapFrom(model => model.Codigo))
          
          .ReverseMap();

        cfg.CreateMap<Pep$dominio$UIModel, Pep$dominio$Negocio>()
          .ForMember(entity => entity.Codigo, map => map.MapFrom(model => model.Codigo))
          .ReverseMap();
      });
    }

    internal static MapperConfiguration Mapper { get; }

    public static IEnumerable<Pep$dominio$Negocio> ToNegocio(this IEnumerable<Pep$dominio$DBModel> notificacao)
    {
      return notificacao == null ? null : Mapper.CreateMapper().Map<IEnumerable<Pep$dominio$Negocio>>(notificacao);
    }

    public static IEnumerable<Pep$dominio$UIModel> ToUIModel(this IEnumerable<Pep$dominio$Negocio> notificacao)
    {
      return notificacao == null ? null : Mapper.CreateMapper().Map<IEnumerable<Pep$dominio$UIModel>>(notificacao);
    }

    public static Pep$dominio$UIModel ToUIModel(this Pep$dominio$Negocio $instanciadominio$)
{
      return $instanciadominio$ == null ? null : Mapper.CreateMapper().Map<Pep$dominio$UIModel>($instanciadominio$);
    }

    public static Pep$dominio$Negocio ToNegocio(this Pep$dominio$DBModel $instanciadominio$)
{
      return $instanciadominio$ == null ? null : Mapper.CreateMapper().Map<Pep$dominio$Negocio>($instanciadominio$);
    }
  }
}
