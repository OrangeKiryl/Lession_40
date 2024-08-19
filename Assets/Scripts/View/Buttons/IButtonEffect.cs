using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace View.Buttons
{
  public interface IButtonEffect
  {
    public void Notify(bool correct);
  }
}