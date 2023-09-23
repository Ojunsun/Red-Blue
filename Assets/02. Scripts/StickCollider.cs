using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StickCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject smObject = GameObject.Find("ScoreManager");
        ScoreManager scoreManager = smObject.GetComponent<ScoreManager>();

        Destroy(collision.gameObject);

        scoreManager.currentScore++;

        scoreManager.currentScoreTextUI.text = "" + scoreManager.currentScore;
    }
}
