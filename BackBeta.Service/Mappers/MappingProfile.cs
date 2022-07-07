using AutoMapper;
using BackBeta.AppService.ViewModel.Selecao;
using BackBeta.Domain.Entities;

namespace BackBeta.AppService.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region Dominio para ViewModel

            CreateMap<ProdutoEntity, ProdutoSelecaoVm>();
            CreateMap<CategoriaEntity, CategoriaSelecaoVm>();
            CreateMap<FornecedorEntity, FornecedorSelecaoVm>();
            CreateMap<FornecedorContatoEntity, FornecedorContatoSelecaoVm>();

            #endregion

            #region ViewModel para Dominio


            #endregion

        }
    }
}
