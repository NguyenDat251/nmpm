creatE DATABASE JOBS

USE JOBS

CREATE TABLE JOB
(
	ID int,
	NAME NVARCHAR(100),
	COMPANY NVARCHAR(100),
	LANGUAGE NVARCHAR(100),
	SALARY INT,
	DESCRIPTION NVARCHAR(4000),
	PRIMARY KEY(ID)
)


INSERT INTO JOB VALUES (1,N'FRONT-END ENGINEER', N'VNG',
						  N'JAVA', 1000, N'University degree in Computer Sciences, or equivalent.\n
At least 3 year of experience in software development using .NET technology\n
Especially in using C#, ASP.NET MVC, ASP.NET Core 2.1')
INSERT INTO JOB VALUES (2,N'UNITY DEVELOPER', N'MONKEY JUNIOR',
						  N'C#', 1000, N'Nắm vững kiến thức căn bản và nâng cao về Android
						  Kinh nghiệm chuyên môn từ 6 tháng trở lên')
INSERT INTO JOB VALUES (3,N'BACK-END ENGINEER', N'ACB',
						  N'JAVA', 1000, N'Bachelors degree in Computer Science or Math preferred.
Strong in client side frameworks such as React, Angular, Flux/Redux.')
INSERT INTO JOB VALUES (4,N'Senior Data Engineer', N'VNG',
						  N'JAVA', 3000, N'Tốt nghiệp Cử nhân về công nghệ thông tin hoặc cao hơn.
						  Có kinh nghiệm làm việc trong lĩnh vực xử lý dữ liệu lớn hoặc các lĩnh vực liên quan trong tích hợp dữ liệu.')
INSERT INTO JOB VALUES (5,N'FULL-STACK DEVELOPER', N'BOSCH',
						  N'JAVA', 1000, N'Good Knowledge & Work Experience in Embedded C/C++')
INSERT INTO JOB VALUES (6,N'BIG DATA ENGINEER', N'TRUSTING SOCIAL',
						  N'NODEJS', 1000, N'Proficient understanding of distributed computing principles
						  Proficiency with Hadoop v2, MapReduce, HDFS
						  Experience with Spark')
INSERT INTO JOB VALUES (7,N'IOS DEVELOPER', N'MONEY FORWARD',
						  N'SWIFT', 1500, N'2+ years experience in ios app
						  Experience with Architecture Patterns not only MVC, but VIPER/MVVM/Clean Architecture')
CREATE TABLE APPLY
(
	IDCAND int,
	IDJOB int,
	PRIMARY KEY(IDCAND, IDJOB)
)

CREATE TABLE CANDIDATE
(
	IDCAND int,
	NAME NVARCHAR(200),
	AGE int,
	PRIMARY KEY(IDCAND)
)

CREATE TABLE [dbo].[SavePDFTable](

      [ID] [int] IDENTITY(1,1) NOT NULL,

      [PDFFile] [varbinary](max) NULL

     

)

INSERT INTO CANDIDATE VALUES (1, N'Nguyễn Quốc Đạt', 20);
INSERT INTO CANDIDATE VALUES (2, N'Phạm Hoàng Chương', 23);
INSERT INTO CANDIDATE VALUES (3, N'Cao Minh Tân', 27);
INSERT INTO CANDIDATE VALUES (4, N'Nguyễn Nhật Duy', 30);
INSERT INTO CANDIDATE VALUES (5, N'Nguyễn Nhật Duy', 30);

INSERT INTO APPLY VALUES (1, 3);
INSERT INTO APPLY VALUES (2, 5);
INSERT INTO APPLY VALUES (2, 4);
INSERT INTO APPLY VALUES (4, 7);
INSERT INTO APPLY VALUES (5, 7);
INSERT INTO APPLY VALUES (3, 7);

ALTER TABLE APPLY
ADD CONSTRAINT FK_APPLY_JOB
FOREIGN KEY (IDJOB)
REFERENCES JOB(ID)

ALTER TABLE APPLY
ADD CONSTRAINT FK_APPLY_CANDIDATE
FOREIGN KEY (IDCAND)
REFERENCES CANDIDATE(IDCAND)

create table ACCOUNT
(
Username char(50) NOT NULL UNIQUE,
Password char(50) NOT NULL,
Displayname nvarchar(50),
Company nvarchar(100),
ID int identity PRIMARY KEY,
type int NOT NULL, -- 1: Applicant ; 2: Employer ; 3: Admin
)



INSERT INTO ACCOUNT (Username, Password, Displayname, type) VALUES ('admin', '3', N'TÂN', 3);
INSERT INTO ACCOUNT (Username, Password, Displayname, Company , type) VALUES ('employer', '2', N'ĐẠT', N'VNG', 2);
INSERT INTO ACCOUNT (Username, Password, Displayname, type) VALUES ('applicant', '1', N'CHƯƠNG', 1);
INSERT INTO ACCOUNT (Username, Password, Displayname, type) VALUES ('applicant2', '1', N'CHƯƠNG', 1);

create procedure AddUser
@Username char(50),
@Password char(50),
@Displayname nvarchar(50),
@type int
as 
INSERT INTO ACCOUNT (Username, Password, Displayname, type) VALUES (@Username, @Password, @Displayname, @type)

ALTER TABLE APPLY
ADD [PDFFile] [varbinary](max) NULL

/*ALTER TABLE APPLY DROP
CONSTRAINT FK_APPLY_JOBS

DROP TABLE SavePDFTable
DROP TABLE ACCOUNT*/
