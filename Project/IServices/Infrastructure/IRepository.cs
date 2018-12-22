﻿using Models.Infrastructure;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace IServices.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);

        void Update(T entity);
    
        void Save(object id, T entity);

        /// <summary>
        /// 按照单主键删除数据
        /// </summary>
        /// <param name="id"></param>
        /// <param name="remove">物理删除标记 默认false</param>
        void Delete(object id, bool remove = false);

        /// <summary>
        /// 按照单个实体删除数据
        /// </summary>
        /// <param name="item"></param>
        /// <param name="remove">物理删除标记 默认false</param>
        void Delete(T item, bool remove = false);

        /// <summary>
        /// 按照条件批量删除数据
        /// </summary>
        /// <param name="where"></param>
        /// <param name="remove">物理删除标记 默认false</param>
        void Delete(Expression<Func<T, bool>> where, bool remove = false);

        /// <summary>
        /// 跟住单个主键获取数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetById(object id);
    
        /// <summary>
        /// 获取全部数据
        /// </summary>
        /// <param name="containsDeleted">是否包含已删除数据</param>
        /// <returns></returns>
        IQueryable<T> GetAll(bool containsDeleted = false, bool allEnt = false);

        IQueryable<T> GetAll(Expression<Func<T, bool>> where);

        int Commit();

        Task<int> CommitAsync();
    }
    public interface IRepository4UserDictionary<T> where T : IUserDictionary
    {

        /// <summary>
        /// 获取指定SystemId实例的Id
        /// </summary>
        /// <param name="systemId"></param>
        /// <returns></returns>
        string GetIdBySystemId(string systemId);
        /// <summary>
        /// 获取指定Id实例的SystemId
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        string GetSystemIdById(object id);
        /// <summary>
        /// 获取指定Id实例的Name
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        string GetNameById(object id);
    }


}
