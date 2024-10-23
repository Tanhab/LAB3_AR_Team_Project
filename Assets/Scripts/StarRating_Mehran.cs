using UnityEngine;
using UnityEngine.UI;

public class StarRating : MonoBehaviour
{
    public Image[] stars;  // Array to hold the 5 star images
    public Sprite emptyStar;  // Sprite for the empty star
    public Sprite filledStar;  // Sprite for the filled star

    private int currentRating = 0;

    // Called when a star is clicked, the 'starIndex' is passed from the UI button
    public void SetRating(int starIndex)
    {
        currentRating = starIndex + 1; // Update rating (starIndex starts at 0)
        UpdateStars();
    }

    // Updates the stars based on the selected rating
    private void UpdateStars()
    {
        for (int i = 0; i < stars.Length; i++)
        {
            if (i < currentRating)
            {
                stars[i].sprite = filledStar;  // Set to filled star
            }
            else
            {
                stars[i].sprite = emptyStar;  // Set to empty star
            }
        }
    }
}
