using UnityEngine;

public static class GlobalState
{
    public static Vector3 gravity;

    static GlobalState()
    {
        gravity = new Vector3(0f, -9.81f, 0f);
    }
}