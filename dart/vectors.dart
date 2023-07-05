import 'dart:math';

void main() {
    // Magnitude of a Vector
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

    // Sum of Vectors
    var a = [2.0, 4.0];
    var b = [3.0, 1.0];

    var sum = [];
    for (var i = 0; i < a.length; i++) {
        sum.add(a[i] + b[i]);
    }

    for (final elementInSum in sum) {
        print(elementInSum);
    }

    // Dot product
    var us = [4.0, -2.0, 0.0, 1.0];
    var vs = [-1.0, -3.0, 1.0, 5.0];

    var dotProduct = 0.0;

    for (var i = 0; i < us.length; i++) {
        dotProduct += us[i] * vs[i];
    }

    print(dotProduct);
}