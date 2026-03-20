namespace Club100;

public class Member
{
    private int _id;
    private string _name;
    private string _club;
    private int _count;
    public int Id
    {
        get => _id;
        set => _id = value;
    }

    public string Name
    {
        get => _name;
        set
        {
            if (value == null || value.Length < 2)
            {
                throw new ArgumentException("Name skal være mindst 2 tegn langt.");
            }
            _name = value;
        }
    }

    public string Club
    {
        get => _club;
        set => _club = value;
    }

    public int Count
    {
        get => _count;
        set
        {
            if (value < 100 || value > 199)
            {
                throw new ArgumentOutOfRangeException("Count skal være mellem 100 og 199.");
            }
            _count = value;
        }
    }

    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name},  Club: {Club}, Count: {Count}";
    }
    public Member()
    {
        
    }
}   