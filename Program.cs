int[] stem = {6, 25, 10, 6, 8, 10, 9};
int size = stem.Length;
int index = 0;
int max = (stem[index] + stem[index +1]) + stem[index +2];
int max2 = (stem[size-2] + stem[size -1]) + stem[0];
int max3 = (stem[size -1] + stem[0]) + stem [1];
int total_max = 0;
while (index <= size - 3){
       int TempSum = (stem[index] + stem[index +1]) + stem[index +2];
    if (TempSum > max){
        max = TempSum;
        index ++; }
    else {
        index ++;
    }    
if (max > max2 && max > max3){
    total_max = max;
}
else if (max2 > max && max2 > max3) {
    total_max = max2;
}
else  {
    total_max = max3;
}
    
       }
    Console.WriteLine(total_max);

