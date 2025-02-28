using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathVolume : Death
{
    private void OnTriggerEnter2D(Collider2D colide)
    {
        Destroy(colide.gameObject); // Note that we need to destroy the GameObject, not just the collider component!
        Destroy(gameObject.gameObject); // The kamikaze ship
    }
}
