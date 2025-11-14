using UnityEngine;

public class ObstaculosMovimiento : MonoBehaviour
{
    public float velocidad = 5f;

    void Update()
    {
        transform.Translate(Vector3.left * velocidad * Time.deltaTime);

        if (transform.position.x < -15f)
            Destroy(gameObject);
    }
}
