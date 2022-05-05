#!/usr/bin/env python3

import csv
import argparse

parser = argparse.ArgumentParser()
parser.add_argument("--file", action="store_const", const=csv_file)
args = parser.parse_args()

print(args.csv_file)
