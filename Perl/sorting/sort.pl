#!/usr/bin/perl -w
use strict;

use Getopt::Long;
use Time::HiRes qw(gettimeofday tv_interval);
use Statistics::Descriptive;

my ($shuffled_lists_file, $algorithm, $results_file);

GetOptions(
	's|shuffled-lists-file=s' => \$shuffled_lists_file,
	'a|algorithm=s' => \$algorithm,
	'r|results-file=s' => \$results_file
);

if ($shuffled_lists_file =~ /shuffled-lists-(\d+)-(\d+).txt/) {
	my ($number_of_lists, $size_of_lists) = ($1, $2);
	my $sorted_lists_file = "sorted-perl-$algorithm-$number_of_lists-$size_of_lists.txt";
	open SORT, '>', $sorted_lists_file or die $!;
	
	my $times_stat = Statistics::Descriptive::Full->new();
	
	open SHUF, '<', $shuffled_lists_file or die $!;
	while (<SHUF>) {
		chomp;
		my @shuffled_list_of_integers = split /,/;
		
		my @sorted_list_of_integers = [];
		
		my $start = [gettimeofday];
		if ($algorithm eq 'built_in') {
			@sorted_list_of_integers = sort {$a <=> $b} @shuffled_list_of_integers;
		} elsif ($algorithm eq 'bubble') {
			@sorted_list_of_integers =  @shuffled_list_of_integers;
			my $swapped;
			do {
				$swapped = 0;
				
				foreach (0..(scalar(@sorted_list_of_integers) - 2)) {
					if ($sorted_list_of_integers[$_] > $sorted_list_of_integers[$_ + 1]) {
						swap(\@sorted_list_of_integers, $_, $_ + 1);
						$swapped = 1;
					}
				}
			} while( $swapped);
		} else {
			die "Please set a valid sorting algorithm!\n";
		}
		my $finish = [gettimeofday];
		$times_stat->add_data(tv_interval ($start, $finish));
		
		print SORT join(',', @sorted_list_of_integers), "\n";
	}
	close SHUF;
	close SORT;
	
	open RSLT, '>>', $results_file or die $!;
	print RSLT "$algorithm,$number_of_lists,$size_of_lists,", $times_stat->min(), ",", $times_stat->max(), ",", $times_stat->mean(), "\n";
	close RSLT;
} else {
	die "Unable to parse file name of the shuffled lists!\n";
}

sub swap
{
	my $array_ref = shift;
	my $first_index = shift;
	my $second_index = shift;
	
	my $temp = @$array_ref[$first_index];
	@$array_ref[$first_index] = @$array_ref[$second_index];
	@$array_ref[$second_index] = $temp;
}
