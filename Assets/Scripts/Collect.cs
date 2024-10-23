using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Collect : MonoBehaviour
{

    int score;
    public TMP_Text ponto;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Apple")
        {
            score++ ;
            ponto.text = "Score: " + score.ToString();
        }
        if(collision.gameObject.tag == "GreenApple")
        {
            score--;
            ponto.text = "Score: " + score.ToString();
        }
        Destroy (collision.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
