using UnityEngine;
using System.Collections;

public class PlayerDamage : MonoBehaviour {
	public UISprite warmthBar;
	public float playerHealth = 5.0f;
	void OnTriggerEnter( Collider objectCollider ){
		float enemyDamage = objectCollider.gameObject.GetComponent< EnemyDestroyClick >( ).enemyDamage;
		if ( objectCollider.tag == "Enemy" ){
			warmthBar.fillAmount = warmthBar.fillAmount - enemyDamage;
		}
	}
}
