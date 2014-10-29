int led = 13;
int i =0;
int j = 0;
void setup() {
 pinMode(led, OUTPUT);
 Serial.begin(9600);
 digitalWrite(led,LOW);
 Serial.flush();
}
 
/**
 * Função que lê uma string da Serial
 * e retorna-a
 */
 void pisca() {
   for (;i>0;i--) {
  digitalWrite(led, HIGH);
      delay(500);
      digitalWrite(led, LOW);
      delay(500);
   }
}
String leStringSerial(){
  String conteudo = "";
  char caractere;
  
 
  // Enquanto receber algo pela serial
  while(Serial.available() > 0) {
    // Lê byte da serial
    caractere = Serial.read();
    // Concatena valores
    conteudo.concat(caractere);
    // Aguarda buffer serial ler próximo caractere
    delay(10);
    i++;
    Serial.print(conteudo);
  }
  pisca();
  //Serial.print("Recebi: ");
 // Serial.println(conteudo);
   
  return conteudo;
}


void loop() {
  
    String recebido = leStringSerial();
  
}
