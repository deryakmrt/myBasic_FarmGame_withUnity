using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemToolbarPanel : ItemPanel
{
    [SerializeField] ToolBarController toolBarController;

    private void Start()
    {
        In�t();
        toolBarController.onChange += HighLight;
        HighLight(0);
    }
    public override void OnClick(int id)
    {
        toolBarController.Set(id);
        HighLight(id);
    }

    int currentSelectedTool;

    public void HighLight(int id)
    {
        buttons[currentSelectedTool].HighLight(false);
        currentSelectedTool = id;
        buttons[currentSelectedTool].HighLight(true);
    }
}
