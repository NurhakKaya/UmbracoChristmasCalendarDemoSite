using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.Extensions.Logging;
using Umbraco.Cms.Core.Web;

namespace UmbracoCalendarDemo.Web.Controllers.Render
{
    public class TestController : UmbracoCalendarDemoBaseRenderController
    {
        // Check Umbraco documentation to see how you can use this render controller: https://our.umbraco.com/documentation/implementation/Default-Routing/Controller-Selection/

        private readonly ILogger<TestController> _logger; // Umbraco is now using the standard Microsoft logging in .Net Core. 

        public TestController(ILogger<TestController> logger,
            ICompositeViewEngine compositeViewEngine,
            IUmbracoContextAccessor umbracoContextAccessor)
            : base(logger, compositeViewEngine, umbracoContextAccessor)
        {
            _logger = logger;
        }

        public override IActionResult Index()
        {
            // If you want to test this method do the following steps;
            // 1. Create a document type and name it as Test
            // 2. Create a template that uses the Test document type and name it Test
            // 3. Create a new content page that uses the Test template and the Test
            // document type, publish it
            // 4. Put a breakpoint here and start debugging
            // 5. Follow the new content page's front end website url - it should hit your breakpoint

            // You are in full control here - if you need to create your custom Model, do it and return it here
            // If you need to make api calls, you can do them, too!
            return CurrentTemplate(CurrentPage);
        }
    }
}
