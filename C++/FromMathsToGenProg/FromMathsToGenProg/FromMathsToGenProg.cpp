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

int get_int_arg(int argc, char* argv[], int position, int default_value)
{
	if (argc > position)
	{
		string arg_str(argv[position]);

		return stoi(arg_str);
	}

	return default_value;
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
		auto max = get_int_arg(argc, argv, 2, 10);

		for (auto i = 1; i <= max; i++)
		{
			cout << i << " " << half(i) << endl;
		}

		return 0;
	}

	if (input == "odd")
	{
		auto max = get_int_arg(argc, argv, 2, 10);

		for (auto i = 1; i <= max; i++)
		{
			cout << i << " " << odd(i) << endl;
		}

		return 0;
	}

	if (input == "multiply0")
	{
		auto mult0 = get_int_arg(argc, argv, 2, 5);
		auto mult1 = get_int_arg(argc, argv, 3, 10);

		cout << multiply0(mult0, mult1) << endl;
		return 0;
	}

	if (input == "multiply1")
	{
		auto mult0 = get_int_arg(argc, argv, 2, 5);
		auto mult1 = get_int_arg(argc, argv, 3, 10);

		cout << multiply1(mult0, mult1) << endl;
		return 0;
	}

	if (input == "multiply0_result")
	{
		auto mult0 = get_int_arg(argc, argv, 2, 5);
		auto mult1 = get_int_arg(argc, argv, 3, 10);

		auto result0 = multiply0_result(mult0, mult1, { 0, 0 });

		cout << result0.result << " " << result0.steps << endl;

		return 0;
	}

	if (input == "multiply1_result")
	{
		auto mult0 = get_int_arg(argc, argv, 2, 5);
		auto mult1 = get_int_arg(argc, argv, 3, 10);

		auto result0 = multiply1_result(mult0, mult1, { 0, 0 });

		cout << result0.result << " " << result0.steps << endl;

		return 0;
	}

	cerr << "Unrecognised task '" << input << "'" << endl;

	return 1;
}
