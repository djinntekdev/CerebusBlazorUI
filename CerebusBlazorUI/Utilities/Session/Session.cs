using CerebusBlazorUI.Classes.User;
using CerebusBlazorUI.Utilities.Entity;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

namespace CerebusBlazorUI.Utilities.Session
{
    public static class Session
    {
        [Inject]
        private static ProtectedSessionStorage? Storage { get; set; }

        [Inject]
        private static CerebusContext? Context { get; set;  }

        [Inject]
        private static ApplicationAccessTokenManager? TokenManager { get; set; }

        #region Properties

        //public UserSession SessionData { get; set; }


        #endregion

        #region Constructors



        #endregion

        #region Methods

        public static async Task StartSession(User user)
        {
            try
            {
                UserSession SessionData = new UserSession(user);
                SessionData.SessionStartTime = DateTime.UtcNow;
                SessionData.LastActivity = DateTime.UtcNow;
                SessionData.SessionExpiration = DateTime.UtcNow.AddMinutes(30d);
                SessionData.IsSessionActive = true;
                SessionData.CanExtend = true;

                //TokenManager.

                await Storage.SetAsync("session", SessionData);
            }
            catch (Exception ex) 
            { 
            
            }
        }

        public static async Task ExtendSession(int minutes)
        {
            try
            {
                UserSession SessionData = await GetSessionData();
                SessionData.SessionExpiration = DateTime.UtcNow.AddMinutes(minutes);
                await Storage.SetAsync("session", SessionData);

            }
            catch (Exception ex)
            {

            }
        }

        public static async Task CloseSession()
        {
            try
            {
                await Storage.DeleteAsync("session");
                //TODO: redirect to login?
            }
            catch (Exception ex)
            {

            }
        }

        public static bool IsSessionValid()
        {
            return true;
        }

        public static async Task<User> GetCurrentUser()
        {
            ProtectedBrowserStorageResult<UserSession> data = new ProtectedBrowserStorageResult<UserSession>();
            User user;

            data = await Storage.GetAsync<UserSession>("session");

            if (!data.Success)
            {
                throw new Exception("Session Data is null");
            }

            int id = data.Value.UserID;
            user = Context.Users.Where(u => u.ID == id).FirstOrDefault();
            return user;
        }

        public static async Task<UserSession> GetSessionData()
        {
            ProtectedBrowserStorageResult<UserSession> data = new ProtectedBrowserStorageResult<UserSession>();

            data = await Storage.GetAsync<UserSession>("session");

            if (!data.Success)
            {
                throw new Exception("Session Data is null");
            }

            return data.Value;
        }

        //public List<UserRole> GetCurrentUserRoles()
        //{
        //    return Roles;
        //}

        #endregion
    }
}
