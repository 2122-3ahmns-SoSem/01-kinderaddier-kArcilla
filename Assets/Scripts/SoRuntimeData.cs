using UnityEngine;

[CreateAssetMenu(menuName = "SoRuntimeData")]

public class SoRuntimeData : ScriptableObject
{
    public string nameKid;

    private void OnEnable ()
    {
        nameKid = "";
    }
}
