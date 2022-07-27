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
