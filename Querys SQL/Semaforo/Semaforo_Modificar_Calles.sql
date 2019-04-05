CREATE PROCEDURE Semaforo_Modificar_Calles
	@ID_Semaforo INT,
    	@Calle_Vertical VARCHAR (50),
    	@Calle_Horizontal VARCHAR (50)
AS
	Update TB_Semaforo set Calle_Vertical=@Calle_Vertical, Calle_Horizontal=@Calle_Horizontal
	where ID_Semaforo=@ID_Semaforo