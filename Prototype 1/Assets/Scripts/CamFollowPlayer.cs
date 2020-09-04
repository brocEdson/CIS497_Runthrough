/* Broc Edson
 * Prototype 1
 * Makes the Camera follow the player
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollowPlayer : MonoBehaviour
{
    public GameObject player;

    public Vector3 offset = new Vector3(0f, 1.5f, 3f);

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
