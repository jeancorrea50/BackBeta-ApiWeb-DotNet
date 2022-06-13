using AutoMapper;
using BackBeta.Domain.Dto.User;
using BackBeta.Domain.Entities;
using BackBeta.Domain.Models;

namespace BackBeta.CrossCutting.Data.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region Model para DTO & DTO para Model 

            CreateMap<UserModel, UsuarioDto>().ReverseMap();
            CreateMap<UserModel, CriarUsuarioDto>().ReverseMap();
            CreateMap<UserModel, AtualizarUsuarioDto>().ReverseMap();

            #endregion

            #region DTO Result para Entidade & Entidade para DTO Result

            CreateMap<UsuarioDto, UserEntity>().ReverseMap();
            CreateMap<CriarUsuarioResultadoDto, UserEntity>().ReverseMap();
            CreateMap<AtualizarUsuarioResultadoDto, UserEntity>().ReverseMap();

            #endregion

            #region Model para Entidade & Entitidade para Model

            CreateMap<UserModel, UserEntity>().ReverseMap();

            #endregion
        }
    }
}
