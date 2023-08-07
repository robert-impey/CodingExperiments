// SumIf357.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;

int find_sum(int n)
{
    auto sum = 0;

    for (auto i = 1; i <= n; i++)
    {
        if (i % 3 == 0 || i % 5 == 0 || i % 7 == 0)
        {
            sum += i;
        }
    }

    return sum;
}

void find_and_print_sum(int n)
{
    auto sum = find_sum(n);

    cout << "n = " << n << ", sum = " << sum << endl;
}

int main()
{
    find_and_print_sum(0);
    find_and_print_sum(1);
    find_and_print_sum(3);
    find_and_print_sum(5);
    find_and_print_sum(7);
    find_and_print_sum(10);
    find_and_print_sum(50);
    find_and_print_sum(100);
}
