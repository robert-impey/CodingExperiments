#!/usr/bin/perl

use strict;
use Getopt::Long;
use Cwd;
use File::Find::Rule;

{
	my $dir = '.';
	my $verbose = 0;
	my $test_data_dir = '.';
	
	GetOptions(
		'd|directory=s' => \$dir,
		'v|verbose' => \$verbose,
		't|test-data-directory=s' => \$test_data_dir
	);
	
	$dir =~ s{/$}{};
	$dir = Cwd::abs_path($dir);
	
	$test_data_dir =~ s{/$}{};
	$test_data_dir = Cwd::abs_path($test_data_dir);
	
	my $successes = 0;
	my $tests = 0;
	
	print "Searching $dir\n" if $verbose;
	
	foreach my $program_dir (File::Find::Rule->directory->in($dir)) {
		$program_dir =~ m{(?:\\|/)\.} && next;
		
		chdir $program_dir or die $!;
		
		if ($verbose) {
			print_separator('+') if $verbose;
			print "Program directory: $program_dir\n";
		}
		
		my $tests_dir = "tests";
		
		if (-d $tests_dir) {
			my @test_files = glob "$tests_dir/*.txt";
			
			foreach my $test_file (sort @test_files) {
				$tests++;
				$test_file = Cwd::abs_path($test_file);
				
				&print_separator if $verbose;
				
				print "Test file: $test_file", $verbose ? "\n" : ' ';
				
				open(my $test_fh, $test_file);
				
				my $command = readline $test_fh;
				$command = "./$command" unless $^O eq 'MSWin32';
				$command =~ s/TEST_DATA_DIR/$test_data_dir/g;
				
				print "Command: $command\n" if $verbose;
				
				readline $test_fh;
				
				my $test_output = '';
				
				while (my $new_line = readline($test_fh)) {
					$test_output .= $new_line;
				}
				close $test_fh;
				print "Test output:\n$test_output\n" if $verbose;
				
				my $command_output = `$command`;
				print "Command output:\n$command_output\n" if $verbose;
				
				if ($command_output eq $test_output) {
					print "OK\n";
					$successes++;
				} else {
					print "FAIL\n";
				}
				
				&print_separator if $verbose;
			}
		}
		
		print_separator('+') if $verbose;
	}
	
	if ($tests == 0) {
		print "No tests found!\n";
	} else {
		printf("Success rate: %d/%d (%.1f%%)\n", $successes, $tests, ($successes/$tests)*100);
	}
}

sub print_separator
{
	my $char = shift || '-';
	my $repetitions = shift || 40;
	
	print "\n", $char x $repetitions, "\n";
}
