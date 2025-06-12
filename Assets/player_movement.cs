using UnityEngine;


public class player_movement : MonoBehaviour
{
    // Start is called once before the first execu
    // tion of Update after the MonoBehaviour is created


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Time.deltaTime * new Vector3(0, 0, 1);
        transform.Translate(0, 0, 1 * Time.deltaTime);

    }
    
} 

