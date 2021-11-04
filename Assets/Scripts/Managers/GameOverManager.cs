using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public Text warningText;
    public NewPlayerHealth playerHealth;       
    public float restartDelay = 5f;            

    Animator anim;                          
    float restartTimer;

    private bool isAnimating = false;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if (playerHealth.currentHealth <= 0)
        {
            if (!isAnimating)
            {
                isAnimating = true;
                ShowDeath();
            }
            restartTimer += Time.deltaTime;

            if (restartTimer >= restartDelay)
            {
                isAnimating = false;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }

    public void ShowWarning(float enemyDistance)
    {
        warningText.text = string.Format("! {0} m", Mathf.RoundToInt(enemyDistance));
        anim.SetTrigger("Warning");
    }

    void ShowDeath()
    {
        Debug.Log("GameOver");
        anim.SetTrigger("GameOver");
    }
}