using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPopUp : MonoBehaviour
{
    [SerializeField]
    GameObject menu;

    private void Start()
    {
        menu.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return))
        {
            if (menu.activeSelf)
            {
                FueraMenu();
            }
        }
    }

    public void FueraMenu()
    { 
        {
            menu.SetActive(false);
        }   
    }
}
