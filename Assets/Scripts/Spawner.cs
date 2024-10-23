using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject apple;
    public GameObject GreenApple;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CriaMaca", 0, 2);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = (new Vector3(Random.Range (-9,10), 5, 0));
    }


    public void CriaMaca()
    {
        int random = Random.Range(0, 3);
        if (random < 2)
        {
            Instantiate(apple, transform.position, Quaternion.identity);
        }
        else
        {
            Instantiate(GreenApple, transform.position, Quaternion.identity);
        }
    }
}

