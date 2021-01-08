using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.ComponentModel.DataAnnotations;
using System.Web.Http.Cors;
using SchemeForFarmers.Models;
using System.Data.Entity;

namespace SchemeForFarmers.Controllers
{
   // [Authorize]
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class BidderController : ApiController
    {
        dbFarmerScheme3Entities entities = new dbFarmerScheme3Entities();
       [Route("api/bidder/GetSaleData")]
       public HttpResponseMessage Get()
        {
           
            if(entities.sp_getCropData().ToList().Count == 0)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No Data Found");
            }
            return Request.CreateResponse<IEnumerable<sp_getCropData_Result>>(HttpStatusCode.OK,entities.sp_getCropData().ToList());
        }
        [HttpGet]
        [Route("api/bidder/currentMax")]
        public HttpResponseMessage Get(int cropid)
        {
            var amt =entities.sp_GetMAxBidAmount(cropid);
            if ( amt == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Crop Not Found");
            }
            return Request.CreateResponse<dynamic>(HttpStatusCode.OK, amt);
        }
        [HttpPost]
        [Route("api/bidder/newbid")]
        public HttpResponseMessage Post(int fid,tblBid bid)
        {
            //entities.tblBids.Add(bid); 
            DbContextTransaction transaction = entities.Database.BeginTransaction();
            try
            {
                entities.sp_newBid(bid.CropId, bid.BidderId, bid.BidAmount, bid.DateOfBid);
                entities.SaveChanges();
                int bidID = entities.tblBids.Max(x => x.bId);
                entities.sp_InsertintoBidCrops(bidID, fid, bid.CropId, bid.BidderId);
                entities.SaveChanges();
                transaction.Commit();
            }catch (Exception)
            {
                transaction.Rollback();
                return Request.CreateErrorResponse(HttpStatusCode.Conflict, "Could not insert data ");
            }
            return Request.CreateResponse(HttpStatusCode.Created);
        }
    }
}
