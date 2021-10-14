using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Plant : MonoBehaviour
{
  [SerializeField] PlantData info;
  SetPlantInfo spi;

  void Start()
  {
    spi = GameObject.FindGameObjectWithTag("PlantInfo").GetComponent<SetPlantInfo>();
  }

  void OnMouseDown()
  {
    spi.OpenPlantPanel();
    spi.plantName.text = info.Name;
    spi.threatLevel.text = info.Threat.ToString();
    spi.plantIcon.GetComponent<RawImage>().texture = info.Icon;
  }

  public PlantData GetPlantData()
  {
    return info;
  }
}