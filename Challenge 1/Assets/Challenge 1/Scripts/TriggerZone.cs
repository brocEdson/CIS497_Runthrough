/* Broc Edson
 * Challenge 1
 * Triggers a score increase when the player enters
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    private bool triggered = false;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && !triggered)
        {
            triggered = true;
            ScoreManager.score++;
        }
    }
}
