using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etilic.Identity.OAuth
{
    /// <summary>
    /// An OAuth callback URL for an OAuth service.
    /// </summary>
    public class OAuthCallback
    {
        #region Properties
        /// <summary>
        /// Gets or sets the globally unique ID of this callback.
        /// </summary>
        public Guid ID
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the globally unique ID of the OAuth service this callback is for.
        /// </summary>
        public Guid ServiceID
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the URL to which an OAuth response should be sent.
        /// </summary>
        public String URL
        {
            get;
            set;
        }
        #endregion
    }
}
