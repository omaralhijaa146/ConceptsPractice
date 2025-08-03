namespace OOPStandardEventPattern;

public class UserEvents
{
    
    private readonly DummyRepository _dummyRepository = new DummyRepository();

    public event EventHandler<UserInfoEventsArgs>? UserUpdated;

    protected virtual void OnUserUpdated(UserInfoEventsArgs userInfoEventsArgs)
    {
        UserUpdated?.Invoke(this,userInfoEventsArgs);
    }

    public void LogInUser(int userId)
    {
        var userInfo= _dummyRepository.GetUserInfo(userId);
        
        if (userInfo == null) return;
        
        if (!userInfo.IsConfirmed) return;
        
        var newUserInfo = new UserInfo
        {
            Id=userInfo.Id,
            Name = userInfo.Name,
            Email = userInfo.Email,
            LogedIn = true,
            IsConfirmed = userInfo.IsConfirmed
        };
        var userInfoEventsArgs= new UserInfoEventsArgs(userInfo,newUserInfo);
        _dummyRepository.SaveUser(newUserInfo,userId);
        OnUserUpdated(userInfoEventsArgs);

    }
    
    public void ConfirmUser(int userId)
    {
        var userInfo= _dummyRepository.GetUserInfo(userId);
        
        if (userInfo == null) return;

        if (userInfo.IsConfirmed)
        {
            LogInUser(userId);
            return;
        }
        
        var newUserInfo = new UserInfo
        {
            Id=userInfo.Id,
            Name = userInfo.Name,
            Email = userInfo.Email,
            LogedIn = userInfo.LogedIn,
            IsConfirmed = true
        };
        var userInfoEventsArgs= new UserInfoEventsArgs(userInfo,newUserInfo);
        _dummyRepository.SaveUser(newUserInfo,userId);
        OnUserUpdated(userInfoEventsArgs);

    }

}