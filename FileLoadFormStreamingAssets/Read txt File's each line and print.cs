
	//(streamReader) class accessing file using file path and store in (source) variable.
	StreamReader source = new StreamReader(Application.streamingAssetsPath + "/name.txt");

	//read a content and stored in (fileContents) variable.
	string fileContents = source.ReadToEnd();
	source.Close();

	//split() function stored each text of line in (lines) array index
	string[] lines = fileContents.Split("\n"[0]);

	//foreach loop stored every single line in (line) variable & print it.
	foreach(string line in lines)
	{
		print(line);
	}
	
