using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score_Direita : MonoBehaviour
{


    


    public void Restart()
    {
        SceneManager.LoadScene("Scene01");
    }









    //detecta colisão

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 8)
        {
            Restart();
           
        }
    }



}
