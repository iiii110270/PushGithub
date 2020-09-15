#region Using
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PushGithub.Models;
using System.Collections.Generic;
using System.Diagnostics;
#endregion Using

#region Summary
/// ==============================================================================
/// <summary>
/// 作者 : CKyle
/// 建立日期 : 2020/09/10
/// 目的 : Github Works
/// 特別註記 : 
///  維護日期     維護人    修改案編號    維   護   內   容
/// ==========    ======    ==========    =================
/// 2020/09/10     Kyle         N/A            新增
/// </summary>
/// ==============================================================================
#endregion Summary

namespace PushGithub.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Works()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult WorksListGrid()
        {
            List<WorkModel> workList = new List<WorkModel>();
            workList.Add(new WorkModel()
            {
                ID = 1,
                WORK_NAME = "WebVille",
                DESCRIPTION = @"A specially designed menu that vagetarian can enjoy too. All you need to do is press a button.",
                FINISH_DATE = "2020/09/14",
            });
            return Json(new
            {
                rows = workList,   //jqGrid呈現在表格中的資料
            });
        }
    }
}
