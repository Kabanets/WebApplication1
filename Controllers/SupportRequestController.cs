using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class SupportRequestController : Controller
    {
        private readonly ISupportRequestRepository supportRequestRepository;

        public SupportRequestController()
        {
            supportRequestRepository = new SupportRequestRepository();
        }
        // GET: SupportRequest
        public ActionResult Index()
        {
            var model = supportRequestRepository.SupportRequests.ToArray();
            return View(model);
        }

        public ActionResult Details (int supportRequestId)
        {
            var supportRequest = supportRequestRepository.SupportRequests.FirstOrDefault(sr => sr.SupportRequestId == supportRequestId);
            if (supportRequest == null) return HttpNotFound();

            return View(supportRequest);
        }
    }
}