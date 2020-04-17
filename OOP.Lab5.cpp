#include <iostream>
#include <iomanip>
#include <cmath>

using namespace std;

void Solve();

class Point//базовий клас
{
protected://модифікатор доступу
	float x, y;
public:
	Point(float ValueX)
	{
		x = ValueX;
		y = x;
	}
	float Length()
	{
		return sqrt(pow(x, 2) + pow(y, 2));
	}
};

class SecondPoint :public Point//похідний клас
{
private :
	char s;
public:
	SecondPoint(char valueS) : Point(valueS)//похідний конструктор створений від базового
	{
		s = valueS;
	}
	/*void Set(char ValueS)
	{
		s = ValueS;
	}
	int Get()
	{
		return s;
	}
	*/
	void foo()
	{
		char arr[6]{'q','w','e','r','t','y',};
		char s1;
		for (int i = 0; i < 6; i++)
		{
			cout << arr[i] << setw(3);
		}
		cout << "\n";
		cout << "Enter s1 for replace: ";
		cin >> s1;
		for (int i = 0; i < 6; i++)
		{
			if (arr[i] == s)
			{
				arr[i] = s1;
			}
		}
		for (int i = 0; i < 6; i++)
		{
			cout << arr[i] << setw(3);
		}
		cout << "\n";
	}
};

int main()
{
	Solve();
}

void Solve()//функція вирішення
{
	cout << "Kovalenko Yura IS-92\n";
	cout << "My string is:" << "\n";
	cout << "q w e r t y\n";
	char symbol;
	cout << "Enter symbol : ";
	cin >> symbol;
	if (symbol == 'q' || symbol == 'w' || symbol == 'e' || symbol == 'r' || symbol == 't' || symbol == 'y')
	{
		SecondPoint a(symbol);
		a.foo();
		Point b(2);
		cout << "Length is : " << b.Length() << "\n";
	}
	else
	{
		cout << "ERROR!!!";
	}
	cout << "\n";
	system("pause");
}
