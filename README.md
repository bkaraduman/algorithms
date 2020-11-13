# algorithms
Technical Interview Algorithms with C#. 

# algorithms

Hello friends. In this repository I want to talk about algorithms. It is really important for technical interviews and also to be a good programmer!

Lets start with sorting algorithms!

1) Bubble Sort Algorithm

What is bubble sort?

Bubble sort, is the simplest algorithm. In this comparison-based algorithm, each element in the list is compared with the next element. If first elements value is bigger than the second one, two elements are swapped. Then the values of the second and third elements are compared. If the value of the second element is greater than the value of the third element, these two elements are swapped, and this process continues until the entire list is sorted!

What is Bubble sort time complexity?

Worst Case: O(n²) - Quadratic Time Complexity
Average Case O(n²) - Quadratic Time Complexity
Best Case O(n) - Linear Time Complexity [If the entire array is sequential, only 1 iteration is performed.]

Here is simple gif: https://miro.medium.com/max/750/1*DOUJStF3et-GKApITUHedw.gif

How Bubble Sort Algorithm works?

Sample array: [3,10,5,12,9,20]. Lets sort this array with bubble sort! It starts with 3 and 10 comparison. Since 3 is less than 10, so they dont move! Then the 10 and 5 are compared! Since 10 is greater than 5, they move and the iteration process continues in this way until the list items are listed!

1. Iterasyon : [3,5,10,9,12,20] → [3,5,10,9,12,20] → [3,5,10,9,12,20] → [3,5,9,10,12,20] → [3,5,9,10,12,20]
2. Iterasyon : [3,5,9,10,12,20] → [3,5,9,10,12,20] → [3,5,9,10,12,20] → [3,5,9,10,12,20] → [3,5,9,10,12,20] → [3,5,9,10,12,20]

You can see the c# code in the repository! And here is great video on youtube about how bubble sort works in traditional dance :) Have fun ! https://www.youtube.com/watch?v=lyZQPjUT5B4

2) Selection Sort Algorithm

The logic of operation is one of the most easily understood sorting algorithms. It is a low performance algorithm. Let's examine the subject on an example;

12, 40, 8, 33, 52, 3, 10, 83

Algorithm works like this; Takes the first element (12). And compare with the other elements. And then, When we find the smallest number in the list, we replace the value in the index with (12). index 0 (first element in array), the smallest value is accepted.

Compared to 40. Since 40 is bigger than 12, no action is taken. Then a comparison is made with 8. Since 8 is less than 12, the new minimum value is 8. This way you can go until the end. The smallest value is set to 3. 3 and 12 are replaced and the index is shifted to the next value. The new value of the index is 1. The new list is as follows.

3, 40, 8, 33, 52, 12, 10, 83

At this stage, the value 40 is compared with the next values. This time, since the smallest number is 8, the values between 8 and 40 are replaced and the index is shifted forward one.

3, 8, 40, 33, 52, 12, 10, 83

This process continues until the all elements are compared!

The analysis of the algorithm is as follows;

Best Case (sorted), No need to swap element but you need to loop all elements! So the complexity of algorithm is n^2.

Worst case (reverse sorted), you need again loop all elements. The only difference between best case, you need the swap elements! But this does not effect the complexity of algorithm! It is again n^2.

Average Case, the complexity of algorithm is n^2.

