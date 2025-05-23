# Candle Burner

## Problem Description

This application solves the "Candle Recycling" problem, which can be described as follows:

You start with a certain number of candles. After burning each candle, you can collect the leftover wax. When you have enough leftover wax parts, you can make a new candle. The program calculates the total number of candles you can burn given:

1. An initial number of candles
2. How many leftover parts are needed to make a new candle

## Example

Given:

- 5 initial candles
- 2 leftover parts needed to make a new candle

The solution works as follows:

1. Burn the initial 5 candles, getting 5 leftover parts
2. With 5 leftover parts, make 2 new candles (using 4 parts), with 1 part remaining
3. Burn the 2 new candles, getting 2 more leftover parts (total: 3 parts)
4. Make 1 new candle from 2 parts, with 1 part remaining
5. Burn the 1 new candle, getting 1 more leftover part (total: 2 parts)
6. Make 1 final candle from the 2 parts
7. Burn the final candle, getting 1 more leftover part (not enough to make a new candle)

Total candles burned: 5 (initial) + 2 + 1 + 1 = 9

## Implementation

The program uses a recursive approach to solve this problem:

- Burn all available candles and collect the leftover parts
- Calculate how many new candles can be made from the current leftover parts
- If no new candles can be made, return the total burned count
- Otherwise, recursively continue the process with the newly created candles

## How to Run

1. Ensure you have .NET 9.0 or later installed
2. Open a terminal and navigate to the project directory
3. Run `dotnet run` to execute the program

The default values are set to 5 initial candles and 2 parts needed for a new candle. You can modify these values in the `Program.cs` file.

## Note
This README file was generated by AI. I did this to demonstrate the power of it in leveraging a developer's daily work with documenting problems/solutions.