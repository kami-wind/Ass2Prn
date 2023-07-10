using BusinessObject;

namespace DataAccess.Repository;

public interface IMemberRepository
{
    IEnumerable<MemberObject> GetMember();
    MemberObject GetMemberById(int MemberID);
    void InsertMember(MemberObject member);
    void UpdateMember(MemberObject member);
    void DeleteMember(int MemberID);
}
