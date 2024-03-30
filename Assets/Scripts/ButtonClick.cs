using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    public int Score = 0;
    public ObjectRandomMove random;
    public scoreManager manager;

    public void IncreaseScore() 
    {
            Score += 1;
            manager.UpdatePoints();
            random.Move();
            random.ColorChange();
    }
}
