#NoEnv  ; Recommended for performance and compatibility with future AutoHotkey releases.
; #Warn  ; Enable warnings to assist with detecting common errors.
SendMode Input  ; Recommended for new scripts due to its superior speed and reliability.
SetWorkingDir %A_ScriptDir%  ; Ensures a consistent starting directory.

^0::
MsgBox Macro started

SetWorkingDir %A_ScriptDir%
;MsgBox %A_WorkingDir%

searchForEnviar()
{
	ImageSearch, Output2X, Output2Y, 0, 0, A_ScreenWidth, A_ScreenHeight, *20 %A_WorkingDir%\Enviar.png
	if ErrorLevel = 2
	{    
		MsgBox Could not conduct the search.
		Return
	}
	else if ErrorLevel = 1
	{    
		MsgBox Icon could not be found on the screen.
		Return
	}
	else
	;    MsgBox The icon was found at %Output2X%x%Output2Y%.
	
	MouseMove, Output2X + 20, Output2Y + 12
	Click
	Sleep 1000
}

searchForMensagem()
{
	;MsgBox Just before the search for Mensagem
	ImageSearch, OutputX, OutputY, 0, 0, A_ScreenWidth, A_ScreenHeight, *20 %A_WorkingDir%\Mensagem.png
	if ErrorLevel = 2
	{    
		MsgBox Could not conduct the search.
		Return
	}
	else if ErrorLevel = 1
	{    
		MsgBox Mensagem could not be found on the screen.
		Return
	}
	else
	;    MsgBox The icon was found at %OutputX%x%OutputY%. 
		
	MouseMove, OutputX + 20, OutputY + 12
	Click
	Sleep, 4000
}


Loop, Read, %A_WorkingDir%\bin\Release\AddressList.txt
{
	Run Chrome.exe %A_LoopReadLine%
	
	Loop 50
	{
		while (A_Cursor = "AppStarting")
		{	
			continue
		}
		Sleep, 100
	}
	
	searchForMensagem()
	
	FileRead, textToSend, %A_WorkingDir%\bin\Release\TextToSend.txt
	Send, %textToSend%
	
	searchForEnviar()
	Send ^w
}
MsgBox Finished
Return