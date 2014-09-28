#!/bin/bash

case "$1" in
'hello')
	echo "Hello to you, too!"
	;;
'bye')
	echo "Bye bye!"
	;;
*)
	echo "Please say either 'hello' or 'bye'!"
esac
exit 0
