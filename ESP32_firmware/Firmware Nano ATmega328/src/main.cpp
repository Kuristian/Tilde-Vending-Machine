#include <Arduino.h>
#include <SPI.h>
#include <Wire.h>
#include <Adafruit_GFX.h>
#include <Adafruit_SSD1306.h>

#define ScarabBlue 1
#define ScarabBlack 2
#define JouleThief 3
#define Butterfly 4
#define Kex 5
#define CoffeePins 6
#define LittlePrinceYellow 7
#define LittlePrinceRGB 8
#define Patch 9

#define sensitivity 6
#define SelectionMenuOptions 5

#define outputA 8
#define outputB 7

#define Welcome 1
#define Selection 2
#define Check 3
#define Confirmation 4
#define Error 5

#define OriginXSelection 6  // Top left
#define OriginYSelection 50 // Top left
#define WidthSelectionBox 18
#define HeightSelectionBox 10
#define GapXSelectionBox 20

// ADAFRUIT DECLARATION
#define SCREEN_WIDTH 128 // OLED display width, in pixels
#define SCREEN_HEIGHT 64 // OLED display height, in pixels

// Declaration for SSD1306 display connected using software SPI (default case):
#define OLED_MOSI 9
#define OLED_CLK 10
#define OLED_DC 11
#define OLED_CS 12
#define OLED_RESET 13

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

#define LOGO_HEIGHT 16
#define LOGO_WIDTH 16
static const unsigned char PROGMEM logo_bmp[] =
    {0b00000000, 0b11000000,
     0b00000001, 0b11000000,
     0b00000001, 0b11000000,
     0b00000011, 0b11100000,
     0b11110011, 0b11100000,
     0b11111110, 0b11111000,
     0b01111110, 0b11111111,
     0b00110011, 0b10011111,
     0b00011111, 0b11111100,
     0b00001101, 0b01110000,
     0b00011011, 0b10100000,
     0b00111111, 0b11100000,
     0b00111111, 0b11110000,
     0b01111100, 0b11110000,
     0b01110000, 0b01110000,
     0b00000000, 0b00110000};

void testdrawline(void);      // Draw many lines
void testfillrect(void);      // Draw rectangles (filled)
void testdrawcircle(void);    // Draw circles (outlines)
void testfillcircle(void);    // Draw circles (filled)
void testdrawroundrect(void); // Draw rounded rectangles (outlines)
void testfillroundrect(void); // Draw rounded rectangles (filled)
void testdrawtriangle(void);  // Draw triangles (outlines)
void testfilltriangle(void);  // Draw triangles (filled)
void testdrawchar(void);      // Draw characters of the default font
void testdrawstyles(void);    // Draw 'stylized' characters
void testscrolltext(void);    // Draw scrolling text
void testdrawbitmap(void);    // Draw a small bitmap image
void testdrawrect(void);      // Draw rectangles (outlines)
void testanimate(const uint8_t *bitmap, uint8_t w, uint8_t h);
// ADAFRUIT DECLARATION END
void ReadRotaryEncoder(void);
void DisplayTextCentered(String TextToDisplay);

int IncomingID = 0;
unsigned long CurrentMillisCycle = 0;
unsigned int CyclesSecond = 0;
unsigned long LastMillisSecond = 0;

int counter = 0;
int aState;
int aLastState;
int CursorRotaryEncoder = 0;

bool StateFlag = false; // 0 means it has not been in the state yet, to run initialisation code for each state, should be cleared after
int State = 0;
unsigned long MillisTimerState1 = 0;
bool InputChange = false;

void setup()
{
  pinMode(outputA, INPUT);
  pinMode(outputB, INPUT);
  Serial.begin(9600);
  aLastState = digitalRead(outputA);

  // SSD1306_SWITCHCAPVCC = generate display voltage from 3.3V internally
  if (!display.begin(SSD1306_SWITCHCAPVCC))
  {
    Serial.println(F("SSD1306 allocation failed"));
    for (;;)
      ; // Don't proceed, loop forever
  }

  // Show initial display buffer contents on the screen --
  // the library initializes this with an Adafruit splash screen.
  // display.display();
  // delay(200); // Pause for 2 seconds

  // Clear the buffer
  // display.clearDisplay();

  // Draw a single pixel in white
  // display.drawPixel(10, 10, SSD1306_WHITE);

  // Show the display buffer on the screen. You MUST call display() after
  // drawing commands to make them visible on screen!
  // display.display();
  // delay(200);
  // display.display() is NOT necessary after every single drawing command,
  // unless that's what you want...rather, you can batch up a bunch of
  // drawing operations and then update the screen all at once by calling
  // display.display(). These examples demonstrate both approaches...

  // Invert and restore display, pausing in-between
  // display.invertDisplay(true);
  // delay(100);
  // display.invertDisplay(false);
  // delay(100);

  // testanimate(logo_bmp, LOGO_WIDTH, LOGO_HEIGHT); // Animate bitmaps

  State = Welcome;
}

void loop()
{
  ReadRotaryEncoder();
  CurrentMillisCycle = millis();
  if ((CurrentMillisCycle % 1000) == 0 && LastMillisSecond != CurrentMillisCycle)
  {
    Serial.print("Cycle: ");
    Serial.println(CyclesSecond);
    Serial.print("millis: ");
    Serial.println(CurrentMillisCycle);
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
    case ScarabBlue:
      Serial.println("ScarabBlue");
      DisplayTextCentered("ScarabBlue");
      break;

    case ScarabBlack:
      Serial.println("ScarabBlack");
      DisplayTextCentered("ScarabBlack");
      break;

    case JouleThief:
      Serial.println("JouleThief");
      DisplayTextCentered("JouleThief");
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
      Serial.println("Welcome Screen Placeholder");
      DisplayTextCentered("Welcome Screen Placeholder");
      MillisTimerState1 = millis();
      StateFlag = true;
    }
    if (MillisTimerState1 + 1500 < millis())
    {
      State = Selection;
      InputChange = true;
      StateFlag = false;
    }
    break;

  case Selection:
    if (StateFlag == false)
    {
      
      if (InputChange == true)
      {    
         Serial.println("Selection Screen");
        DisplayTextCentered("Selection Screen");
        display.drawRect(OriginXSelection, OriginYSelection, WidthSelectionBox, HeightSelectionBox, SSD1306_WHITE);
        display.drawRect(OriginXSelection + GapXSelectionBox, OriginYSelection, WidthSelectionBox, HeightSelectionBox, SSD1306_WHITE);
        display.drawRect(OriginXSelection + GapXSelectionBox * 2, OriginYSelection, WidthSelectionBox, HeightSelectionBox, SSD1306_WHITE);
        display.drawRect(OriginXSelection + GapXSelectionBox * 3, OriginYSelection, WidthSelectionBox, HeightSelectionBox, SSD1306_WHITE);
        display.drawRect(OriginXSelection + GapXSelectionBox * 4, OriginYSelection, WidthSelectionBox + GapXSelectionBox, HeightSelectionBox, SSD1306_WHITE);
        if (CursorRotaryEncoder > sensitivity * (SelectionMenuOptions - 1))
        {
          display.fillRect(OriginXSelection + GapXSelectionBox * 4, OriginYSelection, WidthSelectionBox + GapXSelectionBox, HeightSelectionBox, SSD1306_WHITE);
        }
        else
        {
          display.fillRect(OriginXSelection + GapXSelectionBox * (CursorRotaryEncoder / sensitivity), OriginYSelection, WidthSelectionBox, HeightSelectionBox, SSD1306_WHITE);
        }
        display.display();
        // StateFlag = true;

        InputChange = false;
      }
    }

    break;

  case Check:
    Serial.println("JouleThief");
    DisplayTextCentered("JouleThief");
    break;

  default:
    DisplayTextCentered("Error: State not defined");
  }
}

/**************************************************************************/
/*!
   @brief   Draw a rectangle with no fill color
    @param    x   Top left corner x coordinate
    @param    y   Top left corner y coordinate
    @param    w   Width in pixels
    @param    h   Height in pixels
    @param    color 16-bit 5-6-5 Color to draw with
*/
/**************************************************************************/

void ReadRotaryEncoder(void)
{
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
    Serial.print("Position: ");
    Serial.println(counter);

    if (CursorRotaryEncoder < 0)
      CursorRotaryEncoder = SelectionMenuOptions * sensitivity - 1;
    if (CursorRotaryEncoder >= SelectionMenuOptions * sensitivity)
      CursorRotaryEncoder = 0;
    Serial.print("CursorRotaryEncoder: ");
    Serial.println(CursorRotaryEncoder);
    InputChange = true;
  }
  aLastState = aState; // Updates the previous state of the outputA with the current state
}

void DisplayTextCentered(String TextToDisplay)
{
  display.clearDisplay();
  display.setTextSize(1);
  display.setTextColor(SSD1306_WHITE);
  display.setCursor(30, 30);
  display.println(TextToDisplay);
  display.display();
}

//
//
//
// ADAFRUIT ANIMATION

void testdrawline()
{
  int16_t i;

  display.clearDisplay(); // Clear display buffer

  for (i = 0; i < display.width(); i += 4)
  {
    display.drawLine(0, 0, i, display.height() - 1, SSD1306_WHITE);
    display.display(); // Update screen with each newly-drawn line
    delay(1);
  }
  for (i = 0; i < display.height(); i += 4)
  {
    display.drawLine(0, 0, display.width() - 1, i, SSD1306_WHITE);
    display.display();
    delay(1);
  }
  delay(250);

  display.clearDisplay();

  for (i = 0; i < display.width(); i += 4)
  {
    display.drawLine(0, display.height() - 1, i, 0, SSD1306_WHITE);
    display.display();
    delay(1);
  }
  for (i = display.height() - 1; i >= 0; i -= 4)
  {
    display.drawLine(0, display.height() - 1, display.width() - 1, i, SSD1306_WHITE);
    display.display();
    delay(1);
  }
  delay(250);

  display.clearDisplay();

  for (i = display.width() - 1; i >= 0; i -= 4)
  {
    display.drawLine(display.width() - 1, display.height() - 1, i, 0, SSD1306_WHITE);
    display.display();
    delay(1);
  }
  for (i = display.height() - 1; i >= 0; i -= 4)
  {
    display.drawLine(display.width() - 1, display.height() - 1, 0, i, SSD1306_WHITE);
    display.display();
    delay(1);
  }
  delay(250);

  display.clearDisplay();

  for (i = 0; i < display.height(); i += 4)
  {
    display.drawLine(display.width() - 1, 0, 0, i, SSD1306_WHITE);
    display.display();
    delay(1);
  }
  for (i = 0; i < display.width(); i += 4)
  {
    display.drawLine(display.width() - 1, 0, i, display.height() - 1, SSD1306_WHITE);
    display.display();
    delay(1);
  }

  delay(2000); // Pause for 2 seconds
}

void testdrawrect(void)
{
  display.clearDisplay();

  for (int16_t i = 0; i < display.height() / 2; i += 2)
  {
    display.drawRect(i, i, display.width() - 2 * i, display.height() - 2 * i, SSD1306_WHITE);
    display.display(); // Update screen with each newly-drawn rectangle
    delay(1);
  }

  delay(2000);
}

void testfillrect(void)
{
  display.clearDisplay();

  for (int16_t i = 0; i < display.height() / 2; i += 3)
  {
    // The INVERSE color is used so rectangles alternate white/black
    display.fillRect(i, i, display.width() - i * 2, display.height() - i * 2, SSD1306_INVERSE);
    display.display(); // Update screen with each newly-drawn rectangle
    delay(1);
  }

  delay(2000);
}

void testdrawcircle(void)
{
  display.clearDisplay();

  for (int16_t i = 0; i < max(display.width(), display.height()) / 2; i += 2)
  {
    display.drawCircle(display.width() / 2, display.height() / 2, i, SSD1306_WHITE);
    display.display();
    delay(1);
  }

  delay(2000);
}

void testfillcircle(void)
{
  display.clearDisplay();

  for (int16_t i = max(display.width(), display.height()) / 2; i > 0; i -= 3)
  {
    // The INVERSE color is used so circles alternate white/black
    display.fillCircle(display.width() / 2, display.height() / 2, i, SSD1306_INVERSE);
    display.display(); // Update screen with each newly-drawn circle
    delay(1);
  }

  delay(2000);
}

void testdrawroundrect(void)
{
  display.clearDisplay();

  for (int16_t i = 0; i < display.height() / 2 - 2; i += 2)
  {
    display.drawRoundRect(i, i, display.width() - 2 * i, display.height() - 2 * i,
                          display.height() / 4, SSD1306_WHITE);
    display.display();
    delay(1);
  }

  delay(2000);
}

void testfillroundrect(void)
{
  display.clearDisplay();

  for (int16_t i = 0; i < display.height() / 2 - 2; i += 2)
  {
    // The INVERSE color is used so round-rects alternate white/black
    display.fillRoundRect(i, i, display.width() - 2 * i, display.height() - 2 * i,
                          display.height() / 4, SSD1306_INVERSE);
    display.display();
    delay(1);
  }

  delay(2000);
}

void testdrawtriangle(void)
{
  display.clearDisplay();

  for (int16_t i = 0; i < max(display.width(), display.height()) / 2; i += 5)
  {
    display.drawTriangle(
        display.width() / 2, display.height() / 2 - i,
        display.width() / 2 - i, display.height() / 2 + i,
        display.width() / 2 + i, display.height() / 2 + i, SSD1306_WHITE);
    display.display();
    delay(1);
  }

  delay(2000);
}

void testfilltriangle(void)
{
  display.clearDisplay();

  for (int16_t i = max(display.width(), display.height()) / 2; i > 0; i -= 5)
  {
    // The INVERSE color is used so triangles alternate white/black
    display.fillTriangle(
        display.width() / 2, display.height() / 2 - i,
        display.width() / 2 - i, display.height() / 2 + i,
        display.width() / 2 + i, display.height() / 2 + i, SSD1306_INVERSE);
    display.display();
    delay(1);
  }

  delay(2000);
}

void testdrawchar(void)
{
  display.clearDisplay();

  display.setTextSize(1);              // Normal 1:1 pixel scale
  display.setTextColor(SSD1306_WHITE); // Draw white text
  display.setCursor(0, 0);             // Start at top-left corner
  display.cp437(true);                 // Use full 256 char 'Code Page 437' font

  // Not all the characters will fit on the display. This is normal.
  // Library will draw what it can and the rest will be clipped.
  for (int16_t i = 0; i < 256; i++)
  {
    if (i == '\n')
      display.write(' ');
    else
      display.write(i);
  }

  display.display();
  delay(2000);
}

void testdrawstyles(void)
{
  display.clearDisplay();

  display.setTextSize(1);              // Normal 1:1 pixel scale
  display.setTextColor(SSD1306_WHITE); // Draw white text
  display.setCursor(0, 0);             // Start at top-left corner
  display.println(F("Hello, world!"));

  display.setTextColor(SSD1306_BLACK, SSD1306_WHITE); // Draw 'inverse' text
  display.println(3.141592);

  display.setTextSize(2); // Draw 2X-scale text
  display.setTextColor(SSD1306_WHITE);
  display.print(F("0x"));
  display.println(0xDEADBEEF, HEX);

  display.display();
  delay(2000);
}

void testscrolltext(void)
{
  display.clearDisplay();

  display.setTextSize(2); // Draw 2X-scale text
  display.setTextColor(SSD1306_WHITE);
  display.setCursor(10, 0);
  display.println(F("scroll"));
  display.display(); // Show initial text
  delay(100);

  // Scroll in various directions, pausing in-between:
  display.startscrollright(0x00, 0x0F);
  delay(2000);
  display.stopscroll();
  delay(1000);
  display.startscrollleft(0x00, 0x0F);
  delay(2000);
  display.stopscroll();
  delay(1000);
  display.startscrolldiagright(0x00, 0x07);
  delay(2000);
  display.startscrolldiagleft(0x00, 0x07);
  delay(2000);
  display.stopscroll();
  delay(1000);
}

void testdrawbitmap(void)
{
  display.clearDisplay();

  display.drawBitmap(
      (display.width() - LOGO_WIDTH) / 2,
      (display.height() - LOGO_HEIGHT) / 2,
      logo_bmp, LOGO_WIDTH, LOGO_HEIGHT, 1);
  display.display();
  delay(1000);
}

#define XPOS 0 // Indexes into the 'icons' array in function below
#define YPOS 1
#define DELTAY 2

void testanimate(const uint8_t *bitmap, uint8_t w, uint8_t h)
{
  int8_t f, icons[NUMFLAKES][3];

  // Initialize 'snowflake' positions
  for (f = 0; f < NUMFLAKES; f++)
  {
    icons[f][XPOS] = random(1 - LOGO_WIDTH, display.width());
    icons[f][YPOS] = -LOGO_HEIGHT;
    icons[f][DELTAY] = random(1, 6);
    Serial.print(F("x: "));
    Serial.print(icons[f][XPOS], DEC);
    Serial.print(F(" y: "));
    Serial.print(icons[f][YPOS], DEC);
    Serial.print(F(" dy: "));
    Serial.println(icons[f][DELTAY], DEC);
  }

  for (;;)
  {                         // Loop forever...
    display.clearDisplay(); // Clear the display buffer

    // Draw each snowflake:
    for (f = 0; f < NUMFLAKES; f++)
    {
      display.drawBitmap(icons[f][XPOS], icons[f][YPOS], bitmap, w, h, SSD1306_WHITE);
    }

    display.display(); // Show the display buffer on the screen
    delay(200);        // Pause for 1/10 second

    // Then update coordinates of each flake...
    for (f = 0; f < NUMFLAKES; f++)
    {
      icons[f][YPOS] += icons[f][DELTAY];
      // If snowflake is off the bottom of the screen...
      if (icons[f][YPOS] >= display.height())
      {
        // Reinitialize to a random position, just off the top
        icons[f][XPOS] = random(1 - LOGO_WIDTH, display.width());
        icons[f][YPOS] = -LOGO_HEIGHT;
        icons[f][DELTAY] = random(1, 6);
      }
    }
  }
}