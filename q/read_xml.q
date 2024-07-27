dataDir:getenv `DATA
restaurantsFile:"/" sv (dataDir; "BaltimoreRestaurants.xml")
restaurantsFile: hsym `$restaurantsFile
lines: read0 restaurantsFile

namePattern: "*<name>*"

linesTable: ([] lines)

firstNameLine: raze first select lines from linesTable where lines like namePattern
firstNameLine: ssr[firstNameLine; "\t"; ""]
firstNameLine: ssr[firstNameLine; "<name>"; ""]
firstNameLine: ssr[firstNameLine; "</name>"; ""]

//firstNameLine

zipCodePattern: "*<zipcode>*"

zipCodeLines: select lines from linesTable where lines like zipCodePattern
count zipCodeLines
