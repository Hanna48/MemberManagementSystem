using MemberManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MemberManagementSystem.Service
{
    public class MemberService
    {
        MemberManagementSystemEntities db = new MemberManagementSystemEntities();

        public List<MemberData> GetAllMemberData()
        {
            return db.MemberData.ToList();
        }
    }
}