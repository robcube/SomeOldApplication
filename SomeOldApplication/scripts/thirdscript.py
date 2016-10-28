import clr
import sys
import System.IO # uses .NET file lib
from datetime import * # uses python's time lib
from time import * # uses python's time lib

clr.AddReferenceToFileAndPath(r'C:\Users\robko\documents\visual studio 2015\Projects\SomeOldApplication\SomeOldApplication.PyUtility\bin\Debug\SomeOldApplication.PyUtility.dll')
from SomeOldApplication.PyUtility import *

def Run(scriptName):
    utility = PyUtility()
    utility.WriteToLog(datetime.now().strftime('%H:%M:%S'))
    utility.WriteToLog("Sleep 2 secs")
    sleep(2) 
    source = r"c:\ddd\secondscript.docx"
    attachment = System.Net.Mail.Attachment(source, System.Net.Mime.MediaTypeNames.Application.Rtf)

    utility.WriteToLog("emailing document")
    utility.SendMail("rob@rnwood.co.uk", "py@thiscomputer.com", "test subject", "test body", attachment, "localhost");
    utility.WriteToLog("done at " + datetime.now().strftime('%H:%M:%S'))