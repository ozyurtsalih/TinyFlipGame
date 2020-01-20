using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SahneGec1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // Sahne geçişlerini load level ile sağlıyorum.
    public void Buton1()
    {
        Application.LoadLevel("OyunlarMenu");
    }
    public void PuzzleGecis()
    {
        Application.LoadLevel("GolgePuzzleSahne");
    }
    public void PaintGecis()
    {
        Application.LoadLevel("PaintSahne");
    }
    public void AnimalGecis()
    {
        Application.LoadLevel("AnimalSoundsSahne");
    }

}
