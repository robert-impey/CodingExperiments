import 'dart:io';

void main() {
  final rows = 10;
  var currentNumber = 0;

  for (var row = 0; row < rows; row++) {
    final columns = row;

    for (var column = 0; column <= columns; column++) {
      if (column > 0) {
        stdout.write(' ');
      }

      currentNumber++;
      stdout.write(currentNumber);
    }

    stdout.writeln();
  }
}
