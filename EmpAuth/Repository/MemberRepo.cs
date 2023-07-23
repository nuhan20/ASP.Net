using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using EmpAuth.Models;

namespace EmpAuth.Repository
{
    public class MemberRepo
    {
        public int AddMember(MemberModel MemberModel)
        {
            using (var context = new EmpAuthEntities())
            {
                Member member = new Member()
                {
                    Name = MemberModel.Name,
                    Password = MemberModel.Password
                };

                context.Member.Add(member);
                context.SaveChanges();

                return member.Id;
            }
        }

        public int VarifyMember(MemberModel model)
        {
            using (var context = new EmpAuthEntities())
            {
                var result = context.Member.FirstOrDefault(x => x.Name == model.Name && x.Password == model.Password);
                if (result != null)
                {
                    return result.Id;
                }
                return 0;
            }
        }
    }
}