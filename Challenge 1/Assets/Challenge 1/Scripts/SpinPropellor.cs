/* Broc Edson
 * Challenge 1
 * Spins the propellor
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellor : MonoBehaviour
{
    public float rotationSpeed = 5f;

    void FixedUpdate()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
