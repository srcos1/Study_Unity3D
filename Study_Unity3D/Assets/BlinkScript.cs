using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkScript : MonoBehaviour
{
    //������Ʈ�� ����������
    //  x�� 0~10, z�� 0~10 ������ ������ ������Ʈ�� ��ġ�Ǿ�� �Ѵ�.
    void OnEnable()
    {
        transform.position = new Vector3(Random.Range(0f, 10f), 0f, Random.Range(0f, 10f)); transform.position = new Vector3(Random.Range(0f, 10f), 0f, Random.Range(0f, 10f));
      
           
        }



}
