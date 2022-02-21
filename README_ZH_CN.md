# Zack.DotNetTrimmer
这是一个用来对.NET Core程序进行瘦身的应用程序。尽管.NET Core具有【剪裁未使用的代码】的功能，但是由于它是使用静态分析来实现的，因此它的剪裁效果并不是最优的。它有如下两个缺点：
1) 无法删除运行时没有被使用的程序集。比如，我们的程序中使用了A程序集，A程序又引用了B、C两个程序集，A程序集中只有M1方法使用了B程序集，而A程序集中只有M2方法使用了C程序集。我们的程序中只调用了A中的M1方法，而从未调用A中的M2方法。虽然C程序集没有被我们调用过，但是由于【剪裁未使用的代码】功能只是做静态的引用检查，因此C程序集仍然不会被剪裁掉。
2) 【剪裁未使用的代码】无法很好地支持反射。由于它是使用静态分析来实现的，因此它可能会剪裁掉运行时才会被通过反射加载的程序集。
3) 【剪裁未使用的代码】不支持Windows Forms和WPF，而对于程序剪裁功能需求最强烈的其实反而是桌面程序的开发者。

Zack.DotNetTrimmer则可以解决这些问题，它支持Windows Forms和WPF等，它会在运行时分析程序加载的程序集，从而得知哪些程序集没有被使用，因此它不仅能删掉更多没有被使用的程序集，而且能天然的支持反射。当然，任何事物都不可能只有优点，没有缺点。Zack.DotNetTrimmer的缺点是，它要求运行待剪裁的项目，并且把程序中所有功能都全面地运行一遍，这样才能检测到在任何情况下都不会被使用的程序集。

程序剪裁效果对比：
|				             | 原始尺寸|“剪裁未使用的代码”后尺寸| Zack.DotNetTrimmer后尺寸|
|  ----                      | ----    | ----                     | ----                    |
| 空ASP.NET Core MVC6项目    | 97MB    |  50.3MB                  | 43.6MB                  |
| 空ASP.NET Core WebAPI6项目 | 93MB    |  46.3MB                  | 34.5 MB                 |
| 空WPF(.NET Core 6)项目     | 152 MB  |  不支持                  | 75.2 MB                 |
| 空WinForms(.NET Core 6)项目| 152 MB  |  不支持                  | 50.0 MB                 |


用法：
1) 下载Zack.DotNetTrimmer的可执行程序，并且解压程序到磁盘

[windows x86](https://github.com/yangzhongke/Zack.DotNetTrimmer/raw/main/Binaries/windowsx86.zip)


[windows x64](https://github.com/yangzhongke/Zack.DotNetTrimmer/raw/main/Binaries/windowsx64.zip)


[linux x64](https://github.com/yangzhongke/Zack.DotNetTrimmer/raw/main/Binaries/linux_x64.zip)

2)在命令行中运行Zack.DotNetTrimmer，把待裁剪的程序的全路径做为参数传递给Zack.DotNetTrimmer。运行后，Zack.DotNetTrimmer会以控制台程序开始运行，待裁剪的程序会被自动启动。
3) 执行待裁剪的程序中所有的功能，覆盖所有的代码路径。完成所有功能的执行后，在Zack.DotNetTrimmer的控制台中执行Ctrl+C或者Ctrl+Break向待裁剪的程序的发起关闭请求。稍等一段时间，当待裁剪的程序和Zack.DotNetTrimmer都运行结束后，Zack.DotNetTrimmer会开始进行分析和裁剪，当裁剪结束后会显式“Trimming done.”。这样程序就裁剪完成了。如下图所示;
![程序剪裁结果](https://raw.githubusercontent.com/yangzhongke/Zack.DotNetTrimmer/main/images/1.png)

问题：
1) 如何给待裁剪程序传递命令行参数？
把参数继续放到待裁剪的程序的全路径后即可，比如

```
Zack.DotNetTrimmer.exe d:\a\ASPNETCore6WebAPI1.exe --urls=http://localhost:8888/
```

2) 如何恢复被删除的文件？
Zack.DotNetTrimmer退出前，会提示备份路径，请去那个路径获取裁剪前的备份版本。