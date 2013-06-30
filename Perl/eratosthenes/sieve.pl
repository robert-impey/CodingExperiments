#!/usr/bin/perl

use strict;
use warnings;

my %candidates;

my $max = shift @ARGV;

die "Please enter a positive integer!\n" unless ($max =~ /^\d+$/);

for (2..$max) { $candidates{$_} = 1 }

my @primes;

for my $candidate (sort {$a <=> $b} keys %candidates) {
	if ($candidates{$candidate}) {
		push @primes, $candidate;
		
		my $temp = $candidate;
		
		while ($temp < $max) {
			$temp += $candidate;
			$candidates{$temp} = 0;
		}
	}
}

my $csv_file = "primes-to-$max.csv";
open(CSV, ">$csv_file") or die $!;
print CSV join "\n", @primes;
close CSV;
