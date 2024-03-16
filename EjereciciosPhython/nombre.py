import os
os.system("cls")
n = str(input("Digite su nombre"))
print("su nombre es:"+n)
a = int(input("Digite su año de nacimiento"))
e = 2024 - a 
os.system("cls")
print("Su nombre es:",n)
print("Su edad es:",e)
if e<18: 
    print("Usted es menor de edad")
else:
    print("Usted es mayor de edad")