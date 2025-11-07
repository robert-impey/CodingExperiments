// Strings.cpp : Defines the entry point for the application.
//

#include <CLI/CLI.hpp>
#include <iostream>
#include <fstream>
#include <map>

using namespace std;

int main(int argc, char* argv[])
{
    CLI::App app{"My CLI Tool"};
    
    auto list_cmd = app.add_subcommand("list", "List contents of a file");
    auto count_lengths_cmd = app.add_subcommand("count_lengths", "Count the lengths of the lines");
    
    std::string file_name;
    
    list_cmd->add_option("file", file_name, "File to list")->required();
    count_lengths_cmd->add_option("file", file_name, "File to list")->required();
    
    CLI11_PARSE(app, argc, argv);
    
    if (*list_cmd)
    {
        // See https://www.cplusplus.com/forum/general/281709/
        if (ifstream file{ file_name })
        {
            string s;
            while (file >> s)
            {
                cout << s << endl;
            }
        }
        return 0;
    }
    
    if (*count_lengths_cmd)
    {
        map<size_t, int> counts;
        
        if (ifstream file{ file_name })
        {
            string s;
            while (file >> s)
            {
                if (auto length = s.length(); counts.count(length))
                {
                    counts[length] = counts[length] + 1;
                }
                else
                {
                    counts[length] = 1;
                }
            }
        }
        
        for (auto& [len, cnt] : counts)
        {
            cout << len << " " << cnt << endl;
        }
        
        return 0;
    }
    
    return 0;
}
