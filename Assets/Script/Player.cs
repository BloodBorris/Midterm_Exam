using UnityEngine;

public class Player : MonoBehaviour
{
    int hp = 4;
    int Shotsfire = 0;
    bool isdead = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Walk();
    }

    void Walk()
    {
        if(!isdead)
        {
            if (Input.GetKeyDown(KeyCode.W)) transform.position += Vector3.forward;
            if (Input.GetKeyDown(KeyCode.D)) transform.position += Vector3.right;
            if (Input.GetKeyDown(KeyCode.S)) transform.position += Vector3.back;
            if (Input.GetKeyDown(KeyCode.A)) transform.position += Vector3.left;
        }
   
    }

    void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shotsfire = Shotsfire + 1;
        }
    }

    public int GetHp()
    {
        return hp;
    }

    public void SetHp(int newHp)
    {
        hp = newHp;
    }

    public void SetDead()
    {
        isdead = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            SetHp(hp - 1);
            Debug.Log(hp);
        }
    }
}
