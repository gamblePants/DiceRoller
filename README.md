# DiceRoller

A simple WinForms program which rolls dice and then displays the output. Click on the die icon to select a die (d4, d6, d8, d10, d12 or d20). Use the up-down control to determine how many of that die are thrown. Use the up-down control to add or subtract a modifier from the final result. Click on the "Roll Dice" button to calculate result.

![diceRoller.PNG](https://gamblepants.github.io/img/diceRoller.PNG)

In the above example 4 eight-sided dice are thrown for a total of 13, and then the modifier of 2 is added to give the final result of 15.

## Purpose

The main purpose was for me to practise some more C# using WinForms. However the program could be used as a tool for Role-Playing games (if for example, you found yourself in a situation with no real dice and wanted to simulate them). 

## How to run program

Go to the "release" tab above, download the "DiceRoller.zip" folder and extract. Inside the folder double-click on the DiceRoller.exe file to run. (Runs on Windows only).

![Release_Tab_01.PNG](https://gamblepants.github.io/img/Release_Tab_01.PNG)
![download_01.PNG](https://gamblepants.github.io/img/download_01.PNG)


## Example code

```C#
// method for rolling multiple dice of the same type and adding +/- modifier (eg 3d6 +1)
public static int DiceRoller(int multiplier, int die, int modifier)
{         
    double[] rollArray = new double[multiplier];
    double result = 0.0D;

    // for loop counts for number of dice rolled
    for (int i = 0; i < multiplier; i++)
    {
        // random number created here (1 to die maximum)
        byte[] random = new byte[1];
        generator.GetBytes(random);
        double asciiValue = Convert.ToDouble(random[0]);
        double rounded = Math.Max(0, (asciiValue / 255d) - 0.00000000001d);
        rollArray[i] = Math.Floor(rounded * die) + 1;

        result += rollArray[i];
    }

    // add or subtract modifier here
    result += Convert.ToDouble(modifier);

    // return number as int
    return (int)result;
}
```

## Credits

all icons made by the following authors under the creative commons license by 3.0 
https://creativecommons.org/licenses/by/3.0/

<ul>
  <li>d4, d10 and d12 icons made by Skoll (Andy Meneely) http://www.se.rit.edu/~andy/ </li>
  <li>d6, d8 and d20 icons made by Delapoutie https://delapouite.com/</li>  
</ul>

images can be found here: https://game-icons.net/tags/dice.html
license for dice images can be found in the release tab (license_diceImages.txt)
