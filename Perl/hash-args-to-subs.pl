#!/usr/bin/perl

use strict;
use warnings;

some_sub(
	foo => 'Foo!',
	bar => 'Bar!'
);

# Subs

sub some_sub
{
	my %args = @_;
	foreach (sort keys %args) {
		print "$_: $args{$_}\n"; 
	}
}

