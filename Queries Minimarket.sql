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

 go