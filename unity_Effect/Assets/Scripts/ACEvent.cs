using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ACEvent : MonoBehaviour
{
    [SerializeField] private ParticleSystem effect; // 우리가 사용할 이펙트
    [SerializeField] private Transform effectPosition;
    public void PlayVFX()
    {
        Instantiate(effect, effectPosition.position, Quaternion.EulerRotation(new Vector3(0, 180,0)));
        effect.Play();
    }
}
