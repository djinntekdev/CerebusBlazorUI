namespace CerebusBlazorUI.Classes.Session
{
    public class SessionToken
    {
        public SessionToken() { }

        public SessionToken(string accessToken, string refreshToken) 
        { 
            AccessToken = accessToken;
            RefreshToken = refreshToken;
        }

        public string AccessToken { get; set;  }
        public string RefreshToken { get; set; }
    }
}
