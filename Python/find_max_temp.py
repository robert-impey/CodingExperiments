#!/usr/bin/env python3

import pandas as pd
import sys

for arg in sys.argv[1:]:
    csv_file_name = arg
    df = pd.read_csv(csv_file_name)

    max_id = df["Average Temperature"].idxmax()

    max_year = df["Year"][max_id]
    max_temp = df["Average Temperature"][max_id]

    print(f"In {max_year} the average temperature in December was {max_temp} C")
