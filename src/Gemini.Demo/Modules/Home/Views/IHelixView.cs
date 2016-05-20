using Gemini.Modules.CodeEditor.Controls;

namespace Gemini.Demo.Modules.Home.Views
{
    public interface IHelixView
    {
        CodeEditor TextEditor { get; }
    }
}