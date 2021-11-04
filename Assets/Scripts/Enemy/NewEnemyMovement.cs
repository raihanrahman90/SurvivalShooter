using UnityEngine;

public class NewEnemyMovement : MonoBehaviour
{
    Transform player;
    NewPlayerHealth playerHealth;
    NewEnemyHealth enemyHealth;
    UnityEngine.AI.NavMeshAgent nav;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        playerHealth = player.GetComponent<NewPlayerHealth>();
        enemyHealth = GetComponent<NewEnemyHealth>();
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    private void Update()
    {
        if(enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)
        {
            nav.SetDestination(player.position);
        }
        else
        {
            nav.enabled = false;
        }
    }
}
