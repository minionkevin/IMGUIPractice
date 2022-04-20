using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// 用GUI制作一个游戏开始界面
/// 上面有 开始游戏 退出游戏 设置 等等按钮选项
/// 点击开始游戏可以切换到游戏场景
/// </summary>
public class Lesson3p : MonoBehaviour
{
    [Header("start")]
    [SerializeField]
    private Rect startButton;
    [SerializeField]
    private GUIStyle startStyle;
    [Header("exit")]
    [SerializeField]
    private Rect exitButton;
    [SerializeField]
    private GUIStyle exitStyle;
    [Header("setting")]
    [SerializeField]
    private Rect settingButton;
    [SerializeField]
    private GUIStyle settingStyle;

    [SerializeField]
    private GameObject settingPanel;
    private void OnGUI()
    {
        if(GUI.Button(startButton, "Start", startStyle))
        {
            Debug.Log("切换场景");
            GetComponent<Lesson3p>().enabled = false;
            GetComponent<Lesson5p>().enabled = true;
            //SceneManager.LoadScene("GameScene");
        }
        if(GUI.Button(exitButton, "Exit", exitStyle))
        {
            Debug.Log("退出");
            Application.Quit();
        }
        if (GUI.Button(settingButton, "Setting", settingStyle))
        {
            Debug.Log("设置");
            gameObject.GetComponent<Lesson3p>().enabled = false;
            settingPanel.SetActive(true);
        }
    }
}
