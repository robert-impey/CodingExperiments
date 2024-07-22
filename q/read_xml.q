data_dir:getenv `DATA
restaurants_file:"/" sv (data_dir; "BaltimoreRestaurants.xml")
restaurants_file: hsym `$restaurants_file
lines: read0 restaurants_file
/count lines

pattern: ".*<name>.*"

/first_match: first lines where {x like pattern}

/first_match
