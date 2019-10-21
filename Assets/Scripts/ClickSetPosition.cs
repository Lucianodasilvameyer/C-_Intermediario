using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSetPosition : MonoBehaviour
{
    public ExemploCorotina corotina;    //Referência para a classe "ExemploCorotina"

    Ray ray;    //Representação de um raio

    RaycastHit hit;     //Variável que armazena a informação retornada de um Raycast

    private void OnMouseDown()
    {
        //Cria um raio da câmera para um ponto da tela, sendo este, a posição do mouse
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //Dispara o raio na cena, e recebe um output de "hit"
        Physics.Raycast(ray, out hit);
        //Se o gameObject atingido pelo raio for o mesmo que o gameObject que contém esse script...
        if(hit.collider.gameObject == gameObject)
        {
            //Criar uma variável que irá armazenar a posição do clique
            Vector3 target = hit.point + new Vector3(0, 1, 0); 
            //Atribuir a variável "target" ao valor da propriedade "TargetPosition" da classe ExemploCorotina
            corotina.TargetPosition = target;
        }
    }
}
