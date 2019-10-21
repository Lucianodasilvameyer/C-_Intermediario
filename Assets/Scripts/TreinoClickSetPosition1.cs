using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreinoClickSetPosition1 : MonoBehaviour 
{
    // Start is called before the first frame update
    public ExemploCorotina corotina; 

    Ray ray;

    RaycastHit hit;

    private void OnMouseDown()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        Physics.Raycast(ray, out hit); //q tipo de fisica ocorre aqui por causa do Physics?

        if (hit.collider.gameObject == gameObject) //aqui verifica se o gameObject atingido pelo raio é o mesmo gameObject q contem este script? mas este script não é só para movimentação?
        {
            Vector3 target = hit.point + new Vector3(0, 1, 0);

            corotina.TargetPosition = target;
        }

    }

}
