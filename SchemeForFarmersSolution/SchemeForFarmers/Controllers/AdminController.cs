using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SchemeForFarmers.Models;
using System.Web.Http.Cors;
using System.Data.Entity;

namespace SchemeForFarmers.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    //[Authorize]
    public class AdminController : ApiController
    {
        dbFarmerScheme3Entities entities = new dbFarmerScheme3Entities();
        [HttpGet]
        [Route("api/admin/getPendingSales")]
        public HttpResponseMessage Getsale()
       {
            List<sp_getPendingSaleData_Result> results = entities.sp_getPendingSaleData().ToList();
            if(results.Count == 0)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No pending sale Data");
            }
            return Request.CreateResponse<IEnumerable<sp_getPendingSaleData_Result>>(HttpStatusCode.OK, results);
        }
        [HttpGet]
        [Route("api/admin/getPendingBids")]
        public HttpResponseMessage Getbids()
        {
            List<sp_getpendingbids_Result> results = entities.sp_getpendingbids().ToList();
            if (results.Count == 0)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No pending Bids Found");
            }
            return Request.CreateResponse<IEnumerable<sp_getpendingbids_Result>>(HttpStatusCode.OK, results);
        }
        [HttpGet]
        [Route("api/admin/getPendingBidders")]
        public HttpResponseMessage GetBidders()
        {
            List<sp_getPendingBidders_Result> results = entities.sp_getPendingBidders().ToList();
            if (results.Count == 0)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No bidder is waitng for Approval");
            }
            return Request.CreateResponse<IEnumerable<sp_getPendingBidders_Result>>(HttpStatusCode.OK, results);
        }

        [HttpGet]
        [Route("api/admin/getPendingFarmers")]
        public HttpResponseMessage GetFarmers()
        {
            List<sp_getPendingFarmers_Result> results = entities.sp_getPendingFarmers().ToList();
            if (results.Count == 0)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No bidder is waitng for Approval");
            }
            return Request.CreateResponse<IEnumerable<sp_getPendingFarmers_Result>>(HttpStatusCode.OK, results);
        }
        [HttpPost]
        [Route("api/admin/approveFarmer")]
        public HttpResponseMessage Post(tblFarmer farmer)
        {
            DbContextTransaction transaction = entities.Database.BeginTransaction();
            try
            {
                entities.sp_approveFarmer(farmer.fId, farmer.ApprovedBy, farmer.ApprovedDate, farmer.fPassword, farmer.fEmailId);
                entities.SaveChanges();
                transaction.Commit();
            }
            catch (Exception)
            {
                transaction.Rollback();
                return Request.CreateErrorResponse(HttpStatusCode.Conflict, "Not able to approve the user");

            }
            return Request.CreateResponse(HttpStatusCode.OK);
        }
        [HttpPost]
        [Route("api/admin/approvebidder")]
        public HttpResponseMessage Post(tblBidder bidder)
        {
            DbContextTransaction transaction = entities.Database.BeginTransaction();
            try
            {
                entities.sp_approveBidder(bidder.bId,bidder.ApprovedBy,bidder.ApprovedDate,bidder.bPassword,bidder.bEmailId);
                entities.SaveChanges();
                transaction.Commit();
            }
            catch (Exception)
            {
                transaction.Rollback();
                return Request.CreateErrorResponse(HttpStatusCode.Conflict, "Not able to approve the user");

            }
            return Request.CreateResponse(HttpStatusCode.OK);
        }
        [HttpPost]
        [Route("api/admin/approvebid")]
        public HttpResponseMessage Post(tblBid bid)
        {
            DbContextTransaction transaction = entities.Database.BeginTransaction();
            try
            {
                entities.sp_approveBid(bid.bId,bid.CropId);
                entities.SaveChanges();
                transaction.Commit();
            }
            catch (Exception)
            {
                transaction.Rollback();
                return Request.CreateErrorResponse(HttpStatusCode.Conflict, "Something went Wrong Try to bid again");

            }
            return Request.CreateResponse(HttpStatusCode.OK);
        }
        [HttpPost]
        [Route("api/admin/approveSaleData")]
        public HttpResponseMessage Post(tblCropForSale sale)
        {
            DbContextTransaction transaction = entities.Database.BeginTransaction();
            try
            {
                entities.sp_approvesale(sale.CropId,sale.CropType,sale.CropName);
                entities.SaveChanges();
                transaction.Commit();
            }
            catch (Exception)
            {
                transaction.Rollback();
                return Request.CreateErrorResponse(HttpStatusCode.Conflict, "Not able to approve the user");

            }
            return Request.CreateResponse(HttpStatusCode.OK);
        }
        [HttpGet]
        [Route("api/admin/getCliamData")]
        public HttpResponseMessage GetClaimData()
        {
            List<sp_getClaimData_Result> results = entities.sp_getClaimData().ToList();
            if(results.Count == 0)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NoContent, "No ClaimData Found");
            }
            return Request.CreateResponse<IEnumerable<sp_getClaimData_Result>>(HttpStatusCode.OK, results);
        }
        [HttpPost]
        [Route("api/admin/approveclaim")]
        public HttpResponseMessage approveclaim(DateTime dateofloss,tblInsurance insurance)
        {
            DbContextTransaction transaction = entities.Database.BeginTransaction();
            try
            {
                
                entities.proc_checkexpiredateofclaim(Convert.ToInt32(insurance.InsuranceApplicationId), insurance.DateofApplication,dateofloss, 
                    insurance.FarmerId, insurance.CropType);
                entities.SaveChanges();
                transaction.Commit();

            }
            catch (Exception e)
            {
                transaction.Rollback();
                return Request.CreateErrorResponse(HttpStatusCode.Ambiguous, e.Message);
            }
            return Request.CreateResponse(HttpStatusCode.OK);
        }

    }
}
