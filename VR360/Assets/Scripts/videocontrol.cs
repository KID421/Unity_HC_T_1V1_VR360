
using UnityEngine;
using UnityEngine.UI;               // 引用 介面 API
using UnityEngine.Video;            // 引用 影片 程式 

public class videocontrol : MonoBehaviour
{
    [Header("要播放的影片")]
    public VideoClip clip;
    [Header("要播影片的物件")]
    public VideoPlayer player;
    [Header("開始播放的秒數")]
    public int playSecond;

    // private 私人：在屬性面板上隱藏
    private int time;

    private void Update()
    {
        // 如果 場景時間 360 影片 < 開始播放的秒數 就讓按鈕不允許點選
        if (Time.timeSinceLevelLoad < playSecond)
        {
            GetComponent<Button>().interactable = false;
        }
        // 否則 就讓按鈕允許點選
        else
        {
            GetComponent<Button>().interactable = true;
        }
    }

    // public 公開:可以被按鈕呼叫
    // void 無類型
    public void ClickButton ()
    {
        //指定影片
        player.clip = clip;
        //計算播放的秒數
        time = (int)Time.timeSinceLevelLoad;
        //要播放的時間=當前時間-開始播放的秒數
        int t = time - playSecond;
        //指定影片撥放器的時間=要播放的時間
        player.time = t;
        //播放
        player.Play();
    }
}
