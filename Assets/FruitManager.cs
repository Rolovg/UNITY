using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FruitManager : MonoBehaviour
{

    public Text levelCleared;

    public void Update()
    {
        AllFruitsCollected();
    }
    public void AllFruitsCollected()
    {

        if(transform.childCount == 0)
        {
            Debug.Log("Todas las frutas Recolectadas!");
            levelCleared.gameObject.SetActive(true);
            Invoke("ChangeScene", 1);

        }

    }
    

    void ChangeScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
