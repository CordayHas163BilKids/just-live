using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpAmount = 10;
    public float gravityScale = 5;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityScale;
    }

void Update()
{
    if (Input.GetKeyDown(KeyCode.Space))
    {
        rb.AddForce(Vector3.up * jumpAmount, ForceMode.Impulse);
    }
}

private void FixedUpdate()
{
    
}


}
