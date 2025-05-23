/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package com.robertimpey.StringDecoratorDemo;

/**
 * @author robert
 */
public abstract class StringDecorator implements DecoratedString {
    protected DecoratedString decoratedString;

    public StringDecorator(DecoratedString decoratedString) {
        this.decoratedString = decoratedString;
    }
}
