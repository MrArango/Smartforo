CREATE PROCEDURE Semaforo_Datos
	
AS
	SELECT [Calle_Vertical] as 'Calle Vertical',
	[Calle_Horizontal] as 'Calle Horizontal',
	[Latitud],
	[Longitud],
	[Configuracion] from TB_Semaforo