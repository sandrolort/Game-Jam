using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static PuzzleImageContainer;

public class CompletionProgress : MonoBehaviour
{
    public SpriteRenderer progressImage;
    public SpriteRenderer overlay;
    void FixedUpdate()
    {
        //More that PuzzleImageContainer.Progress increases, decrease the brightness of the image till its black at value of 16. use lerp to smoothly transition between the old color and new color.
        progressImage.color = Color.Lerp(progressImage.color, new Color(1-Progress/16f,1-Progress/16f,1-Progress/16f,1), 0.01f);
        overlay.color = new Color(0,0,0,1-Progress/28f);
        print(1-Progress/16f);
    }
}