namespace PalindromeExercise;

public class WordSmith
{
    public bool IsAPalindrome(string word)
    {
        word = word.ToLower();

        int start = 0;
        int end = word.Length - 1;

        while (start < end)
        {
            if (word[start] != word[end])
                return false;

            start++;
            end--;
        }

        return true;
    }
}