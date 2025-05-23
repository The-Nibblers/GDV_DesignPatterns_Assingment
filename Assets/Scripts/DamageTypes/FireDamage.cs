using InterFaces;
using UnityEngine;

public class FireDamage : IDamageType
{
    public void ApplyDamage(HealthSystem enemy, int damage)
    {
        enemy.TakeDamage(damage, DamageTypes.Fire);
        Debug.Log("Fire Damage Applied");
        //Apply Fire Status effect, different animations, particles etc
    }
}
