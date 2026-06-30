create Database SmartMedPharmacy;

use SmartMedPharmacy;

create table Users(
	MobileNumber varchar(10) primary key,
	Email varchar(50) not null,
	Address varchar(100) not null,
	Password varchar(100) not null,
	Role varchar(20) not null
);

insert into Users (MobileNumber, Email, Address, Password, Role) values ('0762106833', 'admin@gmail.com', 'Colombo', 'admin@123', 'Admin');


create table Medicines (
    MedicineId int AUTO_INCREMENT PRIMARY KEY,
    Name varchar(100) NOT NULL,
    Stock int NOT NULL,
    Category varchar(50) NOT NULL,
    Supplier varchar(100) NOT NULL,
    Price decimal(10,2) NOT NULL,
    Dosage varchar(50) NOT NULL,
    ExpiryDate date NOT NULL
);




