using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnOnOrOff : MonoBehaviour
{
    [SerializeField]
    private GameObject ChosenButton;
    private SpriteRenderer ObjectColor;
    private int ObjectState;
    [SerializeField] private Sprite[] switchSprites;

    private Image SwitchImage;
    
    void Start()
    {
        ObjectColor = ChosenButton.GetComponent<SpriteRenderer>();
        ObjectState = 0;
        SwitchImage = GetComponent<Button>().image;
        SwitchImage.sprite = switchSprites[ObjectState];
        gameObject.GetComponent<Button>().onClick.AddListener(TurnOnAndOff);



    }
    private void TurnOnAndOff()
    {

        ObjectState = 1 - ObjectState;
        SwitchImage.sprite = switchSprites[ObjectState];


    }
        
}

