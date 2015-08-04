#!/usr/bin/perl

use strict;
use warnings;

use Getopt::Long;

my ($max, $runs);

GetOptions(
   'r|runs=i' => \$runs,
   'm|max=i' => \$max
);

my %times;
for my $search_method (qw(sequential sentinel binary)) {

    for (1 .. $runs) {
	    my $sought = int(rand($max));
	    my $command = "./BinarySearch -m $max -s $sought -t -r $search_method";

        my $output = `$command`;
	    if ($output =~ /Finished searching after (\d+) milliseconds/) {
	        my $time = $1;
            push @{$times{$search_method}}, $time;
	    }
	}
}

for my $search_method (sort keys %times) {
    print $search_method, ': ';
    my ($count, $sum) = (0, 0);

    for my $time (@{$times{$search_method}}) {
        $sum += $time;
        $count++;
    }
    printf "%.2f", ($sum / $count);

    print "\n";
}

