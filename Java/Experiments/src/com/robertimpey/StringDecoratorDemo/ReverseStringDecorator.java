/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package com.robertimpey.StringDecoratorDemo;

/**
 * @author robert
 */
public class ReverseStringDecorator extends StringDecorator {
    public ReverseStringDecorator(DecoratedString decoratedString) {
        super(decoratedString);
    }

    @Override
    public String getString() {
        char[] explode = super.decoratedString.getString().toCharArray();
        int len = explode.length;
        char[] reverse = new char[len];
        for (int i = 0; i < len; i++) {
            reverse[i] = explode[len - (i + 1)];
        }
        return new String(reverse);
    }
}
