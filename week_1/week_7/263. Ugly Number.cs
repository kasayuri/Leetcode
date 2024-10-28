//https://leetcode.com/problems/ugly-number/

/*
An ugly number is a positive integer whose prime factors are limited to 2, 3, and 5.

Given an integer n, return true if n is an ugly number.
*/

// numeros primos so podem estar entre 2, 3, 5
public class Solution {
    public bool IsUgly(int n) {
        if (n == 0)
            return false;
        else if (n == 1)
            return true;

        while (n%2 == 0){
            n /= 2;
        } 

        while (n%3 == 0){
            n /= 3;
        } 

        while (n%5 == 0){
            n /= 5;
        } 
            
        return (n == 1);
    }
}
