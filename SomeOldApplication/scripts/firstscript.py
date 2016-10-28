import clr
import sys
#sys.path.append(r'C:\Program Files (x86)\IronPython 2.7\Lib')
import System.IO
import System.Net.Mail
import System.Net.Mime
from datetime import *
from time import *

def Run(scriptName):
    #print scriptName
    current_time = datetime.now().strftime('%H:%M:%S')
    print current_time

    sleep(10)

    current_time = datetime.now().strftime('%H:%M:%S')
    print current_time
