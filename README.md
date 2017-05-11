# ic7100
Control Head Emultator for Icom IC7100

This project is for connecting a computer to the IC7100 radio instead of using its control head.

This ic7100 program shows Icons that are similar to the icons on the 7100 control head, in a similar layout, in order to make the program easy to use for anyone familiar with the control head of the radio.

This project is in its development phase, so it is not complete.  It is placed on Github for experimenters.  Please do not assume that all will work.

It is written using Visual Studio Community, which can be downloaded for free at:

https://www.visualstudio.com/vs/community/

To work with the project, open the file "Icom7100.sln" with visual studio (File, Open).

If you have suggestions or have noticed errors in the source code, you may communicate by opening an issue, or via email at NR6J@arrl.net.

IMPORTANT: I DO NOT ASSUME ANY RESPONSIBILITY FOR YOUR USE OF THIS SOFTWARE, AND I MAKE NO REPRESENTATIONS ABOUT ITS SAFETY, APPROPRIATENESS, OR USE FOR A PARTICULAR PURPOSE.  USE OF THIS SOFTWARE IS AS-IS.

To connect to the radio, I used a USB to serial converter set to 3 volts:

https://amazon.com/gp/product/B00IJXZQ7C/ref=oh_aui_detailpage_o07_s00?ie=UTF8&psc=1

And a USB to audio interface:

https://smile.amazon.com/gp/product/B0027EMHM6/ref=oh_aui_search_detailpage?ie=UTF8&psc=1

I have included a schematic drawn using ExpressPCB's software.  Connect the radio as shown.  The audio from the radio shows up as a "USB Audio Device" in the "Playback Devices" or "Recording Devices" (right-click on the speaker icon in the lower right of the screen).

I have included a copy of the digitally signed com0com software.  To run the emulator from a remote location, use com0com and com2tcp to connect to the com port of the computer that is connected to the radio (Use com2tcp in listen mode at the radio to listen for connections.  I.E., "com2tcp-rfc2217 COM6 7000", where COM6 is replaced by the name of the COM port connected to the radio.  Use com0com and com2tcp at the remote end to connect to the radio.  First, install com0com.  This creates two ports, for instance COM3 and COM4, which are paired.  Then, connect com2tcp to COM4 (in the above example), and the emulator to COM3.  I.E., "com2tcp-rfc2217 COM4 myradiocomputer.mydomain.com 7000".  Start the emulator, choose COM3 in the drop-down box and press the "Init" button.  If you have wired the radio as shown in the schematic, you should be able to press the "Power" button to turn on the radio, and you are in control.)  To get the audio, use the "RemAud-Setup.exe" program - server mode at the radio and client mode at the remote end.  You could also use Skype, or any other remote audio program.

Before trying it remote, get the software working on the radio computer without using com0com or RemAud.  When you have it working locally, try the above remotely.

Hopefully, this program will be helpful for experimenters, and if you have additional contributions for the project, please contact me:

Dennis Engdahl
NR6J
(530) 926-2996
NR6J@arrl.net
