using UnityEngine;
using UnityEngine.UI;

public class GM : MonoBehaviour
{
    public int score;
    public Text uiScore;

    public void AddScore()
    {
        score += 10;
        uiScore.text = "分數：" + score;
    }
}
