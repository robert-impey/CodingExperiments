#!/usr/bin/perl

use strict;
use warnings;

use File::Find;
use Getopt::Long;
use Digest::MD5;

my $directory;

GetOptions(
    "directory=s" => \$directory
);

my %files;

sub add_file_to_files
{
    if (-f $File::Find::name) {
        open (my $fh, '<', $File::Find::name) or die "Can't open '$File::Find::name': $!";
        binmode ($fh);

        my $md5sum = Digest::MD5->new->addfile($fh)->hexdigest;

        push @{$files{$md5sum}}, $File::Find::name;
    }
}

find(\&add_file_to_files, $directory);

my %filtered_files;

for my $hash_key (keys %files) {
    if ($#{$files{$hash_key}} > 1) {
        @{$filtered_files{$hash_key}} = @{$files{$hash_key}};
    }
}

for my $hash_key (sort keys %filtered_files) {
    for my $filename (sort @{$filtered_files{$hash_key}}) {
        print "$hash_key\t$filename\n";
    }
}

