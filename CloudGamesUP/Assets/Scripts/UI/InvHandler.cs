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
        if (Input.GetKeyDown(KeyCode.D))
        {
            AttInv();
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
            slotsGO[i].GetComponentInChildren<Text>().text = Server.itens[i].Descricao;
        }
    }

    private void GetItens()
    {
        
    }
	
}
