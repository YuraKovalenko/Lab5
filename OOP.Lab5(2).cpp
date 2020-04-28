#include <iostream>

using namespace std;

void Solve();

class Figures//похідний клас
{
protected:
	double a, b, r, pi = 3.14;
public :
	Figures(double x)
	{
		r = x;
	}
	Figures(double x, double y)
	{
		a = x;
		b = y;
	}
	virtual void Perimeter()
	{
		double p = 2 * (a + b);
		cout << "Perimetr is:" << p;
	}
	virtual void Area()
	{
		double s = a * b;
		cout << "Area is:" << s;
	}
};

class Rectangle : Figures//похідний клас
{
private:
	double x, y;
public:
	Rectangle(double x, double y) : Figures(x, y)
	{
		this->x = x;
		this->y = y;
	}
	double Length()
	{
		return sqrt(pow(x, 2) + pow(y, 2));
	}
	virtual void Perimeter() 
	{
		double a = sqrt(pow(x, 2) + pow(y, 2));
		double b = sqrt(pow(x, 2) + pow(y, 2));
		double p = 2 * (a + b);
		cout << "Perimetr is:" << p;
	}
	virtual void Area()
	{
		double a = sqrt(pow(x, 2) + pow(y, 2));
		double b = sqrt(pow(x, 2) + pow(y, 2));
		double s = a * b;
		cout << "Area is:" << s;
	}
};

class Circle : Figures//похідний клас
{
protected:
	double x;
public:
	Circle(double r) : Figures(x)
	{
		this->x = r;
	}
	virtual void Perimeter()
	{
		double p = 2 * pi *x;
		cout << "Perimetr is:" << p;
	}
	virtual void Area()
	{
		double s = pi * x*x;
		cout << "Area is:" << s;
	}
};

int main()
{
	Solve();
}

void Solve()
{
	cout << "Kovalenko Yura IS-92\n";
	Rectangle a(3, 4);
	cout << "For Rectangle\n";
	a.Area();
	cout << "\n";
	a.Perimeter();
	cout << "\n";
	Circle b(5);
	cout << "For Circle\n";
	b.Area();
	cout << "\n";
	b.Perimeter();
	cout << "\n";
	system("pause");
}

