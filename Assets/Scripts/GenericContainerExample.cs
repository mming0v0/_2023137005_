using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericContainerExample : MonoBehaviour
{
    private GenericContainer<int> intContainer;         //�����̳� ���� (int)
    private GenericContainer<string> stringContainer;       //�����̳� ���� (string)



    void Start()
    {
        intContainer = new GenericContainer<int>(10);       //10ĭ���� ����
        stringContainer = new GenericContainer<string>(5);      //5ĭ���� ����
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))       //Ű���� 1�� ������
        {
            intContainer.Add(Random.Range(0, 100));     //0 - 100 ���� ���ڸ� �����̳ʿ� �ִ´�.
            DisplayContaineritems(intContainer);            //�Լ��� ���ؼ� Debug.log�� �����ش�
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))           //Ű���� 1�� ������
        {
            string randomString = "Item" + Random.Range(0, 100);            //������ ���ڿ��� ������ش�.
            stringContainer.Add(randomString);          //0 - 100 ���� ���ڿ� �����̳ʿ� �ִ´�.
            DisplayContaineritems(stringContainer);         //�Լ��� ���ؼ� Debug.log�� �����ش�
        }
    }
    //�����̳ʿ� ��� ������ �����ִ� �Լ�
    private void DisplayContaineritems<T>(GenericContainer<T> container)
    {
        T[] item = container.Getltems();        //������ ����Ʈ�� �޾ƿ´�.
        string temp = "";               //Debug.Log�� ������ ĭ String
        for (int i = 0; i < item.Length; i++)          //�����̳��� ��� ���� for������ ���鼭
        {
            if (item[i] != null)            //���� NULL�� �ƴҰ��
            {
                temp += item[i].ToString() + "/";       //string �������� �����ش�.
            }
            else
            {
                temp += "Empty /";              //NULL�� ��쿡�� Empty ǥ�� ���ش�
            }
        }
        Debug.Log(temp);
    }
}