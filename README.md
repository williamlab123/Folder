<h1><div align="center"> Folder </div></h1>
<h3>
When the command 'folder' is entered on the terminal, it opens the current working directory, such as C:\Desktop\programs. Subsequently, executing the 'folder' command will open the 'programs' folder located in the Desktop, under the C drive. It is also possible to customize the command name to anything preferred, like 'home'.</h3>

<h1><div align="center">Windows</div></h1>


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
 
 <h1><div align="center">Linux</div></h1>
 <h3>
 Copy the code and paste on your vscode, then build it using  <i>dotnet build</i>. Once builded, you need the .dll file. Grab its path, open a terminal, go to your home directory (cd ~) and type:  <i>nano .bashrc .</i> Now go to the end of the file and paste:<br> alias folder="The path for your .dll"<br>
 After making this steps, save and type  <i>source ~/.bashrc</i>  in the terminal. Now you can try, open a new terminal e type 'folder'.
 If this steps does not work, please contact me and i'll see why it didn't work.</h3>

<h2>  Result: </h2>
<br>
 


  --->
![image](https://user-images.githubusercontent.com/54008790/215366016-9970a499-bbae-473f-bec7-e44d1dc15b35.png)
![image](https://user-images.githubusercontent.com/54008790/215366055-9c2830af-a54a-4dbe-ba55-e7a4282fc6c4.png)








