package com.robertimpey.springbootexp;

import picocli.CommandLine.Command;

import java.util.concurrent.Callable;

@Command(name = "fivel", mixinStandardHelpOptions = true, description = "The Five Letters Experiment")
public class FiveLCommand implements Callable<Integer> {
    @Override
    public Integer call() throws Exception {
        return 0;
    }
}
