using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    public PlayerController playerLives;
    public float controllerLives;
    public int heartOrder;
    public GameObject collectable;
    public List<Transform> heartSpawns;
    public float spawnTime = 10f;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (controllerLives < 3)
        {
        spawnTime -= 1 * Time.deltaTime;
        if (spawnTime <- 0)
        {
        SpawnHearts();
        }
        }
        controllerLives = playerLives.lives;
        HeartSystem();
        GameOver();
}
    public void GameOver()
    {
        if (controllerLives == 0)
        {
        SceneManager.LoadScene(1);
        }
    }
    public void HeartSystem()
    {
        if (controllerLives == 3)
        {
            heart1.SetActive(true);
            heart2.SetActive(true);
            heart3.SetActive(true);
        }
        if (controllerLives == 2)
        {
            heart1.SetActive(false);
            heart2.SetActive(true);
            heart3.SetActive(true);
        }
        if (controllerLives == 1)
        {
            heart1.SetActive(false);
            heart2.SetActive(false);
            heart3.SetActive(true);
        }
    }
    void SpawnHearts()
    {
  
        int randomizer = (int)Random.Range(0,5);
        collectable.transform.position = new Vector2(heartSpawns[randomizer].position.x, heartSpawns[randomizer].position.y);
        collectable.SetActive(true);
        spawnTime = 10;
    }
}
