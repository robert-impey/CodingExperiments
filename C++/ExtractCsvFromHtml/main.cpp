/*
Extract comma separated values from with a td tag in HTML.
(c) Robert Impey 2016-04-30
*/

#include <iostream>
#include <string>
#include <vector>

#include "TdExtractor.hpp"

using namespace std;

enum TagState
{
    OutsideTag,
    InTag
};

enum TdTagState
{
    OutsideTdTag,
    InTOfTag,
    InDOfTag,
    InSlashOfTag
};

enum TdState
{
    OutsideTd,
    InTd
};

enum CsvState
{
    InValue,
    InComma
};

vector<string> extract(string html)
{
    vector<string> extractedStrings;

    TagState currentTagState = OutsideTag;
    TdTagState currentTdTagState = OutsideTdTag;
    TdState currentTdState = OutsideTd;

    for (string::iterator it = html.begin(); it != html.end(); it++)
    {
        char currentChar = *it;

        switch (currentTagState)
        {
            case OutsideTag:
                if (currentChar == '<')
                {
                    currentTagState = InTag;
                    break;
                }

                switch (currentTdTagState)
                {
                    case InDOfTag:
                        switch (currentTdState)
                        {
                            case OutsideTd:
                                currentTdState = InTd;
                                break;
                        }
                }

                break;
            case InTag:
                if (currentChar == '>')
                {
                    currentTagState = OutsideTag;
                    break;
                }

                switch (currentTdTagState)
                {
                    case OutsideTdTag:
                        if (currentChar == 't')
                        {
                            currentTdTagState = InTOfTag;
                        }
                        break;
                    case InTOfTag:
                        if (currentChar == 'd')
                        {
                            currentTdTagState = InDOfTag;
                        }
                        break;
                }
                break;
        }
    }

    return extractedStrings;
}

void extractAndPrintStrings(string html)
{
    cout << "Extracting the comma separated values from: " << endl;
    cout << html << endl;

    vector<string> extractedStrings = extract(html);

    for (vector<string>::iterator it = extractedStrings.begin(); it != extractedStrings.end(); it++)
    {
        cout << "'" << *it << "'" << endl;
    }

    cout << "----" << endl;
}

void runTests()
{
    vector<string> examplesOfHtml;

    examplesOfHtml.push_back("<html><body><table><tr></tr></table></body></html>");
    examplesOfHtml.push_back("<html><body><table><tr><td></td></tr></table></body></html>");
    examplesOfHtml.push_back("<html><body><table><tr><td>value1,value2, Something Else, and another thing</td></tr></table></body></html>");
    examplesOfHtml.push_back("<html><body><table><tr><th>value1,value2, Something Else, and another thing</th></tr></table></body></html>");
    examplesOfHtml.push_back("<html><body><table><tr><td>value1,value2, Something Else, and another thing</th></tr></table></body></html>");

    for (vector<string>::iterator it = examplesOfHtml.begin(); it != examplesOfHtml.end(); it++)
    {
        extractAndPrintStrings(*it);
    }
}

int main()
{
    runTests();

    return 0;
}
