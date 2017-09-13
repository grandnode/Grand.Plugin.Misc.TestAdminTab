using Grand.Core.Plugins;
using Grand.Framework.Menu;
using Grand.Services.Common;
using Microsoft.AspNetCore.Routing;
using System.Collections.Generic;
using System.Linq;

namespace Grand.Plugin.Misc.TestAdminTab
{
    public class TestAdminTabPlugin : BasePlugin, IMiscPlugin
    {
        #region Ctor
        public TestAdminTabPlugin() { }

        #endregion

        #region Methods

        /// <summary>
        /// Install plugin
        /// </summary>
        public override void Install()
        {
            base.Install();
        }

        /// <summary>
        /// Uninstall plugin
        /// </summary>
        public override void Uninstall()
        {
            base.Uninstall();
        }

        #endregion
    }
}