using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// 1.加入拖动条控制条控制音乐大小
/// 
/// 2.制作一个登录面板
/// 有用户名输入和密码输入
/// 有进入游戏和返回上一级按钮
/// 点击开始界面中的开始游戏后 进入登录面板
/// 输入的 用户名为 admin 登录密码为 888 才能切换场景
/// </summary>
public class Lesson5p : MonoBehaviour
{
    public Rect returnBtnPos;
    public Rect startBtnPos;
    public GameObject menu;

    private void OnGUI()
    {
        //进入游戏和返回上一级按钮
        if(GUI.Button(returnBtnPos, "return"))
        {
            GetComponent<Lesson3p>().enabled = true;
            GetComponent<Lesson5p>().enabled = false;
        }
        if(GUI.Button(startBtnPos, "Start"))
        {
            menu.SetActive(true);
            GetComponent<Lesson5p>().enabled = false;
        }
    }
}
