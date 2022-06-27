int a1 = 22;
int a2 = 23;
int a3 = 43;
int b1 = 65;
int b2 = 8;
int b3 = 93;
int c1 = 12;
int c2 = 634;
int c3 = 2;

// int max = a1;

// if (a2 > max) max = a2;
// if (a3 > max) max = a3;
// if (b1 > max) max = b1;
// if (b2 > max) max = b2;
// if (b3 > max) max = b3;
// if (c1 > max) max = c1;
// if (c2 > max) max = c2;
// if (c3 > max) max = c3;
// Console.WriteLine(max);

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int max1 = Max(a1, a2, a3);
int max2 = Max(b1, b2, b3);
int max3 = Max(c1, c2, c3);
int max = Max(max1,max2,max3);
Console.WriteLine(max);