using AutoMapper;
using BackBeta.AppService.Interface;
using BackBeta.AppService.ViewModel.Selecao;
using BackBeta.Domain.Entities;
using BackBeta.Domain.Interface.Service;
using BackBeta.Infrastructure.CrossCutting.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBeta.AppService.Service
{
    public class ProdutoAppService : IProdutoAppService
    {
        private readonly IProdutoService _produtoService;
        private readonly IMapper _mapper;

        public ProdutoAppService(IProdutoService produtoService, IMapper mapper)
        {
            _produtoService = produtoService;
            _mapper = mapper;
        }
        public IEnumerable<ProdutoSelecaoVm> ObterTodos()
        {

            return _mapper.Mapear<IEnumerable<ProdutoSelecaoVm>>(_produtoService.ObterTodos());
        }
    }
}
