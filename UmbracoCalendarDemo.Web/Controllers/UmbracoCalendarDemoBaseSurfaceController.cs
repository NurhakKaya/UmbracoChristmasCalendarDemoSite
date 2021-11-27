using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Website.Controllers;

namespace UmbracoCalendarDemo.Web.Controllers
{
    public class UmbracoCalendarDemoBaseSurfaceController : SurfaceController
    {
        public UmbracoCalendarDemoBaseSurfaceController(IUmbracoContextAccessor umbracoContextAccessor, 
            IUmbracoDatabaseFactory databaseFactory, 
            ServiceContext services, 
            AppCaches appCaches, 
            IProfilingLogger profilingLogger, 
            IPublishedUrlProvider publishedUrlProvider) 
            : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
        {
        }
    }
}
