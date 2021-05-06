( Set up Basic I/O )
internals definitions
: arduino-cr ( -- ) nl emit ;
' arduino-cr is cr
: arduino-bye   0 terminate ;
' arduino-bye is bye
: arduino-type ( a n -- ) Serial.write drop ;
' arduino-type is type
: arduino-key ( -- n )
   begin Serial.available until 0 >r rp@ 1 Serial.readBytes drop r> ;
' arduino-key is key
: arduino-key? ( -- n ) Serial.available ;
' arduino-key? is key?

DEFINED? Terminal.write [IF]
: terminal-cr ( -- ) nl emit 13 emit ;
' terminal-cr is cr
: terminal-type ( a n -- )  Terminal.write drop ;
' terminal-type is type
: terminal-key ( -- n )  Terminal.read ;
' terminal-key is key
: terminal-key? ( -- n ) Terminal.available ;
' terminal-key? is key?
[THEN]

forth definitions

( Map Arduino / ESP32 things to shorter names. )
: pin ( n pin# -- ) swap digitalWrite ;
: adc ( n -- n ) analogRead ;
: duty ( n n -- ) 255 min 8191 255 */ ledcWrite ;
: freq ( n n -- ) 1000 * 13 ledcSetup drop ;
: tone ( n n -- ) 1000 * ledcWriteTone drop ;

( Utilities )
DEFINED? Terminal.clear [IF]
: page   Terminal.clear ;
[ELSE]
: page   30 for cr next ;
[THEN]

( Basic Ardiuno Constants )
0 constant LOW
1 constant HIGH
1 constant INPUT
2 constant OUTPUT
2 constant LED

( Startup Setup )
-1 echo !
115200 Serial.begin
100 ms
-1 z" /spiffs" 10 SPIFFS.begin drop
led OUTPUT pinMode
high led pin

( Setup entry )
: ok   ." ESP32forth v{{VERSION}} - rev {{REVISION}}" cr prompt refill drop quit ;
