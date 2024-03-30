using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class ObjectRandomMove : MonoBehaviour
{
    public ButtonClick IncreaseScore;
    public GameObject button;
    public int randomx;
    public int randomy;
    public Color randomColor;
    float randomColor1, randomColor2, randomColor3;
    public MeshRenderer meshRenderer;
    private void Start()
    {
        IncreaseScore = button.GetComponent<ButtonClick>();
    }

    public void Move()
    {
            float myX = gameObject.transform.position.x;
            float myY = gameObject.transform.position.y;

            float randomx = Random.Range(-1, 2);
            float randomy = Random.Range(-1, 2);

            float newX = myX + randomx;
            float newY = myY + randomy;

            gameObject.transform.position = new Vector3(newX, newY);
    }

    public void ColorChange() 
    {
        randomColor1 = Random.Range(0f, 1f);
        randomColor2 = Random.Range(0f, 1f);
        randomColor3 = Random.Range(0f, 1f);

        randomColor = new Color(randomColor1, randomColor2, randomColor3);

        meshRenderer.material.SetColor("_Color", randomColor);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Wall") 
        {
            float randx = Random.Range(-1f, 1f);
            float randy = Random.Range(-1f, 1f);

            gameObject.transform.position = new Vector3(randx, randy);
        }
    }
}
