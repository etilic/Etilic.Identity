using Etilic.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etilic.Identity
{
    public class WebIdentity
    {
        #region Properties
        /// <summary>
        /// Gets or sets the globally unique ID of this web identity.
        /// </summary>
        public Guid ID
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the globally unique ID of the person who owns this identity.
        /// </summary>
        public Guid OwnerID
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the globally unique ID of the service this identity is for.
        /// </summary>
        public Guid ServiceID
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the <see cref="System.String"/> identifying this identity.
        /// </summary>
        public String Identity
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets a value indicating whether this identity is the owner's primary identity for the service.
        /// </summary>
        public Boolean IsPrimary
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets a value indicating whether this identity has recently been added.
        /// </summary>
        public Boolean IsNew
        {
            get;
            set;
        }
        #endregion

        #region Navigational properties
        /// <summary>
        /// Gets or sets the owner of this identity.
        /// </summary>
        public virtual Person Owner
        {
            get;
            set;
        }
        #endregion
    }
}
