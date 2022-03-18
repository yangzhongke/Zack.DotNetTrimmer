# Zack.DotNetTrimmer
[Document(English Version)](https://github.com/yangzhongke/Zack.DotNetTrimmer/blob/main/README.md)

这是一个用来对.NET Core程序进行瘦身的应用程序。尽管.NET Core具有【剪裁未使用的代码】（简称“.NET内置剪裁”）的功能，但是由于它是使用静态分析来实现的，因此它的剪裁效果并不是最优的。它有如下两个缺点：
1) 不支持Windows Forms和WPF，而对于程序剪裁功能需求最强烈的其实反而是桌面程序的开发者。
2) 无法删除运行时没有被使用的程序集。比如，我们的程序中使用了A程序集，A程序又引用了B、C两个程序集，A程序集中只有M1方法使用了B程序集，而A程序集中只有M2方法使用了C程序集。我们的程序中只调用了A中的M1方法，而从未调用A中的M2方法。虽然C程序集没有被我们调用过，但是由于【剪裁未使用的代码】功能只是做静态的引用检查，因此C程序集仍然不会被剪裁掉。
3) 无法很好地支持反射。由于它是使用静态分析来实现的，因此它可能会剪裁掉运行时才会被通过反射加载的程序集。


Zack.DotNetTrimmer则可以解决这些问题，它 **支持Windows Forms和WPF** ，它会在运行时分析程序加载的程序集，从而得知哪些程序集没有被使用，因此它不仅 **能删掉更多没有被使用的程序集** ，而且能天然地 **支持反射** 。当然，任何事物都不可能只有优点，没有缺点。Zack.DotNetTrimmer的缺点是，它要求运行待剪裁的项目，并且把程序中所有功能都全面地运行一遍，这样才能检测到在任何情况下都不会被使用的程序集。

程序剪裁效果对比：
|			   |原始尺寸|.NET内置剪裁|Zack.DotNetTrimmer|
|  ----        | ----   | ----       | ----             |
|空Core MVC项目| 97MB   |  50.3MB    | 43.6MB           |
|空WebAPI项目  | 93MB   |  46.3MB    | 34.5 MB          |
| 空WPF项目    | 152 MB |  不支持    | 75.2 MB          |
|空WinForms项目| 152 MB |  不支持    | 50.0 MB          |


# 用法：
1) 下载Zack.DotNetTrimmer的可执行程序，并且解压程序到磁盘，[前往下载](https://github.com/yangzhongke/Zack.DotNetTrimmer/releases)


2) 发布待裁剪的项目，**部署模式请选择【独立】** 。请勿勾选 **【生成单个文件】**，请勿使用【依赖框架】的部署模式。
3) 在命令行中运行Zack.DotNetTrimmer，把待裁剪的程序的 **全路径** 做为--file参数传递给Zack.DotNetTrimmer。比如：

```
Zack.DotNetTrimmer.exe --file d:\a\ASPNETCore6WebAPI1.exe
```

运行后，Zack.DotNetTrimmer会以控制台程序开始运行，待裁剪的程序会被自动启动。

注意：如果程序的全路径中包含空格等特殊符号，请用双引号包裹，比如--file "d:/a  b/1.exe"

4)  执行待裁剪的程序中所有的功能，覆盖所有的代码路径。完成所有功能的执行后，在Zack.DotNetTrimmer的控制台中执行Ctrl+C或者Ctrl+Break向待裁剪的程序的发起关闭请求。稍等一段时间，当待裁剪的程序和Zack.DotNetTrimmer都运行结束后，Zack.DotNetTrimmer会开始进行分析和裁剪，当裁剪结束后会显示“Trimming done.”。

这样程序就裁剪完成了。如下图所示：


![程序剪裁结果](https://raw.githubusercontent.com/yangzhongke/Zack.DotNetTrimmer/main/images/1.png)

# 高级用法：
## 1) 如何给待裁剪程序传递命令行参数？

把参数继续放到待裁剪的程序的全路径后即可，比如

```
Zack.DotNetTrimmer.exe --file d:\a\ASPNETCore6WebAPI1.exe --urls=http://localhost:8888/
```

## 2) 如何恢复被删除的文件？

Zack.DotNetTrimmer退出前，会提示备份路径，请去那个路径获取裁剪前的备份版本。

## 3) 我能进一步缩小文件尺寸吗？

这个程序使用DiagnosticsClient检查.NET Core程序运行中加载的所有的程序集，这样就知道哪些程序集没有被使用了。默认情况下，程序只会删除掉没有被使用的程序集。

如果启用了--greedy参数，则程序还会把程序集中没有被使用的类的方法体清空，这样就可以进一步缩小文件的尺寸。

用法如下：

```
Zack.DotNetTrimmer.exe --greedy --file d:\a\ASPNETCore6WebAPI1.exe
```

不过，这要求对程序运行过程中所有的运行路径进行更全面的测试，否则可能会导致程序运行到某些没有被测试到的功能的时候崩溃。

## 4) 可以多次运行被裁剪的程序，然后最后统一进行裁剪吗？

默认情况下，本程序会在被裁剪的程序退出后立即进行程序的裁剪。但是，在比较复杂的项目中，我们可能需要多次以不同的环境运行被裁剪的程序，以便于全面覆盖代码的运行路径，最后再统一进行裁剪。

本程序支持【录制】、【应用】两种模式运行，在【录制】模式下，本程序会把程序的裁剪信息记录到一个json文件中，如果这个json文件已经存在，则本程序会把程序的裁剪信息追加到json文件中。

在我们多次以【录制】模式运行待裁剪的程序后，我们再用【应用】模型运行本程序，并且指定之前记录的json文件，本程序就会根据json文件中记录的信息对程序进行裁剪。

【录制】模式采用--record参数开启，并且需要把json文件的路径作为参数的值，比如：
```
--record d:/1.json --file d:/1.exe
```

【应用】模式采用--apply参数开启，并且需要把json文件的路径作为参数的值，比如：
```
--apply d:/1.json --file d:/1.exe
```

在apply模式下，我们仍然可以使用--greedy参数。

## 5）我可以录制下来待裁剪的程序信息，然后在自动构建中重复执行裁剪吗？

支持，用上面提到的【录制】模式(--record)进行录制，然后复用录制的json文件，重复执行【应用】(--apply)模式即可。