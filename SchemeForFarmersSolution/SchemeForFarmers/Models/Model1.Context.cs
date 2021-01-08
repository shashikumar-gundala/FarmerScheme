﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchemeForFarmers.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class dbFarmerScheme3Entities : DbContext
    {
        public dbFarmerScheme3Entities()
            : base("name=dbFarmerScheme3Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tblBidCrop> tblBidCrops { get; set; }
        public virtual DbSet<tblBidder> tblBidders { get; set; }
        public virtual DbSet<tblBid> tblBids { get; set; }
        public virtual DbSet<tblCropDetail> tblCropDetails { get; set; }
        public virtual DbSet<tblCropForSale> tblCropForSales { get; set; }
        public virtual DbSet<tblFarmer> tblFarmers { get; set; }
        public virtual DbSet<tblInsurance> tblInsurances { get; set; }
        public virtual DbSet<tblInsuranceClaim> tblInsuranceClaims { get; set; }
        public virtual DbSet<tblUser> tblUsers { get; set; }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_getCropData_Result> sp_getCropData()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_getCropData_Result>("sp_getCropData");
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int sp_newBid(Nullable<int> cropid, Nullable<int> bidderid, Nullable<decimal> bidamt, Nullable<System.DateTime> dateofbid)
        {
            var cropidParameter = cropid.HasValue ?
                new ObjectParameter("cropid", cropid) :
                new ObjectParameter("cropid", typeof(int));
    
            var bidderidParameter = bidderid.HasValue ?
                new ObjectParameter("bidderid", bidderid) :
                new ObjectParameter("bidderid", typeof(int));
    
            var bidamtParameter = bidamt.HasValue ?
                new ObjectParameter("bidamt", bidamt) :
                new ObjectParameter("bidamt", typeof(decimal));
    
            var dateofbidParameter = dateofbid.HasValue ?
                new ObjectParameter("dateofbid", dateofbid) :
                new ObjectParameter("dateofbid", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_newBid", cropidParameter, bidderidParameter, bidamtParameter, dateofbidParameter);
        }
    
        public virtual int sp_InsertintoBidCrops(Nullable<int> bidId, Nullable<int> farmerId, Nullable<int> cropId, Nullable<int> bidderId)
        {
            var bidIdParameter = bidId.HasValue ?
                new ObjectParameter("bidId", bidId) :
                new ObjectParameter("bidId", typeof(int));
    
            var farmerIdParameter = farmerId.HasValue ?
                new ObjectParameter("FarmerId", farmerId) :
                new ObjectParameter("FarmerId", typeof(int));
    
            var cropIdParameter = cropId.HasValue ?
                new ObjectParameter("CropId", cropId) :
                new ObjectParameter("CropId", typeof(int));
    
            var bidderIdParameter = bidderId.HasValue ?
                new ObjectParameter("BidderId", bidderId) :
                new ObjectParameter("BidderId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InsertintoBidCrops", bidIdParameter, farmerIdParameter, cropIdParameter, bidderIdParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> sp_GetMAxBidAmount(Nullable<int> cropid)
        {
            var cropidParameter = cropid.HasValue ?
                new ObjectParameter("cropid", cropid) :
                new ObjectParameter("cropid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("sp_GetMAxBidAmount", cropidParameter);
        }
    }
}
