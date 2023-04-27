create database dbEmail_Parole

use dbEmail_Parole

create table tEmail_Parole(
		Nume varchar(60),
		Email varchar(60),
		Parola varchar(60)
);

delete from tEmail_Parole where Nume = 'Eduard'

insert into tEmail_Parole 
values('Vlad', 'vladatanasiu@gmail.com', 'vlad1234'),
	  ('Laur', 'laurentiu21@yahoo.ro', 'navaspatiala2000'),
	  ('Eduard', 'constantinEduard1999@gmail.com', 'daciaLiterara1840');

SELECT * FROM tEmail_Parole
WHERE Nume = 'Vlad' and Email = 'vladatanasiu@gmail.com' and Parola = 'vlad1234'

select * from tEmail_Parole