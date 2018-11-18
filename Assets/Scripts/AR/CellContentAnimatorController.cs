using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellContentAnimatorController : MonoBehaviour {
	public enum AnimationsType { nextCell, playContent }

	Dictionary<AnimationsType, string> m_animations;
	[SerializeField] private Animator m_animator;

	private void Awake() {
		//m_animations.Add(AnimationsType.nextCell, "NextCell");
		//m_animations.Add(AnimationsType.playContent, "PlayContent");
	}
	private void PlayAnimationClip(AnimationsType m_animationsType) {
		switch (m_animationsType) 
			{
			//case AnimationsType.nextCell:
			//	m_animator.SetTrigger(m_animations[AnimationsType.nextCell]);
			//	break;
			case AnimationsType.playContent:
				m_animator.SetTrigger(m_animations[AnimationsType.playContent]);
			break;
		}

	}
}
