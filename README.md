# FindFirstNonRepeatingCharInString

#Complexity Analysis ofCode
Time Complexity: O(N). You loop through the string twice, where N is the string length. This is already optimal for time.Space Complexity: O(U). You store unique characters in a dictionary. In the worst case, this requires O(N) space if all characters are unique.

#Why It Can Be Better
Dictionary Overhead: A Dictionary<char, int> has high memory and performance overhead for character lookups due to hashing.Fixed Alphabet Size: Characters are usually standard ASCII (128 possibilities) or extended ASCII (256 possibilities). We can optimize space and speed using a fixed-size integer array.Modern C# Conciseness: LINQ can make this code much shorter, though LINQ adds its own minor performance overhead.

