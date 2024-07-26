dataDir:getenv `DATA
restaurantsFile:"/" sv (dataDir; "BaltimoreRestaurants.xml")
restaurantsFile: hsym `$restaurantsFile
lines: read0 restaurantsFile

pattern: "*<name>*"

nameLines: lines like pattern

linesTable: ([] lines)

firstNameLine: raze first select lines from linesTable where lines like pattern
