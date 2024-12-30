# F# Mutable Variables and Recursion Stack Overflow

This example demonstrates a common error when using mutable variables in F# recursive functions. The problem arises when the termination condition for recursion is not correctly handled, potentially causing stack overflow exceptions. The solution introduces a better approach to handling the loop condition.

## Bug

The original code uses mutable variables `x` and `y` to track iterations and has a recursive call that keeps going even if the loop is finished.

## Solution

The solution uses tail-recursion optimization by rewriting the function so that the recursive call is the last operation performed in the function. This allows the compiler to optimize the recursion, preventing stack overflow errors. 