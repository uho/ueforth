# µEforth / ESP32forth

This EForth inspired implementation of Forth is bootstraped from a minimalist C kernel.

## Using the provided Arduino file

You find it as [ueforth/out/esp32/ESP32forth/ESP32forth.ino](https://github.com/uho/eforth/blob/VGA32/ueforth/out/esp32/ESP32forth/ESP32forth.ino)

## Building from Source

To build:

```
make
```

The resulting output will have this structure:

* out/deploy - A copy of the eforth.appspot.com / esp32forth.appspot.com ready to deploy.
* out/windows - A build for Windows.
* out/linux - A build for Linux.
