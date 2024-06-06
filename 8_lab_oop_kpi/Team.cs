using System.Collections.Generic;

namespace _8_lab_oop_kpi
{
    public class Team
    {
        private List<TeamMember> members;

        public Team()
        {
            members = new List<TeamMember>();
        }

        public void AddMember(TeamMember member)
        {
            members.Add(member);
        }

        public void RemoveMember(TeamMember member)
        {
            members.Remove(member);
        }

        public IEnumerable<TeamMember> GetMembers()
        {
            return members;
        }

        public TeamMember GetMemberById(int id)
        {
            return members.Find(m => m.Id == id);
        }
    }
}
