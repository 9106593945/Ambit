namespace AmbitWebAPI.Controllers
{
    using Ambit.APICommon;
    using Ambit.Common.Paging;
    using Ambit.Entities.Contract;
    using Ambit.Services.Contract;
    using Ambit.Services.V1;
    using System;
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        #region Fields
        #endregion

        #region Ctor
        public HomeController()
        {
        }
        #endregion
        public ActionResult Index()
        {
            ViewBag.Title = "Home";
            return View();
        }

    }
}
