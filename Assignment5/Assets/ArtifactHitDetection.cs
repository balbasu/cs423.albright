using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Artifact : MonoBehaviour {
  public float dissolveDuration = 2;
  public float dissolveStrength;

public void StartDissolver()
{
  StartCoroutine(dissolver());
}

  public IEnumerator dissolver()
  {
    float elapsedTime = 0;
    Material dissolveMaterial = GetComponent<Renderer>().material;
    while (elapsedTime < dissolveDuration)
    {
      elapsedTime += Time.deltaTime;

      dissolveStrength = Mathf.Lerp(0, 1, elapsedTime / dissolveDuration);
      dissolveMaterial.SetFloat("_DissolveStrength", dissolveStrength);

      yield return null;
    }
  }
  void OnTriggerEnter(Collider other) {                           
    PlayerCharacter player = other.GetComponent<PlayerCharacter>();
    if (player != null) {    
      Debug.Log("Pyramid hit");
      StartDissolver();
    }
  }
}