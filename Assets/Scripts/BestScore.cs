using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScore : MonoBehaviour
{

    public Text BestScoreText;

    // Start is called before the first frame update
    void Start()
    {
        if (StoreData.Instance != null)
        {
            int bestScore = StoreData.Instance.BestScore;
            string playerName = StoreData.Instance.PlayerWithHighScore;
            BestScoreText.text = "Best Score: " + playerName + " : " + bestScore;
        }


    }

    // Update is called once per frame
    void Update()
    {
        StoreData.Instance.SaveHighScore();
    }
}
