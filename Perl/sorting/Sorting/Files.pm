package Sorting::Files;

use strict;
use warnings;

use base 'Exporter';

our @EXPORT_OK = qw(
make_shuffled_file_name
make_sorted_file_name
parse_shuffled_file_name
);

sub make_shuffled_file_name
{
    my $number_of_lists = shift;
    my $size_of_lists = shift;

    return "shuffled-lists-$number_of_lists-$size_of_lists.txt";
}

sub parse_shuffled_file_name
{
    my $shuffled_lists_file = shift;

    if ($shuffled_lists_file =~ /shuffled-lists-(\d+)-(\d+).txt/) {
        my %shuffled_list_dimensions;
        $shuffled_list_dimensions{number_of_lists} = $1;
        $shuffled_list_dimensions{size_of_lists} = $2;

        return %shuffled_list_dimensions;
    }
    
    return undef;
}

sub make_sorted_file_name
{
    my $algorithm = shift;
    my $results_directory = shift;
    my $number_of_lists = shift;
    my $size_of_lists = shift;

    $results_directory = '.' unless $results_directory;

    return "$results_directory/sorted-perl-$algorithm-$number_of_lists-$size_of_lists.txt";
}

