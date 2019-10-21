using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreinoPlayerController1 : MonoBehaviour
{
    public Humanoide personagem;

    public Classe classePersonagem = Classe.GUERREIRO;//??

    private void Awake()
    {
        switch (classePersonagem)
        {
            case Classe.GUERREIRO:
                personagem = new Guerreiro();
                break;

            case Classe.MAGO:
                personagem = new Mago();
                break;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            personagem.Atacar();
        } 
    }
}
public enum classe
{
    MAGO, GUERREIRO;??
}
