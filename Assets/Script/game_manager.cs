using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class game_manager : MonoBehaviour

{
    public int Points_P1 = 0;
    public int Points_P2 = 0;
    public string score;
    public TextMeshProUGUI marcadorText;
    void Start()
    {
        Points_P1 = 0;
        Points_P2 = 0;
        score = Points_P1 + " | " + Points_P2;
        marcadorText.text = score;

        UpdatePoints();
    }
    public void UpdatePoints()
    {
        Debug.Log("Marcador: " + score);
        score = Points_P1 + " | " + Points_P2;
        marcadorText.text = score;
    }
}