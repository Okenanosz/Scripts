using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class Enemy : NetworkBehaviour
{
    public int MaxHealth;
    [SyncVar]
    public int CurrentHealth;
    

    void Start()
    {
        CurrentHealth = MaxHealth;
    }
    public void TakeDamage(int damage)
    {
        if (!isServer)
            return;
        CurrentHealth -= damage;
    }

	
}
