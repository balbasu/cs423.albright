using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Painting : MonoBehaviour {
  int rngPaintingCollision;
  int rngPaintingMaterial;
  void OnTriggerEnter(Collider other) {                           
    PlayerCharacter player = other.GetComponent<PlayerCharacter>();
    if (player != null) {    
      rngPaintingCollision = Random.Range(1, 4);                                         
      Debug.Log("Painting hit, result " + rngPaintingCollision.ToString());
    }
    if (rngPaintingCollision == 2) {
      rngPaintingMaterial = Random.Range(1, 5);
      if (rngPaintingMaterial == 1) {
        GetComponent<MeshRenderer>().material = Resources.Load("FarmersOnlyDotCom", typeof (Material)) as Material;
      }
      else if (rngPaintingMaterial == 2) {
        GetComponent<MeshRenderer>().material = Resources.Load("HesJustLikeMeFrFr", typeof (Material)) as Material;
      }
      else if (rngPaintingMaterial == 3) {
        GetComponent<MeshRenderer>().material = Resources.Load("Scream", typeof (Material)) as Material;
      }
      else if (rngPaintingMaterial == 4) {
        GetComponent<MeshRenderer>().material = Resources.Load("starryNight", typeof (Material)) as Material;
      }
    }
    //else if (rngPaintingCollision == 3) {
    //  Destroy(this.gameObject);
    //}
  }
}