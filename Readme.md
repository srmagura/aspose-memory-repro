# AsposeMemoryRepro
This simple project demonstrates a memory leak in Aspose.PDF 21.7.0. See `Program.cs` for details.

Steps to run:
* Open the solution file in Visual Studio 2019.
* Place your Aspose license in the project as an embedded resource. Tweak the resource name in the code if necessary.
* Run the console app.

Program output:
```
Page 20: 111 MB allocated
Page 40: 209 MB allocated
Page 60: 294 MB allocated
Page 80: 379 MB allocated
Page 100: 410 MB allocated
Page 120: 482 MB allocated
Page 140: 580 MB allocated
Page 160: 665 MB allocated
Page 180: 736 MB allocated
Page 200: 768 MB allocated
Page 220: 839 MB allocated
Page 240: 951 MB allocated
Page 260: 1035 MB allocated
Page 280: 1094 MB allocated
Page 300: 1125 MB allocated
Page 320: 1210 MB allocated
Page 340: 1321 MB allocated
Page 360: 1393 MB allocated
Page 380: 1451 MB allocated
```
