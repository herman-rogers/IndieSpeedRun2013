using UnityEngine;
using System.Collections;

public class EnemyDestroyClick : MonoBehaviour {
	public float clickDamage = 0.34f;
	public UISprite progressBar;
	float enemyHealth = 1.0f;
	void OnClick ( ) {
		enemyHealth -= clickDamage;
		progressBar.fillAmount = progressBar.fillAmount - clickDamage;
		if ( enemyHealth <= 0.0f ){
			StartCoroutine("DestroyPlease");
		}
	}
	void OnTriggerEnter ( ) {
		StartCoroutine("DestroyPlease");
	}
	
	IEnumerator DestroyPlease()
	{
		yield return new WaitForSeconds(0.009f);
		Destroy( this.gameObject );
	}
}
