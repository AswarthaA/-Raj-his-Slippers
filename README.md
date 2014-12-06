-Raj-his-Slippers
=================

Hacker Earth Challenge question. 


Raj & his Slippers

Raj stays at a hostel. He has N friends, numbered from 1 to N.
One day, when he woke up at time p:q, he found his slippers to be missing.
He couldn't go out to get a new slipper on bare foot. So, he wants to borrow slippers from one of his friends to go to the store to get a new slipper. But there are 5 conditions he must follow:
1. The hostel has an in-time of x:y . He has to return back before x:y.
2. The footwear store in that area opens at a time a:b, only after which a slipper can be selected and bought, no matter how early Raj goes to the shop. Once the shop is opened, it stays open throughout the day.
3. He can borrow the slippers from his friend numbered x, only if x does not use his slippers in the time interval that Raj asks for. 
Luckily, all of Raj's friends are lazy and hence they use their slippers exactly once a day. For each friend, you are given h1:m1 and h2:m2. The friend uses his slippers from h1:m1 to h2:m2 (inclusive)
4. if Raj has the option to use the slippers of friend i and friend j such that i<j, he would prefer to use the slipper of friend i.
5. It takes Raj R minutes to travel from the store to his hostel and from his hostel to the store, both . Once he is at the store, it takes him S minutes to select a new slipper.
Raj wants to go to the footwear store, select and buy a new slipper and return to the hostel at the earliest. Given all the required information, find the friend from whom Raj should borrow the slippers.
He can start his journey after he wakes up, that is, after p:q
Input:
First line contains an integer T, denoting the number of test cases to follow.
Each testcase begins with an integer N. The next 5 lines contains:
1. The in-time of the hostel, x:y,
2. Time at which Raj wakes up, p:q
3. The time from which the Footwear store will be open, a:b
4. Integer R denoting the minutes it takes to travel between the store and his hostel 
5. Integer S denoting the minutes Raj takes to select a new slipper.
N lines follow. The ith line contains the time interval during which his ith friend use his slippers in the format "h1:m1 h2:m2"
Hence, each testcase contains N+6 line.
(Strictly follow the format given in the sample Testcase for input and output)
Output: 
If it is possible to get slippers on that day, print the index of the friend from whom Raj should borrow the slippers, adhering to the above mentioned conditions.
Else print "-1" to denote that he cannot get the slippers before the day end.
Constraints
0<=T<=100
0<=N<=200
0<=R,S<(24*60)
h1:m1 <= h2:m2
All the times are given as hours:minutes. (0<=hours<=23, 0<=minutes<=59) ( See 24 - hour format )
Note: hours and minutes will always be a two digit integer, Eg: 09:05, 13:09
Sample Case:
1
5
21:30
06:00
09:00
25
10
07:00 10:00
08:30 09:20
12:00 13:45
06:00 16:00
12:05 15:00
Sample Output:
3

Sample Input 
1
5
21:30
06:00
09:00
25
10
07:00 10:00
08:30 09:20
12:00 13:45
06:00 16:00
12:05 15:00
Sample Output
Case 1: 3
Explanation
If Raj borrows from his friend 1: He would be back at his hostel by 11:00
If Raj borrows from his friend 2: He would be back at his hostel by 10:20
If Raj borrows from his friend 3: He would be back at his hostel by 9:35
If Raj borrows from his friend 4: He would be back at his hostel by 17:00
If Raj borrows from his friend 5: He would be back at his hostel by 9:35

Thus he can borrow from either of friend 3 or 5. Going by the condition that he would borrow from a closer friend, he picks the friend lowest index. Hence, he would borrow from friend 3.


