run:
	sudo dotnet restore
	sudo dotnet clean
	sudo dotnet publish -c Release -r linux-x64
	sudo dotnet publish -c Release -r linux-x64
	sudo dotnet ${PWD}/bin/Release/netcoreapp3.1/linux-x64/testNet.dll
clear:
	sudo dotnet restore
	sudo dotnet clean