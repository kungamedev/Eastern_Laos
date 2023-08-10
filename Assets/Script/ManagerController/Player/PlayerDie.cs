using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerDie : MonoBehaviour
{

     private Vector3 playerStartPosition;

    void Start()
    {
        playerStartPosition = GameObject.FindGameObjectWithTag("Player").transform.position;
    }

    public void ReloadMap() {
          Destroy(GameObject.FindGameObjectWithTag("Enemy"));
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                    GameObject.FindGameObjectWithTag("Player").transform.position = playerStartPosition;
    }
     public void PlayerDeath()
    {
        ReloadMap();
    }

}