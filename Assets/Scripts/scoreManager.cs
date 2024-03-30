using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using TMPro.EditorUtilities;
public class scoreManager : MonoBehaviour
{
    public Text scoreText;
    public ButtonClick scoreButtonClick;
    void Start()
    {
        scoreText.text = scoreButtonClick.Score.ToString() + " Points";
    }

    // Update is called once per frame
    public void UpdatePoints()
    {
        scoreText.text = scoreButtonClick.Score.ToString() + " Points";
    }
}
