using UnityEngine;

public class Rotator : MonoBehaviour
{
    void Update()
    {
        var dt = Time.deltaTime;
        transform.Rotate(30f * dt, 70f * dt, 130f * dt);
    }
}
