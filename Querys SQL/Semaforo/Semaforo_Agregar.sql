CREATE PROCEDURE Semaforo_Agregar	
    @Calle_Vertical   VARCHAR (50),
    @Calle_Horizontal VARCHAR (50),
    @Latitud          VARCHAR (30),
    @Longitud         VARCHAR (30),
    @Configuracion int
AS
	Insert into TB_Semaforo values(@Calle_Vertical,@Calle_Horizontal,@Latitud,@Longitud,@Configuracion)