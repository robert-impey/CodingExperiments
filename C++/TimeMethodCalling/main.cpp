#include <iostream>
#include <chrono>
#include <vector>
#include <algorithm>

using namespace std;
using namespace std::chrono;

void arrays(const int size, const bool print_ys) {
    auto ys = new int[size];

    auto t1 = high_resolution_clock::now();

    for (auto i = 0; i < size; i++)
        ys[i] = i + i;

    auto t2 = high_resolution_clock::now();

    auto time_span = duration_cast<duration<double, milli>>(t2 - t1);

    cout << "It took me " << time_span.count() << " milliseconds with an array on the heap." << endl;

    if (print_ys) {
        cout << "ys:";

        for (auto i = 0; i < size; i++)
            cout << " " << ys[i];

        cout << endl;
    }

    delete[] ys;
}

void vector_push_back(const int size, const bool print_ys) {
    vector<int> ys;

    cout << "Capacity of ys: " << ys.capacity() << endl;

    auto t1 = high_resolution_clock::now();

    for (auto i = 0; i < size; i++)
        ys.push_back(i + i);

    auto t2 = high_resolution_clock::now();

    auto time_span = duration_cast<duration<double, milli>>(t2 - t1);

    cout << "It took me " << time_span.count() << " milliseconds with a vector and push_back." << endl;

    cout << "Capacity of ys: " << ys.capacity() << endl;

    if (print_ys) {
        cout << "ys:";

        for (auto i = 0; i < size; i++)
            cout << " " << ys[i];

        cout << endl;
    }
}

void vector_back_insert_iterator(const int size, const bool print_ys) {
    vector<int> ys;

    cout << "Capacity of ys: " << ys.capacity() << endl;

    auto t1 = high_resolution_clock::now();

    generate_n(
            back_insert_iterator<std::vector<int>>(ys),
            size, [n=0]()mutable {
                auto sum = n + n;
                n++;
                return sum;
            }
    );

    auto t2 = high_resolution_clock::now();

    auto time_span = duration_cast<duration<double, milli>>(t2 - t1);

    cout << "It took me " << time_span.count() << " milliseconds with a vector and a back_insert_iterator." << endl;

    cout << "Capacity of ys: " << ys.capacity() << endl;

    if (print_ys) {
        cout << "ys:";

        for (auto i = 0; i < size; i++)
            cout << " " << ys[i];

        cout << endl;
    }
}

int main() {
    const int small_size = 10;

    arrays(small_size, true);
    vector_push_back(small_size, true);
    vector_back_insert_iterator(small_size, true);

    const int size = 10 * 1000 * 1000;

    arrays(size, false);
    vector_push_back(size, false);
    vector_back_insert_iterator(size, false);

    return 0;
}
