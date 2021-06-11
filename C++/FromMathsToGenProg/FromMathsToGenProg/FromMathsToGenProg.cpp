// FromMathsToGenProg.cpp : Defines the entry point for the application.
// See Chapter 1 of "From Mathematics to Generic Programming"
// by Alexander Stepanov and Daniel Rose
//

#include "FromMathsToGenProg.h"

using namespace std;

int multiply0(int n, int a)
{
	if (n == 1) return a;
	return multiply0(n - 1, a) + a;
}

bool odd(int n) { return n & 0x1; }
int half(int n) { return n >> 1; }

int multiply1(int n, int a)
{
	if (n == 1) return a;
	int result = multiply1(half(n), a + a);
	if (odd(n)) result = result + a;
	return result;
}

struct Result
{
	int result;
	int steps;
};

Result multiply0_result(int n, int a, Result result)
{
	if (n == 1) return { a, 0 };
	auto new_result = multiply0_result(n - 1, a, result);
	new_result.result += a;
	new_result.steps++;
	return new_result;
}

int main()
{
	cout << multiply0(5, 10) << endl;

	for (auto i = 1; i < 10; i++)
	{
		cout << odd(i) << " " << half(i) << endl;
	}

	cout << multiply1(5, 10) << endl;

	auto result0 = multiply0_result(5, 10, { 0, 0 });

	cout << result0.result << " " << result0.steps << endl;

	auto result1 = multiply0_result(10, 5, { 0, 0 });

	cout << result1.result << " " << result1.steps << endl;

	return 0;
}
