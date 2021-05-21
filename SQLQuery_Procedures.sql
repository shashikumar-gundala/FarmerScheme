--===Procedures for bidder
--==selling data
drop proc sp_getCropData
create proc sp_getCropData1
as
begin
select * from tblCropForSale where StatusOfCropSaleReq='approved'
end

exec sp_getCropData1

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

--===To get Cuuremax bid

Create proc sp_GetMAxBidAmount(@cropid int)
as
begin
select MAX(BidAmount) from tblBids where CropId=@cropid
end

exec sp_GetMAxBidAmount 102



--==>procedures for admin
create proc sp_getPendingSaleData
as 
begin
select * from tblCropForSale where StatusOfCropSaleReq='pending' 
end
exec sp_getPendingSaleData



--==>pending bidder users
create proc sp_getPendingBidders
as
begin
select * from tblBidder where StatusOfBidderDocx='pending'
end
exec sp_getPendingBidders
--==pending farmer users
create proc sp_getPendingFarmers
as 
begin
select * from tblFarmer where StatusOfFarmerDocx='pending'
end
exec sp_getPendingFarmers
--==>pending new bids

create proc sp_getpendingbids
as 
begin
select * from tblBids where BidStatus='pending'
end
exec sp_getpendingbids

sp_rename 'tblCropForSale.DateOfSoldCrop', 'DateOfRequestForSell', 'COLUMN'
alter table tblCropForSale add DateOfSoldCrop date
select * from tblcropforsale
select * from tblFarmer
--===============Procedure for Admin approvals
alter proc sp_approveFarmer(@fid int,@admin varchar(100),@aDate date,@pass varchar(20),@email varchar(50))
as
begin
update tblFarmer set StatusOfFarmerDocx='verified',ApprovedBy=@admin,ApprovedDate=@aDate where fId=@fid;
insert into tblUser(EmailId,Password,UserType,fid)values(@email,@pass,'Farmer',@fid)
end

exec sp_approveFarmer 1,'shashi','2021-01-09','archana123','archanareddypalli@gmail.com'
--==bidder approval
alter proc sp_approveBidder(@bid int,@admin varchar(100),@adate date,@pass varchar(20),@email varchar(50))
as
begin
update tblBidder set StatusOfBidderDocx='verified',ApprovedBy=@admin,ApprovedDate=@aDate where bId=@bid
insert into tblUser(EmailId,Password,UserType,fid)values(@email,@pass,'Farmer',@bid)
end
--==sale data approval
alter proc sp_approvesale(@cropid int,@cropType varchar(20),@cropname  varchar(20))
as
begin
declare @msp money
set @msp = (select MspPerQuintal from tblcropDetails where CropName=@cropname and CropType=@cropType)
update tblCropForSale set MSP=@msp,StatusOfCropSaleReq='approved' where CropId=@cropid
end

---====bid approval


alter  proc sp_approveBid(@bid int,@cropid int)
as 
begin
update tblCropforsale set SoldPrice=(select max(bidamount) from tblBids where cropid = @cropid) where cropid=@cropid
update tblcropforsale set totalprice=quantity*SoldPrice,StatusOfCropSaleReq='sold',DateOfSoldCrop=GETDATE() where CropId=@cropid
update tblBids set BidStatus='approved' where bId=@bid
end

exec sp_approveBid 




exec  sp_approveBid 803
exec sp_approvesale 102,'kharif','paddy'

select * from tblUser
delete from tblUser where EmailId='archanareddypalli@gmail.com'

exec sp_approveBid 810,102


alter table tblcropforsale drop constraint CK__tblCropFo__Statu__1CF15040