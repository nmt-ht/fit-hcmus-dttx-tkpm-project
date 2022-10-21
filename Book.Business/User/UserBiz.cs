﻿using BookManagement.Infrastructure.DataAccess.Data;
using BookManagement.Models;

namespace Book.Business;
public class UserBiz : IUserBiz
{
    private readonly IUserData _userData;
    public UserBiz(IUserData userData)
    {
        _userData = userData;
    }

    public bool AddUser(User user)
    {
       return _userData.InsertUser(user);
    }

    public bool CheckExistingUser(string userName)
    {
        var user = GetUserByUserName(userName);
        if(user is not null)
            return true;
        return false;
    }

    public User GetUserByUserName(string userName)
    {
        return _userData.GetUserByUserName(userName);
    }
}