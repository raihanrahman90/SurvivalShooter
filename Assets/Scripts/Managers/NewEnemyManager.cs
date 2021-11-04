using UnityEngine;

public class NewEnemyManager : MonoBehaviour
{
    public NewPlayerHealth playerHealth;
    public GameObject enemy;
    public float spawnTime = 3f;
    public Transform[] spawnPoints;

    [SerializeField] EnemyFactory factory;
    IFactory Factory
    {
        get
        {
            return factory as IFactory;
        }
    }

    private void Start()
    {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }

    void Spawn()
    {
        if(playerHealth.currentHealth <= 0f)
        {
            return;
        }

        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        int spawnEnemy = Random.Range(0, 3);

        //Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
        Factory.FactoryMethod(spawnEnemy);
    }
}
