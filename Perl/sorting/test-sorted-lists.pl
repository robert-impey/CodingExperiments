#!/usr/bin/env perl

use strict;
use warnings;

use Getopt::Long;

my ($sorted_lists_file);

GetOptions(
    's|sorted-lists-file=s' => \$sorted_lists_file
);

open SORT, '<', $sorted_lists_file or die $!;
my $in_order = 1;
sort_file: while (<SORT>) {
    chomp;
    unless (/^#/) {
        my @hopefully_sorted_list_of_integers = split /,/;

        foreach (1..(scalar(@hopefully_sorted_list_of_integers) - 2)) {
            if ($hopefully_sorted_list_of_integers[$_] > $hopefully_sorted_list_of_integers[$_ + 1]) {
                $in_order = 0;
                last sort_file;
            }
        }
    }
}

if ($in_order) {
    print "In order.\n";
} else {
    print "Not in order.\n";
}
