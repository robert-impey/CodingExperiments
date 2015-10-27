# See http://powershell.com/cs/blogs/tobias/archive/2008/09/29/trapping-errors.aspx

1 / $null # Errors before the trap are still caught

trap { 
    'Something terrible happened!' 
    continue # Surpresses the original error message
    #exit # Stop at the first error
}

1 / $null

1 / 2 # Legal code is still run if we continue
