using AutoMapper;
using BackBeta.Domain.Entities;
using BackBeta.Domain.Interface.Repository;
using BackBeta.Domain.Interface.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBeta.Domain.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
        public IEnumerable<ProdutoEntity> ObterTodos()
        {
            var query = _produtoRepository.ObterTodos();

            return query;
        }
    }
 }
