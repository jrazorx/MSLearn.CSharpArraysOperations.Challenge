string pangram = "The quick brown fox jumps over the lazy dog";

/*
Write the code necessary to reverse the letters of each word in place and display the result.

In other words, don't just reverse every letter in the variable pangram. Instead, you'll need to reverse just the letters in each word, but print the reversed word in its original position in the message.

Your code must produce the following output:
ehT kciuq nworb xof spmuj revo eht yzal god
*/

string[] words = pangram.Split(' ');
string[] reversedPangramWords = new string[words.Length];

/*
 * For each word string in the pangram
 * we convert the word to an array of letters
 * we revert that array of letter
 * we convert that array of letter back to a string
 * we add that string to our new array of words reversedPangramWords
 * at the end, we print the new array of words reversedPangramWords with a join space, in order to put a space between each word
 * */
for (int i = 0; i < words.Length; i++)
{
    char[] wordArray = words[i].ToCharArray();
    Array.Reverse(wordArray);
    reversedPangramWords[i] = new string(wordArray);
}

Console.WriteLine(string.Join(" ", reversedPangramWords));