// Strings.cpp : Defines the entry point for the application.
//

#include <iostream>
#include <fstream>
#include <map>

using namespace std;

int main(int argc, char* argv[]) {
	if (argc <= 1) {
		cerr << "Tell me what to do." << endl;
		return 1;
	}

	string task(argv[1]);

	if (task == "list") {
		if (argc <= 2) {
			cerr << "Please tell me the file name to list!" << endl;
			return 1;
		}

		string file_name(argv[2]);

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

	if (task == "count_lengths")
	{
		string file_name(argv[2]);
		map<size_t, int> counts;

		if (ifstream file{ file_name })
		{
			string s;
			while (file >> s)
			{
				auto length = s.length();

				if (counts.count(length))
				{
					counts[length] = counts[length] + 1;
				}
				else
				{
					counts[length] = 1;
				}
			}
		}

		for (auto& count : counts)
		{
			cout << count.first << " " << count.second << endl;
		}

		return 0;
	}

	cerr << "Unrecognized task - " << task << endl;
	return 1;
}
