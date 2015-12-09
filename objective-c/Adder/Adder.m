#import <Foundation/Foundation.h>

// -----------------------
// Program that sums a series of whitespace delimited numbers passed in via  
// standard input.
// -----------------------
int main(int argc, char *argv[])
{
    int retCode = 0;
    NSAutoreleasePool *pool = [NSAutoreleasePool new];
    
    // Prompt for the user
    NSLog(@"Enter the numbers, separated by spaces.");
    NSLog(@"When you're done hit ENTER then CTRL-D.");
    
    // Get file handle for standard input, and read in a string of numbers
    NSFileHandle *fileHandle = [NSFileHandle fileHandleWithStandardInput];
    NSData *inputData = [fileHandle readDataToEndOfFile];
    NSString *inputString = 
	[[NSString alloc] initWithData:inputData encoding:NSUTF8StringEncoding];
	
    // Split the string on whitespace, and convert to numbers 
    NSArray *tokens = [inputString componentsSeparatedByString:@" "];
    double sum = 0.0;
    unsigned int i;
    for ( i = 0; i < [tokens count]; ++i ) { 
        sum += [[tokens objectAtIndex:i] doubleValue];
    }
    
    // Print output
    NSLog(@"The sum of the numbers was %g.", sum);
    
    // Release objects 
    [inputString release];
    
    [pool release];
    return retCode;
}