using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using UmbracoCalendarDemo.Web.Models;

namespace UmbracoCalendarDemo.Web.Controllers
{
    public class TestFormController : UmbracoCalendarDemoBaseSurfaceController
    {
        // Check Umbraco documentation to see how you can use this surface controller: https://our.umbraco.com/documentation/reference/routing/surface-controllers

        private readonly ILogger<TestFormController> _logger;

        public TestFormController(IUmbracoContextAccessor umbracoContextAccessor,
            IUmbracoDatabaseFactory databaseFactory,
            ServiceContext services,
            AppCaches appCaches,
            IProfilingLogger profilingLogger,
            IPublishedUrlProvider publishedUrlProvider,
             ILogger<TestFormController> logger)
            : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
        {
            // Inject your dependencies here!
            _logger = logger;
        }

        [HttpPost]
        public IActionResult SubmitForm(TestModel model)
        {
       
            if (!ModelState.IsValid)
            {
                return CurrentUmbracoPage();
            }

            try
            {
                // Do whatever you need to do!!

                _logger.LogInformation($"Log some info - id: {model.Id}");
               
            }
            catch (Exception ex)
            {
                var exception = ex.InnerException != null ? ex.InnerException.ToString() : "";
                var message = ex.Message != null ? ex.Message.ToString() : "";

                _logger.LogError(ex, $"SubmitForm - Error! | Exception for id: {model.Id}: {exception} | Message: {message} | Stack Trace: {ex.StackTrace}");
            }

            return RedirectToCurrentUmbracoPage();
        }
    }
}
