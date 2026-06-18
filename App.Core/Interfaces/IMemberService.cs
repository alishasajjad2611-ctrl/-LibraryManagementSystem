using App.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Interfaces
{
    public interface IMemberService
    {
        List<Member> GetAllMembers();
        List<Member> SearchMembers(string keyword); 
        void AddMember(Member member);
        void UpdateMember(Member member);
        void DeleteMember(int memberId);
    }
}
