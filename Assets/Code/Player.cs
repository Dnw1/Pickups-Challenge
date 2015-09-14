using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
	public float m_score = 0;
	public float playerSpeed = 50;
    // Update is called once per frame
    void Update()
    {
		//beweeg de speler naar rechts
		this.transform.position += Vector3.right / playerSpeed;
		Speed ();
		Rotate ();
		}
	    public void Speed(){
		if(m_score == 3){
			playerSpeed = 175;
		}
      }
		public void Rotate(){
			if(m_score == 2){
				transform.Rotate (new Vector3 (0, 4, 480));
			}
		}
}
