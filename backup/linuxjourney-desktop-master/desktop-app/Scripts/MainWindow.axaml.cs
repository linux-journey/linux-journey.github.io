using Avalonia.Controls;
using Avalonia.Interactivity;

namespace linuxjourney_desktop;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    //''Sections'' Clicks

    public void grasshopperButton_Click(object sender, RoutedEventArgs e)
    {
        grasshopperButton.IsVisible=false;
        journeymanButton.IsVisible=false;
        networkingButton.IsVisible=false;

        coursesLabel.IsVisible=true;

        courseOneButton.IsVisible=true;
        courseTwoButton.IsVisible=true;
        courseThreeButton.IsVisible=true;
        courseFourButton.IsVisible=true;
        courseFiveButton.IsVisible=true;
        courseSixButton.IsVisible=true;
        courseSevenButton.IsVisible=true;
        courseEightButton.IsVisible=true;

        
    }

    public void journeymanButton_Click(object sender, RoutedEventArgs e)
    {
        grasshopperButton.IsVisible=false;
        journeymanButton.IsVisible=false;
        networkingButton.IsVisible=false;

        coursesLabel.IsVisible=true;

        courseNineButton.IsVisible=true;
        courseTenButton.IsVisible=true;
        courseElevenButton.IsVisible=true;
        courseTwelveButton.IsVisible=true;
        courseThirteenButton.IsVisible=true;
        courseFourteenButton.IsVisible=true;
        courseFifteenButton.IsVisible=true;
    }

    public void networkingButton_Click(object sender, RoutedEventArgs e)
    {
        grasshopperButton.IsVisible=false;
        journeymanButton.IsVisible=false;
        networkingButton.IsVisible=false;

        coursesLabel.IsVisible=true;

        courseSixteenButton.IsVisible=true;
        courseSeventeenButton.IsVisible=true;
        courseEighteenButton.IsVisible=true;
        courseNineteenButton.IsVisible=true;
        courseTwentyButton.IsVisible=true;
        courseTwentyOneButton.IsVisible=true;
        courseTwentyTwoButton.IsVisible=true;
    }

    //GrassHopper Courses Clicks

    public void courseOneButton_Click(object sender, RoutedEventArgs e)
    {
        coursesLabel.IsVisible=false;
        lessonsLabel.IsVisible=true;

        courseOneButton.IsVisible=false;
        courseTwoButton.IsVisible=false;
        courseThreeButton.IsVisible=false;
        courseFourButton.IsVisible=false;
        courseFiveButton.IsVisible=false;
        courseSixButton.IsVisible=false;
        courseSevenButton.IsVisible=false;
        courseEightButton.IsVisible=false;

        lessonOneButton.IsVisible=true;
        lessonTwoButton.IsVisible=true;
        lessonThreeButton.IsVisible=true;
        lessonFourButton.IsVisible=true;
        lessonFiveButton.IsVisible=true;
        lessonSixButton.IsVisible=true;
        lessonSevenButton.IsVisible=true;
        lessonNineButton.IsVisible=true;
        lessonTenButton.IsVisible=true;
    }

    public void courseTwoButton_Click(object sender, RoutedEventArgs e)
    {
        coursesLabel.IsVisible=false;
        lessonsLabel.IsVisible=true;

        courseOneButton.IsVisible=false;
        courseTwoButton.IsVisible=false;
        courseThreeButton.IsVisible=false;
        courseFourButton.IsVisible=false;
        courseFiveButton.IsVisible=false;
        courseSixButton.IsVisible=false;
        courseSevenButton.IsVisible=false;
        courseEightButton.IsVisible=false;

        lessonElevenButton.IsVisible=true;
        lessonTwelveButton.IsVisible=true;
        lessonThirteenButton.IsVisible=true;
        lessonFourteenButton.IsVisible=true;
        lessonFifteenButton.IsVisible=true;
        lessonSixteenButton.IsVisible=true;
        lessonSeventeenButton.IsVisible=true;
        lessonEighteenButton.IsVisible=true;
        lessonNineteenButton.IsVisible=true;
        lessonTwentyButton.IsVisible=true;
        lessonTwentyOneButton.IsVisible=true;
        lessonTwentyTwoButton.IsVisible=true;
        lessonTwentyThreeButton.IsVisible=true;
        lessonTwentyFourButton.IsVisible=true;
        lessonTwentyFiveButton.IsVisible=true;
        lessonTwentySixButton.IsVisible=true;
        lessonTwentySevenButton.IsVisible=true;
        lessonTwentyEightButton.IsVisible=true;
        lessonTwentyNineButton.IsVisible=true;
    }

    public void courseThreeButton_Click(object sender, RoutedEventArgs e)
    {
        coursesLabel.IsVisible=false;
        lessonsLabel.IsVisible=true;

        courseOneButton.IsVisible=false;
        courseTwoButton.IsVisible=false;
        courseThreeButton.IsVisible=false;
        courseFourButton.IsVisible=false;
        courseFiveButton.IsVisible=false;
        courseSixButton.IsVisible=false;
        courseSevenButton.IsVisible=false;
        courseEightButton.IsVisible=false;

        lessonThirtyButton.IsVisible=true;
        lessonThirtyOneButton.IsVisible=true;
        lessonThirtyTwoButton.IsVisible=true;
        lessonThirtyThreeButton.IsVisible=true;
        lessonThirtyFourButton.IsVisible=true;
        lessonThirtyFiveButton.IsVisible=true;
        lessonThirtySixButton.IsVisible=true;
        lessonThirtySevenButton.IsVisible=true;
        lessonThirtyEightButton.IsVisible=true;
        lessonThirtyNineButton.IsVisible=true;
        lessonFortyButton.IsVisible=true;
        lessonFortyOneButton.IsVisible=true;
        lessonFortyTwoButton.IsVisible=true;
        lessonFortyThreeButton.IsVisible=true;
        lessonFortyFourButton.IsVisible=true;
        lessonFortyFiveButton.IsVisible=true;
    }

    public void courseFourButton_Click(object sender, RoutedEventArgs e)
    {
        coursesLabel.IsVisible=false;
        lessonsLabel.IsVisible=true;

        courseOneButton.IsVisible=false;
        courseTwoButton.IsVisible=false;
        courseThreeButton.IsVisible=false;
        courseFourButton.IsVisible=false;
        courseFiveButton.IsVisible=false;
        courseSixButton.IsVisible=false;
        courseSevenButton.IsVisible=false;
        courseEightButton.IsVisible=false;

        lessonFortySixButton.IsVisible=true;
        lessonFortySevenButton.IsVisible=true;
        lessonFortyEightButton.IsVisible=true;
        lessonFortyNineButton.IsVisible=true;
        lessonFiftyButton.IsVisible=true;
        lessonFiftyOneButton.IsVisible=true;
        lessonFiftyTwoButton.IsVisible=true;
        lessonFiftyThreeButton.IsVisible=true;
        lessonFiftyFourButton.IsVisible=true;
        lessonFiftyFiveButton.IsVisible=true;
        lessonFiftySixButton.IsVisible=true;
        lessonFiftySevenButton.IsVisible=true;
        lessonFiftyEightButton.IsVisible=true;
    }

    public void courseFiveButton_Click(object sender, RoutedEventArgs e)
    {
        coursesLabel.IsVisible=false;
        lessonsLabel.IsVisible=true;

        courseOneButton.IsVisible=false;
        courseTwoButton.IsVisible=false;
        courseThreeButton.IsVisible=false;
        courseFourButton.IsVisible=false;
        courseFiveButton.IsVisible=false;
        courseSixButton.IsVisible=false;
        courseSevenButton.IsVisible=false;
        courseEightButton.IsVisible=false;

        lessonFiftyNineButton.IsVisible=true;
        lessonSixtyButton.IsVisible=true;
        lessonSixtyOneButton.IsVisible=true;
        lessonSixtyTwoButton.IsVisible=true;
        lessonSixtyThreeButton.IsVisible=true;
        lessonSixtyFourButton.IsVisible=true;
    }

    public void courseSixButton_Click(object sender, RoutedEventArgs e)
    {
        coursesLabel.IsVisible=false;
        lessonsLabel.IsVisible=true;

        courseOneButton.IsVisible=false;
        courseTwoButton.IsVisible=false;
        courseThreeButton.IsVisible=false;
        courseFourButton.IsVisible=false;
        courseFiveButton.IsVisible=false;
        courseSixButton.IsVisible=false;
        courseSevenButton.IsVisible=false;
        courseEightButton.IsVisible=false;

        lessonSixtyFiveButton.IsVisible=true;
        lessonSixtySixButton.IsVisible=true;
        lessonSixtySevenButton.IsVisible=true;
        lessonSixtyEightButton.IsVisible=true;
        lessonSixtyNineButton.IsVisible=true;
        lessonSeventyButton.IsVisible=true;
        lessonSeventyOneButton.IsVisible=true;
        lessonSeventyTwoButton.IsVisible=true;
    }

    public void courseSevenButton_Click(object sender, RoutedEventArgs e)
    {
        coursesLabel.IsVisible=false;
        lessonsLabel.IsVisible=true;

        courseOneButton.IsVisible=false;
        courseTwoButton.IsVisible=false;
        courseThreeButton.IsVisible=false;
        courseFourButton.IsVisible=false;
        courseFiveButton.IsVisible=false;
        courseSixButton.IsVisible=false;
        courseSevenButton.IsVisible=false;
        courseEightButton.IsVisible=false;

        lessonSeventyThreeButton.IsVisible=true;
        lessonSeventyFourButton.IsVisible=true;
        lessonSeventyFiveButton.IsVisible=true;
        lessonSeventySixButton.IsVisible=true;
        lessonSeventySevenButton.IsVisible=true;
        lessonSeventyEightButton.IsVisible=true;
        lessonSeventyNineButton.IsVisible=true;
        lessonEightyButton.IsVisible=true;
        lessonEightyOneButton.IsVisible=true;
        lessonEigthyTwoButton.IsVisible=true;
        lessonEightyThreeButton.IsVisible=true;
    }

    public void courseEightButton_Click(object sender, RoutedEventArgs e)
    {
        coursesLabel.IsVisible=false;
        lessonsLabel.IsVisible=true;

        courseOneButton.IsVisible=false;
        courseTwoButton.IsVisible=false;
        courseThreeButton.IsVisible=false;
        courseFourButton.IsVisible=false;
        courseFiveButton.IsVisible=false;
        courseSixButton.IsVisible=false;
        courseSevenButton.IsVisible=false;
        courseEightButton.IsVisible=false;

        lessonEightyFourButton.IsVisible=true;
        lessonEightyFiveButton.IsVisible=true;
        lessonEightySixButton.IsVisible=true;
        lessonEightySevenButton.IsVisible=true;
        lessonEightyEightButton.IsVisible=true;
        lessonEightyNineButton.IsVisible=true;
        lessonNinetyButton.IsVisible=true;
    }

    //JourneyMan Courses Clicks

    public void courseNineButton_Click(object sender, RoutedEventArgs e)
    {
        coursesLabel.IsVisible=false;
        lessonsLabel.IsVisible=true;

        courseNineButton.IsVisible=false;
        courseTenButton.IsVisible=false;
        courseElevenButton.IsVisible=false;
        courseTwelveButton.IsVisible=false;
        courseThirteenButton.IsVisible=false;
        courseFourteenButton.IsVisible=false;
        courseFifteenButton.IsVisible=false;

        lessonNinetyOneButton.IsVisible=true;
        lessonNinetyTwoButton.IsVisible=true;
        lessonNinetyThreeButton.IsVisible=true;
        lessonNinetyFourButton.IsVisible=true;
        lessonNinetyFiveButton.IsVisible=true;
        lessonNinetySixButton.IsVisible=true;
        lessonNinetySevenButton.IsVisible=true;
    }

    public void courseTenButton_Click(object sender, RoutedEventArgs e)
    {
        coursesLabel.IsVisible=false;
        lessonsLabel.IsVisible=true;

        courseNineButton.IsVisible=false;
        courseTenButton.IsVisible=false;
        courseElevenButton.IsVisible=false;
        courseTwelveButton.IsVisible=false;
        courseThirteenButton.IsVisible=false;
        courseFourteenButton.IsVisible=false;
        courseFifteenButton.IsVisible=false;

        lessonNinetyEightButton.IsVisible=true;
        lessonNinetyNineButton.IsVisible=true;
        lessonOneHundredButton.IsVisible=true;
        lessonOneHundredOneButton.IsVisible=true;
        lessonOneHundredTwoButton.IsVisible=true;
        lessonOneHundredThreeButton.IsVisible=true;
        lessonOneHundredFourButton.IsVisible=true;
        lessonOneHundredFiveButton.IsVisible=true;
        lessonOneHundredSixButton.IsVisible=true;
        lessonOneHundredSevenButton.IsVisible=true;
        lessonOneHundredEightButton.IsVisible=true;
        lessonOneHundredNineButton.IsVisible=true;
    }


    public void courseElevenButton_Click(object sender, RoutedEventArgs e)
    {
        coursesLabel.IsVisible=false;
        lessonsLabel.IsVisible=true;

        courseNineButton.IsVisible=false;
        courseTenButton.IsVisible=false;
        courseElevenButton.IsVisible=false;
        courseTwelveButton.IsVisible=false;
        courseThirteenButton.IsVisible=false;
        courseFourteenButton.IsVisible=false;
        courseFifteenButton.IsVisible=false;

        lessonOneHundredTenButton.IsVisible=true;
        lessonOneHundredElevenButton.IsVisible=true;
        lessonOneHundredTwelveButton.IsVisible=true;
        lessonOneHundredThirteenButton.IsVisible=true;
        lessonOneHundredFourteenButton.IsVisible=true;
    }

    public void courseTwelveButton_Click(object sender, RoutedEventArgs e)
    {
        coursesLabel.IsVisible=false;
        lessonsLabel.IsVisible=true;

        courseNineButton.IsVisible=false;
        courseTenButton.IsVisible=false;
        courseElevenButton.IsVisible=false;
        courseTwelveButton.IsVisible=false;
        courseThirteenButton.IsVisible=false;
        courseFourteenButton.IsVisible=false;
        courseFifteenButton.IsVisible=false;

        lessonOneHundredFifteenButton.IsVisible=true;
        lessonOneHundredSixteenButton.IsVisible=true;
        lessonOneHundredSeventeenButton.IsVisible=true;
        lessonOneHundredEighteenButton.IsVisible=true;
        lessonOneHundredNineteenButton.IsVisible=true;
        lessonOneHundredTwentyButton.IsVisible=true;
    }

    public void courseThirteenButton_Click(object sender, RoutedEventArgs e)
    {
        coursesLabel.IsVisible=false;
        lessonsLabel.IsVisible=true;

        courseNineButton.IsVisible=false;
        courseTenButton.IsVisible=false;
        courseElevenButton.IsVisible=false;
        courseTwelveButton.IsVisible=false;
        courseThirteenButton.IsVisible=false;
        courseFourteenButton.IsVisible=false;
        courseFifteenButton.IsVisible=false;

        lessonOneHundredTwentyOneButton.IsVisible=true;
        lessonOneHundredTwentyTwoButton.IsVisible=true;
        lessonOneHundredTwentyThreeButton.IsVisible=true;
        lessonOneHundredTwentyFourButton.IsVisible=true;
        lessonOneHundredTwentyFiveButton.IsVisible=true;
        lessonOneHundredTwentySixButton.IsVisible=true;
        lessonOneHundredTwentySevenButton.IsVisible=true;
    }

    public void courseFourteenButton_Click(object sender, RoutedEventArgs e)
    {
        coursesLabel.IsVisible=false;
        lessonsLabel.IsVisible=true;

        courseNineButton.IsVisible=false;
        courseTenButton.IsVisible=false;
        courseElevenButton.IsVisible=false;
        courseTwelveButton.IsVisible=false;
        courseThirteenButton.IsVisible=false;
        courseFourteenButton.IsVisible=false;
        courseFifteenButton.IsVisible=false;

        lessonOneHundredTwentyEightButton.IsVisible=true;
        lessonOneHundredTwentyNineButton.IsVisible=true;
        lessonOneHundredThirtyButton.IsVisible=true;
        lessonOneHundredThirtyOneButton.IsVisible=true;
        lessonOneHundredThirtyTwoButton.IsVisible=true;
        lessonOneHundredThirtyThreeButton.IsVisible=true;
        lessonOneHundredThirtyFourButton.IsVisible=true;
        lessonOneHundredThirtyFiveButton.IsVisible=true;
    }

    public void courseFifteenButton_Click(object sender, RoutedEventArgs e)
    {
        coursesLabel.IsVisible=false;
        lessonsLabel.IsVisible=true;

        courseNineButton.IsVisible=false;
        courseTenButton.IsVisible=false;
        courseElevenButton.IsVisible=false;
        courseTwelveButton.IsVisible=false;
        courseThirteenButton.IsVisible=false;
        courseFourteenButton.IsVisible=false;
        courseFifteenButton.IsVisible=false;

        lessonOneHundredThirtySixButton.IsVisible=true;
        lessonOneHundredThirtySevenButton.IsVisible=true;
        lessonOneHundredThirtyEightButton.IsVisible=true;
        lessonOneHundredThirtyNineButton.IsVisible=true;
        lessonOneHundredFortyButton.IsVisible=true;
        lessonOneHundredFortyOneButton.IsVisible=true;
    }


    //Networking Courses Clicks
    public void courseSixteenButton_Click(object sender, RoutedEventArgs e)
    {
        coursesLabel.IsVisible=false;
        lessonsLabel.IsVisible=true;
        
        courseSixteenButton.IsVisible=false;
        courseSeventeenButton.IsVisible=false;
        courseEighteenButton.IsVisible=false;
        courseNineteenButton.IsVisible=false;
        courseTwentyButton.IsVisible=false;
        courseTwentyOneButton.IsVisible=false;
        courseTwentyTwoButton.IsVisible=false;

        lessonOneHundredFortyTwoButton.IsVisible=true;
        lessonOneHundredFortyThreeButton.IsVisible=true;
        lessonOneHundredFortyFourButton.IsVisible=true;
        lessonOneHundredFortyFiveButton.IsVisible=true;
        lessonOneHundredFortySixButton.IsVisible=true;
  
    }

    public void courseSeventeenButton_Click(object sender, RoutedEventArgs e)
    {
        coursesLabel.IsVisible=false;
        lessonsLabel.IsVisible=true;
        
        courseSixteenButton.IsVisible=false;
        courseSeventeenButton.IsVisible=false;
        courseEighteenButton.IsVisible=false;
        courseNineteenButton.IsVisible=false;
        courseTwentyButton.IsVisible=false;
        courseTwentyOneButton.IsVisible=false;
        courseTwentyTwoButton.IsVisible=false;

        lessonOneHundredFortySevenButton.IsVisible=true;
        lessonOneHundredFortyEightButton.IsVisible=true;
        lessonOneHundredFortyNineButton.IsVisible=true;
        lessonOneHundredFiftyButton.IsVisible=true;
        lessonOneHundredFiftyOneButton.IsVisible=true;
        lessonOneHundredFiftyTwoButton.IsVisible=true;
        lessonOneHundredFiftyThreeButton.IsVisible=true;
        lessonOneHundredFiftyFourButton.IsVisible=true;
        lessonOneHundredFiftyFiveButton.IsVisible=true;
    }

    public void courseEighteenButton_Click(object sender, RoutedEventArgs e)
    {
        coursesLabel.IsVisible=false;
        lessonsLabel.IsVisible=true;
        
        courseSixteenButton.IsVisible=false;
        courseSeventeenButton.IsVisible=false;
        courseEighteenButton.IsVisible=false;
        courseNineteenButton.IsVisible=false;
        courseTwentyButton.IsVisible=false;
        courseTwentyOneButton.IsVisible=false;
        courseTwentyTwoButton.IsVisible=false;

        lessonOneHundredFiftySixButton.IsVisible=true;
        lessonOneHundredFiftySevenButton.IsVisible=true;
        lessonOneHundredFiftyEightButton.IsVisible=true;
        lessonOneHundredFiftyNineButton.IsVisible=true;
        lessonOneHundredSixtyButton.IsVisible=true;
        lessonOneHundredSixtyOneButton.IsVisible=true;
        lessonOneHundredSixtyTwoButton.IsVisible=true;
    }

    public void courseNineteenButton_Click(object sender, RoutedEventArgs e)
    {
        coursesLabel.IsVisible=false;
        lessonsLabel.IsVisible=true;
        
        courseSixteenButton.IsVisible=false;
        courseSeventeenButton.IsVisible=false;
        courseEighteenButton.IsVisible=false;
        courseNineteenButton.IsVisible=false;
        courseTwentyButton.IsVisible=false;
        courseTwentyOneButton.IsVisible=false;
        courseTwentyTwoButton.IsVisible=false;

        lessonOneHundredSixtyThreeButton.IsVisible=true;
        lessonOneHundredSixtyFourButton.IsVisible=true;
        lessonOneHundredSixtyFiveButton.IsVisible=true;
        lessonOneHundredSixtySixButton.IsVisible=true;
        lessonOneHundredSixtySevenButton.IsVisible=true;
        lessonOneHundredSixtyEightButton.IsVisible=true;
        lessonOneHundredSixtyNineButton.IsVisible=true;
    }

    public void courseTwentyButton_Click(object sender, RoutedEventArgs e)
    {
        coursesLabel.IsVisible=false;
        lessonsLabel.IsVisible=true;
        
        courseSixteenButton.IsVisible=false;
        courseSeventeenButton.IsVisible=false;
        courseEighteenButton.IsVisible=false;
        courseNineteenButton.IsVisible=false;
        courseTwentyButton.IsVisible=false;
        courseTwentyOneButton.IsVisible=false;
        courseTwentyTwoButton.IsVisible=false;

        lessonOneHundredSeventyButton.IsVisible=true;
        lessonOneHundredSeventyOneButton.IsVisible=true;
        lessonOneHundredSeventyTwoButton.IsVisible=true;
        lessonOneHundredSeventyThreeButton.IsVisible=true;
        lessonOneHundredSeventyFourButton.IsVisible=true;
    }

    public void courseTwentyOneButton_Click(object sender, RoutedEventArgs e)
    {
        coursesLabel.IsVisible=false;
        lessonsLabel.IsVisible=true;
        
        courseSixteenButton.IsVisible=false;
        courseSeventeenButton.IsVisible=false;
        courseEighteenButton.IsVisible=false;
        courseNineteenButton.IsVisible=false;
        courseTwentyButton.IsVisible=false;
        courseTwentyOneButton.IsVisible=false;
        courseTwentyTwoButton.IsVisible=false;

        lessonOneHundredSeventyFiveButton.IsVisible=true;
        lessonOneHundredSeventySixButton.IsVisible=true;
        lessonOneHundredSeventySevenButton.IsVisible=true;
        lessonOneHundredSeventyEightButton.IsVisible=true;
        lessonOneHundredSeventyNineButton.IsVisible=true;
    }

    public void courseTwentyTwoButton_Click(object sender, RoutedEventArgs e)
    {
        coursesLabel.IsVisible=false;
        lessonsLabel.IsVisible=true;
        
        courseSixteenButton.IsVisible=false;
        courseSeventeenButton.IsVisible=false;
        courseEighteenButton.IsVisible=false;
        courseNineteenButton.IsVisible=false;
        courseTwentyButton.IsVisible=false;
        courseTwentyOneButton.IsVisible=false;
        courseTwentyTwoButton.IsVisible=false;

        lessonOneHundredEightyButton.IsVisible=true;
        lessonOneHundredEightyOneButton.IsVisible=true;
        lessonOneHundredEightyTwoButton.IsVisible=true;
        lessonOneHundredEightyThreeButton.IsVisible=true;
        lessonOneHundredEightyFourButton.IsVisible=true;
        lessonOneHundredEightyFiveButton.IsVisible=true;
    }
}