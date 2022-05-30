using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoProgressControl : MonoBehaviour
{
    [Header("放 360 影片")]
    public VideoPlayer video;
    [Header("放介面內的 Slider 進度條")]
    public Slider sliderVideo;

    [Header("放 2D 影片")]
    public VideoPlayer video2D;

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
    }

    public void Play()
    {
        video.Play();
    }

    public void Pause()
    {
        video.Pause();
    }

    public void Stop()
    {
        video.Stop();
    }
}
