using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etilic.Identity.OAuth
{
    /// <summary>
    /// Represents an interface of OAuth authentication flows.
    /// </summary>
    public interface IOAuthFlow
    {
        Guid ServiceID
        {
            get;
        }

        Uri GetRequestUri(String immediateCallback, Guid callbackParam);

        #region ExchangeCode
        /// <summary>
        /// Exchanges the code received from an OAuth service for an OAuth token.
        /// </summary>
        /// <param name="previousCallback"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        OAuthToken ExchangeCode(String previousCallback, String userID, String code);
        #endregion
    }
}
