using Etilic.Core.DAL;
using Etilic.Identity.OAuth;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etilic.Identity
{
    /// <summary>
    /// Provides identity-related extension methods for the <see cref="Etilic.Core.DAL.EtilicContext"/> class.
    /// </summary>
    public static class IdentityContext
    {
        #region GetWebIdentities
        public static DbSet<WebIdentity> GetWebIdentities(this EtilicContext context)
        {
            return context.Set<WebIdentity>();
        }
        #endregion

        #region GetOAuthCallbacks
        public static DbSet<OAuthCallback> GetOAuthCallbacks(this EtilicContext context)
        {
            return context.Set<OAuthCallback>();
        }
        #endregion

        #region GetOAuthTokens
        public static DbSet<OAuthToken> GetOAuthTokens(this EtilicContext context)
        {
            return context.Set<OAuthToken>();
        }
        #endregion
    }
}
