int red = 0;
bool flagu = true;

void setup() {
  Serial.begin(9600);
}

void loop() {
  if (millis() == 5000)
  {
    if (flagu == true)
  {
    Serial.print("joulethief");
    flagu = false;
  }
  }

  while (Serial.available() > 0) {

    // look for the next valid integer in the incoming serial stream:
    red = Serial.parseInt();

    if (red == 42) digitalWrite (13, HIGH);
    
    // look for the newline. That's the end of your sentence:
    if (Serial.read() == '\n') {
    }
  }

  
}
