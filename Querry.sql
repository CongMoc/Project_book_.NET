create view BookView
as 
	select IDBook,Title,Category,NameAuthor,Age,Status,Quantity,PercentGift,Money
	from tblBooks as b inner join tblAuthor as a on(b.IDAuthor = a.IDAuthor)
	inner join tblGift as g on(b.IDGift = g.IDGift)
	where Quantity > 0 


create table tblOrderBook(
	IDOrder int identity (1000,1) primary key,
	IDBook smallint,
	IDCustomer smallint,
	BorrowingDate Date,
	PayDay date,
	Quantity int,
	Status nvarchar(45),
	Money float,
	Constraint fk_idb_b_ob Foreign key(IDBook) references tblBooks(IDBook),
	Constraint fk_idc_c_ob Foreign key(IDCustomer) references tblCustomers(IDCustomer),
)


use BOOKS
exec InsertBookForCart 

alter function SumMoney(
	@IDCustomer smallint
)
returns float
as 
begin 
	declare @num float 
	set @num  = (select Sum(Money * Quantity)*1.0 from tblOrderBook where IDCustomer = @IDCustomer)
	if(@num is null)
		set @num = 0.0	
	return @num
end

select dbo.SumMoney(103)



create table tblHistoryOrderBook(
	ID int identity (1,1) primary key,
	IDBook smallint,
	Title nvarchar(45),
	IDCustomer smallint,
	Author nvarchar(45),
	Category nvarchar(45),
	Status nvarchar(45),
	Money float,
	Constraint fk_ib_b_h Foreign key(IDBook) references tblBooks(IDBook),
	Constraint fk_ic_c_h Foreign key(IDCustomer) references tblCustomers(IDCustomer)
)

create proc InsertHistory(
	@idbook smallint,
	@title nvarchar(45),
	@idcus smallint,
	@author nvarchar(45),
	@category nvarchar(45),
	@money float
)
as
begin 
	insert into tblHistoryOrderBook
	values (@idbook,@title,@idcus,@author,@category,'Bought',@money)
end

create proc HistoryView(
	@IDCustomer smallint
)
as 
begin 
	select ID,Title,Author,Category,Status,Money
	from tblHistoryOrderBook where IDCustomer = @IDCustomer
end



alter proc QuantityBook(
	@IDBook smallint,
	@Quantity int
)
as
begin 
	declare @num int
	set @num = (select Quantity from tblBooks where IDBook = @IDBook)
	if(@num >= @Quantity)
	begin
		update tblBooks
		set Quantity = @num - @Quantity
		where IDBook = @IDBook
	end
end


exec QuantityBook 101,5


alter function PrintIDCustomer(
	@email nvarchar(45)
)
returns int
as
begin	
	declare @num int
	if(exists(select IDCustomer from tblCustomers  where Email = @email))
		set @num = (select IDCustomer from tblCustomers  where Email = @email)
	if(exists(select IDEmployee from tblEmployee  where Email = @email))
		set @num = (select IDEmployee from tblEmployee  where Email = @email)
	return @num
end
	
select dbo.PrintIDCustomer('Buithui@gmail.com')




alter proc CartView(
	@IDCustomer smallint
)
as
begin 
	select IDOrder,ob.IDBook,Title,NameAuthor,Category,BorrowingDate,PayDay,PercentGift,ob.Status,ob.Quantity,ob.Money
	from tblOrderBook as ob inner join tblBooks as b on (ob.IDBook = b.IDBook) 
	inner join tblAuthor as a on (b.IDAuthor = a.IDAuthor)
	inner join tblGift as g on (b.IDGift = g.IDGift) 
	where IDCustomer = @IDCustomer and ob.Status = 'Unpaid'
end

 

alter proc UpdateCart(
	@IDOrder int,
	@IDBook int,
	@Quantity int,
	@Borrow date,
	@Pay date
)
as
begin
		update tblOrderBook
		set Quantity = @Quantity,
			BorrowingDate = @Borrow,
			PayDay = @Pay
		where IDOrder = @IDOrder
	
end

create function CheckUpdateCart(
	@IDOrder int,
	@IDBook int,
	@Quantity int
)
returns bit
as
begin
	declare @num int
	declare @check int
	set @num = (select Quantity from tblBooks where IDBook = @IDBook)
	if(@num >= @Quantity)
		set @check = 1
	else
		set @check = 0
	return @check
end



alter proc PayCartWithBook(
	@id int,
	@idcus int
)
as
begin 
	update tblOrderBook
	set Status = 'Bought'
	where IDOrder = @id and IDCustomer = @idcus
end



alter proc PayAllCart(
	@idcus int
)
as
begin
	update tblOrderBook
	set Status = 'Bought'
	where IDCustomer = @idcus
end

create proc AddCartFromHistory(
	@id int,
	@quantity int
)
as
begin 
	update tblOrderBook
	set Status = 'Unpaid', Quantity = @quantity
	where IDOrder = @id
end


alter proc AddLogin(
	@email nvarchar(45),
	@pass nvarchar(45),
	@name nvarchar(45),
	@last nvarchar(45)
)
as
begin
	insert into tblLogin
	values (@email,@pass,@name,@last)

	insert into tblCustomers(Email,NameCustomer)
	values (@email,@name)
end


create table tblCustomers(
	IDCustomer smallint identity (1000,1) primary key,
	NameCustomer nvarchar(45),
	BirthYear Date,
	Email nvarchar(50),
	Address nvarchar(45),
	City nvarchar(45),
	NumberPhone char(10),
	constraint fk_l_l_c foreign key(Email) references tblLogin(Email)
)


alter table tblOrderBook
add Constraint fk_idc_c_ob Foreign key(IDCustomer) references tblCustomers(IDCustomer)


create function OutputPassword(
	@email nvarchar(45)
)
returns nvarchar(45)
as
begin 
	declare @pass nvarchar(45)
	set @pass = (select Password from tblLogin where Email = @email)
	return @pass
end

create proc ChangePass(
	@email nvarchar(45),
	@pass nvarchar(45)
)
as
begin 
	update tblLogin 
	set Password = @pass where Email = @email
end


create proc [dbo].[BookbackCart](
	@id int,
	@idcus int
)
as
begin 
	update tblOrderBook
	set Status = 'Unpaid'
	where IDOrder = @id and IDCustomer = @idcus
end


