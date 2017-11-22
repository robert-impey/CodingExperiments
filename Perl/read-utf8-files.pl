#!/usr/bin/perl

use strict;
use warnings;

use File::Spec;
use File::Remove 'remove';
use File::Copy 'cp';
use File::Copy::Recursive 'dircopy';

my $korean_file_name = "한국어.txt";

# Can we see the file?

print_what_you_see($korean_file_name);

my $tmp_dir = File::Spec->tmpdir() . '/perl-utf-files-experiment';

mkdir $tmp_dir;

# Can we see the file if we copy it?
my $tmp_korean_file_name = "$tmp_dir/$korean_file_name";

cp($korean_file_name,  $tmp_korean_file_name);

print_what_you_see($tmp_korean_file_name);

# Can we see the file if it's in a directory that is copied?

my $tmp_dir_a = "$tmp_dir/a";

cp($korean_file_name, $tmp_dir_a);

my $tmp_dir_b = "$tmp_dir/b";

dircopy($tmp_dir_a, $tmp_dir_b);

my $tmp_korean_file_name_in_a_in_b = "$tmp_dir_b/a/$korean_file_name";

print_what_you_see($tmp_korean_file_name_in_a_in_b);

remove(\1, $tmp_dir);

sub print_what_you_see
{
    my $file_name = shift;

    if (-f $korean_file_name) {
        print "I can see $file_name.\n";
    } else {
        print "I can't see $file_name!\n";
    }
}

