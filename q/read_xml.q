dataDir:getenv `DATA
restaurantsFile:"/" sv (dataDir; "BaltimoreRestaurants.xml")
restaurantsFile: hsym `$restaurantsFile
lines: read0 restaurantsFile
/count lines

pattern: "*<name>*"

nameLines: lines like pattern

nameLines

/first_match: first lines where {x like pattern}

/first_match
