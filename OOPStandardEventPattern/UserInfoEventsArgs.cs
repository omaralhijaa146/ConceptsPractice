namespace OOPStandardEventPattern;

public class UserInfoEventsArgs:EventArgs
{
    private UserInfo _newUserInfo;
    
    private UserInfo _oldUserInfo;
    
    public UserInfo NewUserInfo =>  _newUserInfo;
    
    public UserInfo OldUserInfo =>  _oldUserInfo;
    

    public UserInfoEventsArgs(UserInfo oldUserInfo,UserInfo newUserInfo)
    {
        _oldUserInfo = new UserInfo
        {
            Id = oldUserInfo.Id,
            Name = oldUserInfo.Name,
            Email = oldUserInfo.Email,
            LogedIn = oldUserInfo.LogedIn,
            IsConfirmed = oldUserInfo.IsConfirmed
        };
        
        _newUserInfo = new UserInfo
        {
            Id = newUserInfo.Id,
            Name = newUserInfo.Name,
            Email = newUserInfo.Email,
            LogedIn = newUserInfo.LogedIn,
            IsConfirmed = newUserInfo.IsConfirmed
        };
    }
}