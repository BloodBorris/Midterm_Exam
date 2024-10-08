using UnityEngine;

public class State_Machine : MonoBehaviour
{
    int curState = 0;
    public Material mat;
    Player player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = FindAnyObjectByType<Player>();
        mat.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

   
    public void SetState(int newstate)
    {
        curState = newstate;
    }

    void ManageState()
    {
        if(curState == 1)
        {
            
            mat.color = Color.blue;
        }
        else if (curState == 2)
        {
            mat.color = Color.yellow;
        }
        else if (curState == 3)
        {
            mat.color = Color.red;
        }
        else if (curState == 4)
        {
            mat.color = Color.black;
            player.SetDead();
        }
    }
}
