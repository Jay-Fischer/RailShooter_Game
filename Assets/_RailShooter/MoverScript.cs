using UnityEngine;

public class MoverScript : MonoBehaviour
{
    public float MoveSpeed = 1f;

    void Update()
    {
        transform.Translate(Vector3.forward * MoveSpeed * Time.deltaTime);
    }
}
