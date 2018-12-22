﻿using System;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Web.Mvc;
using Common;
using IServices.ISysServices;


namespace Web.Areas.Platform.Controllers
{
    /// <summary>
    /// 桌面
    /// </summary>
    public class DesktopController : Controller
    {
        private readonly ISysUserService _iSysUserService;
        private readonly ISysUserLogService _iSysUserLogService;
   
        /// <summary>
        /// 
        /// </summary>
        /// <param name="iSysUserService"></param>
        /// <param name="iSysUserLogService"></param>
        public DesktopController(ISysUserService iSysUserService, ISysUserLogService iSysUserLogService)
        {
            _iSysUserService = iSysUserService;
            _iSysUserLogService = iSysUserLogService;
         
        }

        // GET: Platform/Desktop
        /// <summary>
        /// 管理平台的桌面
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            //用户总数统计
            ViewBag.SysUserCount = _iSysUserService.GetAll().Count();

            //近十天用户注册次数
            ViewBag.SysUserCountDay = _iSysUserService.GetAll(a => SqlFunctions.DateDiff("d", a.CreatedDate, DateTimeLocal.Now) <= 14).GroupBy(a => DbFunctions.CreateDateTime(SqlFunctions.DatePart("yyyy", a.CreatedDate), SqlFunctions.DatePart("MM", a.CreatedDate), SqlFunctions.DatePart("dd", a.CreatedDate), 0, 0, 0)).Select(a => new { a.Key, Count = a.Count() }).ToDictionary(a => a.Key.Value.ToShortDateString(), a => (double)a.Count);

            //近十天用户活动次数
            //ViewBag.SysUserLogCountDay = _iSysUserLogService.GetAll(a => SqlFunctions.DateDiff("d", a.CreatedDate, DateTimeLocal.Now) <= 14).GroupBy(a => DbFunctions.CreateDateTime(SqlFunctions.DatePart("yyyy", a.CreatedDate), SqlFunctions.DatePart("MM", a.CreatedDate), SqlFunctions.DatePart("dd", a.CreatedDate), 0, 0, 0)).Select(a => new { Key = (DateTime?)a.Key.Value, Count = a.Count() }).OrderBy(a => a.Key).ToDictionary(a => a.Key.Value.ToShortDateString(), a => (double)a.Count);


            return View();
        }
    }
}