using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class GM : MonoBehaviour
{
    public int score;
    public Text uiScore;

    public VideoPlayer player360;
    public VideoPlayer player2D;

    private bool mute;

    public void AddScore()
    {
        score += 10;
        uiScore.text = "分數：" + score;
    }

    public void SwitchMute()
    {
        mute = !mute;                           // 靜音相反
        player360.SetDirectAudioMute(0, mute);  // 360
        player2D.SetDirectAudioMute(0, !mute);  // 2D
    }
}
