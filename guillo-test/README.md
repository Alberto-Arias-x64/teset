# Extraordinary Substrings 
Each character of the lowercase English alphabet has been mapped to digits as shown in the figure. The numerical value corresponding to
each letter is its mapped value.

An extraordinary substring is one whose sum of the mapped values of each letter is divisible by its length. Given string input_str, count its
total number of non-empty extraordinary substrings.

## Example:
<code>
    input_str = 'asdf'
</code>

All non-empty substrings of input_str are tested in the table.<br>
There are 6 extraordinary substrings.

## Function Description
Complete the function countSubstrings in the editor.
countSubstrings has the following parameter(s):
string input_str: a string of length n

## Returns
int: the number of non-empty extraordinary substrings

## Constraints

1 ≤ n ≤ 2000 

All characters of input_str are lowercase English letters.
