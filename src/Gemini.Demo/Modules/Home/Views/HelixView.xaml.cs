using System.Windows.Controls;
using Gemini.Modules.CodeEditor.Controls;

namespace Gemini.Demo.Modules.Home.Views
{
    /// <summary>
    /// Interaction logic for HelixView.xaml
    /// </summary>
    public partial class HelixView : UserControl, IHelixView
    {
        public CodeEditor TextEditor
        {
            get { return CodeEditor; }
        }

        public HelixView()
        {
            InitializeComponent();
        }
    }
}
