using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.Controllers;

namespace UmbracoCalendarDemo.Web.Controllers.Render
{
    public class TestController : UmbracoCalendarDemoBaseRenderController
    {
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
            return base.Index();
        }
    }
}
