create table sales(
    ino tinyint not null,
    cusn varchar(25) not null,
    item varchar(40)  null,
    quantity tinyint not null,
    price smallint not null,
    gst float(2) not null
);

select*from sales
select max(ino) from sales
truncate table sales

select round(sum(price)-sum(gst),2) as profit  from sales 


insert into sales SELECT avg(ino) as invoice,concat(item),sum(quantity) as quantity ,sum(price) as price from tempin  group by item;
drop table sales



alter table sales
add gst float(2) not null

go
create procedure item(
      @n varchar(20),
      @i tinyint
)
as
begin
    if exists (select item from sales where @i is not null)
          update sales set item=item+','+@n  where ino=@i;
     else
          update sales set item=@n where ino=@i ;
end

drop proc item;

create table tempin(
     ino tinyint not null,
     cusn varchar(25)  null,
     phn varchar(10)  null,
     item varchar(20) not null,
     rate smallint  null,
     quantity tinyint not null,
     price smallint not null,
     gst float(2) not null,
     code varchar(4) not null
);
truncate table tempin
select * from tempin;

insert into tempin(ino,item,quantity,price,gst) values(1,'shirt',1,400,20),(1,'shirt',1,400,20);

alter table tempin
drop column code

drop table tempin

create table pur(
      ino varchar(7) not null,
      seller varchar(20) not null,
      product varchar(20) not null,
      quant tinyint not null,
      rate smallint not null,
      amount int not null,
      gst float(2)  not null,
      dte date not null
);

truncate table pur
drop table pur
select * from pur
--gst
select sum(gst)-(select sum(gst) from pur) from sales
--profit
select sum(price)-(select sum(amount) from pur) from sales

alter table pur
drop column code

go
create procedure purdetail(
      @n varchar(15),
      @q tinyint,
      @i varchar(7)
)
as
begin
   if exists (select product from pur where product is not null and quant is not null)
          update pur set product=product+','+@n , quant=quant+','+@q where ino=@i;
     else
          update pur set product=@n,quant=@q where ino=@i ;
end


create table stock(
       pcode varchar(5) not null,
       item varchar(20) not null,
       size tinyint not null,
       quant tinyint not null,
       cp smallint not null,
       sp smallint not null,
);
truncate table purstock 
insert into purstock values('SHIRT',20,'@P',400,28-03-2024),('SHIRT',10,'@R'),('PANT',10,'@P')

select distinct item from purstock
select * from stock
drop table stock
exec upstock @item ='shirt',@quant = 5;
drop proc upstock

alter table purstock
add dat date not null

create table salstock(
   item varchar(20) not null,
   quant tinyint not null,
   rate smallint not null,
   indate date not null
);

drop table salstock

select * from salstock
truncate table salstock
insert into salstock values('shirt',2,getdate()),('pant',2,'10-feb-2024');
select item,quant from salstock where indate between GETDATE() and getdate();

alter table salstock
add id varchar(4) not null;


go
create PROCEDURE upstock(
   @id varchar(5),
   @item varchar(20), 
   @s tinyint,
   @quant tinyint,
   @cp smallint,
   @sp smallint
)
AS
begin
   if exists (select item from stock where item=@item and size=@s and cp=@cp)
   begin
        update stock set quant=quant+@quant where item=@item and size=@s and cp=@cp;
   end
   else
   begin 
        insert into stock values(@id,@item,@s,@quant,@cp,@sp);
   end
end
go

drop proc upstock

go
create procedure minst(
    @item varchar(20),
    @quant tinyint,
    @rate smallint,
    @date date)
as
begin
if exists(select item from purstock where item=@item)
     begin
         update purstock set quant=quant-@quant where item=@item;
       if exists (select item from salstock where item=@item and indate=@date)
            begin
                  update salstock set quant=quant+@quant where item=@item and indate=@date ;
            end
       else
            begin
                  insert into salstock values(@item,@quant,@rate,@date);
            end
      end
end
    
 drop proc minst
 exec minst @item='shirt',@quant=2,@date='30-Aug-2003';


select item,sum(quant) from purstock group by item

create table temps(
      item varchar(20) not null,
      quant tinyint not null,
      rate smallint not null,
      amount int not null,
      gst float(2) not null,
);
insert into temps values('shirt',2,400,4000,200),('pant',3,300,2000,50)

select SUM(amount) as amount, SUM(gst) as gst from temps

select * from temps
truncate table temps

drop table temps

alter table temps
add code varchar(4) not null;
--custom page
create table pricelist(
     pn varchar(20) not null,
     cp smallint not null,
     sp smallint not null
)

drop table pricelist
truncate table pricelist
select * from pricelist
