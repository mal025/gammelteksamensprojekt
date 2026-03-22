namespace Club100;

public class MemberRepo
{
    private List<Member> _members;
    private int _nextId;

    public List<Member> Members
    {
        get { return _members; }
        set { _members = value; }
    }

    public List<Member> GetAll()
    {
        return _members;
    }

    public Member GetById(int id)
    {
        return _members.FirstOrDefault(m => m.Id == id);
    }

    public Member Add(Member member)
    {
        member.Id = _nextId++;
        _members.Add(member);
        return member;
    }

    public Member? Delete(int id)
    {
        Member? member = _members.FirstOrDefault(m => m.Id == id);
        if (member != null)
        {
            _members.Remove(member);
        }
        return member;
    }
    
    MemberRepo()
    {
        
    }
}