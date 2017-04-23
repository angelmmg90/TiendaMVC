using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Linq.Dynamic;

namespace TiendaMVC.Web.Extensions
{
    public static class IQueryableExtensions
    {
        public static PaginateResult<T> Paginate<T>(this IQueryable<T> query, HttpRequestBase request){
            // El draw pide un id y ese registro es el que se va a ver
            var draw = request.Form.GetValues("draw").FirstOrDefault();
 
            // Start y length son para la paginacion de los registros
            var start = request.Form.GetValues("start").FirstOrDefault();
            var length = request.Form.GetValues("length").FirstOrDefault();
 
            var sortColumn = request.Form.GetValues("columns["
                + request.Form.GetValues("order[0][column]").FirstOrDefault() + "][name]").FirstOrDefault();
            var sortColumnDir = request.Form.GetValues("order[0][dir]").FirstOrDefault();
 
            int pageSize = length != null ? Convert.ToInt32(length) : 0;
            int skip = start != null ? Convert.ToInt32(start) : 0;
            int recordsTotal = 0;
            int recordsFiltered = 0;
 
            var v = query;
            recordsTotal = v.Count();
            recordsFiltered = recordsTotal;
 
            // FILTERING
            var filter = request.Form.GetValues("search[value]").FirstOrDefault();
            if (!string.IsNullOrWhiteSpace(filter))
            {
                Type type = typeof(T);
                string filterSql = "";
                foreach (var property in type.GetProperties())
                {
                    switch (property.PropertyType.Name)
                    {
                        case "String":
                            filterSql = filterSql + property.Name + ".Contains(@0) || ";
                            break;
                        case "Int16":
                        case "Int32":
                        case "Int64":
                            filterSql = filterSql + property.Name + ".ToString().Contains(@0) || ";
                            break;
                    }
 
                }
                if (filterSql.Length > 0)
                    v = v.Where(filterSql.Substring(0, filterSql.Length - 4), filter);
            }
 
            // SORTING
            if (string.IsNullOrEmpty(sortColumn))
                sortColumn = request.Form.GetValues("columns[0][data]").FirstOrDefault();
            if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDir)))
            {
                v = v.OrderBy(sortColumn + " " + sortColumnDir);
            }
 
            recordsTotal = v.Count();
            var data = v.Skip(skip).Take(pageSize);
 
            return new PaginateResult<T>
            {
                draw = int.Parse(draw),
                Data = data,
                RecordsTotal = recordsTotal,
                recordsFiltered = recordsFiltered
            };
        }
 
        public class PaginateResult<T>
        {
            public IQueryable<T> Data { get; set; }
            public int draw { get; set; }
            public int recordsFiltered { get; set; }
            public int RecordsTotal { get; set; }
        }
    }
 }
