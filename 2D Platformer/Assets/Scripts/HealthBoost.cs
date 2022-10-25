using UnityEngine;

public class HealthBoost : MonoBehaviour
{
    
    private float healthboost = 0;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.transform.tag =="HealthBoost"){
            Destroy(gameObject);
        }
    }
}
