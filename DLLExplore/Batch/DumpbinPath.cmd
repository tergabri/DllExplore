echo %1
set logName=%1

echo %2
set fileName=%2

call "C:\Program Files (x86)\Microsoft Visual Studio 11.0\VC\vcvarsall.bat" x86
"C:\Program Files (x86)\Microsoft Visual Studio 11.0\VC\bin\dumpbin.exe" %fileName% /EXPORTS > %logName%