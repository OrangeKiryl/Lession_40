using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using DG.Tweening;

namespace View.Buttons
{
  public class ColorButton : MonoBehaviour, IButtonEffect
  {
    //[SerializeField] private Button button;
    [SerializeField] private Image image;

    public void Notify(bool correct)
    {
      //Todo
      throw new System.NotImplementedException();
    }

    private void Awake()
    {
      GetComponent<Button>().onClick.AddListener(ChangeColorButton);
    }

    private void ChangeColorButton()
    {
      //Image image = button.GetComponent<Image>();
      Color color = image.color;
      image.DOColor(Color.red, 2f).OnComplete(() =>
      {
        image.DOColor(color, 2f);
      });
    }
  }
}