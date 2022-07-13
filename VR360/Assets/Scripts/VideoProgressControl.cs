using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoProgressControl : MonoBehaviour
{
    [Header("放 360 影片")]
    public VideoPlayer video;
    [Header("放 2D 影片")]
    public VideoPlayer video2d;
    [Header("放介面內的 Slider 進度條")]
    public Slider sliderVideo;

    [Header("放 2D 影片")]
    public VideoPlayer video2D;

    [Header("所有影片")]
    public VideoControl[] videosControls;
    [Header("所有影片按鈕")]
    public Button[] btnsVideos;

    private void Awake()
    {
        InvokeRepeating("UpdateVideosButton", 0, 1);
    }

    public void UpdateVideosButton()
    {
        for (int i = 0; i < videosControls.Length; i++)
        {
            if (btnsVideos[i].interactable) continue;

            if (Time.timeSinceLevelLoad > videosControls[i].playSecond)
            {
                btnsVideos[i].interactable = true;
            }
        }
    }

    public void SliderControl(float value)
    {
        // print("進度條的值：" + value);
        // print("frame " + video.frame);
        // print("frame count " + video.frameCount);

        long current = (long)(video.frameCount * value);
        // print("運算完的當前：" + current);
        video.frame = current;
        video.Play();

        long current2D = (long)(video2D.frameCount * value);
        video2D.frame = current2D;
        video2D.Play();

        // 重複執行 影片數量，有六部就執行六次
        for (int i = 0; i < videosControls.Length; i++)
        {
            // 如果 當前影格數 > 影片[i] 的 時間
            if (current > videosControls[i].playSecond * 60)
            {
                // print("影片時間：" + videosControls[i].playSecond);

                btnsVideos[i].interactable = true;
            }
            else
            {
                btnsVideos[i].interactable = false;
            }
        }
    }

    public void Play()
    {
        video.Play();
        video2d.Play();
    }

    public void Pause()
    {
        video.Pause();
        video.Pause();
    }

    public void Stop()
    {
        video.Stop();
        video.Stop();
    }
}
