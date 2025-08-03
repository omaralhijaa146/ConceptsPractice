namespace OOPStandardEventPattern;

public class DummyRepository
{
    private List<UserInfo> _users = new List<UserInfo>
    {
        new UserInfo
        {
            Id = 1,
            Name = "Omar",
            Email = "omar@email.com",
            LogedIn = false,
            IsConfirmed = false
        }
        ,new UserInfo
        {
            Id = 2,
            Name = "Fathi",
            Email = "fathi@email.com",
            LogedIn = false,
            IsConfirmed = false
        }
    };

    public void SaveUser(UserInfo userInfo, int userId)
    {
        var user=_users.FindIndex(x=>x.Id==userId);
        if (user == -1) return;
        _users[user] = userInfo;
       
    }

    public UserInfo? GetUserInfo(int id)
    {
        return _users.FirstOrDefault(x => x.Id == id);
    }

}