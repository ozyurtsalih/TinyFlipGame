using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResimControl : MonoBehaviour
{
    [SerializeField]
    private Transform[] pictures; /// <summary>
    /// 
    /// resimler için dizi oluşturuyorum.
    /// </summary>
    
    public GameObject gecmenuuni; //Splash ekranı tanımladım.
    public static bool youWin;

    // Start is called before the first frame update
    void Start()
    {
        gecmenuuni.SetActive(false);// başlangıçta menu kapalı
        //winText.SetActive(false);
        youWin = false;
    }

    // Update is called once per frame
    void Update()
    {
        // her update yapılışında rotation z değerleri sıfır mı diye kontrol edilir.
        if (pictures[0].rotation.z == 0
             && pictures[1].rotation.z == 0
             && pictures[2].rotation.z == 0
             && pictures[3].rotation.z == 0
             && pictures[4].rotation.z == 0
             && pictures[5].rotation.z == 0)
        {
            youWin = true;
           // işlem doğrulandığında menü açılır.
            gecmenuuni.SetActive(true);
        }
    }
}
