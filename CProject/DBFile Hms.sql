creatE database HMS
use HMS
create table Admin(
username varchar(25),
password varchar(25)
);
alter procedure [AddAdmin]  
@username varchar(40),  
@pwd varchar(40)  
as begin  
insert into Admin values(@username,@pwd)  
return @@rowcount
end  
--sp_helptext addadmin
declare @w int
exec [AddAdmin] 'manutd','cr7'
print @w
select *from Admin 





DROP DATABASE HMS
create table StaffType(
staffType varchar(50)  PRIMARY KEY
)
 create table Staff(
stId int IDENTITY(1,1),
firstName varchar(20) NOT NULL,
lastName varchar(20) NOT NULL,
mobileNo varchar(10) UNIQUE NOT NULL,
gender varchar(6) NOT NULL,
age tinyInt NOT NULL,
email varchar(20) UNIQUE,
homeAddress varchar(50) NOT NULL,
stafftype varchar(50) foreign key references StaffType(staffType),
CONSTRAINT PK_STAFF PRIMARY KEY(stId)
);
SELECT * FROM Staff
SELECT doctorId,firstName,lastName,mobileNo,gender,age,Name,email,homeAddress FROM Doctor,Staff,Department WHERE StaffType='Doctor' AND stId =staffId
DELETE STAFF WHERE stId=4
DELETE DOCTOR WHERE doctorId=1000
INSERT INTO STAFF VALUES('Eman','Yasin','0923567832','FEMALE',27,'emu@gmail.com','nifas silk','Nurse')
INSERT INTO STAFF VALUES('Menal','Yusuf','0923510832','FEMALE',27,'sam@gmail.com','nifas silk','Nurse')
INSERT INTO STAFF VALUES('Kamila','Mustafa','0910867832','FEMALE',27,'aqw12@gmail.com','nifas silk','Nurse')
INSERT INTO STAFF VALUES('Yohhana','Markos','0923563082','FEMALE',27,'dva@gmail.com','nifas silk','Doctor')
INSERT INTO STAFF VALUES('Danait','Sol','0901727832','FEMALE',27,'kope@gmail.com','nifas silk','Receptionist')
INSERT INTO STAFF VALUES('Feruz','Jemal','0920842632','FEMALE',27,'pisa@gmail.com','nifas silk','Receptionist')
INSERT INTO STAFF VALUES('Faiza','Seid','0998526832','FEMALE',27,'aqer@gmail.com','nifas silk','Receptionist')
INSERT INTO StaffType VALUES('Doctor')
INSERT INTO StaffType VALUES('Nurse')
INSERT INTO StaffType VALUES('Receptionist')
select * from staff
create table Department(
deptId int IDENTITY(1,1),
Name varchar(50) NOT NULL,
CONSTRAINT PK_DEPARTMENT PRIMARY KEY(deptId)
);
ALTER TABLE
INSERT INTO Department VALUES('Cardiology')

create table Doctor(
doctorId int identity(1000,1),
depId int foreign key references Department(deptId),
staffId int foreign key references Staff(stId) on delete cascade,
username varchar(25) UNIQUE,
password varchar(25) NOT NULL,
active bit NOT NULL DEFAULT 1,
CONSTRAINT PK_DOCTOR PRIMARY KEY(doctorId)
);
--sp Doc1
create proc Add_Doctor
@depId int,
@stfId int,
@uname varchar(30),
@pwd varchar(50),
@active varchar(5)
as begin
insert into Doctor values(@depId,@stfId,@uname,@pwd,case @active
when 'true' then 1
else 0 end)
end

create proc Edit_Doctor
@depId int,@stfId int,
@uname varchar(30),@pwd varchar(30),@active varchar(5),@docId int
as 
update Doctor set depId=@depId,staffId=@stfId,userName=@uname,password=@pwd  where doctorId=@docId
drop proc Edit_Doctor

create Proc Doctor_count
@x int out
as 
select @x=count(*) from Doctor
 
 create proc delete_Doctor
 @id int
 delete from Doctor where  doctorId=@id

 alter Proc SearchDoctor
 @var varchar(max),
 @var2 int out
 as begin
 select top 1 @var2=doctorId from Doctor where username like '%'+@var+'%' or cast(doctorId as varchar(5))=@var 
 end


 --   if( @n like '%'+@name+'%' or cast(@iq as varchar(5))=@name  or cast(@iq as varchar(5)) like '%'+@name+'%')  




ALTER TABLE Doctor
  ADD CONSTRAINT FK_DOCTOR_STAFF
  FOREIGN KEY (staffId)
  REFERENCES Staff(stId)
  ON DELETE CASCADE;
DELETE STAFF WHERE stId=4
SELECT * FROM Staff
ALTER TABLE Doctor ALTER COLUMN staffId  int  on delete cascade
ALTER VIEW View_Doctors AS
SELECT * FROM Staff,Doctor,Department Where stId=staffId AND depId=deptId
SELECT doctorId,(firstName+' '+lastName)AS Doctor,Name AS Department FROM View_Doctors

INSERT INTO DOCTOR VALUES(1,1000,'belay','12345',1)
SELECT doctorId,firstName,lastName,mobileNo,gender,age,Name,homeAddress FROM Doctor,Staff,Department
create table Nurse(
nurseId int identity(1000,1),
staffId int foreign key references Staff(stId) ON DELETE CASCADE,
active bit NOT NULL DEFAULT 1,
CONSTRAINT PK_NURSE PRIMARY KEY(nurseId),
);
Create VIEW View_Nurses AS
SELECT * FROM Nurse, Staff Where staffId=stId

SELECT nurseId,(firstName+' '+lastName)AS Nurse FROM View_Nurses
alter table nurse alter column nurseId int identity ;
INSERT INTO Nurse VALUES(1001,1)
SELECT * FROM Nurse
SELECT nurseId,firstName,lastName,mobileNo,gender,age,homeAddress FROM NURSE,Staff WHERE StaffType='Nurse'

Create table Receptionist(
rId int identity(1000,1),
staffId int foreign key references Staff(stId) ON DELETE CASCADE,
username varchar(10) UNIQUE  NOT NULL,
password varchar(10)  NOT NULL,
);
ALTER TABLE Nurse
  ADD CONSTRAINT FK_NURSE_STAFF
  FOREIGN KEY (staffId)
  REFERENCES Staff(stId)
  ON DELETE CASCADE;

INSERT INTO Receptionist VALUES(1002,'eman','emuti')
SELECT * FROM Receptionist, Staff
SELECT rId,firstName,lastName,mobileNo,gender,age,homeAddress FROM Receptionist,Staff WHERE StaffType='Receptionist'
create table Patient(
patientId int identity (1000,1),
firstName varchar(25) NOT NULL,
lastName varchar(25) NOT NULL,
mobileNo varchar(20) UNIQUE NOT NULL,
patient_type varchar(25) NOT NULL,
bloodgroup varchar(10) NOT NULL,
Address varchar(50),
dateAdded date NOT NULL DEFAULT GETDATE(),
age tinyint NOT NULL,
gender varchar(6) NOT NULL,
CONSTRAINT PK_PATIENT PRIMARY KEY(patientID));
ALTER TABLE PATIENT ADD disease varchar(50)

INSERT INTO Patient VALUES('John','Smith','0945405147','inpatient','AB-','addis ababa ethiopia',GETDATE(),19,'MALE')


SELECT * FROM Doctor




create table Medicine(
medicineId int identity(1000,1) primary key,
medicineName varchar(20) NOT NULL,
medicineCompany varchar(20) ,
medicineCost money 
);
ALTER TABLE MEDICINE ADD CONSTRAINT UQ_MEDICINE_NAME UNIQUE(medicineName)
INSERT INTO Medicine VALUES('Paracetomol','Julphar','50')
 create table Prescription(
prescId int PRIMARY KEY identity(1000,1),
ptId int foreign key references Patient(patientId),
docId int foreign key references Doctor(doctorId),
medicineId int foreign key references Medicine(medicineId),
dose varchar(255) NOT NULL,
dateof date  NOT NULL DEFAULT GETDATE(),
given bit NOT NULL DEFAULT 0 
);
select *from patient
select * from doctor
select * from medicine
select * from Prescription
UPDATE Appointment
SET done=1
WHERE appointId=1000
SELECT * FROM Appointment
ALTER TABLE Prescription ALTER COLUMN dose text
INSERT INTO Prescription(ptId,docId,medicineId,dose) VALUES(1001,1005,1000,'5ml in 3 times a day')
SELECT * from Prescription
CREATE VIEW Prescription_Details AS 
SELECT prescId,dateof,(firstName+' '+lastName)AS Patient,given FROM Prescription
INNER JOIN Patient ON ptId=patientId;

CREATE VIEW Doctor_Prescription AS 
SELECT prescId,dateof,(firstName+' '+lastName)AS Patient,given,username FROM Prescription 
INNER JOIN Patient ON ptId=patientId 
INNER JOIN Doctor ON docId=doctorId 
SELECT * FROM Doctor_Prescription WHERE username='doc1'
SELECT * FROM Prescription_Details
create table Room(
roomNo TINYint NOT NULL,
roomFloor tinyInt NOT NULL,
available bit DEFAULT 1,
CONSTRAINT PK_ROOM primary key(roomNo)
);
SELECT roomNo,roomFloor FROM Room

 create table Appointment(
appointId int identity(1000,1) primary key,
ptId int foreign key references Patient(patientId),
docId int foreign key references Doctor(doctorId),
nursId int foreign key references Nurse(nurseId),
roomNo tinyint foreign key references Room(roomNo),
dateof date  NOT NULL DEFAULT GETDATE(),
done bit NOT NULL
);
INSERT Appointment(ptId,docId,nursId,roomNo,dateof,done) VALUES (1001,1001,1000,18,default,0)
insert into Admin values('Admin','1234')
Select * from room
SELECT * FROM Prescription_Details Where 
SELECT * FROM Appointment,Patient ,Doctor, Staff WHERE ptId=patientId AND docId=doctorId and nursId=nurseId
CREATE VIEW Appointment_Details AS
SELECT appointId,(Patient.firstName +' '+ Patient.lastName) AS Patient,(Staff.firstName +' '+ Staff.lastName) AS Doctor ,roomNo,dateof,done, Doctor.active FROM Appointment 
                     INNER JOIN Patient ON ptId=patientId 
                     INNER JOIN Doctor  ON docId=doctorId 
                     INNER JOIN Nurse ON nursId=nurseId
                     INNER JOIN Staff ON Doctor.staffId=stId

SELECT * From Doctor

Create VIEW Doctor_Appointment AS
SELECT appointId,(Patient.firstName +' '+ Patient.lastName) AS Patient,roomNo,dateof,done,username,Doctor.active FROM Appointment 
                     INNER JOIN Patient ON ptId=patientId 
                     INNER JOIN Doctor  ON docId=doctorId 
                     INNER JOIN Nurse ON nursId=nurseId
                     INNER JOIN Staff ON Doctor.staffId=stId

SELECT * From Doctor_Appointment WHERE username='habtsh'
CREATE VIEW Edit_Prescription AS
SELECT medicineName,dose,prescId FROM Prescription 
INNER JOIN Medicine ON Prescription.medicineId=Medicine.medicineId
SELECT * FROM Edit_Prescription WHERE prescId=1000

CREATE TABLE Treatment(
treatId int identity(1000,1) PRIMARY KEY,
apId int foreign key references Appointment(appointId) NOT NULL,
prId int foreign key references Prescription(prescId),
symptoms text,
treatmnt text
)

INSERT INTO Treatment(apId,prId,symptoms,treatmnt) VALUES(1000,1000,'FEVER','Syringe')
SELECT * FROM Treatment

ALTER VIEW Appointment_Patient AS
SELECT patientid,firstName,lastName,mobileno,gender,age,bloodgroup,disease,appointId,docId from Patient
JOIN Appointment ON patientId=ptId 
SELECT * FROM Appointment_Patient WHERE appointId=1000
SELECT prescid FROM Prescription
INNER JOIN Patient ON patientId=ptId WHERE ptId=1000

