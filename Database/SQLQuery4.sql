
Create table tblMain
(
MainID int Primary key identity,
aDate date,
aTime varchar(15),
TableName varchar(10),
WaiterName varchar(15),
status varchar(15),
orderType varchar(15),
total float,
recieved float,
change float
)

Create table tblDetails
(
DetailID int Primary key identity,
MainID int,
proID int,
qty int,
price float,
amount float

)

truncate table tblDetails;
truncate table tblMain;

select * from tblMain m inner join tblDetails d on m.MainID = d.MainID

ALTER TABLE tblMain
ADD driverID int,
    CustName varchar(50),
    CustPhone varchar(50);