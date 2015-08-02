using Etilic.Core.Extensibility;
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
    /// 
    /// </summary>
    public class IdentityBundle : Bundle
    {
        #region Constants
        /// <summary>
        /// The globally unique ID of this bundle.
        /// </summary>
        public const String GUID = "D79AA2D6-C44F-43F2-8A82-708DB665379A";
        #endregion

        #region Static members
        /// <summary>
        /// The globally unique ID of this bundle.
        /// </summary>
        public static Guid ID = new Guid(GUID);
        #endregion

        #region Instance members
        /// <summary>
        /// A value indicating whether OAuth identity extensions are enabled.
        /// </summary>
        private Boolean oauthEnabled = true;

        private Dictionary<Guid, IOAuthFlow> oauthFlows;
        #endregion

        #region Properties
        /// <summary>
        /// Gets the globally unique ID of this bundle.
        /// </summary>
        public override Guid BundleID
        {
            get { return ID; }
        }
        /// <summary>
        /// Gets or sets a value indicating whether OAuth identity extensions are enabled.
        /// </summary>
        public Boolean OAuthEnabled
        {
            get { return this.oauthEnabled; }
            set { this.oauthEnabled = value;  }
        }
        /// <summary>
        /// Gets the read-only dictionary containing all registered OAuth authentication flows.
        /// </summary>
        public IReadOnlyDictionary<Guid, IOAuthFlow> OAuthFlows
        {
            get { return this.oauthFlows;  }
        }
        #endregion

        #region Constructors
        public IdentityBundle()
        {
            this.oauthFlows = new Dictionary<Guid, IOAuthFlow>();
        }
        #endregion

        #region RegisterEntities
        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelBuilder"></param>
        public override void RegisterEntities(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WebIdentity>();

            // add OAuth related entity types, if OAuth is enabled
            if(this.oauthEnabled)
            {
                modelBuilder.Entity<OAuthCallback>();
                modelBuilder.Entity<OAuthToken>();
            }
        }
        #endregion

        #region RegisterOAuthFlow
        /// <summary>
        /// Registers an OAuth authentication flow for the specified service.
        /// </summary>
        /// <param name="flow">The implementation of the OAuth flow.</param>
        public void RegisterOAuthFlow(IOAuthFlow flow)
        {
            this.oauthFlows.Add(flow.ServiceID, flow);
        }
        #endregion
    }
}
