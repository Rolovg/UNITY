using UnityEngine;

public class DamageObject : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            Debug.Log("Jugador s'ha fet mal");
            collision.transform.GetComponent<PlayerRespawn>().PlayerDamaged();
        }
    }
}
