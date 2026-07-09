create Database SmartMedPharmacy;

use SmartMedPharmacy;

create table Users(
	MobileNumber varchar(10) primary key,
	Email varchar(50) not null,
	Address varchar(100) not null,
	Password varchar(100) not null,
	Role varchar(20) not null
);

insert into Users (MobileNumber, Email, Address, Password, Role) values ('0762106833', 'admin@gmail.com', 'Colombo', '7676aaafb027c825bd9abab78b234070e702752f625b752e55e55b48e607e358', 'Admin');


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

CREATE TABLE Orders (
    OrderId INT PRIMARY KEY AUTO_INCREMENT,
    CustomerMobile VARCHAR(10) NOT NULL,
    OrderDate DATETIME NOT NULL,
    DeliveryType VARCHAR(20) NOT NULL,
    DeliveryAddress VARCHAR(150),
    TotalAmount DECIMAL(10,2) NOT NULL,
    Status VARCHAR(20) NOT NULL,

    FOREIGN KEY (CustomerMobile)
    REFERENCES Users(MobileNumber)
);

CREATE TABLE OrderItems (
    OrderItemId INT PRIMARY KEY AUTO_INCREMENT,
    OrderId INT NOT NULL,
    MedicineId INT NOT NULL,
    Quantity INT NOT NULL,
    Price DECIMAL(10,2) NOT NULL,

    FOREIGN KEY (OrderId)
    REFERENCES Orders(OrderId),

    FOREIGN KEY (MedicineId)
    REFERENCES Medicines(MedicineId)
);




