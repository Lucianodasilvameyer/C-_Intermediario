using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Humanoide
{
    public virtual void Atacar()
    {
        Debug.Log("Humanoide atacou com seus punhos.");
    }
}

public class Guerreiro : Humanoide
{
    public override void Atacar()
    {        
        Debug.Log("Guerreiro atacou com sua espada.");
    }
}

public class Mago : Humanoide
{
    public override void Atacar()
    {
        Debug.Log("Mago lançou uma magia de ataque.");
    }
}
