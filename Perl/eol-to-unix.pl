#!/usr/bin/perl

use strict;
use warnings;

my @lines;
while (<>) {
	chomp;
	push @lines, $_;
}

print (join "\n", @lines);

