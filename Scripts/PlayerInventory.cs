using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerInventory : MonoBehaviour {

    public int playerPoints;
    public int playerHealth;
    public bool hasKey;


    public void changeHealth(int damageInflicted)
    {
        playerHealth -= damageInflicted;
        if (playerHealth >= 0)
        {
            //Put in here whatever should happen when player is dead
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void changePoints (int pointsChange)
    {
        playerPoints += pointsChange;
    }
}
