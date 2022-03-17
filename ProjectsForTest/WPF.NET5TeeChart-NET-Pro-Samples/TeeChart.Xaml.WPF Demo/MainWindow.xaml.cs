using System.IO;
using System.Windows;
using System.Windows.Media;
using GalaSoft.MvvmLight;
using ICSharpCode.AvalonEdit;
using ICSharpCode.AvalonEdit.Highlighting;
using XamlWPFDemo.ViewModel;

namespace XamlWPFDemo
{
  public partial class MainWindow
  {
    public MainWindow()
    {
      InitializeComponent();

      VisualStudioStyle(CodeEditor);

      UpdateCodeEditor((MainViewModel)DataContext);
      ((ViewModelBase)DataContext).PropertyChanged += (sender, args) =>
      {
        if (args.PropertyName == "File")
        {
          UpdateCodeEditor((MainViewModel)sender);
        }
      };
    }

    private void UpdateCodeEditor(MainViewModel vm)
    {
      if (vm.File == null) return;
      var extension = Path.GetExtension(vm.File);
      CodeEditor.SyntaxHighlighting = HighlightingManager.Instance.GetDefinitionByExtension(extension);
      CodeEditor.Load(Path.Combine("..\\..\\..\\Demos", vm.File));
    }

    private void VisualStudioStyle(TextEditor editor)
    {
      // TODO: Style XAML to VisualStudio as well...
      var syntaxHighlighting = HighlightingManager.Instance.GetDefinitionByExtension(".cs");

      var keywords = new[]
      {
        "ValueTypeKeywords", "ReferenceTypeKeywords", "ThisOrBaseReference", "NullOrValueKeywords", "Keywords",
        "GotoKeywords", "ContextKeywords", "ExceptionKeywords", "CheckedKeyword", "UnsafeKeywords", "OperatorKeywords",
        "ParameterModifiers", "Modifiers", "Visibility", "NamespaceKeywords", "GetSetAddRemove", "TrueFalse",
        "TypeKeywords"
      };

      foreach (var keyword in keywords)
      {
        var color = syntaxHighlighting.GetNamedColor(keyword);
        color.Foreground = new SimpleHighlightingBrush(Colors.Blue);
        color.FontWeight = FontWeights.Normal;
      }

      syntaxHighlighting.GetNamedColor("String").Foreground = new SimpleHighlightingBrush(Colors.Brown);
      syntaxHighlighting.GetNamedColor("Char").Foreground = new SimpleHighlightingBrush(Colors.Brown);
      syntaxHighlighting.GetNamedColor("Preprocessor").Foreground = new SimpleHighlightingBrush(Colors.LightGray);
      syntaxHighlighting.GetNamedColor("NumberLiteral").Foreground = new SimpleHighlightingBrush(Colors.Black);
      var methodCallColor = syntaxHighlighting.GetNamedColor("MethodCall");
      methodCallColor.Foreground = new SimpleHighlightingBrush(Colors.Black);
      methodCallColor.FontWeight = FontWeights.Normal;

      editor.Options.HighlightCurrentLine = true;
      editor.Options.AllowScrollBelowDocument = true;
      editor.ShowLineNumbers = true;
      editor.LineNumbersForeground = new SolidColorBrush(Color.FromRgb(43, 145, 175));
      editor.TextArea.TextView.CurrentLineBackground = Brushes.Cornsilk;
      editor.TextArea.TextView.CurrentLineBorder = new Pen(new SolidColorBrush(Color.FromRgb(235, 235, 235)), 2);
      editor.TextArea.SelectionBorder = null;
    }
  }
}
