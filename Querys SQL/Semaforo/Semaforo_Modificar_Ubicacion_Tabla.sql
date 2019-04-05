CREATE PROCEDURE Semaforo_Modificar_Ubicacion_Tabla
AS
	SELECT 
	[ID_Semaforo] as '#',
	[Calle_Vertical] as 'Calle Vertical',
	[Calle_Horizontal] as 'Calle Horizontal',
	[Latitud],
	[Longitud]
	from TB_Semaforo