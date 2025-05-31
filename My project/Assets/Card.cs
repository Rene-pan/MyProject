using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public bool CardHovered = false;
    public Material CardMaterial;
    void OnMouseOver()
    {
        CardHovered = true;

    }
    void OnMouseExit()
    {
        CardHovered = false;
    }
    void OnMouseDown()
    {
        if (CardHovered)
        {
            print("hi");
        }
    }
}
