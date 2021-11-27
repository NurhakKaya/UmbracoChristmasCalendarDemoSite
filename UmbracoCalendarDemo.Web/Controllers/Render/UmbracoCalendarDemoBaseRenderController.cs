using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.Extensions.Logging;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.Controllers;

namespace UmbracoCalendarDemo.Web.Controllers.Render
{
    public class UmbracoCalendarDemoBaseRenderController : RenderController
    {
        public UmbracoCalendarDemoBaseRenderController(ILogger<RenderController> logger,
            ICompositeViewEngine compositeViewEngine,
            IUmbracoContextAccessor umbracoContextAccessor)
            : base(logger, compositeViewEngine, umbracoContextAccessor)
        {
        }
    }
}
