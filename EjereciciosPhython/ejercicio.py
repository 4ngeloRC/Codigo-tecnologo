import os
os.system("cls")

def salario():
    valorH = 0
    antiguo = 0
    horaM = 0
    sueldo = 0
    desc = 0
    sueldoT = 0
    sueldoTD = 0
    salarioM = 0
    nombre = ""
    salarioM = int(input("Digite el valor de su salario mínimo: \n"))
    if salarioM >= 1300000:
        nombre = input("Digite nombre de empleado: \n")
        antiguo = int(input("Digite la antigüedad en la empresa en años: \n"))
        horaM = int(input("Digite la cantidad de horas trabajadas en el mes: \n"))

        valorH = (salarioM / 30) / 8
        sueldo = valorH * horaM
        sueldoT = sueldo + (antiguo * 50000)
        desc = (sueldoT * 13) / 100
        sueldoTD = sueldoT - desc

        print("Empleado " + nombre + ", lleva " + str(antiguo) + " años en la empresa.")
        print("Su hora laboral está valorizada en " + str(valorH) + ".")
        print("Su pago en bruto es: " + str(sueldo) + ".")
        print("Su pago sin descuento es de: " + str(sueldoT) + ".")
        print("El descuento realizado es del " + str(desc) + "%.")
        print("Su pago total es de " + str(sueldoTD) + ".")
    else:
        print("Para continuar, ingrese el salario mínimo requerido.")

salario()