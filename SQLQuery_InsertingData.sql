insert into tblUser(EmailId,password,usertype,fid) values('archanareddypalli@gmail.com','archana123','farmer',1)
insert into tblUser(EmailId,password,usertype,bid) values('shashikumargundala@gmail.com','shashi123','Bidder',1)
insert into tblUser(EmailId,password,usertype) values('ujjawalsinghi97@gmail.com','ujjawal123','admin')

select * from tblUser

insert into tblFarmer(fUserName,fContactNo,fEmailId,fAddress,fCity,fState,fPincode,fLandArea,fLandAddress,
fLandPincode,fAccountNo,fIFSCcode,fAadhar,fPan,fCertificate,fPassword) 
values('Archana','9876543212','archanared@gmail.com','h.no-1-7-937/1,ashok colony',
'Hyderabad','Telangana','506119',2,'Nilayam','506119','1234123412341234','DWUP123678','123412356712',
'ghfs1234','certificate','archana123')


insert into tblBidder(bUserName,bContactNo,bEmailId,bAddress,bCity,bState,bPincode,bAccountNo,bIFSCcode,bAadhar,bPan,bTraderLicense,bPassword,ApprovedBy,ApprovedDate) 
values('shashi','9876543211','shashikumargundala@gmail.com','h.no-1-7-997/1,ashok colony',
'Hyderabad','Telangana','506019','1234123412341231','DWUP123671','123412356711',
'ghfs12341','certificatebidder','shashi123','ujjawalsinghi97@gmail.com','06-01-2021')

/*select * from tbluser
update tblfarmer set ApprovedBy='ujjawalsinghi97@gmail.com'
update tblBidder set ApprovedBy='ujjawalsinghi97@gmail.com'*/

insert into tblcropforsale(farmerid,croptype,cropname,quantity,FertilizerType,SoilPhCertificate,DateOfSoldCrop) 
values(1,'kharif','paddy','10','type1','certificatesoil','06-01-2021')

insert into tblcropforsale(farmerid,croptype,cropname,quantity,FertilizerType,SoilPhCertificate,DateOfSoldCrop) 
values(1,'kharif','rice','20','type2','certificatesoil','06-06-2020')
insert into tblcropforsale(farmerid,croptype,cropname,quantity,FertilizerType,SoilPhCertificate,DateOfSoldCrop) 
values(1,'rabi','barly','15','type3','certificatesoil','02-01-2021')
insert into tblcropforsale(farmerid,croptype,cropname,quantity,FertilizerType,SoilPhCertificate,DateOfSoldCrop) 
values(1,'kharif','rice','10','type2','certificatesoil','06-10-2020')
insert into tblcropforsale(farmerid,croptype,cropname,quantity,FertilizerType,SoilPhCertificate,DateOfSoldCrop) 
values(1,'rabi','maize','09','type4','certificatesoil','09-09-2021')
-->=========================================

insert into tblBids(CropId,BidderId,BidAmount,DateOfBid) values(102,1,30000,'6-01-2021')
select * from tblBids

insert into tblBidCrops(bidId,FarmerId,CropId,BidderId) values (803,1,102,1)

insert into tblInsurance(FarmerId,CropType,Year,CropName,Area,SumInsuredPerHectare) values (1,'kharif','2021','Paddy',2,40000)

insert into tblInsuranceClaim(Policyno,InsureeName,SumInsured,DateOfLoss,CauseOfLoss) values(250000,'Archana',40000,'6-01-2020','earthquake')

select * from tblbids

select * from tblCropForSale

update tblCropForSale set StatusOfCropSaleReq='approved' where CropId=105 

select * from tblbidder






    
insert into tblFarmer(fUserName,fContactNo,fEmailId,fAddress,fCity,fState,fPincode,fLandArea,fLandAddress,
fLandPincode,fAccountNo,fIFSCcode,fAadhar,fPan,fCertificate,fPassword,StatusOfFarmerDocx,ApprovedBy,ApprovedDate)
values('abc123','9876543212','dimpu@gmail.com','h.no-1-7-937/1,ashok colony',
'Hyderabad','Telangana','506119',2,'Nilayam','506119','1234123412341234','DWUP123678','123412356712',
'ghfs1234','certificate','abc123','verified','ujjawalsinghi97@gmail.com','06-01-2021')

insert into tblFarmer(fUserName,fContactNo,fEmailId,fAddress,fCity,fState,fPincode,fLandArea,fLandAddress,
fLandPincode,fAccountNo,fIFSCcode,fAadhar,fPan,fCertificate,fPassword)
values('dummy','6456543212','dummy@gmail.com','h.no-1-7-937/1,ashok colony',
'Hyderabad','Telangana','506119',2,'Nilayam','506119','1234123412341234','DWUP123678','123412356712',
'ghfs1234','certificate','deffdffd')

    
insert into tblBidder(bUserName,bContactNo,bEmailId,bAddress,bCity,bState,bPincode,bAccountNo,bIFSCcode,bAadhar,bPan,bTraderLicense,bPassword,StatusOfBidderDocx,ApprovedBy,ApprovedDate)
values('swarali','9876543211','swarali@gmail.com','h.no-1-7-997/1,ashok colony',
'Hyderabad','Telangana','506019','1234123412341231','DWUP123671','123412356711',
'ghfs12341','certificatebidder','swarali123','verified','ujjawalsinghi97@gmail.com','06-01-2021')

insert into tblBidder(bUserName,bContactNo,bEmailId,bAddress,bCity,bState,bPincode,bAccountNo,bIFSCcode,bAadhar,bPan,bTraderLicense,bPassword,ApprovedBy,ApprovedDate)
values('shristi','9876543211','shristi@gmail.com','h.no-1-7-997/1,ashok colony',
'Hyderabad','Telangana','506019','1234123412341231','DWUP123671','123412356711',
'ghfs12341','certificatebidder','shristi123','ujjawalsinghi97@gmail.com','06-01-2021')


insert into tblCropDetails(CropType,CropName,MspPerQuintal,ActuarialRatePercentage,YeildPerHectareTons) values('kharif','paddy',1815,4.06,4.5)
insert into tblCropDetails(CropType,CropName,MspPerQuintal,ActuarialRatePercentage,YeildPerHectareTons) values('kharif','jowar',2550,52.54,1)
insert into tblCropDetails(CropType,CropName,MspPerQuintal,ActuarialRatePercentage,YeildPerHectareTons) values('kharif','groundnut',5090,31.54,1.4)
insert into tblCropDetails(CropType,CropName,MspPerQuintal,ActuarialRatePercentage,YeildPerHectareTons) values('kharif','maize',1760,19.24,4)
insert into tblCropDetails(CropType,CropName,MspPerQuintal,ActuarialRatePercentage,YeildPerHectareTons) values('kharif','sesame',6485,22.99,0.5)
insert into tblCropDetails(CropType,CropName,MspPerQuintal,ActuarialRatePercentage,YeildPerHectareTons) values('rabi','wheat',1840,5,1.4)
insert into tblCropDetails(CropType,CropName,MspPerQuintal,ActuarialRatePercentage,YeildPerHectareTons) values('rabi','mustard',4200,10,0.4)
insert into tblCropDetails(CropType,CropName,MspPerQuintal,ActuarialRatePercentage,YeildPerHectareTons) values('rabi','gram(bengal gram)',4620,12,0.5)
insert into tblCropDetails(CropType,CropName,MspPerQuintal,ActuarialRatePercentage,YeildPerHectareTons) values('rabi','masur(lentil)',4475,15,0.4)
insert into tblCropDetails(CropType,CropName,MspPerQuintal,ActuarialRatePercentage,YeildPerHectareTons) values('rabi','barley',1440,2,3.6)
insert into tblCropDetails(CropType,CropName,MspPerQuintal,ActuarialRatePercentage,YeildPerHectareTons) values('horticultural','sugarcane',285,5,42)
insert into tblCropDetails(CropType,CropName,MspPerQuintal,ActuarialRatePercentage,YeildPerHectareTons) values('horticultural','cotton',5550,18,0.8)

select * from tblInsurance
    
insert into tblInsurance(FarmerId,CropType,Year,CropName,Area,SumInsuredPerHectare) values (3,'kharif','2021','Paddy',2,40000)

insert into tblInsuranceClaim(Policyno,InsureeName,SumInsured,DateOfLoss,CauseOfLoss) values(250000,'Archana',40000,'6-01-2020','earthquake')
​
    
alter table tblinsurance add DateofApplication date default getdate()


select * from tblCropDetails

select * from tblCropForSale

select * from tblBids

select * from tblfarmer

select * from tbluser

select * from tblBidder

select * from tblinsurance

select * from tblInsuranceClaim