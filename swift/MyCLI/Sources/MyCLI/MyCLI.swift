// The Swift Programming Language
// https://docs.swift.org/swift-book

// https://www.swift.org/getting-started/cli-swiftpm/

import Figlet
import ArgumentParser

@main
struct FigletTool: ParsableCommand {
    @Option(help: "Specify the input")
    public var input: String

    public func run() throws {
        Figlet.say(self.input)
    }
}
