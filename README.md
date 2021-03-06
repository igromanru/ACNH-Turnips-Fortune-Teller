# ACNH Turnips Fortune Teller
Turnips Fortune Teller is a small tool for New Horizons, that reads out Turnips prices from a save game made with [JKSV](https://github.com/J-D-K/JKSV).  
This tool was made for legit players who don't want to use cheats or save editors, but still want to know the Turnips prices for the coming week. (Not all have the time to check every morning and evening their prices)

### How to use
1. Double click the `ACNH Turnips Fortune Teller.exe`
2. Press the `Open save game...` button and select/open the `main.dat` or `mainHeader.dat` from your save backup. Both files should be in the same location.
3. Done. 

![Preview](https://i.imgur.com/vVV5Iiq.png)
![Preview2](https://i.imgur.com/P2oGOmA.png)

### How to copy values
Just left click into the field that you want to copy to your clipboard, then you can use ctrl+v to paste somewhere else.

![copy click](https://i.imgur.com/zU1k87Q.gif)

### When do the Turnips prices change?
The game generates new Turnips prices on Sunday for the next week.
It means that you have to create a new save file each week, if you want to know latest prices.

### When do the Visitors rotation change?
New visitor rotation begins at Monday, so if you want to know which visitor will come the recent week, you have to create a new save game on Monday or later.

### Requirements
For Windows: [.NET Framework 4.7](https://dotnet.microsoft.com/download/dotnet-framework/net47)  
For Unix / MacOS: [latest Mono](https://www.mono-project.com/download/stable/) 

### Credits
[NHSE](https://github.com/kwsch/NHSE) by [Kurt](https://github.com/kwsch): I'm using NHSE's save parser  
