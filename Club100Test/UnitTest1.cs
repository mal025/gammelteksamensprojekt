using Club100;
namespace Club100Test;

public class UnitTest1
{
    [Fact]
    public void Member_Id_CanBeSet()
    {
        var member = new Member { Id = 1};
        Assert.Equal(1, member.Id);
    }
    [Fact]
    public void Member_Name_CanBeSet()
    {
        var member = new Member {Name = "Bo"};
        Assert.Equal("Bo", member.Name);
    }

    [Fact]
    public void Member_Club_CanBeSet()
    {
        var member = new Member { Club = "FC Test"};
        Assert.Equal("FC Test", member.Club);
    }

    [Fact]
    public void Member_Count_CanBeSet()
    {
        var member = new Member { Count = 150 };
        Assert.Equal(150, member.Count);
    }
    [Fact]
    public void Member_ToString_ReturnsCorrectFormat()
    {
        var member = new Member { Id = 1, Name = "Bo", Club = "FC Test", Count = 150 };
        string result = member.ToString();
        Assert.Equal("Id: 1, Name: Bo,  Club: FC Test, Count: 150", result);
    }
    [Fact]
    public void Name_AtLeastTwoChars_DoesNotThrow()
    {
        var member = new Member();
        member.Name = "Bo";
        Assert.Equal("Bo", member.Name);
    }
    [Fact]
    public void Name_OneChar_ThrowsArgumentException()
    {
        var member = new Member();
        Assert.Throws<ArgumentException>(() => member.Name = "B");
    }
    [Fact]
    public void Name_Empty_ThrowsArgumentException()
    {
        var member = new Member();
        Assert.Throws<ArgumentException>(() => member.Name = "");
    }
    [Fact]
    public void Count_100_DoesNotThrow()
    {
        var member = new Member();
        member.Count = 100;
        Assert.Equal(100, member.Count);
    }
    [Fact]
    public void Count_199_DoesNotThrow()
    {
        var member = new Member();
        member.Count = 199;
        Assert.Equal(199, member.Count);
    }
    [Fact]
    public void Count_Below100_ThrowsArgumentOutOfRangeException()
    {
        var member = new Member();
        Assert.Throws<ArgumentOutOfRangeException>(() => member.Count = 99);
    }

    [Fact]
    public void Count_Above199_ThrowsArgumentOutOfRangeException()
    {
        var member = new Member();
        Assert.Throws<ArgumentOutOfRangeException>(() => member.Count = 200);
    }

}