using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbuyGetir.Core.Authentication
{
    public class TokenClaim
    {
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }
    }

    public class TokenModel
    {
        public string AccessToken { get; set; }
        public DateTime ExpireDate { get; set; }
    }

    public interface ITokenService
    {
        TokenModel CreateAccessToken(List<TokenClaim> claims);
        void RevokeAccessToken(string token);
    }
}
