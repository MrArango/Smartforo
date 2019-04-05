CREATE PROCEDURE Semaforo_Modificar_Calles_Tabla
AS
SELECT 
	[ID_Semaforo] as '#',
	[Calle_Vertical] as 'Calle Vertical',
	[Calle_Horizontal] as 'Calle Horizontal'
	from TB_Semaforo