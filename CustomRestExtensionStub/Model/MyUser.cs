﻿using Microsoft.AspNet.Identity;

namespace CustomRestExtensionStub.Model
{
    /// <summary>
    /// User class for authenticating client requests
    /// </summary>
    public class MyUser : IUser<string>
    {
        #region Id (IUser Member)
        /// <inheritdoc />
        public string Id => UserName;
        #endregion
        #region UserName (IUser Member)
        /// <inheritdoc />
        public string UserName { get; set; }
        #endregion
    }
}
