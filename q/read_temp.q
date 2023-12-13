data_dir:getenv `DATA
location_temp_file:"/" sv (data_dir; "LinkedIn Learning"; "PySpark"; "location_temp.csv")
location_temp_path: hsym `$location_temp_file
temp_table: ("ZSF";enlist ",")0: location_temp_path
over_27:select from temp_table where temp_celcius > 27
