
--join 
--view 
--order by
--desc asc
--where
--top
--group by
--having
--offset
--schema


select S.stu_name as StudentName, S.stu_surname, G.grp_name, T.teach_name, SU.sub_name from Students as S
inner join Groups as G on
S.stu_group_id = G.id 
inner join Teachers as T on
T.id = G.grp_teacher_id
inner join Subjects as SU on
SU.id = T.teach_subject_id

select * from HrEmployees
select * from Universities

select * from HrEmployees as H
full join Universities as U on
H.uni_id = U.id

select * from HrEmployees as H
left join Universities as U on
H.uni_id = U.id

select * from HrEmployees as H
inner join Universities as U on
H.uni_id = U.id

create view getAllStudentsAndGroups
as
select S.id as StudentId, S.stu_name, S.stu_surname, grp_name, G.id as GroupId from Students as S
inner join Groups as G on
S.stu_group_id = G.id


select top 2 * from getAllStudentsAndGroups
where stu_surname  like '%v'
order by stu_name 


select SUBSTRING(stu_surname, 1,  3), stu_name, stu_surname  from Students  
group by stu_name , stu_surname













