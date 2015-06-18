int __declspec(dllexport) MyMethod(int i)
{
	return i * 10;
}

int __declspec(dllexport) MyMethodWithNoParameter()
{
	return 10;
}
