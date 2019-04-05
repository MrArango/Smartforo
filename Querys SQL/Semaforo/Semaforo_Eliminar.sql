CREATE PROCEDURE Semaforo_Eliminar
			@ID_Semaforo INT
AS
	delete from TB_Semaforo where ID_Semaforo=@ID_Semaforo
