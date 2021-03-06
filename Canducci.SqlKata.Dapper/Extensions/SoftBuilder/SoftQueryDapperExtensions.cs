﻿using System.Data;
using SqlKata.QueryBuilder;
using System.Threading.Tasks;
using System.Collections.Generic;
using Canducci.SqlKata.Dapper.Extensions.Internals;
namespace Canducci.SqlKata.Dapper.Extensions.SoftBuilder
{
    public static class SoftQueryDapperExtensions
    {
        public static T FindOne<T>(this Query query, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return query.AsQueryBuilderSoftDapper().FindOne<T>(transaction, commandTimeout, commandType);
        }

        public static async Task<T> FindOneAsync<T>(this Query query, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return await query.AsQueryBuilderSoftDapper().FindOneAsync<T>(transaction, commandTimeout, commandType);
        }

        public static int UniqueResultToInt(this Query query, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return UniqueResult<int>(query, transaction, commandTimeout, commandType);
        }

        public static async Task<int> UniqueResultToIntAsync(this Query query, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return await UniqueResultAsync<int>(query, transaction, commandTimeout, commandType);
        }

        public static long UniqueResultToLong(this Query query, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return UniqueResult<long>(query, transaction, commandTimeout, commandType);
        }

        public static async Task<long> UniqueResultToLongAsync(this Query query, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return await UniqueResultAsync<long>(query, transaction, commandTimeout, commandType);
        }

        public static T UniqueResult<T>(this Query query, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return query.AsQueryBuilderSoftDapper().UniqueResult<T>(transaction, commandTimeout, commandType);
        }

        public static async Task<T> UniqueResultAsync<T>(this Query query, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return await query.AsQueryBuilderSoftDapper().UniqueResultAsync<T>(transaction, commandTimeout, commandType);
        }

        public static IEnumerable<T> List<T>(this Query query, IDbTransaction transaction = null, bool buffered = true, int? commandTimeout = null, CommandType? commandType = null)
        {
            return query.AsQueryBuilderSoftDapper().List<T>(transaction, buffered, commandTimeout, commandType);
        }

        public static async Task<IEnumerable<T>> ListAsync<T>(this Query query, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return await query.AsQueryBuilderSoftDapper().ListAsync<T>(transaction, commandTimeout, commandType);
        }

        public static bool SaveUpdate(this Query query, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return query.AsQueryBuilderSoftDapper().SaveUpdate(transaction, commandTimeout, commandType);                
        }

        public static async Task<bool> SaveUpdateAsync(this Query query, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return await query.AsQueryBuilderSoftDapper().SaveUpdateAsync(transaction, commandTimeout, commandType);
        }

        public static bool SaveInsert(this Query query, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)            
        {
            return query.AsQueryBuilderSoftDapper().SaveInsert(transaction, commandTimeout, commandType);                
        }

        public static async Task<bool> SaveInsertAsync(this Query query, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return await query.AsQueryBuilderSoftDapper().SaveInsertAsync(transaction, commandTimeout, commandType);
        }     
        
        //public static QueryBuilderMultiple QueryBuilderMultipleCollection(this QueryBuilderSoftDapper softDapper)
        //{
        //    return softDapper.QueryBuilderMultipleCollection();
        //}

    }
}
