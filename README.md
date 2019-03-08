
# NOT recommended
**better to check [this repo](https://github.com/kasha01/CodeBlocks/tree/master/InterviewQ)**








##### ~~TestDome~~

~~Solution to testdome.com test questions:~~

~~Projects:~~

<ul>
<li><b>Anagramism - All Anagrams:</b><br>
Get all Anagrams of a word/sequence of characters
</li><br>

<li><b>Are Anagrams:</b><br>
Check if two words are each other's anagrams: An <b>Anagram</b> is a word formed from another by rearranging its letters, using all the original letters exactly once; for example, orchestra can be rearranged into carthorse.
</li>

<li><b>Path:</b><br>
Provides change directory (cd) function for an abstract file system.
Notes:
<ul>
<li>Root path is '/'.</li>
<li>Path separator is '/'.</li>
<li>Parent directory is addressable as "..".</li>
<li>Directory names consist only of English alphabet letters (A-Z and a-z).</li>
</ul>
For example, new Path("/a/b/c/d").Cd("../x").CurrentPath should return "/a/b/c/x".
</li>

<li><b>Palindrome:</b><br> Check if a given sentence is a palindrome: A palindrome is a word, phrase, verse, or sentence that reads the same backward or forward. Only the order of English alphabet letters (A-Z and a-z) should be considered, other characters should be ignored.
For example, IsPalindrome("Noel sees Leon.") should return true as spaces, period, and case should be ignored resulting with "noelseesleon" which is a palindrome since it reads same backward and forward.
</li>

<li><b>Run:</b><br> Finds the zero-based index of the longest run in a string. A run is a consecutive sequence of the same character. If there is more than one run with the same length, return the index of the first one.
For example, IndexOfLongestRun("abbcccddddcccbba") should return 6 as the longest run is dddd and it first appears on index 6.
</li>

<li><b>Sums Of Two:</b> <br>
A function that, given a list and a target sum, returns zero-based indices of any two distinct elements 
whose sum is equal to the target sum. If there are no such elements, the function would return the proper message.
For example, FindTwoSum(new List<int>() { 1, 3, 5, 7, 9 }, 12) should return any of the following tuples of indices:

    1, 4 (3 + 9 = 12)
    2, 3 (5 + 7 = 12)
    3, 2 (7 + 5 = 12)
    4, 1 (9 + 3 = 12)
</li>

<li><b>Frog Leap:</b> <i>for more info see frog leap wiki</i><br>
A frog only moves forward, but it can move in steps 1 inch long or in jumps 2 inches long. A frog can cover the same 
distance using different combinations of steps and jumps.
This calculates the number of different combinations a frog can use to cover a given distance.
For example, a distance of 3 inches can be covered in three ways: step-step-step, step-jump, and jump-step.
</li>
</ul>
