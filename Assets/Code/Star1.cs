using UnityEngine;
using System.Collections;

public class Star1 : Pickup//inherit van pickup
{

	//override = je maakt een extensie van die functie
	public override void PlayerHit(Player _GO)
	{
		base.PlayerHit(_GO);//roep de basis classe nog wel aan(dus de playerhit in pickup)
		Debug.Log ("2");
		_GO.m_score += 1;
		Destroy (gameObject);
		//voeg hier code toe zo dat de speler zijn score omhoog gaat
	}
}
