using UnityEngine;

public class killScript : MonoBehaviour
{
    public float killTime = 2f;

    private void Start()
    {
        Destroy(gameObject, killTime);
    }
}
