User list data with pagination and search,
 In this application i used Mysql database and here are the sql queries i used to create the table and insert data to it.

You can use two ways to create the table in the database :
 1. connect your database, go to the powersheel and run "update-database" then the Table will be created 
 2. Use MySql Query to create Users Table with the requered fields use:
    CREATE TABLE users ( Id int NOT NULL AUTO_INCREMENT, FirstName varchar(250) 
    CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL, LastName varchar(250) 
    CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL, EmailId varchar(250)
    CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL, Address varchar(250)
    CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL, DateOfBirth datetime(6) 
    NOT NULL, PRIMARY KEY (Id) 
    ) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

To insert the data into the table use the below query
INSERT INTO users(Id,FirstName,LastName,EmailId,Address,DateOfBirth) VALUES 
(1,'Zenawit','Kmariam','zenakma@gmail.com','Addis Ababa','2020-02-26 22:51:56.000000'), 
(2,'Nebu','Tame','nebu@gmail.com','Addis Ababa','2004-12-02 22:51:56.000000'), 
(3,'Awi','Twe','Awi@gmail.com','Nazreth','2004-12-02 22:51:56.000000'), 
(4,'Anani','Ashebr','Anani@gmail.com','Assosa','2019-01-15 22:54:12.000000'),
 (5,'Melu','Abebe','Anani@gmail.com','Assosa','2019-01-15 22:54:12.000000'), 
(6,'Tigst','Daniel','TG@gmail.com','Awasa','2014-01-13 22:55:09.000000'), 
(7,'Hani','Asefa','hani@gmail.com','Mekelle','2014-06-17 22:55:47.000000'), 
(8,'Selam','Tesema','soli@gmail.com','Jimma','2009-10-28 22:56:32.000000'), 
(9,'Robi','Dereje','RobuDerege@gmail.com','Robi@gmail.com','2022-06-01 22:57:14.000000');