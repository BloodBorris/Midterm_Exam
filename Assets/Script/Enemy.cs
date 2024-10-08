using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    float newTime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        newTime = 2 + Time.realtimeSinceStartup;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.realtimeSinceStartup >= newTime)
        {
            transform.position += Vector3.forward;
            newTime = 2 + Time.realtimeSinceStartup;
        }
    }
}
