using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    float score = 0;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Player.isdead) return;
        score += Time.deltaTime;
        StartCoroutine(UpdateScore());
    }
     IEnumerator UpdateScore()
    {
        yield return new WaitForSeconds(1);
        gameObject.GetComponent<Text>().text = "Score: " + Math.Round(score);
    }
}
