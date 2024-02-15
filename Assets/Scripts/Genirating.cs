

using UnityEngine;

public class Genirating : MonoBehaviour
{
    [SerializeField] private GameObject [] _truby;
    [SerializeField] private float _timemin;
    [SerializeField] private float _timemax;
    [SerializeField] private TrubaMovement _trubaMovement;
    [SerializeField] private Transform [] points;
    
    private float lasttime;
    private float waittime;
    private void Update()
    {
        if (Time.time > waittime + lasttime)
        {
            waittime = Random.Range(_timemin, _timemax);
            lasttime = Time.time;
            int index = Random.Range(0, points.Length);
            GameObject clone = Instantiate(_truby[index]); // клонируем трубу и записываем клона в переменную
            clone.transform.position = points [index].position; // перемещаем обьект на точку спавна
            clone.transform.parent = _trubaMovement.transform; // выставляем родителя для трубы
        }
    }
}
