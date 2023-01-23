using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      StartCoroutine(restart());  
    }
    public IEnumerator restart()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(1);

    }
}
