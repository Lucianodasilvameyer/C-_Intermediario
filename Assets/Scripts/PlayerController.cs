'using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Humanoide personagem;

    public Classe classePersonagem = Classe.GUERREIRO;

    private void Awake()
    {
        switch(classePersonagem)
        {
            case Classe.GUERREIRO:
                personagem = new Guerreiro();//Downcasting
                break;
            case Classe.MAGO:
                personagem = new Mago();//Downcasting
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

public enum Classe
{
    MAGO, GUERREIRO
};
