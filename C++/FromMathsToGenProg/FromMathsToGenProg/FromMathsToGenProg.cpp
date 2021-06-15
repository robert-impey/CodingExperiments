// FromMathsToGenProg.cpp : Defines the entry point for the application.
// See Chapter 1 of "From Mathematics to Generic Programming"
// by Alexander Stepanov and Daniel Rose
//

#include "FromMathsToGenProg.h"
#include <string>

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
	if (n == 1) return { a, 1 };
	auto new_result = multiply0_result(n - 1, a, result);
	new_result.result += a;
	new_result.steps++;
	return new_result;
}

Result multiply1_result(int n, int a, Result result)
{
	if (n == 1) return { a, 1 };
	auto new_result = multiply1_result(half(n), a + a, result);
	if (odd(n)) new_result.result += a;
	new_result.steps++;
	return new_result;
}

int main(int argc, char* argv[])
{
	if (argc <= 1)
	{
		cerr << "Tell me what to do." << endl;
		return 1;
	}

	string input(argv[1]);

	if (input == "half")
	{
		auto max = 10;

		if (argc > 2)
		{
			string max_str(argv[2]);

			max = stoi(max_str);
		}

		for (auto i = 1; i <= max; i++)
		{
			cout << i << " " << half(i) << endl;
		}

		return 0;
	}

	if (input == "odd")
	{
		for (auto i = 1; i < 10; i++)
		{
			cout << i << " " << odd(i) << endl;
		}

		return 0;
	}

	if (input == "multiply0")
	{
		cout << multiply0(5, 10) << endl;

		cout << multiply1(5, 10) << endl;

		auto result0 = multiply0_result(5, 10, { 0, 0 });

		cout << result0.result << " " << result0.steps << endl;

		auto result1 = multiply0_result(10, 5, { 0, 0 });

		cout << result1.result << " " << result1.steps << endl;

		auto result0_a = multiply1_result(5, 10, { 0, 0 });

		cout << result0_a.result << " " << result0_a.steps << endl;

		auto result1_a = multiply1_result(10, 5, { 0, 0 });

		cout << result1_a.result << " " << result1_a.steps << endl;

		auto result2_a = multiply1_result(15, 5, { 0, 0 });

		cout << result2_a.result << " " << result2_a.steps << endl;

		return 0;
	}

	cerr << "Unrecognised task '" << input << "'" << endl;

	return 1;
}
