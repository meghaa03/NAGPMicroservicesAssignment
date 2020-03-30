using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace UserBDC.Interfaces
{
    public interface IUserBDC
    {
        UserDTO GetUserByID(int userId);
    }
}
