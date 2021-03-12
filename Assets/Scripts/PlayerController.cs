using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody PlayerRb;

    // Start is called before the first frame update
    void Start()
    {
        PlayerRb = GetComponent<Rigidbody>();
        PlayerRb.AddForce(Vector3.up * 400);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
