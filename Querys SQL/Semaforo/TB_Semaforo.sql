CREATE TABLE TB_Semaforo
(
	ID_Semaforo int identity(1,1),
	Calle_Vertical varchar(50),
	Calle_Horizontal varchar(50),
	Latitud varchar(30),
	Longitud varchar(30),
	Configuracion varchar(50)

	primary key(ID_Semaforo)
)
