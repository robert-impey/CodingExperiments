#!/bin/bash

do_foo

function do_foo()
{
	echo "Foo!"
}

do_foo

function do_bar()
{
	echo $1
}

do_bar baz

