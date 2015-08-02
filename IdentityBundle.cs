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
        /// 
        /// </summary>
        public const String ID = "D79AA2D6-C44F-43F2-8A82-708DB665379A";
        #endregion

        #region Instance members
        /// <summary>
        /// The globally unique ID of this bundle.
        /// </summary>
        private Guid bundleID = new Guid(ID);
        /// <summary>
        /// A value indicating whether OAuth identity extensions are enabled.
        /// </summary>
        private Boolean oauthEnabled = true;
        #endregion

        #region Properties
        /// <summary>
        /// Gets the globally unique ID of this bundle.
        /// </summary>
        public override Guid BundleID
        {
            get { return this.bundleID; }
        }
        /// <summary>
        /// Gets or sets a value indicating whether OAuth identity extensions are enabled.
        /// </summary>
        public Boolean OAuthEnabled
        {
            get { return this.oauthEnabled; }
            set { this.oauthEnabled = value;  }
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
    }
}
