creatE DATABASE JOBS

USE JOBS

CREATE TABLE JOBS
(
	ID int,
	NAME NVARCHAR(100),
	COMPANY NVARCHAR(100),
	LANGUAGE NVARCHAR(100),
	SALARY INT,
	DESCRIPTION NVARCHAR(4000),
	PRIMARY KEY(ID)
)

DROP TABLE JOBS

ALTER TABLE JOBS
ADD ID 


PRIMARY KEY (ID)

INSERT INTO JOBS VALUES (1,N'FRONT-END ENGINEER', N'VNG',
						  N'JAVA', 1000, N'University degree in Computer Sciences, or equivalent.\n
At least 3 year of experience in software development using .NET technology\n
Especially in using C#, ASP.NET MVC, ASP.NET Core 2.1')
INSERT INTO JOBS VALUES (2,N'UNITY DEVELOPER', N'MONKEY JUNIOR',
						  N'C#', 1000, N'Nắm vững kiến thức căn bản và nâng cao về Android
						  Kinh nghiệm chuyên môn từ 6 tháng trở lên')
INSERT INTO JOBS VALUES (3,N'BACK-END ENGINEER', N'ACB',
						  N'JAVA', 1000, N'Bachelors degree in Computer Science or Math preferred.
Strong in client side frameworks such as React, Angular, Flux/Redux.')
INSERT INTO JOBS VALUES (4,N'Senior Data Engineer', N'VNG',
						  N'JAVA', 3000, N'Tốt nghiệp Cử nhân về công nghệ thông tin hoặc cao hơn.
						  Có kinh nghiệm làm việc trong lĩnh vực xử lý dữ liệu lớn hoặc các lĩnh vực liên quan trong tích hợp dữ liệu.')
INSERT INTO JOBS VALUES (5,N'FULL-STACK DEVELOPER', N'BOSCH',
						  N'JAVA', 1000, N'Good Knowledge & Work Experience in Embedded C/C++')
INSERT INTO JOBS VALUES (6,N'BIG DATA ENGINEER', N'TRUSTING SOCIAL',
						  N'NODEJS', 1000, N'Proficient understanding of distributed computing principles
						  Proficiency with Hadoop v2, MapReduce, HDFS
						  Experience with Spark')
INSERT INTO JOBS VALUES (7,N'IOS DEVELOPER', N'MONEY FORWARD',
						  N'SWIFT', 1500, N'2+ years experience in ios app
						  Experience with Architecture Patterns not only MVC, but VIPER/MVVM/Clean Architecture')
INSERT INTO JOBS VALUES (8,N'Java Technical Leader', N'VIETTEL',
						  N'JAVA', 2000, N'Have 3+ year experience in web application development
						  Strong experience with OOP design')
