USE [UniversityStudentInfoSystemDb]
GO

/****** Object:  View [dbo].[V_InstructorTable]    Script Date: 22.05.2022 22:47:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create view [dbo].[V_InstructorTable]
as
select i.Id,i.IsActive,i.[Name],i.Surname,i.Age,i.Birtday,i.Email,i.PhoneNumber,i.Gender,i.Cv,i.CourseId,ia.City,ia.Street,ia.Country,ia.HouseNumber,ia.ApartmentNumber,ia.InstructorId from Instructors as i join InstructorAddresses as ia on i.Id = ia.InstructorId
GO


