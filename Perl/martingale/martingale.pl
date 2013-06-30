#!/usr/bin/perl

use strict;
use warnings;

use Getopt::Long;

my ($starting_bet, $runs, $tank, $max_number_of_bets);

$starting_bet = 1;
$max_number_of_bets = 100;

GetOptions(
	'r|runs=i' => \$runs,
	't|tank=i' => \$tank,
	'm|max-number-of-bets:i' => \$max_number_of_bets
);

my $csv_file = "r$runs-t$tank-m$max_number_of_bets.csv";
my $csv_already_present = (-f $csv_file);
open(CSV, ">>$csv_file") or die $!;

if ($csv_already_present) {
	print CSV "---\n" ;
} else {
	print CSV "Run,Bet number in this run,Current Bet,Outcome,Tank in this run\n";
}

foreach my $run (0 .. $runs - 1) {
	my ($tank_in_this_run, $current_bet, $bet_number_in_this_run) = ($tank, $starting_bet, 0);
	
	while ($tank_in_this_run >= 0 and $bet_number_in_this_run < $max_number_of_bets) {
		my $outcome = &make_bet;
		
		if ($outcome eq 'win') {
			$tank_in_this_run += $current_bet;
		} else {
			$tank_in_this_run -= $current_bet;
		}
		
		print CSV "$run,$bet_number_in_this_run,$current_bet,$outcome,$tank_in_this_run\n";
		
		if ($outcome eq 'lose') {
			$current_bet *= 2;
		}
		
		$bet_number_in_this_run++;
	}
}

close CSV;

sub make_bet
{
	my $threshold = 0.5;
	
	return rand >= $threshold ? 'win' : 'lose';
}
