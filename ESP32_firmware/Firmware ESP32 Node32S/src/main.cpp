#include <Arduino.h>
#include <SPI.h>
#include <Wire.h>
#include <Adafruit_GFX.h>
#include <Adafruit_SSD1306.h>

#define PaymentReceivedID 5555
#define UserTimeout 5

#define Yes 0
#define No 1

#define sensitivity 6
#define SelectionMenuOptions 5

#define outputA 26
#define outputB 27
#define RotaryEncoderButtonPin 12
#define PowerEncoder 21
#define Relay1 2
#define Relay2 0
#define Relay3 4
#define Relay4 16
#define Relay5 17
#define Relay6 15

#define SoftwareDebounce 100 // Delay of 100ms between presses

#define Welcome 1
#define Selection 2
#define Check 3
#define AwaitingPayment 4
#define Confirmation 5
#define Error 6
#define Timeout 7
#define CardDeclined 8

#define WelcomeScreenDuration 3000
#define AwaitingPaymentDuration 30000
#define PickupItemDuration 30000
#define AwaitingPaymentAnimationDuration 100

#define OriginXSelection 6  // Top left
#define OriginYSelection 50 // Top left
#define WidthSelectionBox 18
#define HeightSelectionBox 10
#define GapXSelectionBox 20

// ADAFRUIT DECLARATION
#define SCREEN_WIDTH 128 // OLED display width, in pixels
#define SCREEN_HEIGHT 64 // OLED display height, in pixels

// Declaration for SSD1306 display connected using software SPI (default case):
#define OLED_MOSI 13
#define OLED_CLK 14
#define OLED_DC 32
#define OLED_CS 33
#define OLED_RESET 25

Adafruit_SSD1306 display(SCREEN_WIDTH, SCREEN_HEIGHT,
                         OLED_MOSI, OLED_CLK, OLED_DC, OLED_RESET, OLED_CS);

/* Comment out above, uncomment this block to use hardware SPI
#define OLED_DC     6
#define OLED_CS     7
#define OLED_RESET  8
Adafruit_SSD1306 display(SCREEN_WIDTH, SCREEN_HEIGHT,
  &SPI, OLED_DC, OLED_RESET, OLED_CS);
*/

#define NUMFLAKES 10 // Number of snowflakes in the animation example

#define LOGO_HEIGHT 25
#define LOGO_WIDTH 32
static const unsigned char PROGMEM logo_bmp[] =
    {0b11111111, 0b00000000,0b00000000, 0b11111111,
     0b11111111, 0b00000000,0b00000000, 0b11111111,
     0b11000000, 0b00000000,0b00000000, 0b00000011,
     0b11000000, 0b00000000,0b00000000, 0b00000011,
     0b11000000, 0b00000000,0b00000000, 0b00000011,
     0b11000000, 0b00000000,0b00000000, 0b00000011,
     0b11000000, 0b00000000,0b00000000, 0b00000011,
     0b11000000, 0b00000000,0b00000000, 0b00000011,
     0b11000000, 0b00000000,0b00000000, 0b00000011,
     0b11000000, 0b00011100,0b00000000, 0b00000011,
     0b11000000, 0b00111110,0b00000000, 0b00000011,
     0b11000000, 0b01100011,0b00000011, 0b00000011,
     0b11000000, 0b11000001,0b10000011, 0b00000011,// 
     0b11000000, 0b11000000,0b11000110, 0b00000011,
     0b11000000, 0b00000000,0b01111100, 0b00000011,
     0b11000000, 0b00000000,0b00111000, 0b00000011,
     0b11000000, 0b00000000,0b00000000, 0b00000011,
     0b11000000, 0b00000000,0b00000000, 0b00000011,
     0b11000000, 0b00000000,0b00000000, 0b00000011,
     0b11000000, 0b00000000,0b00000000, 0b00000011,
     0b11000000, 0b00000000,0b00000000, 0b00000011,
     0b11000000, 0b00000000,0b00000000, 0b00000011,
     0b11000000, 0b00000000,0b00000000, 0b00000011,
     0b11111111, 0b00000000,0b00000000, 0b11111111,
     0b11111111, 0b00000000,0b00000000, 0b11111111,};
     /*
     static const unsigned char PROGMEM logo_bmp[] =
    {0b11111111, 0b00000000,0b00000000, 0b11111111,
     0b11111111, 0b00000000,0b00000000, 0b11111111,
     0b11111111, 0b00000000,0b00000000, 0b11111111,
     0b11100000, 0b00000000,0b00000000, 0b00000111,
     0b11100000, 0b00000000,0b00000000, 0b00000111,
     0b11100000, 0b00000000,0b00000000, 0b00000111,
     0b11100000, 0b00000000,0b00000000, 0b00000111,
     0b11100000, 0b00000000,0b00000000, 0b00000111,
     0b11100000, 0b00000000,0b00000000, 0b00000111,
     0b11100000, 0b00111100,0b00000000, 0b00000111,
     0b11100000, 0b11111111,0b00000000, 0b00000111,
     0b11100000, 0b11111111,0b00000000, 0b00000111,
     0b11100000, 0b11000011,0b11000011, 0b00000111,// 
     0b11100000, 0b00000000,0b11111111, 0b00000111,
     0b11100000, 0b00000000,0b11111111, 0b00000111,
     0b11100000, 0b00000000,0b00111100, 0b00000111,
     0b11100000, 0b00000000,0b00000000, 0b00000111,
     0b11100000, 0b00000000,0b00000000, 0b00000111,
     0b11100000, 0b00000000,0b00000000, 0b00000111,
     0b11100000, 0b00000000,0b00000000, 0b00000111,
     0b11100000, 0b00000000,0b00000000, 0b00000111,
     0b11100000, 0b00000000,0b00000000, 0b00000111,
     0b11111111, 0b00000000,0b00000000, 0b11111111,
     0b11111111, 0b00000000,0b00000000, 0b11111111,
     0b11111111, 0b00000000,0b00000000, 0b11111111,};
*/

// ADAFRUIT DECLARATION END
void ReadRotaryEncoder(void);
void DisplayTextCentered(String TextToDisplay);
void DisplayTextCenteredY(String TextToDisplay, int XCoordinate);
void DisplaySelectionMenu(void);
void DisplayCheck(void);
void DisplayItems(void);
void DisplayWelcomeTilde(void);
void DisplayAwaitingPayment(void);
void DisplayConfirmation(void);
void DisplayError(void);
void DisplayTimeout(void);

int IncomingID = 0;
unsigned long CurrentMillisCycle = 0;
unsigned int CyclesSecond = 0;
unsigned long LastMillisSecond = 0;

int counter = 0;
int aState;
int aLastState;
int CursorRotaryEncoder = 0;
unsigned long RotaryEncoderButtonDebounce = 0;
bool RotaryEncoderButtonPressed = false; // used to raise/lower the flag
bool RotaryEncoderButtonFlag = false;    // to use in event

bool StateFlag = false; // 0 means it has not been in the state yet, to run initialisation code for each state, should be cleared after, right now redundant with the InputChange flag
int State = 0;
unsigned long MillisTimerState1 = 0;
unsigned long MillisTimerAnimation1 = 0;
int StateAnimation = 0;
bool InputChange = false;
int MenuSelection = 0; // used to select the item and is kept in memory
int YesNo = 0;
bool PaymentReceivedFlag = false;

int ItemsPrice[5] = {15, 10, 20, 8, 25};
// char *ItemsNames[] = {"Scarabs/Tyrannopixelus Rex", "Coffee Beans pins", "Little Prince pins", "Patch", "Joule Thief Cat"};

void setup()
{
  pinMode(outputA, INPUT);
  pinMode(outputB, INPUT);
  pinMode(RotaryEncoderButtonPin, INPUT);
  pinMode(Relay1, OUTPUT);
  pinMode(Relay2, OUTPUT);
  pinMode(Relay3, OUTPUT);
  pinMode(Relay4, OUTPUT);
  pinMode(Relay5, OUTPUT);
  pinMode(Relay6, OUTPUT);
  pinMode(PowerEncoder, OUTPUT);

  digitalWrite(PowerEncoder, LOW);

  Serial.begin(9600);
  aLastState = digitalRead(outputA);

  if (!display.begin(SSD1306_SWITCHCAPVCC))
  {
    Serial.println(F("SSD1306 allocation failed"));
    for (;;)
      ; // Don't proceed, loop forever
  }
  State = Welcome;
}

void loop()
{
  /*if (YesNo == Yes)
  {
    digitalWrite(Relay1, HIGH);
    digitalWrite(Relay2, HIGH);
    digitalWrite(Relay3, HIGH);
    digitalWrite(Relay4, HIGH);
    digitalWrite(Relay5, HIGH);
    digitalWrite(Relay6, HIGH);
  }
  if (YesNo == No)
  {
    digitalWrite(Relay1, LOW);
    digitalWrite(Relay2, LOW);
    digitalWrite(Relay3, LOW);
    digitalWrite(Relay4, LOW);
    digitalWrite(Relay5, LOW);
    digitalWrite(Relay6, LOW);
  }*/

  ReadRotaryEncoder();


  // to remove not used
  CurrentMillisCycle = millis();
  if ((CurrentMillisCycle % 1000) == 0 && LastMillisSecond != CurrentMillisCycle)
  {
    // DEBUG Serial.print("Cycle: ");
    // DEBUG Serial.println(CyclesSecond);
    // DEBUG Serial.print("millis: ");
    // DEBUG Serial.println(CurrentMillisCycle);
    CyclesSecond++;
    LastMillisSecond = CurrentMillisCycle;
    // every 1 second
  }

  while (Serial.available() > 0)
  {
    IncomingID = Serial.parseInt();
    Serial.print("Received by Microcontroller: ");
    Serial.println(IncomingID);
    Serial.print("Parsed by Microcontroller:");
    // if (Serial.read() == '\n')
    //{
    switch (IncomingID)
    {
    case PaymentReceivedID:
      Serial.println("PaymentReceivedID");
      if (State == AwaitingPayment)
        PaymentReceivedFlag = true;
      break;

    default:
      Serial.println("Not defined");
    }
    //}
    InputChange = true;
  }

  switch (State)
  {
  case Welcome:
    if (StateFlag == false)
    {
      // DEBUG Serial.println("Welcome Screen Placeholder");
DisplayWelcomeTilde();
      digitalWrite(PowerEncoder, HIGH);
      MillisTimerState1 = millis();
      StateFlag = true;

        digitalWrite(Relay1, HIGH);
  digitalWrite(Relay2, HIGH);
  digitalWrite(Relay3, HIGH);
  digitalWrite(Relay4, HIGH);
  digitalWrite(Relay5, HIGH);
  digitalWrite(Relay6, HIGH);
    }
    if (MillisTimerState1 + WelcomeScreenDuration < millis())
    {
      State = Selection;
      InputChange = true;
      RotaryEncoderButtonFlag = false; //clear the button flag that sets accidentally on boot
      StateFlag = false;
    }
    break;

  case Selection:
    if (StateFlag == false || InputChange == true)
    {

      //  over/underflow the rotary encoder
      if (CursorRotaryEncoder < 0)
        CursorRotaryEncoder = SelectionMenuOptions * sensitivity - 1;
      if (CursorRotaryEncoder >= SelectionMenuOptions * sensitivity)
        CursorRotaryEncoder = 0;

      // Sets Menu Selection
      int tempMenuSelection = MenuSelection;
      MenuSelection = CursorRotaryEncoder / sensitivity;
/*
if (MenuSelection == 0)    digitalWrite(Relay1, LOW);
else digitalWrite(Relay1, HIGH);
if (MenuSelection == 1)    digitalWrite(Relay2, LOW);
else digitalWrite(Relay2, HIGH);
if (MenuSelection == 2)    digitalWrite(Relay3, LOW);
else digitalWrite(Relay3, HIGH);
if (MenuSelection == 3)    digitalWrite(Relay4, LOW);
else digitalWrite(Relay4, HIGH);
if (MenuSelection == 4)    digitalWrite(Relay5, LOW);
else digitalWrite(Relay5, HIGH);*/

      if (MenuSelection != tempMenuSelection || StateFlag == false)
      {
        DisplaySelectionMenu();
      }
    }
    InputChange = false;
    if (RotaryEncoderButtonFlag == true)
    {
      State = Check;
      StateFlag = false;
      InputChange = false;
      RotaryEncoderButtonFlag = false;
    }
    else
      StateFlag = true; // Set the first time flag if it is not the condition to exit
    break;

  case Check:
    if (StateFlag == false || InputChange == true)
    {
      //  over/underflow the rotary encoder
      if (CursorRotaryEncoder < 0)
        CursorRotaryEncoder = 2 * sensitivity - 1;
      if (CursorRotaryEncoder >= 2 * sensitivity)
        CursorRotaryEncoder = 0;

      // Sets Menu Selection
      int tempYesNo = YesNo;
      YesNo = CursorRotaryEncoder / sensitivity;

      if (YesNo != tempYesNo || StateFlag == false)
      {
        DisplayCheck();
      }
    }
    InputChange = false;
    if (RotaryEncoderButtonFlag == true)
    {
      if (YesNo == Yes)
      {
        // Serial.print("Item");
        Serial.print(MenuSelection);
      }
      State = AwaitingPayment;
      if (YesNo == No)
        State = Selection;
      StateFlag = false;
      InputChange = false;
      RotaryEncoderButtonFlag = false;
    }
    else
      StateFlag = true; // Set the first time flag if it is not the condition to exit
    break;

  case AwaitingPayment:
    if (StateFlag == false)
    {
      DisplayAwaitingPayment();
      MillisTimerState1 = millis();
      MillisTimerAnimation1 = millis();
      StateFlag = true;
    }

if (MillisTimerAnimation1 + AwaitingPaymentAnimationDuration < millis())
{
  MillisTimerAnimation1 = millis();
  DisplayAwaitingPayment();
  StateAnimation++;
  if (StateAnimation > 4) StateAnimation = 0; 
}

    if (MillisTimerState1 + AwaitingPaymentDuration < millis())
    {
      State = Timeout;
      InputChange = true;
      StateFlag = false;
    }
    if (PaymentReceivedFlag == true)
    {
      State = Confirmation;
      PaymentReceivedFlag = false;
      InputChange = true;
      StateFlag = false;
    }
    break;

  case Confirmation:
    if (StateFlag == false)
    {
      DisplayConfirmation();
      switch (MenuSelection)
      {

      case 0: digitalWrite(Relay1, LOW);
      break;

      case 1: digitalWrite(Relay2, LOW);
      break;
      
      case 2: digitalWrite(Relay3, LOW);
      break;
      
      case 3: digitalWrite(Relay4, LOW);
      break;
      
      case 4: digitalWrite(Relay5, LOW);
      break;
      }
      MillisTimerState1 = millis();
      StateFlag = true;
    }
    if (MillisTimerState1 + PickupItemDuration < millis())
    {
      State = Welcome;
      InputChange = true;
      StateFlag = false;
      digitalWrite(Relay1, LOW);
    }
    break;

  case Error:
    if (StateFlag == false)
    {
      DisplayTextCentered("Error");
      MillisTimerState1 = millis();
      StateFlag = true;
    }
    if (MillisTimerState1 + 2300 < millis())
    {
      State = Selection;
      InputChange = true;
      StateFlag = false;
    }
    break;

      case Timeout:
    if (StateFlag == false)
    {
      DisplayTextCenteredY("Timeout", 40);
      MillisTimerState1 = millis();
      StateFlag = true;
    }
    if (MillisTimerState1 + 2300 < millis())
    {
      
      State = Selection;
      InputChange = true;
      StateFlag = false;
    }
    break;

          case CardDeclined:
    if (StateFlag == false)
    {
      DisplayTextCenteredY("Timeout", 40);
      MillisTimerState1 = millis();
      StateFlag = true;
    }
    if (MillisTimerState1 + 2300 < millis())
    {
      State = Selection;
      InputChange = true;
      StateFlag = false;
    }
    break;

  default:
    DisplayTextCentered("Error: State not defined");
  }
}

//
//
// END OF MAIN LOOP
//
//

void ReadRotaryEncoder(void)
{
  // BUTTON HANDLING
  // It is pulled high, grounded when pressed
  if (RotaryEncoderButtonPressed != digitalRead(RotaryEncoderButtonPin))
  {
    if (RotaryEncoderButtonPressed == true) // previous state was high/released, this is high to low
    {
      RotaryEncoderButtonPressed = false;
    }
    else // previous state was low/pressed, this is low to high
    {
      // DEBUG Serial.println("Button pressed");
      if (millis() > RotaryEncoderButtonDebounce + SoftwareDebounce)
      {
        RotaryEncoderButtonFlag = true;
        RotaryEncoderButtonDebounce = millis();
        // DEBUG Serial.println("Debounced Button pressed");
        InputChange = true;
      }
      RotaryEncoderButtonPressed = true;
    }
  }

  // ROTARY ENCODER HANDLING
  aState = digitalRead(outputA); // Reads the "current" state of the outputA
  // If the previous and the current state of the outputA are different, that means a Pulse has occured
  if (aState != aLastState)
  {
    // If the outputB state is different to the outputA state, that means the encoder is rotating clockwise
    if (digitalRead(outputB) != aState)
    {
      counter++;
      CursorRotaryEncoder++;
    }
    else
    {
      counter--;
      CursorRotaryEncoder--;
    }
    // DEBUG Serial.print("Position: ");
    // DEBUG Serial.println(counter);
    // DEBUG Serial.print("CursorRotaryEncoder: ");
    // DEBUG Serial.println(CursorRotaryEncoder);
    InputChange = true;
  }
  aLastState = aState; // Updates the previous state of the outputA with the current state
}



//
//
//
// Display functions
//
//
//
void DisplayTextCentered(String TextToDisplay)
{
  display.clearDisplay();
  display.setTextSize(1);
  display.setTextColor(SSD1306_WHITE);
  display.setCursor(30, 30);
  display.println(TextToDisplay);
  display.display();
}

void DisplayTextCenteredY(String TextToDisplay, int XCoordinate)
{
  display.clearDisplay();
  display.setTextSize(1);
  display.setTextColor(SSD1306_WHITE);
  display.setCursor(XCoordinate, 30);
  display.println(TextToDisplay);
  display.display();
}

void DisplaySelectionMenu(void)
{
  // Select an item
  display.clearDisplay();
  display.setTextSize(1);
  display.setTextColor(SSD1306_WHITE);
  display.setCursor(20, 3);
  display.println("Select an item");
  // DEBUG Serial.println("Selection Screen");
  // Boxes at the bottom
  display.drawRect(OriginXSelection, OriginYSelection, WidthSelectionBox, HeightSelectionBox, SSD1306_WHITE);
  display.drawRect(OriginXSelection + GapXSelectionBox, OriginYSelection, WidthSelectionBox, HeightSelectionBox, SSD1306_WHITE);
  display.drawRect(OriginXSelection + GapXSelectionBox * 2, OriginYSelection, WidthSelectionBox, HeightSelectionBox, SSD1306_WHITE);
  display.drawRect(OriginXSelection + GapXSelectionBox * 3, OriginYSelection, WidthSelectionBox, HeightSelectionBox, SSD1306_WHITE);
  display.drawRect(OriginXSelection + GapXSelectionBox * 4, OriginYSelection, WidthSelectionBox + GapXSelectionBox, HeightSelectionBox, SSD1306_WHITE);
  if (MenuSelection == (SelectionMenuOptions - 1))
  {
    display.fillRect(OriginXSelection + GapXSelectionBox * 4, OriginYSelection, WidthSelectionBox + GapXSelectionBox, HeightSelectionBox, SSD1306_WHITE);
  }
  else
  {
    display.fillRect(OriginXSelection + GapXSelectionBox * (MenuSelection), OriginYSelection, WidthSelectionBox, HeightSelectionBox, SSD1306_WHITE);
  }
  DisplayItems();
  display.display();
}

void DisplayCheck(void)
{
  // Select an item
  display.clearDisplay();
  display.setTextSize(1);
  display.setTextColor(SSD1306_WHITE);
  display.setCursor(3, 3);
  display.println("Confirm selection of");
  // DEBUG Serial.println("Confirm selection of");
  // Boxes at the bottom

  if (YesNo == Yes)
  {
    display.fillRect(OriginXSelection + GapXSelectionBox * 2 - 3, OriginYSelection, WidthSelectionBox + 3, HeightSelectionBox + 1, SSD1306_WHITE);
    display.drawRect(OriginXSelection + GapXSelectionBox * 3, OriginYSelection, WidthSelectionBox + 3, HeightSelectionBox + 1, SSD1306_WHITE);
    display.setTextColor(SSD1306_BLACK);
    display.setCursor(45, 52);
    display.println("Yes");
    display.setTextColor(SSD1306_WHITE);
    display.setCursor(71, 52);
    display.println("No");
  }
  if (YesNo == No)
  {
    display.drawRect(OriginXSelection + GapXSelectionBox * 2 - 3, OriginYSelection, WidthSelectionBox + 3, HeightSelectionBox + 1, SSD1306_WHITE);
    display.fillRect(OriginXSelection + GapXSelectionBox * 3, OriginYSelection, WidthSelectionBox + 3, HeightSelectionBox + 1, SSD1306_WHITE);
    display.setTextColor(SSD1306_WHITE);
    display.setCursor(45, 52);
    display.println("Yes");
    display.setTextColor(SSD1306_BLACK);
    display.setCursor(71, 52);
    display.println("No");
  }
  DisplayItems();
  display.display();
}

void DisplayItems(void)
{
  switch (MenuSelection)
  {
  case 0:
    display.setTextSize(1);
    display.setTextColor(SSD1306_WHITE);
    display.setCursor(20, 20);
    display.println("Cyber Scarab or");
    display.setCursor(10, 30);
    display.println("Tyrannopixelus Rex");
    display.setCursor(45, 40);
    display.println("12 euros");
    break;

  case 1:
    display.setTextSize(1);
    display.setTextColor(SSD1306_WHITE);
    display.setCursor(13, 20);
    display.println("Coffee Beans pins");
    display.setCursor(30, 30);
    display.println("or Tesla Pin");
    display.setCursor(45, 40);
    display.println("10 euros");
    break;

  case 2:
    display.setTextSize(1);
    display.setTextColor(SSD1306_WHITE);
    display.setCursor(15, 20);
    display.println("MCH2022 Butterfly");
    display.setCursor(45, 40);
    display.println("5 euros");
    break;

  case 3:
    display.setTextSize(1);
    display.setTextColor(SSD1306_WHITE);
    display.setCursor(50, 20);
    display.println("Patch");
    display.setCursor(45, 40);
    display.println("8 euros");
    break;

  case 4:
    display.setTextSize(1);
    display.setTextColor(SSD1306_WHITE);
    display.setCursor(12, 20);
    display.println("Joule Thief Cat or");
    display.setCursor(10, 30);
    display.println("Little Prince pins");
    display.setCursor(45, 40);
    display.println("20 euros");

    break;
  }
}

void DisplayWelcomeTilde(void)
{
  display.clearDisplay();
  display.setTextColor(SSD1306_WHITE);
  display.drawBitmap(
      (display.width() - LOGO_WIDTH) / 2,
      (display.height() - LOGO_HEIGHT) / 2-10,
      logo_bmp, LOGO_WIDTH, LOGO_HEIGHT, 1);
  display.setTextSize(1);
  display.setCursor(20, 45);
  display.println("tilde mini mart");
  display.display();
}

void DisplayAwaitingPayment (void)
{
  display.clearDisplay();
  display.setTextColor(SSD1306_WHITE);
  display.setTextSize(1);
  display.setCursor(15, 30);
  display.println("Awaiting Payment");
  display.setCursor(StateAnimation+2, 20);
  display.println("////////////////////");
  display.setCursor(StateAnimation+2, 40);
  display.println("////////////////////");
      display.fillRect(2, 20, 3, 28, SSD1306_BLACK);
      display.fillRect(121, 20, 4, 28, SSD1306_BLACK);

  display.display();
}

void DisplayConfirmation(void)
{
  display.clearDisplay();
  display.setTextColor(SSD1306_WHITE);
  display.setTextSize(1);
  display.setCursor(20, 10);
  display.println("Thank you for");
  display.setCursor(20, 20);
display.println("your support!");
  display.setCursor(20, 45);
  display.println("the tilde team~");
    display.display();
}
