using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 制作一个滚动试图
/// 外部有一个字符串数组
/// 通过在Inspector修改这个字符串数组数量
/// 会在滚动试图内部动态的创建label依次显示内容
/// </summary>

public class Lesson7p : MonoBehaviour
{
    public Rect startPos;
    public Vector2 curPos;
    public Rect inPos;
    public int indexNum = 0;
    private string[] holder;
    private Rect labelPos = new Rect(100, 100, 100, 100);
    public GUIStyle style;

    private int checker;

    private void OnGUI()
    {
        holder = new string[indexNum];

        GUI.BeginScrollView(startPos, curPos, inPos);
        if (checker != indexNum)
        {
            for (int i = 0; i < indexNum; i++)
            {
                GUI.Label(new Rect(labelPos.x, labelPos.y + 100 * i, labelPos.width, labelPos.height), indexNum.ToString(), style);
            }
        }
        GUI.EndScrollView();
    }
}