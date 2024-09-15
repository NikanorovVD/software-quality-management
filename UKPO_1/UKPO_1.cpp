#include <iostream>
#include <string>

int main()
{
	std::string input;
	std::cin >> input;

	int len = input.length();
	for (int i = 0; i < len / 2; i++)
	{
		int j = len - i - 1;
		char buff = input[i];

		input[i] = input[j];
		input[j] = buff;
	}
	std::cout << input << std::endl;
}


