using AutoMapper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBeta.Infrastructure.CrossCutting.Mapping
{
    public static class MapperUtils
    {
        public static TDestination Mapear<TDestination>(this IMapper imapper, object source)
        {
            return imapper.Map<TDestination>(source);
        }

        /// <summary>
        /// Mapeamento de Entidade
        /// </summary>
        /// <typeparam name="TSource">Classe de Origem</typeparam>
        /// <typeparam name="TDestination">Classe Destino</typeparam>
        /// <param name="source">Entidade</param>
        public static TDestination Mapear<TSource, TDestination>(this IMapper imapper, TSource source, bool createMapper = true, bool upperCase = true)
        {
            if (createMapper) MapCreateMapper<TSource, TDestination>(ref imapper);

            var resultado = imapper.Map<TSource, TDestination>(source);

            if (upperCase)
                return TransformarCaixaAlta<TDestination>(ref resultado);
            else
                return resultado;

        }

        /// <summary>
        /// Mapeamento de classe
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TDestination"></typeparam>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        public static void Mapear<TSource, TDestination>(this IMapper imapper, TSource source, TDestination destination, bool createMapper = true, bool upperCase = true)
        {
            if (createMapper) MapCreateMapper<TSource, TDestination>(ref imapper);
            var resultado = imapper.Map<TSource, TDestination>(source, destination);

            if (upperCase)
                TransformarCaixaAlta<TDestination>(ref resultado);
        }

        private static void MapCreateMapper<TSource, TDestination>(ref IMapper imapper)
        {
            var config = new MapperConfiguration(x => {
                x.CreateMap<TSource, TDestination>();
                x.CreateMap<TDestination, TSource>();
            });

            imapper = config.CreateMapper();
        }
        private static TDestination TransformarCaixaAlta<TDestination>(ref TDestination lista)
        {
            string json = JsonConvert.SerializeObject(lista).ToUpper();
            return JsonConvert.DeserializeObject<TDestination>(json.Replace("NULL", "null"));
        }
    }
}
