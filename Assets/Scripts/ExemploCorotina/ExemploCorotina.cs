using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aula0910
{
    public class ExemploCorotina : MonoBehaviour
    {
        public float smoothing = 1f;        //Valor de suavização utilizado na interpolação dos pontos

        private Vector3 targetPosition;     //Vetor que armazena a posição onde o objeto será deslocado

        public Vector3 TargetPosition       //Propriedade da variável "targetPosition"
        {
            get //Acessar o valor da variável privada
            {
                return targetPosition;
            }
            set //Modificar o valor da variável privada
            {
                targetPosition = value;

                //Invocar função que mostra a posição do clique
                MostraPosicao();
                //Interrompe a execução da corotina
                StopCoroutine("MovePosition");
                //Inicia a corotina "MovePosition", passando como parâmetro o valor de "targetPosition"
                StartCoroutine("MovePosition", targetPosition);
            }
        }

        private IEnumerator MovePosition(Vector3 target)
        {
            //Enquanto a distância entre a posição do gameObject e a posição destino for maior que zero...
            while (Vector3.Distance(transform.position, target) > 0)
            {
                //Criar a variável "currentPos" e armazenar o vetor de interpolação entre os dois ponto            
                Vector3 currentPos = Vector3.Lerp(transform.position, target, Time.deltaTime * smoothing);
                //Mostrar no console o valor do vetor
                Debug.Log(currentPos);
                //Atribuir o valor do vetor a posição do objeto
                transform.position = currentPos;
                //Sinalizar um retorno nulo da corotina
                yield return null;
            }
        }

        void MostraPosicao()
        {
            //Mostra no console o valor da variável "targetPosition"
            Debug.Log("Posicao: " + targetPosition);
        }
    }
}
