CREATE PROCEDURE Semaforo_Modificar_Config
		@ID_Semaforo INT,
		@Config VARCHAR (50)
AS
	Update TB_Semaforo set Configuracion=@Config where ID_Semaforo=@ID_Semaforo
