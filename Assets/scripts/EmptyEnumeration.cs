using UnityEngine;
using System.Collections;

public class EmptyEnumeration : MonoBehaviour {

	public string[] perguntas;

	IEnumerator Start(){
		WWW perguntas = new WWW("http://localhost/Nova%20pasta/perguntas.php");
		yield return perguntas;
		string itemsDataString = perguntas.text;
		print (itemsDataString);

}
}