﻿using System;

namespace DiWalkthrough_002.Manual_DI.Code.DbLayer
{
    public class UserRepository
    {
        public User Get(int userId)
        {
            if (userId == 1)
            {
                return new User()
                {UserId = 1, Name = "Foo"};
            }

            if (userId == 2)
            {
                return new User()
                {UserId = 2, Name = "Bar"};
            }

            throw new ArgumentOutOfRangeException($"User {userId} not found.");
        }

        internal void Add(User user)
        {
            //Add the user right here.
        }
    }
}