#!/usr/bin/env perl

use strict;
use warnings;

use Getopt::Long;
use Time::HiRes qw(gettimeofday tv_interval);
use Statistics::Descriptive;

use Sorting qw(built_in bubble);
use Sorting::Files qw(
make_sorted_file_name
parse_shuffled_file_name
);

my ($shuffled_lists_file, $algorithm, $results_directory);

GetOptions(
    's|shuffled-lists-file=s' => \$shuffled_lists_file,
    'a|algorithm=s' => \$algorithm,
    'r|results-directory=s' => \$results_directory
);

if (my %sorted_lists_dimensions = parse_shuffled_file_name($shuffled_lists_file)) {
    my $sorted_lists_file = make_sorted_file_name(
        $algorithm,
        $results_directory,
        $sorted_lists_dimensions{number_of_lists}, 
        $sorted_lists_dimensions{size_of_lists});
    open SORT, '>', $sorted_lists_file or die $!;

    my $times_stat = Statistics::Descriptive::Full->new();

    open SHUF, '<', $shuffled_lists_file or die $!;
    while (<SHUF>) {
        chomp;
        my @shuffled_list_of_integers = split /,/;

        my @sorted_list_of_integers = [];

        my $start = [gettimeofday];
        if ($algorithm eq 'built_in') {
            @sorted_list_of_integers = built_in @shuffled_list_of_integers;
        } elsif ($algorithm eq 'bubble') {
            @sorted_list_of_integers = bubble @shuffled_list_of_integers;
        } else {
            die "Please set a valid sorting algorithm!\n";
        }
        my $finish = [gettimeofday];
        $times_stat->add_data(tv_interval ($start, $finish));

        print SORT join(',', @sorted_list_of_integers), "\n";
    }
    close SHUF;

    print SORT "#$algorithm,$sorted_lists_dimensions{number_of_lists},$sorted_lists_dimensions{size_of_lists},", $times_stat->min(), ",", $times_stat->max(), ",", $times_stat->mean(), "\n";
    close SORT;
} else {
    die "Unable to parse file name of the shuffled lists!\n";
}

