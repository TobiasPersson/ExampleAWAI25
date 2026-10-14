using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Referencer : MonoBehaviour
{
    [SerializeField] TMP_Text text;
    test2 sammaObjekt;
    TMP_Text buttonText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        buttonText = FindAnyObjectByType<Button>().GetComponentInChildren<TMP_Text>();
        sammaObjekt = GetComponent<test2>();
        sammaObjekt.coolNumber = 15;
        text.text = "Hello";
        buttonText.text = "Elias";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
