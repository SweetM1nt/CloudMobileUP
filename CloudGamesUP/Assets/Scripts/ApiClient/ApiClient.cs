using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class ApiClient : MonoBehaviour {

    public string baseUrl = "http://localhost:57038/API";

    [HideInInspector]
    public Item[] itens;

    // Use this for initialization
    void Start ()
    {
        //StartCoroutine(GetItensApiAsync());
	}
	

    public void GetItensApiAsync2()
    {

    }

	IEnumerator GetItensApiAsync()
    {
        UnityWebRequest request = UnityWebRequest.Get(baseUrl + "/Itens");
        yield return request.Send();

        if (request.isNetworkError || request.isHttpError)
        {
            Debug.Log(request.error);
        }
        else
        {
            string response = request.downloadHandler.text;
            Debug.Log(response);

            byte[] bytes = request.downloadHandler.data;

            itens = JasonHelper.getJsonArray<Item>(response);

            /*foreach (Item i in itens)
            {
                ImprimirItem(i);
            }*/
        }
    }

    private void ImprimirItem(Item i)
    {
        Debug.Log("============ Dados Objeto ============");
        Debug.Log("Nome :" + i.Nome);
        Debug.Log("Descrição: " + i.Descricao);
        Debug.Log("Dano Maximo: " + i.DanoMaximo);
        Debug.Log("Raridade: " + i.Raridade);
        Debug.Log("TipoItemID: " + i.TipoItemID);
    }

}
