import 'package:test/test.dart';
// Replace 'dart' with the name defined in your pubspec.yaml 'name' field
import 'package:dart_experiments/arithmetic.dart';

void main() {
  test('Arithmetic works', () {
    expect(add(1, 2), equals(3));
  });
}
