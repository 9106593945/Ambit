using Ambit.APICommon;
using Ambit.Common;
using Ambit.Common.Paging;
using Ambit.Entities.Contract;
using Ambit.Entities.V1;
using Ambit.Services.Contract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace AmbitWebAPI.Controllers.V1
{
    public class CustomerV1Controller : AbstractBaseController
    {
        #region Fields
        private readonly AbstractCustomerLoginServices abstractCustomerServices;
        #endregion

        #region Ctor
        public CustomerV1Controller(AbstractCustomerLoginServices abstractCustomerServices)
        {
            this.abstractCustomerServices = abstractCustomerServices;
        }
        #endregion

        #region Methods

        //Register
        [System.Web.Http.HttpPost]
        //[System.Web.Http.Authorize]
        [InheritedRoute("CustomerLoginUpsert")]
        public async Task<IHttpActionResult> CustomerLoginUpsert([FromBody]CustomerLogin customer)
        {
            var model = abstractCustomerServices.CustomerLoginUpsert(customer);
            return this.Content((HttpStatusCode)model.Code, model);
        }

        //[System.Web.Http.HttpGet]
        //[System.Web.Http.Authorize]
        //[InheritedRoute("UserById")]
        //public async Task<IHttpActionResult> UserById(int UserId)
        //{
        //    var result = abstractUsersServices.UserById(UserId, "");
        //    return this.Content(HttpStatusCode.OK, result);
        //}

        //[System.Web.Http.HttpGet]
        //[System.Web.Http.Authorize]
        //[InheritedRoute("UserAll")]
        //public async Task<IHttpActionResult> UserAll(int Offset = 0, int Limit = 100, string Search = "")
        //{
        //    PageParam pageParam = new PageParam();
        //    pageParam.Offset = Offset;
        //    pageParam.Limit = Limit;
        //    var result = abstractUsersServices.UserAll(pageParam, Search);
        //    return this.Content(HttpStatusCode.OK, result);
        //}

        //[System.Web.Http.HttpPost]
        //[System.Web.Http.Authorize]
        //[InheritedRoute("UserDelete")]
        //public async Task<IHttpActionResult> UserDelete(int CustomerId)
        //{
        //    var model = abstractUsersServices.UserDeendregionlete(CustomerId);
        //    return this.Content(HttpStatusCode.OK, model);
        //}

        //Login
        //[System.Web.Http.Authorize]
        [System.Web.Http.HttpPost]
        [InheritedRoute("Login")]
        public async Task<IHttpActionResult> Login([FromBody]CustomerLogin customer)
        {
            SuccessResult<AbstractCustomerLogin> result = this.abstractCustomerServices.Login(customer);
            return this.Content((HttpStatusCode)result.Code, result);
        }

    }

    #endregion
}
