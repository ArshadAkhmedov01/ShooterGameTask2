using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oyuncu : MonoBehaviour
{
    [SerializeField] GameObject Sharig;
    [SerializeField] Transform gulleCixisNoqtesi;

    [SerializeField] float vertical;
    [SerializeField] float horizontal;
    [SerializeField] GameObject Player;
    [SerializeField] float speed = 6f;

    [SerializeField] int Puanlar;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Sharig, gulleCixisNoqtesi.position, transform.rotation);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.rotation *= Quaternion.Euler(0f, -1f, 0f * speed* Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.rotation *= Quaternion.Euler(0f, 1f, 0f * speed* Time.deltaTime);
        }
        

        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");
        transform.position += new Vector3(horizontal * Time.deltaTime, 0f ,vertical * Time.deltaTime) * speed;

                                                   

    }

     
}
