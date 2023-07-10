using BusinessObject;

namespace DataAccess.Repository;

public class MemberRepository : IMemberRepository
{
    public IEnumerable<MemberObject> GetMember() => MemberDAO.Instance.GetMemberList();


    public MemberObject GetMemberById(int MemberID) => MemberDAO.Instance.GetMemberByID(MemberID);
    

    public void InsertMember(MemberObject member) => MemberDAO.Instance.Add(member);
    

    public void UpdateMember(MemberObject member) => MemberDAO.Instance.Update(member);
    

    public void DeleteMember(int MemberID) =>   MemberDAO.Instance.Remove(MemberID);
    



}
