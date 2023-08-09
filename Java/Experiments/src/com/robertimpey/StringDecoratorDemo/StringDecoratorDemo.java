/*
 * To experiment with the Decorator Pattern.
 * 
 * http://en.wikipedia.org/wiki/Decorator_pattern
 * 
 * Also taking inspiration from
 * http://www.ictcool.com/2011/06/12/java-program-to-sort-and-reverse-a-string/
 */
package com.robertimpey.StringDecoratorDemo;

/**
 *
 * @author robert
 */
public class StringDecoratorDemo 
{

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) 
    {
        DecoratedString reversedString = new ReverseStringDecorator(new SimpleDecoratedString("'Under Milk Wood' takes place in Llareggub."));
        System.out.println(reversedString.getString());
        
        DecoratedString sortedString = new SortStringDecorator(new SimpleDecoratedString("The quick fox jumps over the lazy brown dog."));
        System.out.println(sortedString.getString());
        
        // Decorators can be stacked.
        DecoratedString sortedThenReversedString = new ReverseStringDecorator(new SortStringDecorator(new SimpleDecoratedString("Bright vixens jump; dozy fowl quack.")));
        System.out.println(sortedThenReversedString.getString());
        
        // Some ways of ordering stacking do not make sense.
        SimpleDecoratedString mySimpleDecoratedString = new SimpleDecoratedString("Reversing doesn't survive sorting.");
        DecoratedString sortedButNotReversedString = new SortStringDecorator(mySimpleDecoratedString);
        System.out.println(sortedButNotReversedString.getString());
        DecoratedString reversedThenSortedString = new SortStringDecorator(new ReverseStringDecorator(mySimpleDecoratedString));
        System.out.println(reversedThenSortedString.getString());
        
        DecoratedString doublyReversedString = new ReverseStringDecorator(new ReverseStringDecorator(new SimpleDecoratedString("I should look the same!")));
        System.out.println(doublyReversedString.getString());
    }
}
