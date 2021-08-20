using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class GM : MonoBehaviour
{
    public int score;
    public Text uiScore;

    public VideoPlayer play360;
    public VideoPlayer play2D;

    public GameObject obj360samll;
    public GameObject obj2Dbig;

    private bool mute;

    public void AddScore()
    {
        score += 10;
        uiScore.text = "分數：" + score;
    }

    public void SwitchMaute()
    {
        mute = !mute;                           //靜音相反   
        play360.SetDirectAudioMute(0, mute);    //360
        play2D.SetDirectAudioMute(0, !mute);    //2D

        obj360samll.SetActive(mute);
        // obj2Dbig.SetActive(mute);

        if (mute)
        {
            obj2Dbig.transform.localScale = new Vector3(16f / 2, 9f / 2, 1);
        }
        else
        {
            obj2Dbig.transform.localScale = new Vector3(1.6f / 4, 0.9f / 4, 1);
        }
    }

    public void Quit()
    {
        // 應用程式.離開(); - 關閉應用程式
        Application.Quit();
    }
}
