	# Algorithms&DataStructursHW2

	The task here is to find the one unique element in a sorted array where every other element appears twice.
	To solve this efficiently, we use a binary search, taking advantage of the sorted nature of the array. 
	This way, we get a solution that runs in O(log n) time.

Here’s how the algorithm works step-by-step:

	1.	Setup: Start with two pointers, lower and upper, which are set to the beginning and the end of the array.
	2.	Binary Search Loop: Keep looking as long as there’s more than one element in the search space. 
		Find the middle index of the current search space. If this index is odd, move it back by one to make it even. 
		This adjustment helps in comparing pairs easily.
	3.	Check Pairs: Look at the element at the middle index and the next one. 
		If they are the same, it means the unique element must be further to the right, so we move our lower 
		pointer past this pair. If they are not the same, the unique element must be to the left, so we move our
		upper pointer to the middle.
	4.	Conclusion: When the loop ends, lower will point to the unique element.

This approach narrows down the search space quickly by halving it each time, making it very efficient.

Challenges

The main challenge was making sure the boundaries were adjusted correctly. It was important to get the midpoint
right and to ensure the comparisons worked as expected, especially with handling even and odd indices.

How We Overcame Challenges

	1.	Midpoint Adjustment: We made sure the midpoint was always even by checking if it was odd and then 
		decrementing it. This way, we always compare pairs properly.
	2.	Boundary Management: Clear logic and lots of testing helped ensure that our adjustments to lower and 
		upper pointers were correct. Writing comments and stepping through the code ensured it 
		worked as expected.

Conclusion

Using binary search for this problem is a smart move because it makes the search very fast. 
By carefully adjusting our search space and ensuring correct comparisons, we can efficiently 
find the unique element in the array.