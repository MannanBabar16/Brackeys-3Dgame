using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool isGameOver = false;
   public void gameOver()
    {
        if(isGameOver==false) 
        {
            isGameOver = true;
            Invoke("Restart",1f);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
