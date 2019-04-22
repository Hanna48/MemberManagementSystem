using MemberManagementSystem.Models;
using MemberManagementSystem.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MemberManagementSystem.Controllers
{
    public class MemberController : Controller
    {
        MemberManagementSystemEntities db = new MemberManagementSystemEntities();
        MemberService memberService = new MemberService();
        // GET: Member

        #region 首頁
        public ActionResult Index()
        {
            List<MemberData> MemberLsit = new List<MemberData>();
            MemberLsit = memberService.GetAllMemberData();
            return View(MemberLsit);
        }
        #endregion

        #region 新增會員資料頁面
        public ActionResult CreatMember()
        {
            MemberData member = new MemberData();
            return View(member);
        }
        #endregion

        #region 新增會員資料
        [HttpPost]
        public ActionResult UpdateCreatData(MemberData data)
        {
            memberService.UpdateCreatData(data);
            return RedirectToAction("index");
        }
        #endregion

        #region 編輯資料頁面
        public ActionResult EditMember(int ID)
        {
            MemberData member = new MemberData();
            member = memberService.GetMemberByID(ID);
            return PartialView(member);
        }
        #endregion

        #region 編輯資料
        [HttpPost]
        public ActionResult UpdateEditData(MemberData data)
        {
            memberService.UpdateEditData(data);
            return RedirectToAction("index");
        }
        #endregion

        #region 刪除會員資料
        public ActionResult DeleteMember(int ID)
        {
            memberService.DeleteMemberData(ID);
            return RedirectToAction("index");
        }
        #endregion
    }
}