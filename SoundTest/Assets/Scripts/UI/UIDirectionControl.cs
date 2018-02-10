using UnityEngine;

public class UIDirectionControl : MonoBehaviour
{
    public bool m_UseRelativeRotation = true;  


    private Quaternion m_RelativeRotation;     


    private void Start()
    {
        m_RelativeRotation = transform.parent.localRotation;
    }


    private void Update()
    {
        if (m_UseRelativeRotation)
            transform.rotation = m_RelativeRotation;
    }
}

//finds the rotation of the canvas, and then using that every updates set the current rotation to that rotation