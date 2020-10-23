using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SuperComponent : MonoBehaviour
{
    // Start is called before the first frame update
    public UnityEvent hideSubComponent;
    public UnityEvent showSubComponent;
    public MeshRenderer m_renderer;
    public virtual void Start()
    {
        m_renderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    public virtual void Update()
    {
        if (m_renderer.isVisible)
            hideSubComponent.Invoke();
        else
            showSubComponent.Invoke();
    }
}
