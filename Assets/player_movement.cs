using UnityEngine;

public class player_movement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void update()
    {
        transform.position += Time.deltaTime * new Vector3(0, 0, 2);
    }
} // wsd script se hatana
//bullet ke clone ko destroy
//bullet kisi se collide kare usse bhi destroy
//bullet se joline aarhi hai peeche usse hatana

