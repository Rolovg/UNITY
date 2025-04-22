using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class DoorsScript : MonoBehaviour
{
    public Text text;
    public string levelName;
    private bool inDoor = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            
            text.gameObject.SetActive(true);
            inDoor = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            text.gameObject.SetActive(false);
            inDoor = false;
        }
    }

    private void Update()
    {
        if (inDoor && Input.GetKeyDown("e"))
        {
            SceneManager.LoadScene(levelName);
        }
    }
}
