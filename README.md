BeamerMeister
=============

A small C# tool to control the the Epson EH-TW3200 projector over RS232C serial link cable. It might also work with other Epson projectors, since they all seem to have a similar protocol - if you want to extend it to support more models, go right ahead and please send me a pull request!
You can find information about the protocol here: 
ftp://download.epson-europe.com/pub/download/3737/epson373739eu.pdf
http://ftp.epson.com/pdf/pl600p/pl600pcm.pdf

This tool was hacked together at the Nordlicht 2013 demoparty to control the main projector, because I forgot to bring the remote control :). I'm uploading it here in the hope that it might be useful to someone else.

Usage: The projector needs to be connected to a serial port via cross-cable (nullmodem cable). Starting the program will try to autodetect the projector, so make sure you don't have anything connected to serial ports that doesn't like to get a random CR character. If the projector is found, you are presented with a small UI that should be self-explanatory, otherwise the program will refuse to start.
