using System;
using Caliburn.Micro;
using Gemini.Demo.Modules.Home.ViewModels;

public class MyClass : IDemoScript
{
    public void Execute(HelixViewModel viewModel)
    {
        viewModel.RotationAngle += 0.1;
    }
}
