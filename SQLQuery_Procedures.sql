--==selling data
alter proc sp_getCropData
as
begin
select * from tblCropForSale where StatusOfCropSaleReq='approved'
end
exec sp_getCropData

create proc sp_newBid(@cropid int,@bidderid int,@bidamt money,@dateofbid date)
as
begin
insert into tblBids(CropId,BidderId,BidAmount,DateOfBid) values(@cropid,@bidderid,@bidamt,@dateofbid)
end

--============================================
create proc sp_InsertintoBidCrops(@bidId int,@FarmerId int ,@CropId int ,@BidderId int)
as
begin
insert into tblBidCrops(bidId,FarmerId,CropId,BidderId) values (@bidId,@FarmerId,@CropId,@BidderId)
end