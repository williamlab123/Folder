<h1><div align="center"> Folder </div></h1>
<h3>
When you type 'folder' on your terminal, it opens the corrent repository that you are working on, for example:
C:\Desktop\programs. If you type 'folder', it will open the folder 'programs', in the Desktop, in disc C.
You can change the name of the command, for example, 'home', or anything you want. </h3>

<h1><div align="center">How to use on Windows</div></h1>


<h3> To use, copy the code and run on your IDE or on WindowsPowershell using the command <i>dotnet build</i>. Then, go to the folder -> bin -> debug -> net(6.0, 7.0,etc).
 There you'll see 5 files:
 <br>
 * ??.deps 
  <br>
 * ??.dll
  <br>
 * ??.exe
  <br>
 * ??.pdb
  <br>
 * ??.runtimeconfig
  <br>
 If you see that, it means that is correct. Now you will copy the path of the net folder. Then, you will open the <i> environment variables </i>, by typing path on your start menu. Then search for 'Path'. Select 'Path', then click in new. In variable name, put the name of the command you want to use, the default is 'folder'. Then in 'variable value', put the path you have copied before. Click  ok. You will do that twice, for the user and for the system, then click ok and you should be capable to use the program. <i> Note: If your terminal is openned during the process, close it and open a new one. </i> </h3>
 <br>
 
 <h1><div align="center">How to use on Linux</div></h1>
 Copy the code and paste on your vscode, then build it using 'dotnet build'. Once builded, you need the .dll file. Grab its path, open a terminal, go to your home directory and type: nano .bashrc. Now go to the end of the file and paste: alias folder="The path for your .dll"
 After making this steps, save and type source ~/.bashrc in the terminal. Now you can try, open a new terminal e type 'folder'.
 If this steps does not work, please contact me and i'll see why it didn't work.

<h2>  Result: </h2>
<br>
 


  --->
![image](https://user-images.githubusercontent.com/54008790/215366016-9970a499-bbae-473f-bec7-e44d1dc15b35.png)
![image](https://user-images.githubusercontent.com/54008790/215366055-9c2830af-a54a-4dbe-ba55-e7a4282fc6c4.png)








