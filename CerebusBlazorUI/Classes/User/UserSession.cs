namespace CerebusBlazorUI.Classes.User
{
    public class UserSession
    {
        #region Constructors

        public UserSession() { }
        public UserSession(User user)
        { 
            UserID = user.ID;
            UserName = user.Username;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Email = user.EmailAddress;
            Role = user.UserRole;
            SessionStartTime = DateTime.UtcNow;
            LastActivity = DateTime.UtcNow;

            //TODO: Get User Role From Database to populate
        }

        #endregion

        #region Properties

        public int UserID { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public UserRole Role { get; set; }

        public DateTime SessionStartTime { get; set; }
        public DateTime SessionExpiration { get; set; }

        public DateTime LastActivity { get; set; }
        public bool CanExtend { get; set; }
        public bool IsSessionActive { get; set; }

        #endregion

    }
}
