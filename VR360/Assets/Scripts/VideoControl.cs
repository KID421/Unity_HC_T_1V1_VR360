using UnityEngine;
using UnityEngine.Video;        // 引用 影片 程式

public class VideoControl : MonoBehaviour
{
    [Header("要播放的影片")]
    public VideoClip clip;
    [Header("要播影片的物件")]
    public VideoPlayer player;
    [Header("開始播放的秒數")]
    public int playSecond;

    public int time;

    // public 公開：可以被按鈕呼叫
    // void 無類型
    public void ClickButton()
    {
        // 指定影片
        player.clip = clip;
        // 計算播放秒數
        time = (int)Time.timeSinceLevelLoad;
        // 要播放的時間 = 當前時間 - 開始播放的秒數
        int t = time - playSecond;
        // 指定影片播放器的時間 = 要播放的時間
        player.time = t;
        // 播放
        player.Play();
    }
}
