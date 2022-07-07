using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BackBeta.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using BackBeta.Domain.Interface.Repository;
using BackBeta.Infrastructure.CrossCutting.IoC.Context;

namespace BackBeta.Infrastructure.CrossCutting.IoC.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly MyDbContext _context;
        private DbSet<T> _dataset;
        public BaseRepository(MyDbContext context)
        {
            _context = context;
            _dataset = _context.Set<T>();
        }
        public async Task<bool> Excluir(int id)
        {
            try
            {
                var result = await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(id));
                if (result == null)
                {
                    return false;
                }

                _dataset.Remove(result);
                await _context.SaveChangesAsync();
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<T> Criar(T item)
        {
            try
            {
                if (item.Id == 0)
                {

                    item.CreateAt = DateTime.UtcNow;
                    _dataset.Add(item);

                    await _context.SaveChangesAsync();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return item;
        }

        public async Task<T> ObterPorId(int id)
        {
            try
            {
                return await _dataset.SingleOrDefaultAsync(p => p.Id == id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<T>> ObterTodos()
        {
            try
            {
                return await _dataset.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<T> Alterar(T item)
        {
            try
            {
                var result = await _dataset.SingleOrDefaultAsync(p => p.Id == item.Id);
                if (result == null)
                {
                    return null;
                }

                item.UpdateAt = DateTime.UtcNow;
                item.CreateAt = result.CreateAt;

                _context.Entry(result).CurrentValues.SetValues(item);
                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return item;
        }
    }
}
