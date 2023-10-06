using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ColourChange : MonoBehaviour
{
    SpriteRenderer m_SpriteRenderer;
    public void ChangeColour(InputAction.CallbackContext ctx)
    {
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        m_SpriteRenderer.color = Color.magenta;
        Debug.Log("ranColour");
    }

}
