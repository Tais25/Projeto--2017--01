using UnityEngine;

public class PranchaMove : MonoBehaviour {

    public float velocidade;
    public 

	void Start () {
		
	}
	
	void Update () {
        Vector3 velocidadeVetorial = Vector3.left * velocidade;
        transform.position = transform.position + velocidadeVetorial * Time.deltaTime;
	}
}
