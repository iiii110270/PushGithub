#region Using
using Microsoft.AspNetCore.Mvc;
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
/// 2020/09/13     Kyle         N/A            新增
/// </summary>
/// ==============================================================================
#endregion Summary

namespace PushGithub.Controllers
{
    public class WebVilleController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.WorkNO = "1";
            return View();
        }
    }
}
