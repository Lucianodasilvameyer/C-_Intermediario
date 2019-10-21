using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
    private Rigidbody m_Rigidbody;

    public float speed = 5f;
    
    // Start is called before the first frame update
    private void Awake()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float y = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        DoMovement(x, y);
    }

    void DoMovement(float h, float v)
    {
        Vector3 movement = new Vector3(h, 0, v);

        m_Rigidbody.velocity = movement;
    }
}
