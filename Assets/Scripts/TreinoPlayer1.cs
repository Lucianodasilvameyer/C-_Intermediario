using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))] //??
public class TreinoPlayer1 : MonoBehaviour
{
    public float speed = 5f;

    Rigidbody righ;

    private void Awake()
    {
        righ = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float x = Input.GetAxis("horizontal") * Time.deltaTime * speed;
        float y = Input.GetAxis("vertical") * Time.deltaTime * speed;

        FazerMovimento(x, y);
    }
    public void FazerMovimento(float t, float f)
    {
        Vector3 moviment = new Vector3(t, 0, f);
        righ.velocity = moviment;
    }

}
