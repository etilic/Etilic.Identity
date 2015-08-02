using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etilic.Identity.OAuth
{
    /// <summary>
    /// Represents an OAuth token that was obtained from an OAuth-enabled service.
    /// </summary>
    public class OAuthToken
    {
        #region Properties
        /// <summary>
        /// Gets or sets the globally unique ID of this token.
        /// </summary>
        public Guid ID
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the globally unique ID of the OAuth service this token is for.
        /// </summary>
        [Required]
        public Guid ServiceID
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the globally unique ID of the web identity this token belongs to.
        /// </summary>
        [Required]
        public Guid IdentityID
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the token.
        /// </summary>
        [Required]
        public String AccessToken
        {
            get;
            set;
        }

        public String RefreshToken
        {
            get;
            set;
        }
        [Required]
        public DateTime Issued
        {
            get;
            set;
        }
        [Required]
        public DateTime Expires
        {
            get;
            set;
        }
        public String Scope
        {
            get;
            set;
        }

        public String TokenType
        {
            get;
            set;
        }
        #endregion

        #region Navigational properties
        /// <summary>
        /// Gets or sets the web identity this token belongs to.
        /// </summary>
        public virtual WebIdentity Identity
        {
            get;
            set;
        }
        #endregion

        public OAuthToken()
        {
            this.ID = Guid.NewGuid();
        }

        public OAuthToken(Guid serviceID)
            : this()
        {
            this.ServiceID = serviceID;
        }
    }
}
