using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int ScoreToGive = 1;
    public int ClicksToPop = 5;
    public float ScaleIncreasePerClick = 0.1f;

    public ScoreManager ScoreManager;

    private void OnMouseDown()
    {
        ClicksToPop -= 1;

        transform.localScale += Vector3.one * ScaleIncreasePerClick;

        if (ClicksToPop == 0)
        {
            ScoreManager.IncreaseScore(ScoreToGive);
            Destroy(gameObject);
        }
    }

}
