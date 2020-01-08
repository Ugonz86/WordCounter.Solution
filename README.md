# Word Counter
##### _"Let's count words in a sentence." — by **Uriel Gonzalez** 12/20/2019_

## Description
A C# program with 2 initial inputs that gather both a word and a sentence from a user, then checks how frequently the word appears in the sentence. It should check for full word matches only. If the word brain but the sentence is "I like to brainstorm.", the first 5 letters of the word brainstorm will not be counted.

### Specs
| Spec | Input | Output |
| :-------------     | :------------- | :------------- |
| **The program determines if the user input is valid or not. User inputs a word and then a sentence.** | brain; My brain hurts. | The word 'brain' appears 1 time in your sentence. |
| **The program determines if the user input is valid or not when there's a space in the word.** | br ain | Invalid word. Please try again. |
| **The program determines if the user input is valid or not when there are special character(s) in the word.** | br@in! | Invalid word. Please try again. |
| **The program counts how many matching words are in one sentence with no special characters or punctuation.** | brain; The brain is like a muscle I like to call super brain and it goes to the brain gym. | The word 'brain' appears 3 time(s) in your sentence. |
| **The program counts how many matching words are in one sentence with punctuation.** | brain; The brain, like a muscle, needs a brain workout, good brain care and rest! | The word 'brain' appears 3 time(s) in your sentence. |
| **The program determines if the user input is valid or not when there are numbers in the word.** | br4in | Invalid word. Please try again. |
| **The program determines if the user input is valid or not when if no input was submitted.** |  | Invalid word. Please try again. |
| **The program matches full words only.** | brain; I like to brainstorm | The word 'brain' appears 0 time(s) in your sentence. |

The brain, like a muscle, needs a brain workout, good brain care and rest!

## Setup/Installation Requirements
1. Clone this repository:
   ```
   $git clone https://github.com/Ugonz86/WordCounter.git
   ```
2. Run the application
   ```
   $dotnet run
   ```

## Known Bugs
* No known bugs at this time.

## Technologies Used
* C# 
* .NET

## Support and Contact Details
Please contact _ugonzalez86@gmail.com_ with questions or comments.

### License
MIT License
Copyright (c) 2019 **_Uriel Gonzalez_**