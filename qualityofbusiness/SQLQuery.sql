create table sales(
    ino tinyint not null,
    cusn varchar(25) not null,
    phone varchar(10) not null,
    amount smallint not null,
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

create table userinfo(
    sn varchar(20) not null,
    un varchar(15) not null,
    pw varchar(8) not null,
);
select * from userinfo
truncate table userinfo

go
create procedure item(
      @n varchar(20),
      @i tinyint
)
as
begin
    if exists (select item from sales where item is null)
    begin
          update sales set item=@n where ino=@i;
      end
     else
     begin
           update sales set item=item+','+@n  where ino=@i;
      end
end

drop proc item;

create table tempin(
     pid varchar(5) not null,
     item varchar(20) not null,
     pd varchar(20) not null,
     size tinyint not null,
     rate smallint  null,
     quantity tinyint not null,
     price smallint not null,
     gst float(2) not null
);
truncate table tempin
select * from tempin;

insert into tempin(ino,item,quantity,price,gst) values(1,'shirt',1,400,20),(1,'shirt',1,400,20);

alter table tempin
drop column code

drop table tempin

create table amt(
     ino varchar(8) not null,
     seller varchar(20) not null,
     amount int not null,
     gst float(2) not null,
     dte date not null
);
select * from amt

create table pur(
      ino varchar(8) not null,
      seller varchar(20) not null,
      pid varchar(5) not null,
      prod varchar(10) not null,
      pd varchar(20) not null,
      quant tinyint not null,
      cp smallint not null,
      sp smallint not null,
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

drop proc purdetail


create table stock(
       pcode varchar(5) not null,
       item varchar(10) not null,
       pd varchar(20) not null,
       quant tinyint not null,
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
   pcode varchar(5) not null,
   item varchar(10) not null,
   pd varchar(20) not null,
   size tinyint not null,
   quant tinyint not null,
   rate smallint not null,
   indate date not null
);

drop table salstock

select * from salstock
truncate table salstock
insert into salstock values('P1','PANT','COTTON PANT',36,2,650,'2024-04-04')
select pd,size,sum(quant) from salstock where indate between getdate()-7 and getdate() group by pd,size 

alter table salstock
add id varchar(4) not null;

delete salstock where size=46

go
create PROCEDURE upstock(
   @id varchar(5),
   @item varchar(10),
   @pd varchar(20),
   @quant tinyint
)
AS
begin
   if exists (select item from stock where pcode=@id)
   begin
        update stock set quant=quant+@quant where pcode=@id;
   end
   else
   begin 
        insert into stock values(@id,@item,@pd,@quant);
   end
end
go

drop proc upstock

go
create procedure minst(
    @id varchar(5),
    @n varchar(10),
    @pd varchar(20),
    @s tinyint,
    @quant tinyint,
    @rate smallint,
    @date date)
as
begin
if exists(select item from stock where pcode=@id)
     begin
         update stock set quant=quant-@quant where pcode=@id;
       if exists (select pcode from salstock where pcode=@id and size=@s and indate=@date)
            begin
                  update salstock set quant=quant+@quant where pcode=@id and size=@s and indate=@date ;
            end
       else
            begin
                  insert into salstock values(@id,@n,@pd,@s,@quant,@rate,@date);
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
