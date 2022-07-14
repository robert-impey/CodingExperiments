#include <iostream>
#include <chrono>
#include <vector>

void vector_push_back(const int size)
{
    using namespace std::chrono;

    std::vector<int> ys;

    auto t1 = high_resolution_clock::now();

    for (auto i = 0; i < size; i++)
        ys.push_back(i + i);

    auto t2 = high_resolution_clock::now();

    auto time_span = duration_cast<duration<double,std::milli>>(t2 - t1);

    std::cout << "It took me " << time_span.count() << " milliseconds with a vector and push_back." << std::endl;
}

void arrays(const int size)
{
    using namespace std::chrono;

    int *ys = new int[size];

    auto t1 = high_resolution_clock::now();

    for (auto i = 0; i < size; i++)
        ys[i] = i + i;

    auto t2 = high_resolution_clock::now();

    auto time_span = duration_cast<duration<double,std::milli>>(t2 - t1);

    std::cout << "It took me " << time_span.count() << " milliseconds with an array on the heap." << std::endl;

    delete[] ys;
}

int main() {
    const int size = 10 * 1000 * 1000;

    //vector_push_back(size);
    arrays(size);

    return 0;
}
