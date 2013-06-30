#!/usr/bin/perl -w
use strict;

use Getopt::Long;
use List::Util qw(shuffle);

my ($number_of_lists, $size_of_lists);

GetOptions(
	'n|number-of-lists=i' => \$number_of_lists,
	's|size-of-lists=i' => \$size_of_lists
);

my $output_file_name = "shuffled-lists-$number_of_lists-$size_of_lists.txt";

open FILE, '>', $output_file_name or die $!;

foreach (1..$number_of_lists) {
	my @list_of_ints = shuffle(1..$size_of_lists);
	
	print FILE join ',', @list_of_ints;
	print FILE "\n";
}

close FILE;
