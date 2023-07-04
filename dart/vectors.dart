import 'dart:math';

void main() {
    var xs = [3.0, 2.0, 4.0];

    for (final x in xs) {
        print(x);
    }

    var sumOfSquares = 0.0;

    for (final x in xs) {
        sumOfSquares += x * x;
    }

    final mag = sqrt(sumOfSquares);

    print(mag);
}