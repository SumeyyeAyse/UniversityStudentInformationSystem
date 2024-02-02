
create view V_DepartmantTable 
as
select d.Id,d.FacultyId,d.[Name],d.IsActive,f.[Name] as [FacultyName] from Departmants as d join Faculties as f on d.FacultyId = f.Id
