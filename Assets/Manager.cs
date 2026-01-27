using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public List<Wishlist> wishlists;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Wishlist nyLista = new Wishlist();
        nyLista.personName = "Tobias";
        wishlists.Add(nyLista);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
