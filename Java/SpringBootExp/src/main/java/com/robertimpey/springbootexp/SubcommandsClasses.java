package com.robertimpey.springbootexp;

import java.util.concurrent.Callable;

import picocli.CommandLine.Command;

@Command(name = "subcommands", subcommands = { FiveLCommand.class}, mixinStandardHelpOptions = true, description = "Subcommands for Java Experiments.")
public class SubcommandsClasses implements Callable<Integer> {
    @Override
    public Integer call() throws Exception {
        System.out.println("Subcommand needed: 'fivel'");
        return 0;
    }
}
