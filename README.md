#### Developer Set-Up Instructions



Add references for the \[Under BepInEx specifically: 0Harmony, BepInEx] \[Under your Cult Of The Lamb\_Data folder: Assembly-CSharp, Assembly-CSharp-firstpass, UnityEngine, UnityEngine.CoreModule], and \[Under BepInEx plugins: COTL\_API] dlls.



In project properties, add to the post-build event command line: mkdir "\[wherever your bepinex for cotl is]\\BepInEx\\plugins\\$(TargetName)"xcopy /q/y/i "$(TargetPath)" "\[wherever your bepinex for cotl is]\\BepInEx\\plugins\\$(TargetName)" /E /H /C

