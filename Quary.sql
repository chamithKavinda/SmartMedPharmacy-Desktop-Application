create Database SmartMedPharmacy;

use SmartMedPharmacy;

create table Users(
	MobileNumber varchar(10) primary key,
	Email varchar(50) not null,
	Address varchar(100) not null,
	Password varchar(20) not null,
	Role varchar(20) not null
);

