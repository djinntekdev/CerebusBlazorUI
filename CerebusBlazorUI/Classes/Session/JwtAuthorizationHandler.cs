namespace CerebusBlazorUI.Classes.Session
{
    public class UserTokenState
    {
        public string? Token { get; set; }
    }

    public class JwtAuthorizationHandler : DelegatingHandler
    {
        private readonly UserTokenState _tokenState;

        public JwtAuthorizationHandler(UserTokenState tokenState)
        {
            _tokenState = tokenState;
        }

        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request, CancellationToken cancellationToken)
        {
            // Get token from our server-side scoped state
            var token = _tokenState.Token;

            if (!string.IsNullOrEmpty(token))
            {
                request.Headers.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            }

            return await base.SendAsync(request, cancellationToken);
        }
    }
}
