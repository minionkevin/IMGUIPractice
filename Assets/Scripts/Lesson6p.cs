using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 制作三个页签
/// 选择不同的页签
/// 将在下面显示不同的信息
/// </summary>
public class Lesson6p : MonoBehaviour
{
    public Rect pos;
    public Rect textPos;
    public GUIStyle textStyle;
    private string info = "";
    private int holder;
    private string[] choices = { "1", "2", "3" };
    private void OnGUI()
    {
        holder = GUI.Toolbar(pos, holder, choices);
        GUI.Label(textPos, info, textStyle);
        switch (holder)
        {
            case 0:
                info = "1";
                break;
            case 1:
                info = "2";
                break;
            case 2:
                info = "3";
                break;
            default:
                info = "---";
                break;
        }
    }
}
