using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treinoExemploCorotina1 : MonoBehaviour
{
    public float smoothing = 1f;

    private Vector3 targetPosition;

    public Vector3 TargetPosition
    {
        get
        {
            return targetPosition;
        }
        set
        {
            targetPosition = value;

            MostrarPosicao();               
                                                 //deve-se usar coroutine sempre q envolve algo com tempo?
            StopCoroutine("MoveForPosition"); //quando se chama uma coroutine deve-se sempre para-la para depois inicia-la? 

            StartCoroutine("MoveForPosition", targetPosition); // só se usa o parametro no StartCoroutine?  


        }
    }
    private IEnumerator MoveForPosition(Vector3 target) 
    {
        while (Vector3.Distance(transform.position, target) > 0)// esta Coroutine vai durar até o objeto chegar no alvo?
        {
            Vector3 currentPos = Vector3.Lerp(transform.position, target, Time.deltaTime * smoothing);

            Debug.Log(currentPos);

            transform.position = currentPos; //aqui se a posição do objeto esta recebendo o vetor de interpolação entre 2 pontos q seriam ele e o alvo, o objeto apenas ja sabe para onde e por onde tem q ir?

            yield return null;
        } 
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MostrarPosicao()
    {
        Debug.Log("Posicao: " + targetPosition);
    }
}
