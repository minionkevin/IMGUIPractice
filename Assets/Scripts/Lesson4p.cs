using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 背景音乐的开关和音效的开关
/// 点击开始界面的设置面板可以打开设置面板
/// </summary>
public class Lesson4p : MonoBehaviour
{
    public Rect BGMBtnPos;
    public Rect audioBtnPos;
    public Rect audioSliderPos;
    public GUIStyle BGMStyle;
    public GUIStyle audioStyle;
    public GUIStyle audioSliderStyle;

    private bool isBGMPlay;
    private bool isAudioPlay;


    private float inputAudio;
    private void OnGUI()
    {
        isBGMPlay = GUI.Toggle(BGMBtnPos, isBGMPlay,"BGM",BGMStyle);
        isAudioPlay = GUI.Toggle(audioBtnPos, isAudioPlay,"audio", audioStyle);

        //5p拖动条
        inputAudio = GUI.HorizontalSlider(audioSliderPos, inputAudio, -20, 20);
    }

}
