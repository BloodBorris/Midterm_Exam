using UnityEngine;

public class Observer : MonoBehaviour
{
    Player player;
    State_Machine mach;
    GameObject[] HealthBar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = FindAnyObjectByType<Player>();
        mach = FindAnyObjectByType<State_Machine>();
        HealthBar = GameObject.FindGameObjectsWithTag("Hp");
        Debug.Log(HealthBar[0].tag);
    }

    // Update is called once per frame
    void Update()
    {
        Observe();
    }

    void Observe()
    {
        if(player.GetHp() == 3)
        {
            Destroy(HealthBar[0]);
            mach.SetState(1);
        }
        else if (player.GetHp() == 2)
        {
            Destroy(HealthBar[1]);
            mach.SetState(2);
        }
        else if (player.GetHp() == 1)
        {
            Destroy(HealthBar[2]);
            mach.SetState(3);
        }
        else if (player.GetHp() == 0)
        {
            Destroy(HealthBar[3]);
            mach.SetState(4);
        }
    }
}
