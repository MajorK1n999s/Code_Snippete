

		//how write single text in file.txt
		void Start()
		{
			string name = "mk";
			File.AppendAllText(Application.streamingAssetsPath + "/name.txt", name + "," + "\n");
		}
		
		//how write multiple text in file.txt
		void Start()
		{
			string[] names = new string[] { "ali", "bilal", "tohid" };
			foreach (string name in names)
			{
				File.AppendAllText(Application.streamingAssetsPath + "/name.txt", name + "," + "\n");
			}

		}

