dataDir:getenv `DATA
restaurantsFile:"/" sv (dataDir; "BaltimoreRestaurants.xml")
restaurantsFile: hsym `$restaurantsFile
lines: read0 restaurantsFile
/count lines

pattern: "*<name>*"

nameLines: lines like pattern

linesTable: ([] lines; nameLines)

firstNameLine: raze first select lines from linesTable where nameLines=1
