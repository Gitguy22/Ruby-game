using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D other)
    {
        RubyController damager = other.GetComponent<RubyController>();

        if (damager != null)
        {
            //Taking One Damage when it touches spikes
            damager.ChangeHealth(-1);

        }
    }
}
