using Grand.Framework.Controllers;
using Grand.Framework.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Grand.Plugin.Misc.TestAdminTab.Controllers
{
    [AuthorizeAdmin]
    public class TestAdminTabController : BasePluginController
    {
        public TestAdminTabController() { }

        public IActionResult Configure()
        {
            return Content("TestAdminTab " + DateTime.Now.ToLongDateString());
        }
    }
}