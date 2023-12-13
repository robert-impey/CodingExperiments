data_dir:getenv `DATA
utilization_file:"/" sv (data_dir; "LinkedIn Learning"; "PySpark"; "util_headers.csv")
utilization_path: hsym `$utilization_file
util_table: ("ZIFFI";enlist ",")0: utilization_path

avg util_table[`free_memory]
sdev util_table[`free_memory]

sample_size:"i"$0.05 * count util_table

sample:(-1*sample_size)?util_table
count sample

avg sample[`free_memory]
sdev sample[`free_memory]
