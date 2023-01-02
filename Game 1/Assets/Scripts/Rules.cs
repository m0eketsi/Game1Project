using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rules : MonoBehaviour
{

    public GameObject rulesTab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OpenTab()
    {
        rulesTab.SetActive(true);
    }
    public void CloseTab()
    {
        rulesTab.SetActive(false);
    }
}
