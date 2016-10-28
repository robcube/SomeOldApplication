import clr
import sys
import System.IO # uses .NET file lib
from datetime import * # uses python's time lib
from time import * # uses python's time lib
clr.AddReferenceByName('Microsoft.Office.Interop.Word, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c')
from Microsoft.Office.Interop import Word

def Run(scriptName):
    word_application = Word.ApplicationClass()
    word_application.visible = False
    
    sleep(1) 

    source = r"c:\ddd\secondscript.docx"
    destination = r"c:\ddd\secondscript_new.docx"

    document = word_application.Documents.Open(source)
    print "Updating Word Document"
    
    range = word_application.ActiveDocument.Range(0, 5)
    range.Text = "Hey from script"

    document.SaveAs(destination)
    document.Close()
    document = None
    print "Saved Word Document to " + destination

    word_application.Quit()
    word_application = None
    sleep(1) # wait to make sure we're detached from process
