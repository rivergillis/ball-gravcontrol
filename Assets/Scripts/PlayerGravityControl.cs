using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// We allow for gravity to be angled a certain number of degrees from Vector3.up.
// Ex: At no deflection, gravity is 0,0,0
//     At full +X deflection, gravity is +maxGravityDeflection, 0, 0
//     At full -Y deflection, gravity is 0, 0, -maxGravityDeflection
//     At full +X/+Y deflection, gravity is +(sqrt2) * maxGravityDeflection, 0, +(sqrt2) * maxGravityDeflection
// The player cannot control gravity in the Y dimension.

// Gravity control is instantaneous, because we're changing an acceleration.

public class PlayerGravityControl : MonoBehaviour
{
    [SerializeField, Range(0f, 90f)]
    float maxGravityDeflection = 30f;

    void Update()
    {
        Vector2 playerInput;
        playerInput.x = Input.GetAxis("Horizontal");
        playerInput.y = Input.GetAxis("Vertical");
        playerInput = Vector2.ClampMagnitude(playerInput, 1f);

        GlobalState.gravity.x = playerInput.x * maxGravityDeflection;
        GlobalState.gravity.z = playerInput.y * maxGravityDeflection;
    }
}
