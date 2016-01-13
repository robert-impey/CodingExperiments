#!/usr/bin/env perl

use strict;
use warnings;

use Getopt::Long;
use Time::HiRes qw(gettimeofday tv_interval);
use Statistics::Descriptive;

use Sorting qw(built_in bubble);

my ($shuffled_lists_file, $algorithm, $results_directory);

GetOptions(
    's|shuffled-lists-file=s' => \$shuffled_lists_file,
    'a|algorithm=s' => \$algorithm,
    'r|results-directory=s' => \$results_directory
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
    close SORT;

    my $results_file = get_results_file_name($algorithm, $results_directory, $number_of_lists, $size_of_lists);
    open RSLT, '>>', $results_file or die $!;
    print RSLT "#$algorithm,$number_of_lists,$size_of_lists,", $times_stat->min(), ",", $times_stat->max(), ",", $times_stat->mean(), "\n";
    close RSLT;
} else {
    die "Unable to parse file name of the shuffled lists!\n";
}

sub get_results_file_name
{
    my $algorithm = shift;
    my $results_directory = shift;
    my $number_of_lists = shift;
    my $size_of_lists = shift;

    $results_directory = '.' unless $results_directory;

    return "$results_directory/sorted-perl-$algorithm-$number_of_lists-$size_of_lists.txt";
}

