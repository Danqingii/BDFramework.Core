﻿using BDFramework.Hotfix.ScreenView;
using BDFramework.UFlux;
using BDFramework.UI;
using Game;

/// <summary>
/// 这个是ui的标签，
/// index 
/// resource 目录
/// </summary>
[UI((int) WinEnum.Win_Demo1, "Windows/window_demo1")]
public class Window_Demo1 : AWindow
{
    //[]
    public Window_Demo1(string path) : base(path)
    {
    }

    [ButtonOnclick("Button")]
    private void btn_01()
    {
        this.Close();
        ScreenViewManager.Inst.MainLayer.BeginNavTo(ScreenViewEnum.Main);
    }
}