// FromMathsToGenProg.cpp : Defines the entry point for the application.
// See Chapter 1 of "From Mathematics to Generic Programming"
// by Alexander Stepanov and Daniel Rose
//

#include "FromMathsToGenProg.h"
#include <string>

using namespace std;

// Helpers

bool odd(int n) { return n & 0x1; }
int half(int n) { return n >> 1; }

int get_int_arg(int argc, char *argv[], int position, int default_value) {
  if (argc > position) {
    string arg_str(argv[position]);

    return stoi(arg_str);
  }

  return default_value;
}

// Chapter 1

int multiply0(int n, int a) {
  if (n == 1)
    return a;
  return multiply0(n - 1, a) + a;
}

int multiply1(int n, int a) {
  if (n == 1)
    return a;
  int result = multiply1(half(n), a + a);
  if (odd(n))
    result = result + a;
  return result;
}

int mult_acc0(int r, int n, int a) {
  if (n == 1)
    return r + a;
  if (odd(n)) {
    return mult_acc0(r + a, half(n), a + a);
  } else {
    return mult_acc0(r, half(n), a + a);
  }
}

int mult_acc1(int r, int n, int a) {
  if (n == 1)
    return r + a;
  if (odd(n)) {
    r += a;
  }
  mult_acc1(r, half(n), a + a);
}

int mult_acc2(int r, int n, int a) {
  if (odd(n)) {
    r += a;
    if (n == 1)
      return r;
  }
  return mult_acc2(r, half(n), a + a);
}

int mult_acc3(int r, int n, int a) {
  if (odd(n)) {
    r += a;
    if (n == 1) {
      return r;
    }
  }
  n = half(n);
  a = a + a;
  return mult_acc3(r, n, a);
}

int mult_acc4(int r, int n, int a) {
  while (true) {
    if (odd(n)) {
      r += a;
      if (n == 1) {
        return r;
      }
    }
    n = half(n);
    a = a + a;
  }
}

int multiply2(int n, int a) {
  if (n == 1) {
    return a;
  }
  return mult_acc4(a, n - 1, a);
}

int multiply3(int n, int a) {
  while (!odd(n)) {
    a += a;
    n = half(n);
  }
  if (n == 1) {
    return a;
  }
  return mult_acc4(a, n - 1, a);
}

int multiply4(int n, int a) {
  while (!odd(n)) {
    a += a;
    n = half(n);
  }
  if (n == 1) {
    return a;
  }
  return mult_acc4(a, half(n), a + a);
}

ResultSteps multiply0_steps(int n, int a, ResultSteps result) {
  if (n == 1)
    return {a, 1};
  auto new_result = multiply0_steps(n - 1, a, result);
  new_result.result += a;
  new_result.steps++;
  return new_result;
}

ResultSteps multiply1_steps(int n, int a, ResultSteps result) {
  if (n == 1)
    return {a, 1};
  auto new_result = multiply1_steps(half(n), a + a, result);
  if (odd(n))
    new_result.result += a;
  new_result.steps++;
  return new_result;
}

int main(int argc, char *argv[]) {
  if (argc <= 1) {
    cerr << "Tell me what to do." << endl;
    return 1;
  }

  string task(argv[1]);

  // Chapter 1
  if (task == "half") {
    auto max = get_int_arg(argc, argv, 2, 10);

    for (auto i = 1; i <= max; i++) {
      cout << i << " " << half(i) << endl;
    }

    return 0;
  }

  if (task == "odd") {
    auto max = get_int_arg(argc, argv, 2, 10);

    for (auto i = 1; i <= max; i++) {
      cout << i << " " << odd(i) << endl;
    }

    return 0;
  }

  if (task == "multiply0") {
    auto mult0 = get_int_arg(argc, argv, 2, 5);
    auto mult1 = get_int_arg(argc, argv, 3, 10);

    cout << multiply0(mult0, mult1) << endl;
    return 0;
  }

  if (task == "multiply1") {
    auto mult0 = get_int_arg(argc, argv, 2, 5);
    auto mult1 = get_int_arg(argc, argv, 3, 10);

    cout << multiply1(mult0, mult1) << endl;
    return 0;
  }

  if (task == "multiply0_steps") {
    auto mult0 = get_int_arg(argc, argv, 2, 5);
    auto mult1 = get_int_arg(argc, argv, 3, 10);

    auto result0 = multiply0_steps(mult0, mult1, {0, 0});

    cout << result0.result << " " << result0.steps << endl;

    return 0;
  }

  if (task == "multiply1_steps") {
    auto mult0 = get_int_arg(argc, argv, 2, 5);
    auto mult1 = get_int_arg(argc, argv, 3, 10);

    auto result0 = multiply1_steps(mult0, mult1, {0, 0});

    cout << result0.result << " " << result0.steps << endl;

    return 0;
  }

  if (task == "mult_acc0") {
    auto mult0 = get_int_arg(argc, argv, 2, 5);
    auto mult1 = get_int_arg(argc, argv, 3, 10);

    cout << mult_acc0(0, mult0, mult1) << endl;

    return 0;
  }

  if (task == "mult_acc1") {
    auto mult0 = get_int_arg(argc, argv, 2, 5);
    auto mult1 = get_int_arg(argc, argv, 3, 10);

    cout << mult_acc1(0, mult0, mult1) << endl;

    return 0;
  }

  if (task == "mult_acc2") {
    auto mult0 = get_int_arg(argc, argv, 2, 5);
    auto mult1 = get_int_arg(argc, argv, 3, 10);

    cout << mult_acc2(0, mult0, mult1) << endl;

    return 0;
  }

  if (task == "mult_acc3") {
    auto mult0 = get_int_arg(argc, argv, 2, 5);
    auto mult1 = get_int_arg(argc, argv, 3, 10);

    cout << mult_acc3(0, mult0, mult1) << endl;

    return 0;
  }

  if (task == "mult_acc4") {
    auto mult0 = get_int_arg(argc, argv, 2, 5);
    auto mult1 = get_int_arg(argc, argv, 3, 10);

    cout << mult_acc4(0, mult0, mult1) << endl;

    return 0;
  }

  if (task == "multiply2") {
    auto mult0 = get_int_arg(argc, argv, 2, 5);
    auto mult1 = get_int_arg(argc, argv, 3, 10);

    cout << multiply2(mult0, mult1) << endl;

    return 0;
  }

  if (task == "multiply3") {
    auto mult0 = get_int_arg(argc, argv, 2, 5);
    auto mult1 = get_int_arg(argc, argv, 3, 10);

    cout << multiply3(mult0, mult1) << endl;

    return 0;
  }

  if (task == "multiply4") {
    auto mult0 = get_int_arg(argc, argv, 2, 5);
    auto mult1 = get_int_arg(argc, argv, 3, 10);

    cout << multiply4(mult0, mult1) << endl;

    return 0;
  }

  cerr << "Unrecognised task '" << task << "'" << endl;

  return 1;
}
