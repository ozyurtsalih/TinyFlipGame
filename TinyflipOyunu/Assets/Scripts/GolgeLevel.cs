using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolgeLevel : MonoBehaviour
{
    
    public GameObject aslan, inek, maymun, aslanGolge, inekGolge, maymunGolge;

    Vector2 aslanKonum, inekKonum, maymunKonum;

    bool aslanCorrect, inekCorrect, maymunCorrect = false;

    public AudioSource source;
    public AudioClip[] correct; // ses dizisi tanımlıyorum doğru işlem için
    public AudioClip incorrect; // yanlışsa bir tane hatalı ses çalacak.
    public GameObject gecmenuuni; // bittiğinde çıkacak menu.
    // Start is called before the first frame update
    void Start()
    {
        // nesnelerin başlangıç konumlarını değikenlerde tutuyoruz
        aslanKonum = aslan.transform.position; // aslanın konumunu alır.
        inekKonum = inek.transform.position;
        maymunKonum = maymun.transform.position;
    }
    /// <summary>
    /// Mouse tutup konum bilgisine göre hareket etmesi sağlanır.
    /// </summary>
    public void DragAslan()
    {
       

        //mouse ile aslanı tuttuğumuzda mouse takip eder.
        aslan.transform.position = Input.mousePosition;

    }
    public void DragInek()
    {
        //mouse ile aslanı tuttuğumuzda mouse takip eder.
        inek.transform.position = Input.mousePosition;
    }
    public void DragMaymun()
    {
        //mouse ile aslanı tuttuğumuzda mouse takip eder.
        maymun.transform.position = Input.mousePosition;
    }
    /// <summary>
    /// Bırakma eylemi için 50 mesafesine göre kontrol edilir.
    /// </summary>
    public void DropAslan()
    {
        float Distance = Vector3.Distance(aslan.transform.position,aslanGolge.transform.position);
        //iki nesne arasındaki mesafe tutulur
        if (Distance<50)
        {
            aslan.transform.position = aslanGolge.transform.position;
            source.clip = correct[Random.Range(0, correct.Length)]; 
            // farklı 3 ses dosyasında birisi rasgele oynatılır diziden
            source.Play(); //Ses oynatılır.
            aslanCorrect = true;
        }
        else
        {
            //En başta tutulan konuma geri döner.
            aslan.transform.position = aslanKonum;
            source.clip = incorrect;
            source.Play();
            
        }
    }
    
    public void DropInek()
    {
        float Distance = Vector3.Distance(inek.transform.position, inekGolge.transform.position);
        //iki nesne arasındaki mesafe tutulur
        if (Distance < 50)
        {
            // yeni konum gölgenin olduğu konuma eşitlenir.
            inek.transform.position = inekGolge.transform.position;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
            inekCorrect = true;

        }
        else
        {
            //En başta tutulan konuma geri döner.
            inek.transform.position = inekKonum;
            source.clip = incorrect;
            source.Play();
        }
    }
    public void DropMaymun()
    {
        float Distance = Vector3.Distance(maymun.transform.position, maymunGolge.transform.position);
        //iki nesne arasındaki mesafe tutulur
        if (Distance < 50)
        {
            maymun.transform.position = maymunGolge.transform.position;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
            maymunCorrect = true;
        }
        else
        {
            // yeni konum gölgenin olduğu konuma eşitlenir.
            maymun.transform.position = maymunKonum;
            source.clip = incorrect; //yanlış işlem için olan ses klibi çalıştırır
            source.Play();
        }
    }
   
    void Update()
    {
        // tüm eşleşmeler doğruysa splash menu çıkar.
        if (maymunCorrect && inekCorrect && aslanCorrect==true)
        {
            
        }
    }
}
