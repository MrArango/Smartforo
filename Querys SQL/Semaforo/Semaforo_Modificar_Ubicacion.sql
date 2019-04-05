CREATE PROCEDURE Semaforo_Modificar_Ubicacion
		@ID_Semaforo INT,
		@LNG VARCHAR (50),
		@LAT VARCHAR (50)
AS
	Update TB_Semaforo set Latitud=@LAT, Longitud=@LNG
	where ID_Semaforo=@ID_Semaforo
