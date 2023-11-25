using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CubeSceneManager : MonoBehaviour
{
    [SerializeField] private Text _textInfo;

    [SerializeField] private ControllableCube _cube_1;
    [SerializeField] private ControllableCube _cube_2;

    [SerializeField] private GameObject _spheres;

    private void FixedUpdate()
    {
        var distance = Vector3.Distance(_cube_1.transform.position, _cube_2.transform.position);

        if (distance < 1)
        {
            SceneManager.LoadScene(1);
            return;
        }

        _spheres.SetActive(distance < 2);

        _textInfo.text = $"Distance between cubes: {distance.ToString("0.00")}";
    }
}
