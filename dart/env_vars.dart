import 'dart:io';

void main() {
  var localScripts = Platform.environment["LOCAL_SCRIPTS"];

  print(localScripts);

  var dev = Platform.environment["DEV"];

  if (dev == null) {
    print("DEV not set!");
  } else {
    print(dev);
  }
}
