create database db_study
go
use db_study
create table tb_Bulletin
(
	ID int identity(1,1) not null,
	Title text not null,
	Content text not null,
	Date datetime default(CONVERT (date, SYSDATETIME())) not null,
	Name text not null
)
create table tb_login
(
	ID int identity(1,1) primary key,
	Name text not null,
	Pass text not null,
	Zname text,
	Sex text not null,
	Email text not null,
	IDcard text not null,
	PassQuestion text not null,
	PassSolution text not null,
	LoginDate datetime default(CONVERT (date, SYSDATETIME())) not null,
	Lock int default(0)
)
insert into tb_login(Name,Pass,Zname,Sex,Email,IDcard,PassQuestion,PassSolution) values('asd','aa','aa','男','ads@asd.com','324324','asdas','asdasas')
create table tb_Sound
(
	SoundID int identity(1,1) primary key,
	SoundType int not null,
	SoundName text not null,
	SoundUrl text not null,
	ClickSum int default(0),
	SoundContent text ,
	FBDate datetime default(CONVERT (date, SYSDATETIME())) not null,
	Name text not null
)
create table tb_Video
(
	VideoID int identity(1,1) primary key,
	VideoType int not null,
	VideoName text not null,
	VideoUrl text not null,
	ClickSum int default(0),
	VideoContent text ,
	FBDate datetime default(CONVERT (date, SYSDATETIME())) not null,
	Name text not null
)
create table tb_Speak
(
	SpeakID int identity(1,1) primary key,
	Speakman text not null,
	TutorialType text not null,
	TutorialID int not null,
	SpeakContent text,
	SpeakDate datetime default(CONVERT (date, SYSDATETIME())) not null
)
create table tb_Type
(
	TypeID int identity(1,1) primary key,
	TypeName text not null
)
go
insert into tb_Type values('.NET')
insert into tb_Type values('ASP')
insert into tb_Type values('JSP')
insert into tb_Type values('VB')
insert into tb_Type values('VC')
insert into tb_Type values('DELPHI')
go

CREATE PROC GETSPEAKTABLEPAGE @TABLENAME VARCHAR(100),  -------分页的表
							  @TutorialID INT, -------分页的表的条件
                              @PAGEINDEX INT=1,         -------显示的页码
                              @PAGESIZE INT=1           -------每一页显示的行数
AS
BEGIN
	if(@TABLENAME='Video')
	begin
		select * from 
           (select *,ROW_NUMBER() over(order by SpeakID asc) as row 
                           from tb_Speak,tb_Video where convert(varchar,TutorialType)='Video' and TutorialID=@TutorialID ) as newtable 
               where row between CAST((@PAGEINDEX-1)*@PAGESIZE+1 AS VARCHAR(20)) and CONVERT (VARCHAR(20), @PAGEINDEX*@PAGESIZE)          
	end
	else if(@TABLENAME='Sound')
	begin
		select * from 
           (select *,ROW_NUMBER() over(order by SpeakID asc) as row 
                           from tb_Speak,tb_Sound where convert(varchar,TutorialType)='Sound' and TutorialID=@TutorialID ) as newtable 
               where row between CAST((@PAGEINDEX-1)*@PAGESIZE+1 AS VARCHAR(20)) and CONVERT (VARCHAR(20), @PAGEINDEX*@PAGESIZE)
	end
END 
go
CREATE PROC GETTUTORIALTABLEPAGE @TABLENAME VARCHAR(100),  -------分页的表
							  @TutorialID INT,  -------分页的表类型号
							  @SearchKey VARCHAR(100), -------分页的表的关键字
                              @pageIndex INT=1,         -------显示的页码
                              @pageSize INT=1           -------每一页显示的行数
AS
BEGIN
	if(@TABLENAME='Video')
	begin
		select VideoID,VideoName,FBDate,Name from
		(select *,ROW_NUMBER() over(order by VideoID) as rowIndex 
		from tb_Video where VideoType=@TutorialID and VideoName like '%'+@SearchKey+'%')as newtable 
		where rowindex between (@pageIndex-1)*@pageSize+1  and @pageIndex*@pageSize          
	end
	else if(@TABLENAME='Sound')
	begin
		select SoundID,SoundName,FBDate,Name from
		(select *,ROW_NUMBER() over(order by SoundID) as rowIndex 
		from tb_Sound where SoundType=@TutorialID and SoundName like '%'+@SearchKey+'%')as newtable 
		where rowindex between (@pageIndex-1)*@pageSize+1  and @pageIndex*@pageSize
	end
END 
go
