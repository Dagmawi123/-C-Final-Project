---------Stored Procedures--------
----------------------------------
----------------------------------
----------------------------------
----------- Doctors --------------
----------------------------------
----------------------------------
----------------------------------
----------------------------------

go
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


-----------------
go
create proc spDeleteDoctor
@doctorId int
as
begin
	declare @staffid int
	select @staffid=staffId from doctor where doctorId=@doctorId

	delete Staff 
	where stId=@staffid
end
-----------
go
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
-------------------

go
CREATE PROC spViewDoctor AS
SELECT doctorId,firstName,lastName,mobileNo,gender,age,email,homeAddress,Name 
FROM Staff,Doctor,Department Where stId=staffId AND depId=deptId

-------------------------
GO
CREATE proc spSearchDoctorById
@id int
as
begin
select firstName,lastName,mobileNo,gender,age,email,homeAddress,Name,username,password from Doctor 
join Staff on stId = staffId
join Department on depId=deptId
where doctorId=@id
end

-------------------------------
GO
CREATE proc spSearchDoctorByName
@name varchar(50)
as
begin
select firstName,lastName,mobileNo,gender,age,email,homeAddress,Name,username,password from Doctor 
join Staff on stId = staffId
join Department on depId=deptId
where firstName+lastName like '%'+@name+'%'
end
GO

----------------------------------
----------------------------------
----------------------------------
----------- Patients --------------
----------------------------------
----------------------------------
----------------------------------
----------------------------------


go
CREATE PROC spViewPatient 
AS
Select * from Patient

-------------------------
GO
CREATE proc spSearchPatientById
@id int
as
select * from Patient
where patientId=@id


-------------

go
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

--------------------
go
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
--------------------
go
create proc spDeletePatient
@patientId int
as
begin
	
	delete Patient
	where patientId=@patientId
end

----------------------------------
----------------------------------
----------------------------------
----------- Nurse --------------
----------------------------------
----------------------------------
----------------------------------
----------------------------------

go
Create Proc spViewNurse
AS
SELECT nurseId,firstName,lastName,mobileNo,gender,age,email,homeAddress FROM Nurse, Staff Where staffId=stId

---------------------------

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
----------------

select  TOP 1 nurseId from Nurse ORDER BY nurseId desc
		select * from Nurse
		select * from Receptionist
		delete Receptionist where staffId is null

		ALTER TABLE Receptionist ALTER COLUMN staffId int not null

		DBCC CHECKIDENT ('staff', RESEED);

		exec spAddNurse 'a','y','0928765676','male',88,'rerfg@hm.com','fdfg'

-----------------

go
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
----------------------------------
----------------------------------
----------------------------------
----------- Receptionist ---------
----------------------------------
----------------------------------
----------------------------------
----------------------------------

go
Create Proc spViewReceptionist
AS
SELECT rId,firstName,lastName,mobileNo,gender,age,email,homeAddress FROM Receptionist, Staff Where staffId=stId

-------------------------
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
----------------------------------
----------------------------------
----------------------------------
----------- Department -----------
----------------------------------
----------------------------------
----------------------------------
----------------------------------

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
go
create proc spViewDepartment
as
select deptId,Name from Department
---------------------
go
create proc spEditDepartment
@depid int,
@depname varchar(25)
as
update Department set Name=@depname where deptId=@depId
--------------------
go
create proc spSearchDepartmentById
@depid int
as
select * from Department where deptId=@depid
-----------------------
go
create proc spGetAllDepartment
as
select Name from Department
-------------------------
go
create proc spDeleteDepartment
@depid int
as 
delete Department where deptId=@depid

