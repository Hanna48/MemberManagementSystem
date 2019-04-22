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

        public MemberData GetMemberByID(int ID)
        {
            return db.MemberData.SingleOrDefault(x => x.ID == ID);
        }

        public void UpdateCreatData(MemberData data)
        {
            db.MemberData.Add(data);
            db.SaveChanges();
        }

        public void UpdateEditData(MemberData data)
        {
            MemberData member = GetMemberByID(data.ID);
            member.Name = data.Name;
            member.Age = data.Age;
            member.Address = data.Address;
            member.Tel = data.Tel;
            db.SaveChanges();
        }

        public void DeleteMemberData(int ID)
        {
            MemberData member = GetMemberByID(ID);
            db.MemberData.Remove(member);
            db.SaveChanges();
        }
    }
}