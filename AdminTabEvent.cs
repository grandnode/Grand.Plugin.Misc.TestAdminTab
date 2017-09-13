using Grand.Framework.Events;
using Grand.Services.Events;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Routing;

namespace Grand.Plugin.Misc.TestAdminTab
{
    public class AdminTabEvent : IConsumer<AdminTabStripCreated>
    {
        public void HandleEvent(AdminTabStripCreated eventMessage)
        {
            if (eventMessage.TabStripName == "category-edit")
            {
                var actionName = "Configure";
                var controllerName = "TestAdminTab";

                var urlHelper = new UrlHelper(eventMessage.Helper.ViewContext).Action(new UrlActionContext { Action = actionName, Controller = controllerName });

                eventMessage.BlocksToRender.Add(new HtmlString("<script>" +
                                                                  "$(document).ready(function() {" +
                                                                  "$('#category-edit').data('kendoTabStrip').append(" +
                                                                  "[{" +
                                                                  "text: 'Test Admin Tab'," +
                                                                  "contentUrl: '" + urlHelper + "'" +
                                                                  "}]);" +
                                                                  "});" +
                                                                  "</script>"));
            }
        }
    }
}
