using UnityEngine;

public class Singelton : MonoBehaviour
{
    Observer obs;
    public GameObject obj;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        obs = FindAnyObjectByType<Observer>();
        if(obs != null)
        {

        }
        else
        {
            Instantiate(obj);
        }
    }

   
}
