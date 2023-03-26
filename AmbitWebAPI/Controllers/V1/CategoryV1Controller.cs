using Ambit.APICommon;
using Ambit.Common;
using Ambit.Common.Paging;
using Ambit.Entities.Contract;
using Ambit.Entities.V1;
using Ambit.Services.Contract;
using AmbitWebAPI.Helper;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace AmbitWebAPI.Controllers.V1
{
    public class CategoryV1Controller : AbstractBaseController
    {
        #region Fields
        private readonly AbstractCategoryServices abstractCategoryServices;
        #endregion

        #region Ctor
        public CategoryV1Controller(AbstractCategoryServices abstractCategoryServices)
        {
            this.abstractCategoryServices = abstractCategoryServices;
        }
        #endregion

        #region Methods

        //Register
        [System.Web.Http.HttpGet]
        //[System.Web.Http.Authorize]
        [InheritedRoute("CategorySelectAll")]
        public async Task<IHttpActionResult> CategorySelectAll()
        {
            var result = abstractCategoryServices.CategorySelectAll();
            return this.Content(HttpStatusCode.OK, result);
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

    }

    #endregion
}
