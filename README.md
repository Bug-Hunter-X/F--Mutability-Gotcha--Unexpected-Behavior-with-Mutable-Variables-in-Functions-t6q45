# F# Mutability Gotcha: Unexpected Behavior with Mutable Variables in Functions

This example demonstrates a common pitfall in F# when dealing with mutable variables within functions.  The behavior might be unexpected for developers coming from imperative programming backgrounds.

The `bug.fs` file contains code exhibiting the issue. The `bugSolution.fs` file provides a solution illustrating how to achieve the desired behavior if modifications to the mutable values within the function are needed.

## Problem

When mutable variables are passed to a function, the function operates on copies of the values, not direct references. This can lead to unexpected results if you expect the function to modify the original variables.