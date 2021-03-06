use SharpStore
go

create table Knives (

	[Id] int primary key identity(1,1),
	[Name] nvarchar(50) not null,
	[Price] money not null default (0.00),
	[ImageUrl] nvarchar(200) null
)
go

insert into Knives values
('Super Edge', 200.34, '../../content/images/knife.jpg'),
('Blade', 10.15, '../../content/images/knife.jpg'),
('Razor', 200.34, '../../content/images/knife.jpg'),
('Headcutter', 111.34, '../../content/images/knife.jpg'),
('Doombringer', 23443.34, '../../content/images/knife.jpg')

insert into Knives values
('Best Knife', 100.15, '../../content/images/knife.jpg')


create table [Messages](
	[Id] int primary key identity(1,1),
	[Sender] varchar(100) not null,
	[Subject] nvarchar(200) not null,
	[Message] nvarchar(max)
)

