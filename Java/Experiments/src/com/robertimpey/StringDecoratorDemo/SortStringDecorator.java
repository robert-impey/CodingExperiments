/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package com.robertimpey.StringDecoratorDemo;

import java.util.Arrays;

/**
 *
 * @author robert
 */
public class SortStringDecorator extends StringDecorator
{
    public SortStringDecorator(DecoratedString decoratedString)
    {
        super(decoratedString);
    }
    
    @Override
    public String getString()
    {
        char[] explode = super.decoratedString.getString().toCharArray();
        Arrays.sort(explode);
        return new String(explode);
    }
}
