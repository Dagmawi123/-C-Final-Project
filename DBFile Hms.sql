create database HMS
use HMS
create table Admin(
username varchar(25) unique,
password varchar(25)
);
--sp Admin 1
alter procedure [spAddAdmin]  
@username varchar(40),  
@pwd varchar(40)  
as begin  
insert into Admin values(@username,@pwd)  
return @@rowcount
end  

--sp Admin 2
create procedure [spSelectAdmins]
as 
select *from Admin

--sp Admin 3
create procedure [spDeleteAdmin]
@username varchar(40)
as 
delete from Admin where username=@username

--sp Admin 4
create procedure [spChangePwd]
@username varchar(40),@pwd varchar(50)
as
update Admin set password=@pwd where username=@username

--sp Admin 5
create procedure [spSearchAdmin]
@username varchar(40)
as 
select username from Admin where username like '%'+@username+'%'

--sp_helptext addadmin
--sp Admin 
DROP table Admin

select *from receptionist
delete from receptionist
insert into admin values('Mesfin','Debebe')
insert into Receptionist(username,password) values('Zelalem','Ze')

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

select * from stafftype


create table Department(
deptId int IDENTITY(1,1),
Name varchar(50) NOT NULL,
CONSTRAINT PK_DEPARTMENT PRIMARY KEY(deptId)
);
--sp Dep 1
go
create proc spAddDepartment
@depname varchar(25)
as
begin
		declare @reseedvalueDepartment int
		select  TOP 1 @reseedvalueDepartment =deptId from Department ORDER BY deptId desc
insert into Department values (@depname)
if @@ERROR > 0

		begin
			DBCC CHECKIDENT ('Department', RESEED,@reseedvalueDepartment);
		end
end
--------------------
--so Dep2
go
create proc spViewDepartment
as
select deptId,Name from Department
---------------------
--sp Dep3
go
create proc spEditDepartment
@depid int,
@depname varchar(25)
as
update Department set Name=@depname where deptId=@depId
--------------------
--sp Dep4
go
create proc spSearchDepartmentById
@depid int
as
select * from Department where deptId=@depid
-----------------------
--sp Dep 5

go
create proc spGetAllDepartment
as
select Name from Department
-------------------------
--Sp Dep 6
go
create proc spDeleteDepartment
@depid int
as 
delete Department where deptId=@depid








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
go
create proc spSearchDoctorById
@id int
as
begin
select firstName,lastName,mobileNo,gender,age,email,homeAddress,Name,username,password from Doctor 
join Staff on stId = staffId
join Department on depId=deptId
where doctorId=@id
end

exec spSearchDoctorById 1001


go
--sp Doc2

create proc spSearchDoctorByName
@name varchar(50)
as
begin
select firstName,lastName,mobileNo,gender,age,email,homeAddress,Name,username,password from Doctor 
join Staff on stId = staffId
join Department on depId=deptId
where firstName+lastName like '%'+@name+'%'
end


drop proc Add_Doctor

--spDoc3

CREATE PROC spAddDoctor
@firstname varchar(25),
@lastname varchar(25),
@mobileno varchar(25),
@gender varchar(10),
@age int,
@email varchar(100),
@homeAddress varchar(100),
@department varchar(25),
@username varchar(25),
@password  varchar(25)
AS
BEGIN
		DECLARE @staffId int,@depId int,@errvalue int,@staffreseed int
		DECLARE @Stafftbl TABLE (staffID INT)

		declare @reseedvalueStaff int
			select  TOP 1 @reseedvalueStaff =stId from Staff ORDER BY stId desc
		
		declare @reseedvalueDoctor int
		select  TOP 1 @reseedvalueDoctor =doctorId from Doctor ORDER BY doctorId desc
		
		begin transaction

	    INSERT INTO Staff OUTPUT inserted.stId INTO @StaffTbl(staffID) VALUES(@firstname,@lastname,@mobileno,@gender,@age,@email,@homeAddress,'Doctor') 
		select @staffId=staffID from @Stafftbl
		
		if @@ERROR > 0
			rollback transaction
	
		select @depId= deptid from Department where Name=@department
		insert into Doctor(depId,staffId,username,password) values(@depId,@staffId,@username,@password)
		
		if @@ERROR > 0
			rollback transaction
	
		commit transaction

		if @@ERROR > 0

		begin
			DBCC CHECKIDENT ('Doctor', RESEED,@reseedvalueDoctor);
			DBCC CHECKIDENT ('Staff', RESEED,@reseedvalueStaff);
		end

END


drop proc Edit_Doctor

--spDoc4
create proc spEditDoctor
@doctorId int,
@firstname varchar(25),
@lastname varchar(25),
@mobileno varchar(25),
@gender varchar(10),
@age int,
@email varchar(100),
@homeAddress varchar(100),
@department varchar(25),
@username varchar(25),
@password  varchar(25)
as
begin
declare @staffId int,@depId int
select @staffId=staffId from Doctor where doctorId=@doctorId
select @depId=deptid from Department where Name=@department

Update Staff set firstName =@firstname,lastName = @lastname, mobileNo = @mobileno, gender = @gender, age = @age , email = @email, homeAddress = @homeAddress WHERE stId= @staffId
Update Doctor set depId =@depId,username = @username ,password =@password WHERE doctorId= @doctorId

end
drop proc Edit_Doctor
 
 --spDoc5
create proc spDeleteDoctor
@doctorId int
as
begin
	declare @staffid int
	select @staffid=staffId from doctor where doctorId=@doctorId

	delete Staff 
	where stId=@staffid
end
 --spDoc7
 --alter Proc SearchDoctor
 --@var varchar(max),
 --@var2 int out
 --as begin
 --select top 1 @var2=doctorId from Doctor where username like '%'+@var+'%' or cast(doctorId as varchar(5))=@var 
 --end


--sp Doc 6
 create proc[spDocIdByName]
@name varchar(50),
@id int output
as  
Select @id=doctorId from Doctor where username=@name


 --   if( @n like '%'+@name+'%' or cast(@iq as varchar(5))=@name  or cast(@iq as varchar(5)) like '%'+@name+'%')  

 --sp Doc 7
 Create Proc [spChangeStatus]
 @docId int,
 @preValue bit
 as 
 Begin
 if(@preValue=0)
 update Doctor set Active=1 where doctorId=@docId
 else
 update Doctor set Active=0 where doctorId=@docId
 End
 --spProc 8
 CREATE PROC spViewDoctor AS
SELECT doctorId,firstName,lastName,mobileNo,gender,age,email,homeAddress,Name 
FROM Staff,Doctor,Department Where stId=staffId AND depId=deptId

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

--sp nurse 1
go
Create Proc spViewNurse
AS
SELECT nurseId,firstName,lastName,mobileNo,gender,age,email,homeAddress FROM Nurse, Staff Where staffId=stId

---------------------------
--sp nurse 2
GO
CREATE proc spSearchNurseById
@id int
as
begin
select firstName,lastName,mobileNo,gender,age,email,homeAddress from Nurse
join Staff on stId = staffId
where nurseId=@id
end

-------------------------------
--sp nurse 3
go
CREATE PROC spAddNurse
@firstname varchar(25),
@lastname varchar(25),
@mobileno varchar(25),
@gender varchar(10),
@age int,
@email varchar(100),
@homeAddress varchar(100)
AS
BEGIN
		DECLARE @staffId int,@errvalue int,@staffreseed int
		DECLARE @Stafftbl TABLE (staffID INT)

		declare @reseedvalueStaff int
			select  TOP 1 @reseedvalueStaff =stId from Staff ORDER BY stId desc
		
		declare @reseedvalueNurse int
		select  TOP 1 @reseedvalueNurse =nurseId from Nurse ORDER BY nurseId desc

		begin transaction

	    INSERT INTO Staff OUTPUT inserted.stId INTO @StaffTbl(staffID) VALUES(@firstname,@lastname,@mobileno,@gender,@age,@email,@homeAddress,'Receptionist') 
		select @staffId=staffID from @Stafftbl
		
		if @@ERROR > 0
			rollback transaction
	
		insert into Nurse(staffId) values(@staffId)
		
		if @@ERROR > 0
			rollback transaction
	
		commit transaction

		if @@ERROR > 0

		begin
			DBCC CHECKIDENT ('Nurse', RESEED,@reseedvalueNurse);
			DBCC CHECKIDENT ('Staff', RESEED,@reseedvalueStaff);
		end

END

--sp nurse 4
create proc spDeleteNurse
@nurseId int
as
begin
	declare @staffid int
	select @staffid=staffId from Nurse where nurseId=@nurseId

	delete Staff 
	where stId=@staffid
end
-----------
--sp nurse 5

go
create proc spEditNurse
@nurseId int,
@firstname varchar(25),
@lastname varchar(25),
@mobileno varchar(25),
@gender varchar(10),
@age int,
@email varchar(100),
@homeAddress varchar(100)
as
begin
declare @staffId int
select @staffId=staffId from Nurse where nurseId=@nurseId
Update Staff set firstName =@firstname,lastName = @lastname, mobileNo = @mobileno, gender = @gender, age = @age , email = @email, homeAddress = @homeAddress WHERE stId= @staffId
end









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

--sp Receptionist 1
create proc [spSelectRecep]
as 
select username,password from Receptionist

--sp recep 2
go
Create Proc spViewReceptionist
AS
SELECT rId,firstName,lastName,mobileNo,gender,age,email,homeAddress FROM Receptionist, Staff Where staffId=stId

-------------------------
--sp recep 3
GO
CREATE proc spSearchReceptionistById
@id int
as
begin
select firstName,lastName,mobileNo,gender,age,email,homeAddress,username,password from Receptionist 
join Staff on stId = staffId
where rId=@id
end

-------------------------------
--sp recep 4
go
CREATE PROC spAddReceptionist
@firstname varchar(25),
@lastname varchar(25),
@mobileno varchar(25),
@gender varchar(10),
@age int,
@email varchar(100),
@homeAddress varchar(100),
@username varchar(25),
@password  varchar(25)
AS
BEGIN
		DECLARE @staffId int,@errvalue int,@staffreseed int
		DECLARE @Stafftbl TABLE (staffID INT)

		declare @reseedvalueStaff int
			select  TOP 1 @reseedvalueStaff =stId from Staff ORDER BY stId desc
		
		declare @reseedvalueReceptionist int
		select  TOP 1 @reseedvalueReceptionist =rId from Receptionist ORDER BY rId desc
		
		begin transaction

	    INSERT INTO Staff OUTPUT inserted.stId INTO @StaffTbl(staffID) VALUES(@firstname,@lastname,@mobileno,@gender,@age,@email,@homeAddress,'Receptionist') 
		select @staffId=staffID from @Stafftbl
		
		if @@ERROR > 0
			rollback transaction
	
		insert into Receptionist(staffId,username,password) values(@staffId,@username,@password)
		
		if @@ERROR > 0
			rollback transaction
	
		commit transaction

		if @@ERROR > 0

		begin
			DBCC CHECKIDENT ('Receptionist', RESEED,@reseedvalueReceptionist);
			DBCC CHECKIDENT ('Staff', RESEED,@reseedvalueStaff);
		end

END


-----------------
--sp recep 5

go
create proc spDeleteReceptionist
@receptionistId int
as
begin
	declare @staffid int
	select @staffid=staffId from Receptionist where rId=@receptionistId

	delete Staff 
	where stId=@staffid
end
-----------
--sp recep 6
go
create proc spEditReceptionist
@receptionistId int,
@firstname varchar(25),
@lastname varchar(25),
@mobileno varchar(25),
@gender varchar(10),
@age int,
@email varchar(100),
@homeAddress varchar(100),
@username varchar(25),
@password  varchar(25)
as
begin
declare @staffId int
select @staffId=staffId from Receptionist where rId=@receptionistId


Update Staff set firstName =@firstname,lastName = @lastname, mobileNo = @mobileno, gender = @gender, age = @age , email = @email, homeAddress = @homeAddress WHERE stId= @staffId
Update Receptionist set username = @username ,password =@password WHERE rId= @receptionistId

end
















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
alter table patient drop column disease
--sp Patient1
create proc [spLoadPatients]
as 
select cast(patientId as varchar(10))+'-'+firstName+' '+lastName from Patient
--spPat2
create proc [spPatIdByName]
@name varchar(50),
@id int output
as begin 
select @id=patientId from Patient where  firstName+' '+lastName=@name
end

ALTER TABLE PATIENT ADD disease varchar(50)
select *from patient
INSERT INTO Patient VALUES('John','Smith','0945405147','inpatient','AB-','addis ababa ethiopia',Default,19,'MALE')


SELECT * FROM appointment
--sp Proc patients 3
CREATE PROC spViewPatient 
AS
Select * from Patient


--sp patient 4
CREATE proc spSearchPatientById
@id int
as
select * from Patient
where patientId=@id


--sp patient 5
CREATE PROC spAddPatient
@firstname varchar(25),
@lastname varchar(25),
@mobileno varchar(25),
@gender varchar(10),
@age int,
@homeAddress varchar(100),
@bloodgroup varchar(10),
@disease varchar(50)
AS
BEGIN
		declare @reseedvaluePatient int
			select  TOP 1 @reseedvaluePatient =patientId from Patient ORDER BY patientId desc
		
		INSERT INTO Patient VALUES(@firstname,@lastname,@mobileno,'inpatient',@bloodgroup,@homeAddress,GETDATE(),@age,@gender,@disease)
		select * from Patient
		
		if @@ERROR > 0
			DBCC CHECKIDENT ('Patient', RESEED,@reseedvaluePatient);
	END


--sp patient 6
	CREATE PROC spEditPatient
@patientid int,
@firstname varchar(25),
@lastname varchar(25),
@mobileno varchar(25),
@gender varchar(10),
@age int,
@homeAddress varchar(100),
@bloodgroup varchar(10),
@disease varchar(50)
AS
BEGIN
	
	UPDATE Patient
	SET firstName=@firstname,lastName=@lastname,mobileNo=@mobileno,
	bloodgroup=@bloodgroup,Address=@homeAddress,age=@age,gender=
	@gender,disease=@disease where patientId=@patientId
		
End
--sp patient 7
create proc spDeletePatient
@patientId int
as
begin
	
	delete Patient
	where patientId=@patientId
end






create table Medicine(
medicineId int identity(1000,1) primary key,
medicineName varchar(20) NOT NULL,
medicineCompany varchar(20) ,
medicineCost money 
);

--sp Medicine1
alter proc [spMedIdByName]
@medname varchar(50),
@id int output
as
Select @id=MedicineId from Medicine where MedicineName=@medname

--sp Medicine 2
create proc [spLoadMed]
as 
select medicineName from Medicine


ALTER TABLE MEDICINE ADD CONSTRAINT UQ_MEDICINE_NAME UNIQUE(medicineName)
INSERT INTO Medicine VALUES('Paracetomol','Julphar','50')

Insert into Medicine (medicineName)values('Atorvastatin'),('Levothyroxine'),('Metformin'),('Lisinopril'),('Amlodipine')
,('Metoprolol') 
,('Albuterol') 	
, ('Omeprazole') 	
,('Losartan') 	
,('Gabapentin'),('Hydrochlorothiazide') 	
,	('Sertraline')	
, 	('Simvastatin')
,	('Montelukast'),('Escitalopram ')	
, ('Acetaminophen'),('Rosuvastatin') 	
, 	('Bupropion'),('Furosemide')
,	('Pantoprazole')
, 	('Trazodone')
, 	('Dextroamphetamine')
, 	('Fluticasone') 	
, 	('Tamsulosin')	
, 	('Fluoxetine')
, 	('Carvedilol')	
, 	('Duloxetine')	
,	('Meloxicam')
, 	('Clopidogrel') 	
, 	('Prednisone')
, 	('Citalopram '), ('Insulin Glargine ')
, 	('Potassium Chloride')
, 	('Pravastatin')	
, 	('Tramadol') 	
, 	('Aspirin')
, 	('Alprazolam')	
, 	('Ibuprofen')
, 	('Cyclobenzaprine') 
,	('Amoxicillin')
, 	('Methylphenidate') 	
, 	('Allopurinol')	
, 	('Venlafaxine')	
, 	('Clonazep')



 create table Prescription(
prescId int PRIMARY KEY identity(1000,1),
ptId int foreign key references Patient(patientId),
docId int foreign key references Doctor(doctorId),
medicineId int foreign key references Medicine(medicineId),
dose varchar(255) NOT NULL,
dateof date  NOT NULL DEFAULT GETDATE(),
given bit NOT NULL DEFAULT 0 
);

--sp Prescription 1
ALTER Procedure [spAddPrescription]
@ptId int,@docId int,@mid int,@dose varchar(max)
as
begin
Insert into Prescription values(@ptID,@docId,@mid,@dose,GETDATE(),1)
end


drop proc AddPrescription

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

drop table Appointment
insert into Appointment values(1003,1001,null,18,default,0)
delete from appointment where ptId=1003
select *from Appointment
select *from Treatment

--sp1 Appointment
alter procedure [spLoadAppointment]
@uname varchar(50) 
as begin
Select Patient,roomNo,DateOf from Doctor_appointment where username=@uname and done=0
end

exec [sploadAppointment] 'sad'

-- Sp2 Appointment
create proc [spTreat]
@PID int
as
update Appointment set done=1 where ptId=@PID
select *from Appointment
--insert into Appointment values(1003)
update appointment set done=0 where ptId=1001

INSERT Appointment(appointId) VALUES (null)
insert into Admin values('Admin','1234')
Select * from room
SELECT * FROM Prescription_Details Where 
SELECT * FROM Appointment,Patient ,Doctor, Staff WHERE ptId=patientId AND docId=doctorId and nursId=nurseId






SELECT * FROM Edit_Prescription WHERE prescId=1000
drop table treatment
select *from patient
select *from appointment
delete from Treatment where ptId=1001


CREATE TABLE Treatment(
treatId int identity(1000,1) PRIMARY KEY,
ptId int not null,
apId int foreign key references Appointment(appointId)  NULL ,
prId int foreign key references Prescription(prescId)  NULL,
symptoms text,
trtHistory text
)
alter table treatment add constraint fk_app_trt foreign key(apId) references Appointment(appointId)  on delete cascade


--Proc Treatement1
alter proc [spAddTreatment]
@ptId int,@aId int,@prId int,@sym Text,@trt Text
as 
begin
if(@aId is null and @prId is null )
insert into Treatment(ptId,symptoms,trtHistory) values (@ptId,@sym,@trt)
else if(@aid is null)
insert into Treatment(ptId,prId,symptoms,trtHistory) values(@ptId,@prId,@sym,@trt)
else if(@prId is null)
insert into Treatment(ptId,apId,symptoms,trtHistory) values(@ptId,@aId,@sym,@trt)
else
insert into Treatment values(@ptId,@aId,@prId,@sym,@trt)
end

Exec  [spAddTreatment] 1000,null,null,'high fever','x-ray'
select *from Treatment

--spTreatment2
create proc [spIdSeparator]
@name varchar(70),
@id int out
as 
set @id =cast(left(@name,charIndex('-',@name)-1) as Int)

--sp3 treatment 
alter proc [spTrtById]
@Id int,@trt text output
as  
select @trt=trtHistory from Treatment where ptId=@Id 
select  *from Patient
--sp4 treatment
create proc [spSymById]
@Id int,@sym text output
as 
select @sym=symptoms from Treatment where  ptId=@Id
--sp5 treatment
create proc [spEditTreatment]
as begin

end
INSERT INTO Treatment(apId,prId,symptoms,treatment) VALUES(1000,1000,'FEVER','Syringe')

SELECT * FROM treatment


SELECT * FROM Appointment_Patient WHERE appointId=1000
SELECT prescid FROM Prescription
INNER JOIN Patient ON patientId=ptId WHERE ptId=1000


--Func 1
create function AppDetails() 
returns table
as return(
SELECT appointId,(Patient.firstName +' '+ Patient.lastName) AS Patient,(Staff.firstName +' '+ Staff.lastName) AS Doctor ,roomNo,dateof,done, Doctor.active FROM Appointment 
                     INNER JOIN Patient ON ptId=patientId 
                     INNER JOIN Doctor  ON docId=doctorId 
                     INNER JOIN Nurse ON nursId=nurseId
                     INNER JOIN Staff ON Doctor.staffId=stId
)


SELECT * From Doctor
--Func 2
Create function DocAppoin()
returns table 
AS 
return SELECT appointId,(Patient.firstName +' '+ Patient.lastName) AS Patient,roomNo,dateof,done,username,Doctor.active FROM Appointment 
                     INNER JOIN Patient ON ptId=patientId 
                     INNER JOIN Doctor  ON docId=doctorId 
                     full JOIN Nurse ON nursId=nurseId
                     INNER JOIN Staff ON Doctor.staffId=stId


drop view Doctor_Appointment
SELECT * From Doctor_Appointment

--Func 3
CREATE function EditPresc()
returns table
AS
return
SELECT medicineName,dose,prescId FROM Prescription 
INNER JOIN Medicine ON Prescription.medicineId=Medicine.medicineId

--Func 4
create function  AppointPat() 
returns table 
AS
return
SELECT patientid,firstName,lastName,mobileno,gender,age,bloodgroup,appointId,docId from Patient
JOIN Appointment ON patientId=ptId 


--Func 5
create function PatNameById(@id int)
returns varchar(50)
as 
begin
declare @name varchar(50)
select @name =firstName+' '+lastname from Patient where patientId=@id
return @name
end
declare @name varchar(50)
select dbo.patnameById(1003)
print @name