using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerRespawn : MonoBehaviour
{
 

    private float checkpointPositionX, checkpointPositionY;

    public Animator animator;
    
    void Start()
    {
        if (PlayerPrefs.GetFloat("CheckpointPositionX") != 0)
        {
            transform.position = new Vector2(PlayerPrefs.GetFloat("CheckpointPositionX"), PlayerPrefs.GetFloat("CheckpointPositionY"));
        }
    }

    public void ReachedCheckPoint(float x, float y)
    {
        PlayerPrefs.SetFloat("CheckpointPositionX", x);
        PlayerPrefs.SetFloat("CheckpointPositionY", y);
    }

    public void PlayerDamaged()
    {
        animator.Play("Hit");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
