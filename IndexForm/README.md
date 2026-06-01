# Word Scramble

A Windows Forms word puzzle game written in C# (.NET 10).

## How to run

1. Extract the ZIP
2. Double-click **Scramble.slnx** to open in Visual Studio
3. Press **F5** to build and run

## How to play

- A scrambled word appears - type your guess and click **Check**
- Click **Hint** to reveal the first letter (costs 2 points)
- Click **Skip** to move on to a different word
- Click **Reset Game** to start over from the beginning
- You get 10 attempts per word before it skips automatically

## Scoring

| Action | Points |
|--------|--------|
| Correct guess (no hint) | +10 |
| Correct guess (hint used) | +5 |
| Wrong guess | -1 |
| Using hint | -2 |

## File structure

| File | What it does |
|------|-------------|
| `Program.cs` | Starts the app, opens IndexForm |
| `IndexForm.cs` | All game logic |
| `IndexForm.Designer.cs` | Form layout and controls |
| `words.txt` | Word list |
