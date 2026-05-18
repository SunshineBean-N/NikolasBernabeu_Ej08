using UnityEngine;

public class Camara : MonoBehaviour
{
    [Header("Camara")]
    public Transform player;
    public float alturaCamara = 20f;

    private void LateUpdate()
    {
        Vector3 nuevaPosicion = player.position;
        nuevaPosicion.y = player.position.y + alturaCamara;
        transform.position = nuevaPosicion;

        transform.rotation = Quaternion.Euler(90f, 0f, 0f);
    }
}
