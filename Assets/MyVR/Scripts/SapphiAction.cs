using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SapphiAction : MonoBehaviour {

	public Animator _SapphiArtChanAnimator;

	// Use this for initialization
	void Start () {
		SetAllAnimationFlagsToFalse ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void SetAllAnimationFlagsToFalse() {
		_SapphiArtChanAnimator.SetBool("param_idletowalk", false);
		_SapphiArtChanAnimator.SetBool("param_idletorunning", false);
		_SapphiArtChanAnimator.SetBool("param_idletojump", false);
		_SapphiArtChanAnimator.SetBool("param_idletowinpose", false);
		_SapphiArtChanAnimator.SetBool("param_idletoko_big", false);
		_SapphiArtChanAnimator.SetBool("param_idletodamage", false);
		_SapphiArtChanAnimator.SetBool("param_idletohit01", false);
		_SapphiArtChanAnimator.SetBool("param_idletohit02", false);
		_SapphiArtChanAnimator.SetBool("param_idletohit03", false);
	}

	public void SetGazedAt(bool gazedAt) {
		SetAllAnimationFlagsToFalse ();
		_SapphiArtChanAnimator.SetBool("param_idletowinpose", gazedAt);
	}

	public void SetTouched() {
		SetAllAnimationFlagsToFalse ();
		_SapphiArtChanAnimator.SetBool("param_idletodamage", true);
	}
}
