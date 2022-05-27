using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BackBeta.Domain.Entities;
using BackBeta.Domain;
using Microsoft.EntityFrameworkCore;
using BackBeta.Domain.Interfaces;
using BackBeta.CrossCutting.Data.Context;

namespace BackBeta.CrossCutting.DataRepository
{
    public class BaseRepository<T> : IRepository<T> where T : Base
    {
        protected readonly MyDbContext _context;
        private DbSet<T> _dataset;
        public BaseRepository(MyDbContext context)
        {
            _context = context;
            _dataset = _context.Set<T>();
        }
        public async Task<bool> DeleteAsync(int id)
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

        public async Task<bool> ExistAsync(int id)
        {
            return await _dataset.AnyAsync(p => p.Id == id);
        }

        public async Task<T> InsertAsync(T item)
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

        public async Task<T> SelectAsync(int id)
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

        public async Task<IEnumerable<T>> SelectAsync()
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

        public async Task<T> UpdateAsync(T item)
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
