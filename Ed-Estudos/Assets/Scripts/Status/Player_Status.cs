using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Status : MonoBehaviour
{
    public Slider   Barra_Vida,
                    Barra_Mana, 
                    Barra_Stamina;

    public float    Vida,
                    Mana,
                    Stamina,
                    Taxa_Regen;

    // Start is called before the first frame update
    void Start()
    {
        Vida = 100;
        Mana = 100;
        Stamina = 100;
    }

    // Update is called once per frame
    void Update()
    {
        Regen_Status();
        Atualizar_Status();
    }

    public void Atualizar_Status()
    {
        Barra_Vida.value = Vida/100;
        Barra_Mana.value = Mana/100;
        Barra_Stamina.value = Stamina/100;
    }
    public void Regen_Status()
    {
        if(Vida<100)
        {
            Vida = Vida+Taxa_Regen;
        }    
        if(Mana<100)
        {
            Mana = Mana+Taxa_Regen;
        }
        if(Stamina<100)
        {
            Stamina = Stamina+Taxa_Regen;
        }  
    }
}
