'TODO: Open Task List Panel in Visual Studio
'TODO: Add Json package to the resources
'TODO: Create A Project Class
'TODO: Create A Json file for the Project Class
'TODO: Refactor writeFile procedure to take a string for data input
'TODO: move the input variable up to the global class variable access
'TODO: Seralize Project Class
'TODO: Seseralize The Project json Class
'TODO: Use snippets (insert comment) to add comments to procedures and functions
'TODO: Refactor your code to create subfolders in a separate procedure
'TODO: Remove reference comments

Module Module1

	'READ: 'More information on file reading and writing in the coursebook: pg 68: FileRead
	'https://drive.google.com/file/d/1qwb9Sq3bf9sWPdAUeiFX_xM1Knb4Ikpp/view


	Dim ProjectName As String
	Dim FullDirectory As String
	Sub Main()

		Dim input As String = 0
		While input <> "exit"
			Console.WriteLine("Welcome to the Bracer Guild")
			Console.WriteLine("---------------------------")
			Console.WriteLine("Please Enter Name")
			ProjectName = Console.ReadLine
			Console.WriteLine("Please enter")
			Console.WriteLine("Show Missions and Branches | Exit")

			input = Console.ReadLine.ToString()
			If input = "Show Missions and Branches" Then
				MakeP2PProjectFolders()
			End If
		End While

	End Sub

	Private Sub MakeP2PProjectFolders()
		'TODO: Add Json database
		'TODO: Change MakeP2PProjectFolders to MakeProjectFolders


		Dim newFolderPath As String = My.Computer.FileSystem.SpecialDirectories.Desktop
		If ProjectName = "" Then
			ProjectName = " Not Set\"
		End If

		' My.Computer.Filesystem.CreateDirectory(newFolderPath + ProjectName)
		CreateProjectFolder(newFolderPath, ProjectName)
		newFolderPath += "\" + ProjectName
		FullDirectory = newFolderPath
		CreateProjectFolder(newFolderPath, "\Branchs")
		CreateProjectFolder($"{newFolderPath}\Branchs", "Liberl")
		CreateProjectFolder($"{newFolderPath}\Branchs", "Calvard")
		CreateProjectFolder($"{newFolderPath}\Branchs", "Erebonia")
		CreateProjectFolder($"{newFolderPath}\Branchs", "Crossbell")
		CreateProjectFolder($"{newFolderPath}\Branchs", "Nord")

		CreateProjectFolder(newFolderPath, "\Mission Types")
		CreateProjectFolder($"{newFolderPath}\Mission Types", "Monster Hunt")
		CreateProjectFolder($"{newFolderPath}\Mission Types", "Lost and Found")
		CreateProjectFolder($"{newFolderPath}\Mission Types", "Escorting to Location")
		CreateProjectFolder($"{newFolderPath}\Mission Types", "General Assistance")


		WriteFile("ReadMe.txt", newFolderPath)
		WriteFile("ReadMe.txt", $"{newFolderPath}\Branchs")



		Console.WriteLine("Project created in: " + FullDirectory)
	End Sub

	Private Sub WriteFile(fileName As String, location As String)
		'Ref:https://docs.microsoft.com/en-us/dotnet/visual-basic/developing-apps/programming/drives-directories-files/how-to-write-text-to-files

		If fileName <> "" Then
			Dim file As System.IO.StreamWriter
			file = My.Computer.FileSystem.OpenTextFileWriter(location + "\" + fileName + ".txt", True)
			file.WriteLine("Welcome to the Bracer Guild. Best of luck with your missions. Remember the creed and always put civilians before the crest.")
			file.Close()
		End If

	End Sub

	Sub CreateProjectFolder(newFolderPath As String, ProjectName As String)
		My.Computer.FileSystem.CreateDirectory(newFolderPath + "\" + ProjectName)
	End Sub



End Module