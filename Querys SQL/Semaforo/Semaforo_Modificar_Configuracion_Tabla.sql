CREATE PROCEDURE Semaforo_Modificar_Config_Tabla	
AS
select
	[ID_Semaforo] as '#',
	[Calle_Vertical] as 'Calle Vertical',
	[Calle_Horizontal] as 'Calle Horizontal',
	[Configuracion] as 'Configuraci�n'
	from TB_Semaforo