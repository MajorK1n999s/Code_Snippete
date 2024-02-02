
*HOW TO PRINT EVERY ROW OF .CSV FILE LOGIC

void Start()
    {

        StreamReader source = new StreamReader(Application.streamingAssetsPath+"/student.csv");
        string fileContents = source.ReadToEnd();
        source.Close();
		
        string[] lines = fileContents.Split("\n"[0]);
        foreach (string line in lines)
        {
            print(line);


        }
    }
	
	
	*HOW TO PRINT EVERY COLUMN OF .CSV FILE LOGIC


void Start()
    {

        StreamReader source = new StreamReader(Application.streamingAssetsPath+"/student.csv");
        string fileContents = source.ReadToEnd();
        source.Close();
        string[] lines = fileContents.Split("\n"[0]);
        foreach (string line in lines)
        {
            string[] value = line.Split(',');
            print(value[0]);
        }
    }



