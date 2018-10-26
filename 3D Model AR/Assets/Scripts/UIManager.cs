using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    public static UIManager instance;

    public GameObject actionBarPanel;

    // Called when the script instance is loaded
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void EnterFullScreen()
    {
        StartCoroutine(HideActionBarWithTimeout());
    }

    private IEnumerator HideActionBarWithTimeout()
    {
        actionBarPanel.GetComponent<Animator>().Play("Hide");
        yield return new WaitForSeconds(3);
        actionBarPanel.GetComponent<Animator>().Play("Show");
    }
}
