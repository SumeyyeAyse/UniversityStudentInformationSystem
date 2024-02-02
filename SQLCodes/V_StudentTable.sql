
create view V_StudentTable
as
select s.Id, s.IsActive, s.[Name], s.Surname, s.Age,s.Birtday,s.Email,s.PhoneNumber,s.YearOfEntry,s.AcademicTranscript,s.Gpa,s.Gender,s.DepartmantId,s.CourseId,sa.City,sa.Street,sa.Country,sa.HouseNumber,sa.ApartmentNumber,sa.StudentId, d.[Name] as DepartmantName, c.[Name] as CourseName from Students as s join StudentAddresses as sa 
on s.Id = sa.StudentId join Departmants as d on d.Id = s.DepartmantId join Courses as c on c.Id = s.CourseId
