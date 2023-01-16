# -*- coding: utf-8 -*-
"""
Created on Sun Jan 15 16:06:47 2023

@author: Remko
"""

import os 

def read_dat_file(filepath):
    if not os.path.exists(filepath):
        print("File not found")
        return
    
    if not filepath.endswith(".dat"):
        print("Not a *.dat file")
        return
    
    with open(filepath, "r") as f:
        data = f.read()
        
    print(data)
        
filepath = "est-prog.dat"
read_dat_file(filepath)