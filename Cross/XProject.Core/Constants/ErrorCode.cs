﻿namespace XProject.Core.Constants
{
    /// <summary>
    ///     Unique Error Code
    /// </summary>
    /// <remarks> Use "nameof(ErrorCode.Key)" to get unique code </remarks>
    /// <remarks> Use ErrorCode.Key to get message </remarks>
    public class ErrorCode
    {
        // Common
        public const string BadRequest = "Bad Request";

        public const string UnAuthenticated = "Un-Authenticate";
        public const string UnAuthorized = "Forbidden";
        public const string CreateFailed = "Create Failed";
        public const string UpdateFailed = "Update Failed";
        public const string NotFound = "Not Found";
        public const string Unknown = "Oops! Something went wrong, please try again later.";
        public const string NotUnique = "The resource is already, please try another.";
        public const string TokenExpired = "The Token is already expired.";
        public const string TokenInvalid = "The Token is invalid.";

        // Client
        public const string GrantTypeInValid = "Grant Type is invalid.";

        public const string SecretInValid = "Secret is invalid.";

        // User
        public const string UserPasswordWrong = "Password is wrong.";

        public const string UserBanned = "User is banned.";
        public const string UserInActive = "User is in-active.";

        // Access Token
        public const string AuthCodeInValid = "The Code is invalid.";

        // App
        public const string AppBanned = "App is banned.";

        // Update callback Balance
        public const string UserInvalid = "Username invalid.";

        // Callback update transaction
        public const string TransIdInvalid = "Can not found User or Transaction";
    }
}