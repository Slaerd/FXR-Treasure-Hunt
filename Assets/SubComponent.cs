using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubComponent : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject model;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Hide()
    {
        model.SetActive(false);
        Debug.Log("subComponent hidden");
    }

    public void Show()
    {
        model.SetActive(true);
        Debug.Log("subComponent shown");
    }
}
