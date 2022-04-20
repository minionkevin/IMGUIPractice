using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 点击一个按钮
/// 弹出一个模态窗口
/// 让玩家确定是否退出(退出，取消)
/// 点击取消后 关闭窗口
/// 点击退出后 退出游戏
/// </summary>
public class Lesson8p : MonoBehaviour
{
    public Rect btnPos;
    public Rect windowPos;
    public GUIStyle btnStyle;
    

    private void OnGUI()
    {
        GUI.ModalWindow(1, windowPos, DrawWindow, "确定退出");
    }
    private void DrawWindow(int id)
    {
        if(GUI.Button(new Rect(100, 50, 100, 100), "退出"))
        {
            //Application.Quit();
        }
        if(GUI.Button(new Rect(300, 50, 100, 100), "取消"))
        {

        }
    }
}
