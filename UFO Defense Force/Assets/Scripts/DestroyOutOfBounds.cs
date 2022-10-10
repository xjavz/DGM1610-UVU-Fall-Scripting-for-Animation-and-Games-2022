using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBounds = 30.0f;
    public float lowerBounds = -10.0f;
    
    private ScoreManager scoreManager;
    private DetectCollision detectCollision;

    
    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        detectCollision = GetComponent<DetectCollision>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }

        else if(transform.position.z < lowerBounds)
        {
            scoreManager.DecreaseScore(detectCollision.scoreToGive); // Everytime a ship sneaks past lower bounds deduct points
            Destroy(gameObject);
        }
    }
}
