using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InvHandler : MonoBehaviour
{
    public GameObject[] slotsGO;
    public int[] slotsContent;

    public Texture[] textures;

    // # Refs
    public ApiClient Server;

    void Update()
    {
        // Update inventory
        if (Input.GetKeyDown(KeyCode.D))
        {
            AttInv();
        }

        // test
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Lenght of the array: " + Server.itens.Length);
        }
    }


    // Att the inv
    private void AttInv()
    {
        for (int i = 0; i < slotsContent.Length; i++)
        {
            // Add content
            slotsGO[i].GetComponentInChildren<RawImage>().texture = textures[slotsContent[i] - 1];
            // Add description and name:
            slotsGO[i].GetComponentInChildren<Text>().text = Server.itens[slotsContent[i] - 1].Descricao;
        }
    }

    private void GetItens()
    {
        
    }
	
}
