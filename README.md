# Zack.DotNetTrimmer
[中文文档(Chinese Version)](https://github.com/yangzhongke/Zack.DotNetTrimmer/blob/main/README_ZH_CN.md)

This application can be used for trimming .NET Core applications.  Although .NET Core has the capability of tailoring unused code, however, because it is implemented using static analysis, its tailoring is not optimal.  It has the following two disadvantages:  
1) It doesn't support Windows Forms or WPF, and it's desktop developers who are most eager to tailor applications.  
2) It cannot delete assemblies that are not being used at runtime.  For example, our program uses assembly A, which in turn references two assemblies B and C. Only method M1 in assembly A uses assembly B, and only method M2 in assembly A uses assembly C.  Our program only calls M1 in A, but never M2 in A.  Although the C assembly has not been called, the 'tailoring unused code' function does static reference checking, so the C assembly will not be removed.
3) It doesn't support reflection very well.  Because it is implemented using static analysis, it may remove assemblies that would only be loaded by reflection at runtime.  

In contrast, Zack.DotNetTrimmer **supports Windows Forms and WPF**. It analyzes the assemblies loaded by an application at runtime to check which assemblies are not being used, so it not only  **deletes more assemblies** that are not being used, but also naturally ** supports reflection ** . Every advantage has its disadvantage, the downside of Zack.dotnetTrimmer is that it requires you to run the project to be trimmed and run through all the functionality in the program so that you can detect assemblies that will not be used under any circumstances.  

Comparison of trimming：
|			   |original size|.NET Core|Zack.DotNetTrimmer|
|  ----        | ----   | ----       | ----             |
|Empty Core MVC Project| 97MB   |  50.3MB    | 43.6MB           |
|Empty WebAPI Project| 93MB   |  46.3MB    | 34.5 MB          |
|Empty Empty WPF Project| 152 MB | Unsupported| 75.2 MB          |
|Empty WinForms Project| 152 MB | Unsupported| 50.0 MB          |



How to：
1) Download the Zack.DotNetTrimmer executable and unzip the program to disk, [Download](https://github.com/yangzhongke/Zack.DotNetTrimmer/releases)

2) Publish the project to be trimmed, please use the ** 'self-contained'**  as deployment mode . Do not select **Produce single file**  or 'Framework-dependent' deployment mode.
3) Run DotNetTrimmer on the command line and pass the **full path** of the program to be trimmed as the parameter of --file. For example:  

```
Zack.DotNetTrimmer.exe --file d:\a\ASPNETCore6WebAPI1.exe
```

After running, Zack.DotNetTrimmer will start as a console program, and the program to be trimmed will start automatically.  

4)  Execute all functions in the program to be trimmed, covering all code paths.  After completing all functions, press Ctrl+C or Ctrl+Break in the Zack.DotNetTrimmer console to send a shutdown request for the program to be trimmed. Zack.DotNetTrimmer analyzes and trim the program . When trimming is complete, "Timming done." will be shown.  

So the program is clipped. As shown below:

![Result](https://raw.githubusercontent.com/yangzhongke/Zack.DotNetTrimmer/main/images/1.png)

Advanced usage：

Q1) How do I pass command-line arguments to the program to be trimmed?

Answer:

```
Zack.DotNetTrimmer.exe --file d:\a\ASPNETCore6WebAPI1.exe --urls=http://localhost:8888/
```

Q2) How to restore the deleted files?

Answer:

Before it exits, it will prompt the backup path, please go to that path to get the backup version. 

Q3) Can I reduce the file size further?

Answer:

This program uses DiagnosticsClient to check all the assemblies loaded at runtime, so that it knows which assemblies are not being used.  By default, only unused assemblies are deleted. 
 
If the --greedy parameter is used, the program also clear the method bodies of unsed classes in the used assemblies, further reducing the file size.  

Usage:

```
Zack.DotNetTrimmer.exe --greedy --file d:\a\ASPNETCore6WebAPI1.exe
```

However, this requires a more thorough test of all the running paths of the program, or it may cause the program to crash when it runs on something that is not being tested.  

Note: If the full path contains special characters such as Spaces, please enclose them in double quotation marks, for example: --file "d:/a  b/1.exe"

Q4)Can a program run multiple times before it's trimmed?  

Answer:

By default, this program will trim the program as soon as the clipped program exits.  On more complex projects, however, you may need to run the program multiple times in different environments to cover the entire path of the code before trimming it.  

The program supports two modes: Record and Apply. In Record mode, the program will record the running information of the program to a JSON file. If the JSON file already exists, the program will append the information to the JSON file.  

After we run the program to be trimmed in Record mode for many times, we run the program with the Apply model again and specify the JSON file recorded previously. The program will trim the program according to the recorded JSON file.  

Record mode uses --record parameter to enable, and need to take the JSON file path as the parameter value, for example:  
```
--record d:/1.json --file d:/1.exe
```

Apply mode uses --apply parameter to enable, and need to take the JSON file path as the parameter value, for example:  
```
--apply d:/1.json --file d:/1.exe
```

In Apply mode, we can still use the --greedy parameter.

Q5)Can I record information about the program to be trimmed and repeat the trimming in an automated build multiple times?  

Answer:

Yes. Please use the --record mode mentioned above, then reuse the recorded JSON file with --apply during building.  