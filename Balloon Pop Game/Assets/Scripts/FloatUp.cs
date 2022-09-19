using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatUp : MonoBehaviour
{
    
    public float moveSpeed; // Speed at which balloon will move upwards
    public float upperBound; // Top boundary for when balloon exits the screen it will get destroyed
    
    private Balloon balloon; // Reference the balloon gameObject

    private ScoreManager scoreManager;

    // Start is called before the first frame update
    void Start()
    {
       balloon = GetComponent<Balloon>();
       scoreManager = GameObjct.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // Move the balloon upwards
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);

        //Destroy balloon if it passes the top boundry
        if(transform.position.y > upperBound)
        {
            scoreManager.DecreaseScoreText(balloon.scoreToGive);
            Destroy(gameObject);
        }
    }
}
