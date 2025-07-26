using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ACEvent : MonoBehaviour
{
    [SerializeField] private ParticleSystem effect; // �츮�� ����� ����Ʈ
    [SerializeField] private Transform effectPosition;
    public void PlayVFX()
    {
        Instantiate(effect, effectPosition.position, Quaternion.EulerRotation(new Vector3(0, 180,0)));
        effect.Play();
    }
}
