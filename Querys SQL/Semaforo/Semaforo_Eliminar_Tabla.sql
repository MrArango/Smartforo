CREATE PROCEDURE Semaforo_Eliminar_Tabla
	
AS
	SELECT 
	[ID_Semaforo] as '#',
	[Calle_Vertical] as 'Calle Vertical',
	[Calle_Horizontal] as 'Calle Horizontal',
	[Latitud],
	[Longitud],
	[Configuracion] from TB_Semaforo