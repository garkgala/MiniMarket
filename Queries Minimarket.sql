Create procedure Sp_Listado_ca '%'
@cTexto varchar(100)=''
as
	select codigo_ca, descripcion_ca 
	from dbo.TB_CATEGORIAS 
	WHERE estado=1 and 
	upper(trim(cast(codigo_ca as char)) + trim(descripcion_ca)) 
	like '%' + upper(trim(@cTexto)) + '%';
	GO

CREATE PROCEDURE Sp_Guardar_ca
@nOpcion int=0,
@nCodigo_ca int =0,
@cDescripcion_ca varchar(40)=''
as
if @nOpcion=1 --Nuevo registro
begin
	Insert into TB_CATEGORIAS(descripcion_ca, estado) values (@cDescripcion_ca, 1);
end;
else --Actualizar registro
begin
	update TB_CATEGORIAS set descripcion_ca = @cDescripcion_ca where codigo_ca=@nCodigo_ca;
end;
go

create procedure SP_ELIMINAR_CA
@nCodigo_ca int=0
as
update TB_CATEGORIAS set estado=0 where	 codigo_ca = @nCodigo_ca;
go
select * from TB_CATEGORIAS

--para reestablecer el numero que se coloca automaticamente en el identity de una tabla (el codigo)
 dbcc CHECKIDENT (TB_CATEGORIAS, reseed, 6)
 go

 sp_helptext SP_ELIMINAR_CA
 go
 
 Create procedure Sp_Listado_ma
@cTexto varchar(40)=''  
as  
 select codigo_ma, descripcion_ma   
 from dbo.TB_MARCAS   
 WHERE estado=1 and   
 upper(trim(cast(codigo_ma as char)) + trim(descripcion_ma))   
 like '%' + upper(trim(@cTexto)) + '%';  

 go

   
CREATE PROCEDURE Sp_Guardar_ma  
@nOpcion int=0,  
@nCodigo_ma int =0,  
@cDescripcion_ma varchar(40)=''  
as  
if @nOpcion=1 --Nuevo registro  
begin  
 Insert into TB_MARCAS(descripcion_ma, estado) values (@cDescripcion_ma, 1);  
end;  
else --Actualizar registro  
begin  
 update TB_MARCAS set descripcion_ma = @cDescripcion_ma where codigo_ma=@nCodigo_ma;  
end;  

go

create procedure SP_ELIMINAR_MA  
@nCodigo_ma int=0  
as  
update TB_MARCAS set estado=0 where  codigo_ma = @nCodigo_ma;  

go

CREATE PROCEDURE Sp_Guardar_ma  
@nOpcion int=0,  
@nCodigo_ma int =0,  
@cDescripcion_ma varchar(40)=''  
as  
if @nOpcion=1 --Nuevo registro  
begin  
 Insert into TB_MARCAS(descripcion_ma, estado) values (@cDescripcion_ma, 1);  
end;  
else --Actualizar registro  
begin  
 update TB_MARCAS set descripcion_ma = @cDescripcion_ma where codigo_ma=@nCodigo_ma;  
end;  

go

 Create procedure Sp_Listado_um
@cTexto varchar(20)=''  
as  
 select codigo_um, abreviatura_um, descripcion_um   
 from dbo.TB_UNIDADES_MEDIDA   
 WHERE estado=1 and   
 upper(trim(cast(codigo_um as char)) 
 + trim(abreviatura_um) 
 + trim(descripcion_um))   
 like '%' + upper(trim(@cTexto)) + '%';  

 go

 CREATE PROCEDURE Sp_Guardar_um  
@nOpcion int=0,  
@nCodigo_um int =0,  
@cDescripcion_um varchar(40)='',
@cAbreviatura_um varchar(3)
as  
if @nOpcion=1 --Nuevo registro  
begin  
 Insert into TB_UNIDADES_MEDIDA(abreviatura_um,
								descripcion_um, 
								estado) 
						values (@cAbreviatura_um,
								@cDescripcion_um, 
								1);  
end;  
else --Actualizar registro  
begin  
 update TB_UNIDADES_MEDIDA set	abreviatura_um = @cAbreviatura_um, 
								descripcion_um = @cDescripcion_um 
							where codigo_um=@nCodigo_um;  
end; 

GO

create procedure SP_ELIMINAR_UM  
@nCodigo_um int=0  
as  
update TB_UNIDADES_MEDIDA set estado=0 where  codigo_um = @nCodigo_um;  

GO

 Create procedure Sp_Listado_al
@cTexto varchar(40)=''  
as  
 select codigo_al, descripcion_al  
 from dbo.TB_ALMACENES  
 WHERE estado=1 and   
 upper(trim(cast(codigo_al as char)) + trim(descripcion_al))   
 like '%' + upper(trim(@cTexto)) + '%';  

 GO

 ALTER PROCEDURE Sp_Guardar_al 
@nOpcion int=0,  
@nCodigo_al int =0,  
@cDescripcion_al varchar(40)=''  
as 
declare @xCodigo int=0
if @nOpcion=1 --Nuevo registro  
begin  
 Insert into TB_ALMACENES(descripcion_al, estado) values (@cDescripcion_al, 1); 
 set @xCodigo = @@IDENTITY
 INSERT INTO TB_STOCK_PRODUCTOS (codigo_pr,
								codigo_al,
								stock_actual,
								pu_compra)
							SELECT codigo_pr,
									@xCodigo,
									0.00,
									0.00
							FROM TB_PRODUCTOS;
end;  
else --Actualizar registro  
begin  
 update TB_ALMACENES set descripcion_al = @cDescripcion_al where codigo_al=@nCodigo_al;  
end;  


GO

create procedure SP_ELIMINAR_AL 
@nCodigo_al int=0  
as  
update TB_ALMACENES set estado=0 where  codigo_al = @nCodigo_al;  

GO

 Create procedure Sp_Listado_pr
@cTexto varchar(100)=''  
as  
 select a.codigo_pr, 
		a.descripcion_pr,
		b.descripcion_ma,
		c.descripcion_um,
		d.descripcion_ca,
		a.stock_max,
		a.stock_max,
		a.codigo_ma,
		a.codigo_ca,
		a.codigo_um
 from dbo.TB_PRODUCTOS         a
 inner join TB_Marcas          b on a.codigo_ma = b.codigo_ma
 inner join TB_UNIDADES_MEDIDA c on c.codigo_um = a.codigo_um
 inner join TB_CATEGORIAS      d on d.codigo_ca = a.codigo_ca
 WHERE a.estado=1 and   
 upper	(trim(cast(a.codigo_pr as char)) +
		trim(a.descripcion_pr)+
		trim(b.descripcion_ma)+
		trim(c.descripcion_um)+
		trim(d.descripcion_ca))
 like '%' + upper(trim(@cTexto)) + '%'
 order by a.codigo_pr;

 GO

 CREATE PROCEDURE Sp_Guardar_pr    
@nOpcion int=0,    
@nCodigo_pr int =0,    
@cDescripcion_pr varchar(100)='',
@nCodigo_ma int = 0,
@nCodigo_um int = 0,
@nCodigo_ca int = 0,
@nStock_min decimal(10,2)=0,
@nStock_max decimal(10,2)=0
as    
declare @xCodigo int = 0
declare @fFecha as datetime
set @fFecha = convert(datetime, GETDATE())
if @nOpcion=1 --Nuevo registro    
begin    
 INSERT INTO TB_PRODUCTOS(descripcion_pr,
							codigo_ma,
							codigo_um,
							codigo_ca,
							stock_min,
							stock_max,
							fecha_crea,
							fecha_modifica,
							estado)
						VALUES
							(@cDescripcion_pr,
							@nCodigo_ma,
							@nCodigo_um,
							@nCodigo_ca,
							@nStock_min,
							@nStock_max,
							@fFecha,
							@fFecha,
							1);
		set @xCodigo = @@IDENTITY --obtiene el codigo que se genero automaticamente

		INSERT INTO TB_STOCK_PRODUCTOS(codigo_pr, 
										codigo_al,
										stock_actual,
										pu_compra)
									SELECT @xCodigo,
											codigo_al,
											0.00,
											0.00
									FROM TB_ALMACENES
end;    
else --Actualizar registro    
begin    
 UPDATE TB_PRODUCTOS SET descripcion_pr=@cDescripcion_pr,
						codigo_ma = @nCodigo_ma,
						codigo_um = @nCodigo_um,
						codigo_ca = @nCodigo_ca,
						stock_min = @nStock_min,
						stock_max = @nStock_max,
						fecha_modifica = @fFecha
					WHERE
						codigo_pr = @nCodigo_pr;
--hacemos una insercion en un nuevo almacen en el caso de que este no existia al momento de crear el producto inicialmente
 INSERT INTO TB_STOCK_PRODUCTOS			(codigo_pr, 
										codigo_al,
										stock_actual,
										pu_compra)
									SELECT @nCodigo_pr,
											codigo_al,
											0.00,
											0.00
									FROM TB_ALMACENES --Filtramos para que no se haga la insercion en los almacenes iniciales
									WHERE codigo_al not in (select codigo_al 
															from TB_STOCK_PRODUCTOS 
															where codigo_pr=@nCodigo_pr)
end; 

GO

create procedure SP_ELIMINAR_pr    
@nCodigo_pr int=0    
as    
update TB_PRODUCTOS set estado=0 where  codigo_pr = @nCodigo_pr; 

GO

 Create procedure Sp_Listado_ma_pr
@cTexto varchar(40)=''    
as    
 select  descripcion_ma, codigo_ma     
 from dbo.TB_MARCAS     
 WHERE estado=1 and     
 upper(trim(descripcion_ma))     
 like '%' + upper(trim(@cTexto)) + '%'; 

 GO

 Create procedure Sp_Listado_um_pr  
@cTexto varchar(20)=''      
as      
 select  descripcion_um, codigo_um      
 from dbo.TB_UNIDADES_MEDIDA       
 WHERE estado=1 and       
 upper(trim(descripcion_um))       
 like '%' + upper(trim(@cTexto)) + '%'; 

 GO

  Create procedure Sp_Listado_ca_pr  
@cTexto varchar(20)=''      
as      
 select  descripcion_ca, codigo_ca      
 from dbo.TB_CATEGORIAS    
 WHERE estado=1 and       
 upper(trim(descripcion_ca))       
 like '%' + upper(trim(@cTexto)) + '%'; 

 GO

 CREATE PROCEDURE SP_Ver_Stock_Actual_ProductoxAlmacenes
 @nCodigo_pr int =0
 as
 select c.descripcion_al,
		b.stock_actual,
		b.pu_compra
 FROM TB_STOCK_PRODUCTOS b
 INNER JOIN TB_ALMACENES c on b.codigo_al = c.codigo_al
 WHERE b.codigo_pr = @nCodigo_pr
 ORDER BY b.codigo_al
 
GO

 Create procedure Sp_Listado_ru  
@cTexto varchar(60)=''    
as    
 select codigo_ru, descripcion_ru     
 from dbo.TB_RUBROS     
 WHERE estado=1 and     
 upper(trim(cast(codigo_ru as char)) + trim(descripcion_ru))     
 like '%' + upper(trim(@cTexto)) + '%'; 

 GO

CREATE PROCEDURE Sp_Guardar_ru    
@nOpcion int=0,    
@nCodigo_ru int =0,    
@cDescripcion_ru varchar(60)=''    
as    
if @nOpcion=1 --Nuevo registro    
begin    
 Insert into TB_RUBROS(descripcion_ru, estado) values (@cDescripcion_ru, 1);    
end;    
else --Actualizar registro    
begin    
 update TB_RUBROS set descripcion_ru = @cDescripcion_ru where codigo_ru=@nCodigo_ru;    
end; 

GO

create procedure SP_ELIMINAR_RU    
@nCodigo_ru int=0    
as    
update TB_RUBROS set estado=0 where  codigo_ru = @nCodigo_ru; 

GO

 Create procedure Sp_Listado_de    
@cTexto varchar(100)=''      
as      
 select codigo_de, descripcion_de       
 from dbo.TB_DEPARTAMENTOS       
 WHERE estado=1 and       
 upper(trim(cast(codigo_de as char)) + trim(descripcion_de))       
 like '%' + upper(trim(@cTexto)) + '%'; 

 GO

CREATE PROCEDURE Sp_Guardar_de      
@nOpcion int=0,      
@nCodigo_de int =0,      
@cDescripcion_de varchar(100)=''      
as      
if @nOpcion=1 --Nuevo registro      
begin      
 Insert into TB_DEPARTAMENTOS(descripcion_de, estado) values (@cDescripcion_de, 1);      
end;      
else --Actualizar registro      
begin      
 update TB_DEPARTAMENTOS set descripcion_de = @cDescripcion_de where codigo_de=@nCodigo_de;      
end; 

GO

create procedure SP_ELIMINAR_DE      
@nCodigo_de int=0      
as      
update TB_DEPARTAMENTOS set estado=0 where  codigo_de = @nCodigo_de; 

GO

 Create procedure Sp_Listado_po      
@cTexto varchar(100)=''        
as        
 select a.codigo_po, 
		a.descripcion_po,
		b.descripcion_de,
		a.codigo_de
 from dbo.TB_PROVINCIAS a
 INNER JOIN TB_DEPARTAMENTOS b on a.codigo_de = b.codigo_de
 WHERE a.estado=1 and         
 upper(trim(cast(a.codigo_po as char)) + 
	   trim(a.descripcion_po) +
	   trim(b.descripcion_de))
 like '%' + upper(trim(@cTexto)) + '%'; 

 GO

ALTER PROCEDURE Sp_Guardar_po        
@nOpcion int=0,        
@nCodigo_po int =0,        
@cDescripcion_po varchar(100)=''  ,
@nCodigo_de int=0
as        
if @nOpcion=1 --Nuevo registro        
begin        
 Insert into TB_PROVINCIAS(descripcion_po,codigo_de, estado) values (@cDescripcion_po,@nCodigo_de, 1);        
end;        
else --Actualizar registro        
begin        
 update TB_PROVINCIAS set descripcion_po = @cDescripcion_po, 
						  codigo_de = @nCodigo_de 
					  where codigo_po=@nCodigo_po;        
end; 

GO

create procedure SP_ELIMINAR_PO        
@nCodigo_po int=0        
as        
update TB_PROVINCIAS set estado=0 where  codigo_po = @nCodigo_po; 

GO

 Create procedure Sp_Listado_de_po      
@cTexto varchar(100)=''        
as        
 select descripcion_de, codigo_de       
 from dbo.TB_DEPARTAMENTOS         
 WHERE estado=1 and         
 upper(trim(cast(codigo_de as char)) + trim(descripcion_de))         
 like '%' + upper(trim(@cTexto)) + '%'; 