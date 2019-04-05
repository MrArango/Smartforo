/*Verde dura de 5 a 15 seg
  Amarillo dura 2 a 5 seg
  Roja dura 5 a 15 seg */

//Definir Pines
int verde = 4;
int amarillo = 3;
int rojo = 2;
int vibrador = 7;
int Buzzer = 13;

char opcion = '0';
char aux = '0';

//Med
int TiempoVerde1 = 8000; // 8 seg + 2 seg de parpadeo = 10 seg
int TiempoAmarillo1 = 3000; // 3 seg
int TiempoRojo1 = 5000; // 5 seg

//Rapido
int TiempoVerde2 = 3000; // 3 seg + 2 seg de parpadeo = 5 seg
int TiempoAmarillo2 = 2000; // 2 seg
int TiempoRojo2 = 5000; //

//Lento
int TiempoVerde3 = 13000 ; // 13 seg + 2 seg de parpadeo = 15 seg
int TiempoAmarillo3 = 5000; // 5 seg
int TiempoRojo3 = 15000; // 15 seg

void setup()
{
    Serial.begin(9600); 
    pinMode(verde, OUTPUT);
    pinMode(amarillo,OUTPUT);
    pinMode(rojo,OUTPUT);
    pinMode(vibrador,OUTPUT);
    pinMode(Buzzer,OUTPUT);
}

void loop()
{     
  if((Serial.available() > 0))
  {
    opcion = Serial.read();   
    
    if(!(opcion == ' '))
    {
      aux = opcion;
    }
  }
    if(aux == '1')
    {
      Carga_1();
    }
    if(aux == '2')
    {
      Carga_2();
    }
    if(aux == '3')
    {
       Carga_3();
    }
}      

void Carga_1()
{
  digitalWrite(verde,HIGH); //encendemos el led verde
    delay(TiempoVerde1);
    digitalWrite(verde,LOW);  //apagamos el led verde
    delay(500); 
    
    digitalWrite(verde,HIGH); //encendemos el led verde
    delay(500);             //esperamos .5 segundos
    digitalWrite(verde,LOW);  //apagamos el led verde
    delay(500);      //esperamos medio segundo

    digitalWrite(verde,HIGH); //encendemos el led verde
    delay(500);             //esperamos .5 segundos
    digitalWrite(verde,LOW);  //apagamos el led verde
    delay(500); 
 
    digitalWrite(amarillo,HIGH); //encendemos el led amarillo
    delay(TiempoAmarillo1);
    digitalWrite(amarillo,LOW);  //apagamos el led amarillo
    delay(500);                  //esperamos medio segundo

    digitalWrite(rojo,HIGH); // encendemos el led rojo
    int e=0;
    for(int i=0;i<TiempoRojo1;i=i+1000)
    {        
        tone(Buzzer,(880 + e),(280 - e));
        digitalWrite(vibrador,HIGH);
        delay(1000);  //esperamos 1 segundos
        digitalWrite(vibrador,LOW);
        e=e+10;
    }
                  
    digitalWrite(rojo,LOW);  //apagamos el led rojo 
    delay(500);
}

void Carga_2()
{
  digitalWrite(verde,HIGH); //encendemos el led verde
    delay(TiempoVerde2);            
    digitalWrite(verde,LOW);  //apagamos el led verde
    delay(500); 
    
    digitalWrite(verde,HIGH); //encendemos el led verde
    delay(500);             //esperamos .5 segundos
    digitalWrite(verde,LOW);  //apagamos el led verde
    delay(500);      //esperamos medio segundo

    digitalWrite(verde,HIGH); //encendemos el led verde
    delay(500);             //esperamos .5 segundos
    digitalWrite(verde,LOW);  //apagamos el led verde
    delay(500); 
 
    digitalWrite(amarillo,HIGH); //encendemos el led amarillo
    delay(TiempoAmarillo2);                 
    digitalWrite(amarillo,LOW);  //apagamos el led amarillo
    delay(500);                  //esperamos medio segundo

    digitalWrite(rojo,HIGH); // encendemos el led rojo
    int e=0;
    for(int i=0;i<TiempoRojo2;i=i+1000)
    {        
        tone(Buzzer,(880 + e),(280 - e));
        digitalWrite(vibrador,HIGH);
        delay(1000);  //esperamos 1 segundos
        digitalWrite(vibrador,LOW);
        e=e+10;
    }
                  
    digitalWrite(rojo,LOW);  //apagamos el led rojo 
    delay(500);
}

void Carga_3()
{
  digitalWrite(verde,HIGH); //encendemos el led verde
    delay(TiempoVerde3);
    digitalWrite(verde,LOW);  //apagamos el led verde
    delay(500); 
    
    digitalWrite(verde,HIGH); //encendemos el led verde
    delay(500);             //esperamos .5 segundos
    digitalWrite(verde,LOW);  //apagamos el led verde
    delay(500);      //esperamos medio segundo

    digitalWrite(verde,HIGH); //encendemos el led verde
    delay(500);             //esperamos .5 segundos
    digitalWrite(verde,LOW);  //apagamos el led verde
    delay(500); 
 
    digitalWrite(amarillo,HIGH); //encendemos el led amarillo
    delay(TiempoAmarillo3);
    digitalWrite(amarillo,LOW);  //apagamos el led amarillo
    delay(500);                  //esperamos medio segundo

    digitalWrite(rojo,HIGH); // encendemos el led rojo

    int e=0;
    for(int i=0;i<TiempoRojo3;i=i+1000)
    {        
        tone(Buzzer,(880 + e),(280 - e));
        digitalWrite(vibrador,HIGH);
        delay(1000);  //esperamos 1 segundos
        digitalWrite(vibrador,LOW);
        e=e+10;
    }
                  
    digitalWrite(rojo,LOW);  //apagamos el led rojo 
    delay(500);
}
